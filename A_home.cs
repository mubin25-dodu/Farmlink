using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class A_home : Form
    {
        string admin_id;
        public A_home(string id)
        {
            InitializeComponent();
            this.admin_id = id;
        }

        private void A_home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
             apanel.Controls.Clear();
             a_orders aOrdersControl = new a_orders();
                apanel.Controls.Add(aOrdersControl);

        }

        private void manage_Click(object sender, EventArgs e)
        {
            a_manageuser m= new a_manageuser(admin_id);
            apanel.Controls.Clear();
            apanel.Controls.Add(m);

        }

        private void payment_Click(object sender, EventArgs e)
        {
            a_payment paymentControl = new a_payment();
            apanel.Controls.Clear();
            apanel.Controls.Add(paymentControl);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                intro form2 = new intro();
                form2.Show(); this.Visible = false;
            }
        }
    }
}
