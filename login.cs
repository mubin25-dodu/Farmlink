using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Farmlink
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
         
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //query build 
            string email = mail.Text;
            string password = pass.Text;

            string query = "SELECT * FROM userinfo WHERE mail = '" + email + "' AND pass = '"+password+"'";
            db db = new db();
            DataRow data = db.read(query);
            if (this.mail.Text == "" && this.pass.Text == "")
            {
                MessageBox.Show("Please fill the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(data == null)
            {
                MessageBox.Show("Wrong password or mail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mail.Clear();
                pass.Clear();
            }
            else if (data != null)
               
            {
                if ( data[6].ToString()== "approved") { 
                 //Console.WriteLine(data[6].ToString().Substring(0, 8));
                    string r = data[5].ToString();
                    if (r.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Close();

                        B_Home b_Home = new B_Home(data[0].ToString());
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("seller", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Close();
                        S_Home b_Home = new S_Home(data[0].ToString());
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("agent", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Close();
                        agent_home b_Home = new agent_home(data[0].ToString());
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Close();

                        A_home b_Home = new A_home(data[0].ToString());
                        b_Home.Visible = true;
                    }
                }
                else { 
                    MessageBox.Show("You are not allowed to log in.\nWait for few hours if you are new.\nor else contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            } 

        }

        private void getstarted_Click(object sender, EventArgs e)
        {
            this.Close();

            signin signin = new signin();
            signin.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            intro intro = new intro();
            intro.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
            showpass.Hide();
            pass.UseSystemPasswordChar = true;
            forgotpanel.Hide();
        }

        private void showpass_Click(object sender, EventArgs e)
        {

            pass.UseSystemPasswordChar = true;
            hidepass.Show();
            showpass.Hide();

        }
        private void hidepass_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = false;

            hidepass.Hide();
            showpass.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from userinfo where (mail ='"+mailf.Text+"' and fullname ='"+fullname.Text+"' and phone = '"+num.Text+"' and roles ='"+role.Text+"')";
            db d = new db();
            if (passf.Text!=""||conpass.Text!="" || fullname.Text ==""|| mailf.Text==""||num.Text=="") {
                if (passf.Text == conpass.Text)
                {
                    string changepass = passf.Text;
                    if (d.read(query) != null)
                    {
                        string update = "update userinfo set pass ='" + changepass + "' where mail='" + mailf.Text + "'";
                        if (d.write(update) == 1)
                        {
                            MessageBox.Show("password changed", "succcess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            signinpanel.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("user Not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else { 
                        MessageBox.Show("password dosen't match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else { 
                   MessageBox.Show("fill in the boxes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
