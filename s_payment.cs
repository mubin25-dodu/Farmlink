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
    public partial class s_payment : UserControl
    {
        string seller_id;
        string query;
        double withdrawable_balance;
        public s_payment(string id)
        {
            InitializeComponent();

            this.seller_id = id;


        }

        private void Totalcard_Click(object sender, EventArgs e)
        {

        }

        private void s_payment_Load(object sender, EventArgs e)
        {
            mobilepay.Visible = false;

            query = "SELECT SUM(p.seller_share) AS total_sell,  " +
                " SUM(o.total_price) AS total_sales,  SUM(p.seller_share - w.amount) AS withdrawable_balance,  " +
                "  SUM(w.amount) AS total_withdrawn, sum(p.platform_share) as platformshare,  sum(p.agent_share) as " +
                "agentshare FROM pay_history p JOIN orderhistory o ON o.history_id = p.history_id LEFT JOIN withdraw w ON  w.uid = o.seller_id  " +
                "WHERE o.seller_id = '" + seller_id + "'and status Not like '%cancel%' or status = 'recived' ";
            db d = new db();
            DataRow dr = d.read(query);
            if (dr != null && dr[0] != DBNull.Value)
            {
                Total.Text = "Total Amount: " + dr[0].ToString() + " BDT";
                Pending.Text = "Pending Amount: " + dr[1].ToString() + " BDT";
                Withdraw.Text = "Withdrawable Amount: " + dr[2].ToString() + " BDT";
                Withdrawn.Text = "Withdrawed Amount: " + dr[3].ToString() + " BDT";
                platformfee.Text = "Platform Fee: " + dr[4].ToString() + " BDT";
                agent.Text = "Agent Fee: " + dr[5].ToString() + " BDT";
                withdrawable_balance = double.Parse(dr[2].ToString());
            }
            else
            {
                Total.Text = "Total Amount: 0 BDT";
                Pending.Text = "Pending Amount: 0 BDT";
                Withdraw.Text = "Withdrawable Amount: 0 BDT";
                Withdrawn.Text = "Withdrawed Amount: 0 BDT";
                platformfee.Text = "Platform Fee: 0 BDT";
                agentfee.Text = "Agent Fee: 0 BDT";
            }
        }

        private void Platformfeebtn_Click(object sender, EventArgs e)
        {

        }

        private void Withdrawabtn_Click(object sender, EventArgs e)
        {
            mobilepay.Visible = true;
        }

        private void donep_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(am.Text);
            if (withdrawable_balance > amount)
            {
                string query = "INSERT INTO withdraw  values('" + double.Parse(am.Text) + "' , '" + seller_id + "' , getdate() , '" + num.Text + "')";
                db d = new db();

                if (d.write(query) > 0)
                {
                    MessageBox.Show("Withdraw successfull.");
                    mobilepay.Visible = false;
                    s_payment k = new s_payment(seller_id);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Not Enough Balance.");
                am.Text.Clone();
                am.Focus();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            s_payment k = new s_payment(seller_id);
            mobilepay.Visible = false;

        }
    }
}
