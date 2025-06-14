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
    public partial class a_payment : UserControl
    {
        string query;
        public a_payment()
        {
            
            InitializeComponent();
       }

        private void Totalcard_Click(object sender, EventArgs e)
        {
           
        }

        private void a_payment_Load(object sender, EventArgs e)
        {
            tablepanel.Hide();
            query = "select sum(agent_share + platform_share + seller_share) from pay_history ";
            db d = new db();
            DataRow dr = d.read(query);
            Total.Text = "Total Amount: " + dr[0].ToString() + " BDT";
            query = "select sum(agent_share) from pay_history";
            dr = d.read(query);
            agent.Text = "Agent Fee: " + dr[0].ToString() + " BDT";
            query = "select sum(platform_share) from pay_history";
            dr = d.read(query);
            platform.Text = "Platform Fee: " + dr[0].ToString() + " BDT";
            query = "select sum(seller_share) from pay_history";
            dr = d.read(query);
            seller.Text = "Withdrawable Amount: " + dr[0].ToString() + " BDT";

            query = "select sum(amount) from withdraw";
            dr = d.read(query);
            widthdrawd.Text = "Withdrawed Amount: " + dr[0].ToString() + " BDT";
            noti.Text = widthdrawd.Text;

        }

        private void widthdraw_Click(object sender, EventArgs e)
        {
            tablepanel.Show();
            query = "select * from withdraw ";
            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt.Rows.Count > 0)
            {
                tablepanel.Show();
                table.DataSource = dt;
                table.AutoGenerateColumns = true;
            }
            else
            {
                MessageBox.Show("No withdraw history found.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tablepanel.Hide();
            table.DataSource = null;
        }
    }
}
