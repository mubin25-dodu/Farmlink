using CefSharp.DevTools.Autofill;
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
using System.Xml.Linq;

namespace Farmlink
{
    public partial class A_home : Form
    {
        private string admin_id;
        
        public A_home(string id)
        {
            InitializeComponent();
            this.admin_id = id;

            DataRow dr = new db().read("SELECT * FROM userinfo WHERE uid = '" + id + "'");

            
            name.Text = dr[1].ToString();
            Console.WriteLine(name);
            propic.Image = Image.FromFile(dr[7].ToString());

        }

        private void A_home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
            tablepanel.Hide();
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
        private void orderbtn_Click(object sender, EventArgs e)
        {
            btnactive(orderbtn, null);
            apanel.Controls.Clear();
            a_orders aOrdersControl = new a_orders();
            apanel.Controls.Add(aOrdersControl);

        }

        private void manage_Click(object sender, EventArgs e)
        {
            btnactive(manage, null);
            a_manageuser m = new a_manageuser(admin_id);
            apanel.Controls.Clear();
            apanel.Controls.Add(m);

        }

        private void payment_Click(object sender, EventArgs e)
        {
            btnactive(payment, null);
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

        private void apanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            btnactive(home, null);

            apanel.Controls.Clear();
            apanel.Controls.AddRange(new Control[] { tablepanel , agent_section });
            tablepanel.Hide();
        }

        private void agent_section_Click(object sender, EventArgs e)
        {
            tablepanel.Show();
            string query = "SELECT * FROM agent where status <> 'approved'";
            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                agentcount.Text = "Number Of request -> " + dt.Rows.Count;
                agenttable.AutoGenerateColumns = true;
                agenttable.DataSource = dt;


                if (agenttable.Columns.Contains("Accept"))
                {
                    agenttable.Columns.Remove("Accept");
                }

                DataGridViewButtonColumn cancel = new DataGridViewButtonColumn();
                cancel.HeaderText = " hire agent ";
                cancel.Text = "Accept";
                cancel.Name = "Accept";
                cancel.UseColumnTextForButtonValue = true;
                cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                agenttable.Columns.Insert(0, cancel);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            tablepanel.Hide();
        }

        private void agenttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string query = "update agent set status = 'approved' where agent_id = '" + agenttable.Rows[e.RowIndex].Cells["agent_id"].Value.ToString() + "'";
                db d = new db();
                if (d.write(query) == 1)
                {
                    MessageBox.Show("Agent Approved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Failed to approve agent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
