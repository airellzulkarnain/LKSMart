using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class Cart : Form
    {
        List<TableLayoutPanel> productPanels = new List<TableLayoutPanel>();
        LKSMart_DBDataContext db = new LKSMart_DBDataContext();
        decimal sub_total = 0.0M, total = 0.0M, fee = 0.0M;
        Customer customer;
        public Cart(int customer_id)
        {
            InitializeComponent();
            paymentType_comboBox.DataSource = (from paymentType in db.PaymentTypes where paymentType.deleted_at == null select paymentType).ToList();
            paymentType_comboBox.DisplayMember = "name";
            paymentType_comboBox.ValueMember = "id";
            customer = (from customer in db.Customers where customer.id == customer_id select customer).FirstOrDefault();
        }
        private TableLayoutPanel createProductPanel(string gambar, string nama, decimal harga, string qty, int id)
        {
            PictureBox pict = new PictureBox()
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile(Helper.GetProductPicture(gambar) ?? Helper.GetProductPicture("not_available.png")),
                SizeMode = PictureBoxSizeMode.Zoom

            };
            Button editButton = new Button()
            {
                Text = "Edit",
                BackColor = Color.Black,
                ForeColor = Color.White,
                Width = 50,
            };
            Button deleteButton = new Button()
            {
                Text = "Delete",
                BackColor = Color.White,
                ForeColor = Color.Black,
                Width = 50,
            };
            TableLayoutPanel productPanel = new TableLayoutPanel()
            {
                Width = productPanelsContainer.Width - 20,
                Height = 100,
                ColumnCount = 6,
                RowCount = 2,
                BackColor = Color.White
            };

            editButton.Click += (sender, e) => editButton_click(sender, e, id);
            deleteButton.Click += (sender, e) => deleteButton_click(sender, e, id);
            productPanel.Controls.Add(new Label() { Text = $"Product Name: {nama}", Dock = DockStyle.Fill, Width = 200 }, 1, 0);
            productPanel.Controls.Add(new Label() { Text = $"Price: Rp. {harga}", Dock = DockStyle.Fill, Width = 150 }, 2, 0);
            productPanel.Controls.Add(new Label() { Text = $"Quantity: {qty}", Dock = DockStyle.Fill }, 3, 0);
            productPanel.Controls.Add(pict, 0, 0);
            productPanel.SetRowSpan(pict, 2);
            productPanel.Controls.Add(editButton, 4, 0);
            productPanel.Controls.Add(deleteButton, 5, 0);
            foreach (ColumnStyle style in productPanel.ColumnStyles)
            {
                style.SizeType = SizeType.AutoSize;
            }

            return productPanel;
        }

        private void editButton_click(object sender, EventArgs e, int id_barang)
        {
            AddToCart addToCart = new AddToCart(id_barang);
            if (addToCart.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("Edited Successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadProducts();
            }
        }

        private void deleteButton_click(object sender, EventArgs e, int id_barang)
        {
            if (MessageBox.Show("Are You Sure Wanted to remove this from cart ?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Helper.productInCart.Remove(id_barang);
                loadProducts();
            }
        }

        private void loadProducts()
        {
            foreach (var product in productPanels)
            {
                productPanelsContainer.Controls.Remove(product);
            }
            productPanels.Clear();
            int counter = 0;
            var query = from product in db.Products where Helper.productInCart.Keys.Contains(product.id) && product.deleted_at == null select product;
            sub_total = 0.0M;
            total = 0.0M;
            fee = 0.0M;
            foreach (var product in query)
            {
                TableLayoutPanel productPanel = createProductPanel(product.image_name, product.name, product.price, Helper.productInCart[product.id], product.id);
                sub_total += product.price * Convert.ToInt32(Helper.productInCart[product.id]);
                productPanel.Location = new Point(10, 10 + (110 * counter++));
                productPanels.Add(productPanel);
            }
            fee = sub_total * 0.05M;
            total = sub_total + sub_total * 0.05M;
            subTotal_label.Text = "Rp. " + sub_total.ToString();
            platformFee_label.Text = "Rp. " + fee.ToString();
            total_label.Text = "Rp. " + total.ToString();
            if (payUsingPoint_Checkbox.Checked)
            {
                availablePoint_label.Text = "Rp. " + (customer.point <= total ? customer.point : Convert.ToInt32(total)).ToString();
                amountToPay_label.Text = "Rp. " + (customer.point <= total ? total - customer.point : total - Convert.ToInt32(total)).ToString();
            }
            else
            {
                availablePoint_label.Text = string.Empty;
                amountToPay_label.Text = "Rp. " + total.ToString();
            }
            productPanelsContainer.Controls.AddRange(productPanels.ToArray());
            if (!(productPanels.Count > 0))
                submit_button.Enabled = false;
            else
                submit_button.Enabled = true;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_button_click(object sender, EventArgs e)
        {
            HeaderTransaction headerTransaction = new HeaderTransaction() 
            {
                customer_id= customer.id,
                payment_type_id=Convert.ToInt32(paymentType_comboBox.SelectedValue), 
                datetime=DateTime.Now,
                sub_total=sub_total, 
                point_used=0, 
                payment_code=Helper.GetPaymentCode(), 
                created_at=DateTime.Now, 
            };
            if (payUsingPoint_Checkbox.Checked)
                headerTransaction.point_used = Convert.ToInt32(customer.point <= total ? customer.point : total);
            db.HeaderTransactions.InsertOnSubmit(headerTransaction);
            db.SubmitChanges();
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, headerTransaction);

            PointHistory pointHistory = new PointHistory() 
            { 
                customer_id=customer.id,
                header_transaction_id=headerTransaction.id,
                point_gained=payUsingPoint_Checkbox.Checked ? 0:(int)Math.Round(sub_total*0.2M),
                point_deducted=headerTransaction.point_used, 
                point_before=customer.point, 
                point_after=customer.point - headerTransaction.point_used + (int)Math.Round(sub_total * 0.2M),
                created_at=DateTime.Now
            };
            customer.point = pointHistory.point_after;
            db.PointHistories.InsertOnSubmit(pointHistory);
            db.SubmitChanges();
            List<DetailTransaction> detailTransactions = new List<DetailTransaction>();
            foreach (KeyValuePair<int, string> item in Helper.productInCart)
            {
                var product = (from pd in db.Products where pd.id == item.Key && pd.deleted_at == null select pd).First();
                product.stock -= Convert.ToInt32(item.Value);
                db.SubmitChanges();
                detailTransactions.Add(new DetailTransaction() { header_transaction_id=headerTransaction.id, product_id=item.Key, quantity=Convert.ToInt32(item.Value), price=product.price, created_at=DateTime.Now});
            }
            db.DetailTransactions.InsertAllOnSubmit(detailTransactions);
            db.SubmitChanges();
            Helper.productInCart.Clear();
            PaymentNotification paymentNotification = new PaymentNotification(headerTransaction.payment_code, paymentType_comboBox.Text);
            paymentNotification.ShowDialog(this);
            this.Close();
        }

        private void payUsingAvailablePoint_checkedChanged(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
}
