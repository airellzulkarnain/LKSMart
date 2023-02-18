using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class AddToCart : Form
    {
        LKSMart_DBDataContext db;
        Product product;
        string qty;
        public AddToCart(int id_barang)
        {
            InitializeComponent();
            db = new LKSMart_DBDataContext();
            product = (from product in db.Products where product.id == id_barang select product).First();
            productName_label.Text = product.name;
            productPrice_label.Text = $"Rp. {product.price}";
            productDescription_label.Text = "";
            product_pictureBox.Image = Image.FromFile(Helper.GetProductPicture(product.image_name) ?? Helper.GetProductPicture("not_available.png"));
            productQuantity_label.Text = Helper.productInCart.TryGetValue(product.id, out qty) ? qty : "0";
            if (product.stock == 0)
                submit_button.Enabled = false;
        }

        private void decrease_button_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(productQuantity_label.Text);
            if (qty > 0)
                productQuantity_label.Text = (--qty).ToString();
        }

        private void increase_button_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(productQuantity_label.Text);
            if (qty < product.stock)
                productQuantity_label.Text = (++qty).ToString();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(productQuantity_label.Text) > 0)
            {
                Helper.productInCart[product.id] = productQuantity_label.Text;
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
