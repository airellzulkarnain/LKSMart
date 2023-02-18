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
    public partial class PointHistoryForm : Form
    {
        LKSMart_DBDataContext db = new LKSMart_DBDataContext();
        Customer customer;
        public PointHistoryForm(int customer_id)
        {
            InitializeComponent();
            customer = (from customer in db.Customers where customer.id == customer_id select customer).First();
            currentPoint_label.Text = $"Current Point \t{customer.point}";
            dataGridView1.DataSource =
                (from ph in db.PointHistories
                 join ht in db.HeaderTransactions
                 on
                 ph.header_transaction_id equals ht.id
                 where ph.customer_id == customer.id && ph.point_gained > 0
                 && ph.deleted_at == null 
                 select
                 new
                 {
                     Date = ph.created_at,
                     PaymentCode = ht.payment_code,
                     PointGained = ph.point_gained,
                     PointBefore = ph.point_before,
                     PointAfter = ph.point_after,
                 }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PointHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
