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
    public partial class Login : Form
    {
        public int customer_id { get; set; } = 0;
        LKSMart_DBDataContext db;
        public Login()
        {
            InitializeComponent();
            db = new LKSMart_DBDataContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phone_or_email.Focus();
        }

        private void toPinNumber(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                pin.Focus();
        }

        private void Submit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                loginButton.PerformClick();
            }
        }

        private void PerformLogin(object sender, EventArgs e)
        {
            var query =
                from Customer in db.Customers
                where
                (Customer.phone_number == phone_or_email.Text
                || Customer.email == phone_or_email.Text)
                && Customer.pin_number == pin.Text
                && Customer.deleted_at == null
                select Customer;
            Customer  customer = query.FirstOrDefault();
            if (customer != null)
            {
                customer_id = customer.id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Your Phone Number/Email or Password is invalid or your account is deleted !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone_or_email.Text = string.Empty;
                phone_or_email.Focus();
                pin.Text = string.Empty;
            }
        }
    }
}
