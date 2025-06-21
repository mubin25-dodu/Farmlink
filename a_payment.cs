using CefSharp.DevTools.FedCm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            string query = @"SELECT 
                                SUM(agent_share + platform_share + seller_share) AS total_amount,
                                SUM(agent_share) AS agent_fee,
                                SUM(platform_share) AS platform_fee,
                                SUM(seller_share) AS seller_fee
                            FROM pay_history;
";

            db d = new db();
            DataRow dr = d.read(query);
            Total.Text = "Total Amount: " + dr[0].ToString() + " BDT";
            agent.Text = "Agent Fee: " +  dr[1].ToString() + " BDT";
            platform.Text = "Platform Fee: " + dr[2].ToString()  + " BDT";
            seller.Text = "Withdrawable Amount: " +dr[3].ToString() + " BDT";
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
            searchbox.Text = "";
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            tablepanel.Show();
            query = "select * from withdraw where uid like '%" + searchbox.Text + "%'";

            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt.Rows.Count > 0)
            {
                tablepanel.Show();
                table.DataSource = dt;
                table.AutoGenerateColumns = true;
                query = "select sum(amount) as total from withdraw where uid like '%" + searchbox.Text + "%'";
                dt = d.readAll(query);
                noti.Text = "Withdrawed Amount: " + dt.Rows[0]["total"].ToString() + " BDT";

            }
            else
            {
                noti.Text = "No withdraw history found.";
                table.DataSource = null;
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
