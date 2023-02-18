using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class Shop : Form
    {
        LKSMart_DBDataContext db;
        int? current_category;
        List<ComboBox> breadcrumb;
        List<TableLayoutPanel> productPanels = new List<TableLayoutPanel>();
        public Shop()
        {
            db = new LKSMart_DBDataContext();
            current_category = null;
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            loadProducts();
            breadcrumb = new List<ComboBox>() {
                new ComboBox(){
                    DataSource = (from category in db.Categories where (current_category == null ? category.parent_id == null : category.parent_id == current_category) && category.deleted_at == null select category).ToList(),
                    DisplayMember = "name",
                    ValueMember = "id",
                    DropDownStyle = ComboBoxStyle.DropDownList
                }
            };
            breadcrumb[0].SelectedValueChanged += new EventHandler(breadcrumb_click);
            flowLayoutPanel1.Controls.AddRange(breadcrumb.ToArray());
        }

        private TableLayoutPanel createProductPanel(string gambar, string nama, decimal harga, int stok, int id)
        {
            PictureBox pict = new PictureBox()
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile(Helper.GetProductPicture(gambar) ?? Helper.GetProductPicture("not_available.png")),
                SizeMode = PictureBoxSizeMode.Zoom

            };
            Button addToCart = new Button()
            {
                Text = "Add To Cart",
                BackColor = Color.Black,
                ForeColor = Color.White,
                Width=100,
            };
            TableLayoutPanel productPanel = new TableLayoutPanel() 
            { 
                Width = productPanelContainer.Width - 40, 
                Height = 100, 
                ColumnCount = 5, 
                RowCount = 2, 
                BackColor = Color.White
            };

            addToCart.Click += (sender, e) => openAddToCart(sender, e, id);
            productPanel.Controls.Add(new Label() { Text = $"Product Name: {nama}", Dock=DockStyle.Fill, Width=200 }, 1, 0);
            productPanel.Controls.Add(new Label() { Text = $"Price: Rp. {harga}", Dock=DockStyle.Fill, Width=200 }, 2, 0);
            productPanel.Controls.Add(new Label() { Text = $"Stock: {stok}", Dock=DockStyle.Fill }, 3, 0);
            productPanel.Controls.Add(pict, 0, 0);
            productPanel.SetRowSpan(pict, 2);
            productPanel.Controls.Add(addToCart, 4, 0);
            foreach (ColumnStyle style in productPanel.ColumnStyles)
            {
                style.SizeType = SizeType.AutoSize;
            }

            return productPanel;
        }

        private void keyword_keyup(object sender, EventArgs e) 
        {
            loadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<int> getCategory(int starting_point)
        {
            List<int> temp = (from category in db.Categories where category.parent_id == starting_point && category.deleted_at == null select category.id).ToList();
            List<int> result = temp.ToList();
            foreach (var item in temp)
            {
                result.AddRange(getCategory(item));
            }
            return result;
        }

        private void loadProducts()
        {
            foreach (var product in productPanels)
            {
                productPanelContainer.Controls.Remove(product);
            }
            productPanels.Clear();
            List<int> category_ids = new List<int>();
            if (current_category != null)
                category_ids = getCategory(current_category.Value);
            var query = from product in db.Products
                        where product.deleted_at == null
                        && SqlMethods.Like(product.name, $"%{keyword_textBox.Text}%")
                        && product.price >=
                        ((minPrice_textBox.Text.Length > 0) ? Convert.ToInt32(minPrice_textBox.Text) : 0)
                        && product.price <=
                        ((maxPrice_textBox.Text.Length > 0) ? Convert.ToInt32(maxPrice_textBox.Text) : int.MaxValue)
                        && (current_category == null ? true : category_ids.Contains(product.category_id) || product.category_id == current_category)
                        && product.deleted_at == null
                        select product;

            int counter = 0;
            foreach (var product in query)
            {
                TableLayoutPanel productPanel = createProductPanel(product.image_name, product.name, product.price, product.stock, product.id);
                productPanel.Location = new Point(10, 10 + (110 * counter++));
                productPanels.Add(productPanel);
            }
            productPanelContainer.Controls.AddRange(productPanels.ToArray());
        }

        private void price_textChanged(object sender, EventArgs e)
        {
            TextBox price = sender as TextBox;
            if (price.Text.Length > 0 && !price.Text.All(x => "1234567890".Contains(x)))
            {
                price.Text = price.Text.Substring(0, price.Text.Length - 1);
            }
            loadProducts();
        }

        private void openAddToCart(object sender, EventArgs e, int id_barang)
        {
            AddToCart addToCart = new AddToCart(id_barang);
            if(addToCart.ShowDialog(this) == DialogResult.OK)
                MessageBox.Show("Product Added to Cart !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void breadcrumb_click(object sender, EventArgs e)
        {
            foreach (Control item in breadcrumb)
            {
                flowLayoutPanel1.Controls.Remove(item);
            }
            ComboBox current_breadcrumb_item = sender as ComboBox;
            ComboBox breadcrumb_item = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
            Category temp = current_breadcrumb_item.SelectedItem as Category;
            current_category = temp.id;
            var data = (from category in db.Categories where (current_category == null ? category.parent_id == null : category.parent_id == current_category.Value) && category.deleted_at == null select category).ToList();
            breadcrumb_item.DataSource = data;
            breadcrumb_item.DisplayMember = "name";
            breadcrumb_item.ValueMember = "id";
            breadcrumb_item.SelectedValueChanged += new EventHandler(breadcrumb_click);
            breadcrumb = breadcrumb.GetRange(0, breadcrumb.IndexOf(current_breadcrumb_item) + 1);
            if (breadcrumb.IndexOf(breadcrumb_item) == -1 && data.Count > 0)
            {
                breadcrumb.Add(breadcrumb_item);
            }
            flowLayoutPanel1.Controls.AddRange(breadcrumb.ToArray());
            loadProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in breadcrumb)
            {
                flowLayoutPanel1.Controls.Remove(item);
            }
            current_category = null;
            breadcrumb = breadcrumb.GetRange(0, breadcrumb.IndexOf(breadcrumb[0]) + 1);
            flowLayoutPanel1.Controls.AddRange(breadcrumb.ToArray());
            loadProducts();
        }
    }
}
