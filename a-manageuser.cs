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
    public partial class a_manageuser : UserControl
    {
        private string query;
        private string admin_id;
        private string clicked = " ";
        public a_manageuser(string id)
        {
            InitializeComponent();
            this.admin_id = id;
          
        }

        private void loadproducts(string query) {
            table.DataSource = null;
            tablepanel.Show();

            db d = new db();
            DataTable dt = d.readAll(query);
            if (dt.Rows != null)
            {
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
            //clicked = " ";
        }

        private void ban_user_Click(object sender, EventArgs e)
        {
            clicked = "ban";
            query = "select * from userinfo where status_ <> '%approved%'";
            loadproducts(query);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            table.DataSource = null;
            tablepanel.Hide();
            profilecard.Hide();

        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (accept.Text != "Ban User")
            {
                query = "update userinfo set status_ = 'approved' where uid = '" + userid.Text + "'";
            }
            else
            {
                query = "update userinfo set status_ = 'ban' where uid = '" + userid.Text + "'";
            }
            db d = new db();
            if (d.write(query) == 1)
            {
                profilecard.Hide();

                if (clicked == "customer") {
                    query = "select * from userinfo where status_ ='approved' and uid like '%cu-%'";

                }
                else if (clicked == "ban") {
                    query = "select * from userinfo where status_ <> 'approved'";
                }
                else if (clicked == "agent")
                {
                    query = "select * from userinfo where status_ ='approved' and uid like '%ag-%'";
                }
                else if (clicked == "seller")
                {
                    query = "select * from userinfo where status_ ='approved' and uid like '%se-%'";
                }
                else if (clicked == "agdmin")
                {
                    query = "select * from userinfo where status_ ='approved' and uid like '%ad-%'";
                }
                loadproducts(query);
            }
            else
            {
                MessageBox.Show("Failed to approve user.");
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.ColumnIndex==0) { 
                    profilecard.Show();
                    userid.Text =table.Rows[e.RowIndex].Cells["uid"].Value.ToString();

                    name.Text = "Name:" + table.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                    mail.Text = "Mail:"+table.Rows[e.RowIndex].Cells["mail"].Value.ToString();
                    address.Text ="Address:"+ table.Rows[e.RowIndex].Cells["fulladdress"].Value.ToString();
                    profile.Image = Image.FromFile(table.Rows[e.RowIndex].Cells["profile_pic"].Value.ToString());
                if (table.Rows[e.RowIndex].Cells["status_"].Value.ToString() == "ban") { 
                 reject.Hide();
                 accept.Text = "Unban User";
                }
                if (table.Rows[e.RowIndex].Cells["status_"].Value.ToString() == "approved")
                {
                    reject.Hide();
                    accept.Text = "Ban User";
                }

            }
        }

        private void customer_Click(object sender, EventArgs e)
        {
            clicked = "customer";
            query = "select * from userinfo where status_ ='approved' and uid like '%cu-%'";
            loadproducts(query);
        }

        private void reject_Click(object sender, EventArgs e)
        {
            Console.WriteLine("sdfsdfdsf" + userid.Text);
            query = "update userinfo set status_ = 'rejected->"+admin_id+"' where uid = '" + userid.Text + "'";
            db d = new db();
            if (d.write(query) == 1)
            {
                profilecard.Hide();
                customer.PerformClick();
            }
            else
            {
                MessageBox.Show("Failed to approve user.");
            }
        }

        private void noti1_Click(object sender, EventArgs e)
        {

        }

        private void agents_Click(object sender, EventArgs e)
        {
            clicked = "agent";
            query = "select * from userinfo where status_ ='approved' and uid like '%ag-%'";
            loadproducts(query);
        }

        private void seller_Click(object sender, EventArgs e)
        {
            clicked = "seller";
            query = "select * from userinfo where status_ ='approved' and uid like '%se-%'";
            loadproducts(query);
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            profilecard.Hide();
        }

        private void a_manageuser_Load(object sender, EventArgs e)
        {
            tablepanel.Hide();
            profilecard.Hide();
         
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
           
            if(clicked == "ban") { 
                query = "select * from userinfo where status_ <> 'approved' and (fullname like '%" + searchbox.Text + "%' or fulladdress like '%" + searchbox.Text + "%' or uid like '%" + searchbox.Text + "%' or status like '%" + searchbox.Text + "%'";
            }
            else if (clicked == "customer")
            {
                query = "select * from userinfo where status_ ='approved' and uid like '%cu-%' and (fullname like '%" + searchbox.Text + "%' or fulladdress like '%" + searchbox.Text + "%' or uid like '%" + searchbox.Text + "%')";
            }
            else if (clicked == "agent")
            {
                query = "select * from userinfo where status_ ='approved' and uid like '%ag-%' and (fullname like '%" + searchbox.Text + "%' or fulladdress like '%" + searchbox.Text + "%' or uid like '%" + searchbox.Text + "%')";
            }
            else if (clicked == "seller")
            {
                query = "select * from userinfo where status_ ='approved' and uid like '%se-%' and (fullname like '%" + searchbox.Text + "%' or fulladdress like '%" + searchbox.Text + "%' or uid like '%" + searchbox.Text + "%')";
            }

            loadproducts(query);
        }

        private void andmincount_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            clicked = "agdmin";
            query = "select * from userinfo where status_ ='approved' and uid like '%ad-%'";
            loadproducts(query);
        }
    }
}
