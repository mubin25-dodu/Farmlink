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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Farmlink
{
    public partial class login : Form
    {
        private int otp;
        private string usermail;
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
            newpass.Hide();
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
            if (forgot_applyBtn.Text == "OK") {
                if (forgot_textbox.Text == otp.ToString()) { 
                 newpass.Show();
                   
                }
            }
            else
            {
                usermail = forgot_textbox.Text;
                string query = "select * from userinfo where mail ='" + forgot_textbox.Text + "'";
                if (new db().read(query) != null)
                {
                    // otp and mail
                    Random random = new Random();
                    this.otp = random.Next(0000, 9999);

                    string body = $@"
                <html>
                <body style='font-family: Arial; color: #333;'>
                    <h2>FarmLink - Password Reset</h2>
                    <p>Your OTP for password reset is:</p>
                    <h1 style='color: #2E8B57;'>{otp}</h1>
                    <p>This OTP will expire in 5 minutes.</p>
                    <br/>
                    <p>If you did not request this, please ignore this email.</p>
                    <p style='font-size: 12px;'>- FarmLink Team</p>
                </body>
                </html>";

                    if (new sendmail().send(forgot_textbox.Text, body, "FarmLink Password Reset OTP") == true)
                    {
                        forgot_textbox.Clear();
                        forgot_label.Text = "Enter Your OTP";
                        forgot_applyBtn.Text = "OK";
                    }
                }
                else
                {
                    MessageBox.Show("User Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (newp.Text == "" || conp.Text == "") { MessageBox.Show("Fill the boxs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (newp.Text != conp.Text) { MessageBox.Show("Password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string q = "update userinfo set pass='" + newp.Text + "' where mail ='" + usermail + "' ";
                Console.WriteLine("Updating for email: " + usermail);
                if (new db().write(q) == 1) {
                    forgotpanel.Hide();
                    MessageBox.Show("Password updated successfully!"); }
                else { MessageBox.Show("error"); }
            }
        }
    }
}
