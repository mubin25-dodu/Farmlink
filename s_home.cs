using CefSharp.DevTools.Profiler;
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
    public partial class S_Home : Form
    {
       private string id; // User ID
       private string fullname;
       private string district;
       private string agent_id;

        public S_Home(string i)
        {
            InitializeComponent();
            id = i;
            DataRow dr = new db().read("SELECT * FROM userinfo WHERE uid = '" + id + "'");


            sname.Text = dr[1].ToString();
            Console.WriteLine(name);
            propic.Image = Image.FromFile(dr[7].ToString());

                fullname = dr[1].ToString();
                district = dr[9].ToString();
                Console.WriteLine(fullname);
                Console.WriteLine(district);
          
        }

        private void btnactive(object sender, EventArgs e)
        {
            foreach (Control b in btnpanel.Controls)
            {
                if (b is Button)
                {
                    b.BackColor = Color.FromArgb(21, 72, 84);
                }
            }

            Control click = (Control)sender;
            click.BackColor = Color.FromArgb(30, 43, 39);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnactive(mypbtn, null);
            spanel.Controls.Clear();
            sproduct signinControl = new sproduct(id);
            spanel.Controls.Add(signinControl);
        }

        private void home_Click(object sender, EventArgs e)
        {
            btnactive(home, null);

            spanel.Controls.Clear();
            spanel.Controls.AddRange(new Control[] { Total, Totalcard, agent, agentfee, hireag, hire, tablepanel });
            tablepanel.Hide();
            profilecard.Hide();

        }

        private void S_Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
            tablepanel.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            btnactive(orderbtn, null);

            spanel.Controls.Clear();
            sell_order signinControl = new sell_order(id, "seller_id");
            signinControl.Dock = DockStyle.Fill;
            spanel.Controls.Add(signinControl);
        }

        private void payment_Click(object sender, EventArgs e)
        {
            btnactive(payment, null);
            spanel.Controls.Clear();
            s_payment a = new s_payment(id, "seller_id");
            a.Dock = DockStyle.Fill;
            spanel.Controls.Add(a);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agentfee_Click(object sender, EventArgs e)
        {

        }

        private void hire_Click(object sender, EventArgs e)
        {


            profilecard.Hide();
            tablepanel.Show();
            tablepanel.BringToFront();
            string query = "select  u.fullname as fullname , u.mail as mail , profile_pic as pro , district as area2, working_area_2 as address, comm_percent  as comm,rating as rate, agent_id as agent from userinfo u join agent a on a.agent_id = u.uid where status_ = 'approved' and (working_area_2 = '" + district + "' or district = '" + district + "') ";
            DataTable dt = new db().readAll(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                agentcount.Text = "Number Of Orders -> " + dt.Rows.Count;
                //order.ColumnCount = 6;
                agenttable.AutoGenerateColumns = true;
                agenttable.DataSource = dt;


                if (agenttable.Columns.Contains("hire"))
                {
                    agenttable.Columns.Remove("hire");
                }

                DataGridViewButtonColumn cancel = new DataGridViewButtonColumn();
                cancel.HeaderText = " hire agent ";
                cancel.Text = "hire";
                cancel.Name = "hire";
                cancel.UseColumnTextForButtonValue = true;
                cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //cancel.InheritedStyle.ForeColor = Color.Red;

                agenttable.Columns.Insert(0, cancel);
            }
            else
            {
                MessageBox.Show("No agents available in your district.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void tablepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            tablepanel.Hide();
        }

        private void agenttable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {

                profilecard.Show();
                name.Text = agenttable.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                mail.Text = agenttable.Rows[e.RowIndex].Cells["mail"].Value.ToString();
                profile.Image = Image.FromFile(agenttable.Rows[e.RowIndex].Cells["pro"].Value.ToString());
                workingwith.Text = agenttable.Rows[e.RowIndex].Cells["address"].Value.ToString() + " , " + agenttable.Rows[e.RowIndex].Cells["area2"].Value.ToString(); ;
                comm.Text = agenttable.Rows[e.RowIndex].Cells["comm"].Value.ToString() + "%";
                rating.Text = agenttable.Rows[e.RowIndex].Cells["rate"].Value.ToString() + " / 5.0";
                agent_id = agenttable.Rows[e.RowIndex].Cells["agent"].Value.ToString();
                string q = "select * from commission where seller_id ='" + id + "' and status ='accepted'";
                DataRow d = new db().read(q);

                if (d != null)
                {
                    cancelctn.Text = "Remove my agent";

                }
                else { }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            profilecard.Hide();
            if (cancelctn.Text== "Remove my agent") {
                string q = "select * from commission where seller_id ='" + id + "' and status ='accepted'";
                DataRow d = new db().read(q);
                string query = "delete from commission where seller_id ='" + id + "' and status ='accepted'";
                string query2 = "update userinfo set status_ = 'approved' where uid = '" + agent_id + "'";
                string query3 = "update product set agent_id = NULL where seller_id = '" + id + "'";
                db dd = new db();
                dd.write(query2);
                dd.write(query3);
                if (dd.write(query) > 0)
                {
                    MessageBox.Show("Agent removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    profilecard.Hide();
                    tablepanel.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to remove agent. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void donep_Click(object sender, EventArgs e)
        {
            string q = "select * from commission where seller_id ='" + id + "' and status ='accepted'";
            DataRow d = new db().read(q);

            if (d == null)
            {
                db d1 = new db();
                string q1 = "select * from commission where agent_id = '" + agent_id + "' and seller_id = '" + id + "'";
                DataRow dr = d1.read(q1);
                if (dr != null)
                {
                    MessageBox.Show("You have already hired this agent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string query = "insert into commission values('" + id + "','pending','" + agent_id + "' )";

                    if (d1.write(query) > 0)
                    {
                        MessageBox.Show("request send. wait for responce", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        profilecard.Hide();
                        tablepanel.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to hire agent. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You already have an agent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            profilecard.Hide();
        }
    }
    
}