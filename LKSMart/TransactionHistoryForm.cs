using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class TransactionHistoryForm : Form
    {
        LKSMart_DBDataContext db = new LKSMart_DBDataContext();
        int _customer_id;
        public TransactionHistoryForm(int customer_id)
        {
            InitializeComponent();
            _customer_id = customer_id;
            dataGridView1.DataSource = (from ht in db.HeaderTransactions where ht.customer_id == _customer_id && ht.deleted_at == null select new
            {
                ht.id,
                date=ht.datetime, 
                totalPayment=ht.sub_total, 
                pointGained=ht.point_used == 0 ? ht.sub_total*0.2M:0.0M, 
                pointDeducted=ht.point_used, 
                paymentCode=ht.payment_code, 
            }).ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TableLayoutPanel createProductPanel(string picture, string name, decimal price, int quantity)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Width = panel1.Width - 20;
            tableLayoutPanel.Height = 100;
            tableLayoutPanel.BackColor = Color.White;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 4;

            Label product_name = new Label();
            Label product_price = new Label();
            Label product_quantity = new Label();
            product_name.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
            product_price.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
            product_quantity.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point);
            product_name.Dock = DockStyle.Fill;
            product_price.Dock = DockStyle.Fill;
            product_quantity.Dock = DockStyle.Fill;
            product_name.Text = name;
            product_price.Text = price.ToString();
            product_quantity.Text = quantity.ToString();

            PictureBox product_picture = new PictureBox();
            product_picture.SizeMode = PictureBoxSizeMode.Zoom;
            product_picture.Dock = DockStyle.Fill;
            product_picture.Image = Image.FromFile(Helper.GetProductPicture(picture) ?? Helper.GetProductPicture("not_available.png"));
            

            tableLayoutPanel.Controls.Add(product_picture, 0, 0);
            tableLayoutPanel.SetRowSpan(product_picture, 2);
            tableLayoutPanel.Controls.Add(product_name, 1, 0);
            tableLayoutPanel.Controls.Add(product_price, 2, 0);
            tableLayoutPanel.Controls.Add(product_quantity, 3, 0);

            return tableLayoutPanel;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var query = from dt in db.DetailTransactions
                            join pd in db.Products
                            on dt.product_id equals pd.id
                            where dt.header_transaction_id == id && dt.deleted_at == null
                            select new
                            {
                                picture = pd.image_name,
                                pd.name,
                                pd.price,
                                dt.quantity
                            };
                int counter = 0;
                foreach (var item in query)
                {
                    var productPanel = createProductPanel(item.picture, item.name, item.price, item.quantity);
                    productPanel.Location = new Point(8, (counter++)*110);
                    panel1.Controls.Add(productPanel);
                    
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
            }
        }
    }
}
