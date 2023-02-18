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
    public partial class Main : Form
    {
        LKSMart_DBDataContext db;
        private Customer _customer;
        public Main(int customer_id)
        {
            InitializeComponent();
            db = new LKSMart_DBDataContext();
            _customer = (
                from customer in db.Customers
                where customer.id == customer_id
                select customer
                ).First();
            greeting.Text = $"Welcome, {_customer.name}!";
            profilePicutre.Image = Image.FromFile(
                Helper.GetProfilePicture(_customer.profile_image_name)
                ?? Helper.GetProfilePicture("default_profile_picture")
                );
            timer1.Start();

        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CurrentTime(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure want to log out ?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void tableLayoutPanel3_MouseHover(object sender, EventArgs e)
        {
            Control menu = sender as Control;
            menu.Parent.BackColor = Color.LightSkyBlue;
        }

        private void tableLayoutPanel2_MouseLeave(object sender, EventArgs e)
        {
            Control menu = sender as Control;
            menu.Parent.BackColor = SystemColors.Control;
        }

        private void ProfileMenu_click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(_customer.id);
            if (profileForm.ShowDialog(this) == DialogResult.Cancel)
            {
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, _customer);
                greeting.Text = $"Welcome, {_customer.name}!";
                profilePicutre.Image = Image.FromFile(Helper.GetProfilePicture(_customer.profile_image_name)
                    ?? Helper.GetProfilePicture("default_profile_image"));
            }
        }

        private void ShopMenu_click(object sender, EventArgs e)
        {
            Form shop = new Shop();
            shop.ShowDialog(this);
        }

        private void TransactionHistory_click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm(_customer.id);
            transactionHistoryForm.ShowDialog(this);
        }

        private void PointHistory_click(object sender, EventArgs e)
        {
            PointHistoryForm pointHistoryForm = new PointHistoryForm(_customer.id);
            pointHistoryForm.ShowDialog(this);
        }

        private void Cart_click(object sender, EventArgs e)
        {
            Cart cart = new Cart(_customer.id);
            cart.ShowDialog(this);
        }
    }
}
