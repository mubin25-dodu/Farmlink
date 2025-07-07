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
        private string seller_id;
        private string query,query2;
        private double withdrawable_balance;
        private string role;
        public s_payment(string id , string r)
        {
            InitializeComponent();

            this.seller_id = id;
            this.role = r;


        }

        private void Totalcard_Click(object sender, EventArgs e)
        {

        }

        private void s_payment_Load(object sender, EventArgs e)
        {
            mobilepay.Visible = false;
            stats();
        }
        private void stats() {
            db d = new db();
            if (role == "agent_id")
            {
                query = query = "SELECT " +
                      "  ISNULL((SELECT SUM(ISNULL(p.seller_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS total_sell, " +

                      "  (ISNULL((SELECT SUM(ISNULL(p.seller_share, 0)) " +
                      "    FROM pay_history p " +
                      "    JOIN orderhistory o ON o.history_id = p.history_id " +
                      "    WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) - " +
                      "   ISNULL((SELECT SUM(ISNULL(w.amount, 0)) FROM withdraw w WHERE w.uid = '" + seller_id + "'), 0)) AS withdrawable_balance, " +

                      " ISNULL((SELECT SUM(ISNULL(w.amount, 0)) " +
                      "   FROM withdraw w " +
                      "   WHERE w.uid = '" + seller_id + "'), 0) AS total_withdrawn, " +

                      "  ISNULL((SELECT SUM(ISNULL(p.platform_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS platformshare, " +

                      "  ISNULL((SELECT SUM(ISNULL(p.agent_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS agentshare";

                DataRow dr = d.read(query);
                if (dr != null && dr[0] != DBNull.Value)
                {
                    Total.Text = "Total Amount: " + dr[0].ToString() + " BDT";
                    Withdraw.Text = "Withdrawable Amount: " + dr[1].ToString() + " BDT";
                    Withdrawn.Text = "Withdrawed Amount: " + dr[2].ToString() + " BDT";
                    withdrawable_balance = double.Parse(dr[1].ToString());
                    platformfee.Hide();
                    Platformfeebtn.Hide();
                    agent.Hide();
                    agentfee.Hide();
                    Pending.Hide();
                    Pendingcard.Hide();

                }
                else
                {
                    Total.Text = "Total Amount: 0 BDT";
                    Withdraw.Text = "Withdrawable Amount: 0 BDT";
                    Withdrawn.Text = "Withdrawed Amount: 0 BDT";

                }

            }
            else if (role == "seller_id")
            {
                query = "SELECT " +
                      "  ISNULL((SELECT SUM(ISNULL(p.seller_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS total_sell, " +

                      "  (ISNULL((SELECT SUM(ISNULL(p.seller_share, 0)) " +
                      "    FROM pay_history p " +
                      "    JOIN orderhistory o ON o.history_id = p.history_id " +
                      "    WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) - " +
                      "   ISNULL((SELECT SUM(ISNULL(w.amount, 0)) FROM withdraw w WHERE w.uid = '" + seller_id + "'), 0)) AS withdrawable_balance, " +

                      " ISNULL((SELECT SUM(ISNULL(w.amount, 0)) " +
                      "   FROM withdraw w " +
                      "   WHERE w.uid = '" + seller_id + "'), 0) AS total_withdrawn, " +

                      "  ISNULL((SELECT SUM(ISNULL(p.platform_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS platformshare, " +

                      "  ISNULL((SELECT SUM(ISNULL(p.agent_share, 0)) " +
                      "   FROM pay_history p " +
                      "   JOIN orderhistory o ON o.history_id = p.history_id " +
                      "   WHERE o." + role + " = '" + seller_id + "' AND status = 'received'), 0) AS agentshare";

                query2 = "select SUM( ISNULL(total_price, 0)) AS total_sales from orderhistory where seller_id='" + seller_id + "' and status = 'on the way' ";
                DataRow drr = d.read(query2);
                Pending.Text = "Pending Amount: " + (0 + drr[0].ToString()) + " BDT";
                DataRow dr = d.read(query);
                if (dr != null && dr[0] != DBNull.Value)
                {
                    Total.Text = "Total Amount: " + dr[0].ToString() + " BDT";
                    Withdraw.Text = "Withdrawable Amount: " + dr[1].ToString() + " BDT";
                    Withdrawn.Text = "Withdrawed Amount: " + dr[2].ToString() + " BDT";
                    platformfee.Text = "Platform Fee: " + dr[3].ToString() + " BDT";
                    agent.Text = "Agent Fee: " + dr[4].ToString() + " BDT";

                    withdrawable_balance = double.Parse(dr[1].ToString());
                }
                else
                {
                    Total.Text = "Total Amount: 0 BDT";
                    Withdraw.Text = "Withdrawable Amount: 0 BDT";
                    Withdrawn.Text = "Withdrawed Amount: 0 BDT";
                    platformfee.Text = "Platform Fee: 0 BDT";
                    agentfee.Text = "Agent Fee: 0 BDT";
                }
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
            if (num.Text=="" || am.Text=="") { 
                        MessageBox.Show("fill the box.");
            }
            else
            { double amount = double.Parse(am.Text);
                if (withdrawable_balance > amount)
                {
                    string query = "INSERT INTO withdraw  values('" + double.Parse(am.Text) + "' , '" + seller_id + "' , getdate() , '" + num.Text + "')";
                    db d = new db();

                    if (d.write(query) > 0)
                    {
                        MessageBox.Show("Withdraw successfull.");
                        mobilepay.Visible = false;
                       
                        stats();
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
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            s_payment k = new s_payment(seller_id ,"seller_id");
            mobilepay.Visible = false;

        }

        private void Withdrawnbtn_Click(object sender, EventArgs e)
        {

        }

        private void Withdrawn_Click(object sender, EventArgs e)
        {

        }

        private void Withdraw_Click(object sender, EventArgs e)
        {

        }
    }
}
