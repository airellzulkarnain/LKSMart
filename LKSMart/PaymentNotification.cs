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
    public partial class PaymentNotification : Form
    {
        public PaymentNotification(string paymentCode, string paymentType)
        {
            InitializeComponent();
            label2.Text = $"Your order has been submitted successfully. Please continue the payment proccess in your {paymentType} application.\n\nPlease input this code for the payment proccess.\n{paymentCode}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
