using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class agent_home : Form
    {
        private string agent_id;
        private string query;
        private string seller_id;

        public agent_home( string id)
        {
            InitializeComponent();
            this.agent_id= id;
        }

        private void agent_home_Load(object sender, EventArgs e)
        {   
            count.Hide();
            Req.PerformClick();
            tablepanel.Hide();
            profilecard.Hide();
           agent.Hide();

        }

        private void Req_Click(object sender, EventArgs e)
        {

            tablepanel.Show();
            query = "select * from commission where agent_id = '"+agent_id+"' and status = 'pending'";
            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt.Rows.Count > 0)
            {
                count.Show();
                count.Text = dt.Rows.Count.ToString();
                table.DataSource = dt;
                table.AutoGenerateColumns = true;
                if (table.Columns.Contains("Profile"))
                {
                    table.Columns.Remove("Profile");
                }
                DataGridViewButtonColumn profile = new DataGridViewButtonColumn();
                profile.HeaderText = "Profile";
                profile.Text = "Profile";
                profile.UseColumnTextForButtonValue = true;
                profile.Name = "Profile";
                table.Columns.Insert(0, profile);
            }
            else
            {
                noti.Text = "No pending requests found.";
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                profilecard.Show();
                 seller_id = table.Rows[e.RowIndex].Cells["seller_id"].Value.ToString();
                query = "select * from userinfo where uid = '"+seller_id+"' ";


                db d = new db();
                DataRow dr = d.read(query);
                if (dr != null)
                {
                    query = "select * from product where seller_id = '"+seller_id+"' ";
                    DataTable dt = d.readAll(query);
                    if (dt != null) {
                        profiletable.DataSource = dt;
                        profiletable.AutoGenerateColumns = true;
                        profiletable.Columns.Remove("seller_id");
                        profiletable.Columns.Remove("product_id");
                        profiletable.Columns.Remove("image");
                        if (table.Rows[e.RowIndex].Cells["status"].Value.ToString() =="pending") { 
                            profiletable.Columns.Remove("agent_id");
                        }
                       
                    }
                    else
                    {
                        notipro.Text = "No products found for this seller.";
                    }
                    query = "select sum(quantity) from orderhistory where seller_id = '" + seller_id + "' and status = 'received' ";
                    DataRow orderCount = d.read(query);
                    if (orderCount != null) {
                        notipro.Text = "Total product sold -> " + orderCount[0].ToString();
                    }
                    else
                    {
                        notipro.Text = "No orders found for this seller.";
                    }
                    name.Text = dr["fullname"].ToString();
                    mail.Text = dr["mail"].ToString();
                    profile.Image = Image.FromFile(dr["profile_pic"].ToString());
                    workingwith.Text = dr["fulladdress"].ToString() + " , " + dr["district"].ToString();
                    //comm.Text = dr["comm_percent"].ToString() + "%";
                    
                }
                else
                {
                   
                }

                
            }
        }

        private void spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            profilecard.Hide();
        }

        private void donep_Click(object sender, EventArgs e)
        {
            query = "update commission set status = 'accepted' where agent_id = '" + agent_id + "' ";
            Console.WriteLine("agent---"+agent_id);
            db d = new db();
            if (d.write(query) == 1)
            {
                MessageBox.Show("Request accepted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                profilecard.Hide();
                table.DataSource = null;
                Req.PerformClick();
            }
            else
            {
                MessageBox.Show("Failed to accept request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            tablepanel.Hide();
            profilecard.Hide();
            table.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            query = "update commission set status = 'rejected' where agent_id = '" + agent_id + "' ";
            db d = new db();
            if (cancel.Text== "cancel" && d.write(query) == 1)
            {
                profilecard.Hide();
                table.DataSource = null;
                Req.PerformClick();
            }
            else if (cancel.Text=="Remove") {
                string query = "update product set agent_id = NULL from product where seller_id ='"+seller_id+"' and agent_id = '"+agent_id+"' ";
                string q2 = "delete from commission where agent_id= '"+agent_id+"' and seller_id ='"+seller_id+"' ";
                db d2 = new db();
                d2.write(query);
                d2.write(q2);
                profilecard.Hide();
                table.DataSource = null;
                Req.PerformClick();
            }
            else
            {
                MessageBox.Show("Failed to reject request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sellers_Click(object sender, EventArgs e)
        {
            tablepanel.Show();
            accept.Hide();
            cancel.Text ="Remove";
            query = "select * from commission where agent_id = '" + agent_id + "' and status = 'accepted'";
            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt.Rows.Count > 0)
            {
                tablepanel.Show();
                table.DataSource = dt;
                table.AutoGenerateColumns = true;
                if (table.Columns.Contains("Profile"))
                {
                    table.Columns.Remove("Profile");
                }
                DataGridViewButtonColumn profile = new DataGridViewButtonColumn();
                profile.HeaderText = "Profile";
                profile.Text = "Profile";
                profile.UseColumnTextForButtonValue = true;
                profile.Name = "Profile";
                table.Columns.Insert(0, profile);

              
            }
            else
            {
                noti.Text = "No sellers found.";
            }
        }

        private void mypbtn_Click(object sender, EventArgs e)
        {
           agent_products products = new agent_products(agent_id);
            spanel.Controls.Clear();
            spanel.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.BringToFront();
            products.Show();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            sell_order order = new sell_order(agent_id, "agent_id");
            spanel.Controls.Clear();
            spanel.Controls.Add(order);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            intro form2 = new intro();
            form2.Show();
            this.Close();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            s_payment paymentControl = new s_payment(agent_id, "agent_id");
            spanel.Controls.Clear();
            spanel.Controls.Add(paymentControl);

        }

        private void home_Click(object sender, EventArgs e)
        {
            spanel.Controls.Remove(tablepanel);
            spanel.Controls.Clear();
            spanel.Controls.AddRange( new Control[] { tablepanel , Req , sellers, count , info } );
            tablepanel.Hide();

        }

        private void profilecard_Paint(object sender, PaintEventArgs e)
        {

        }


        private void info_Click(object sender, EventArgs e)
        {
            string query = "select * from agent where agent_id = '" + agent_id + "' and status <> 'approved'";
            db d = new db();
            DataRow dr = d.read(query);
            if (dr != null)
            {
                MessageBox.Show("you are already an agent. or wait for few min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                agent.Show();
            }
            
        }

        private void apply_Click_1(object sender, EventArgs e)
        {
            string query = "insert into agent (agent_id , name , working_area_2 ,  comm_percent , status) values ('" + agent_id + "','" + fullname.Text + "','" + district.Text + "' , '" + comm.Text + "' , 'pending')";
            db d = new db();
            if (d.write(query) == 1)
            {
                MessageBox.Show("Request sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                agent.Hide();
               
            }
            else
            {
                MessageBox.Show("Failed to send request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            agent.Hide();
        }
    }
}
