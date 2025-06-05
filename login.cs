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
        private void MakeButtonRounded(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }
        public login()
        {
            InitializeComponent();
            MakeButtonRounded(button1, 40); 
            MakeButtonRounded(getstarted, 40);

        }

        private void login_Paint(object sender, PaintEventArgs e)
        {

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
                if (data[6].ToString()== "approved") { 
                
                    string r = data[5].ToString();
                    if (r.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        B_Home b_Home = new B_Home(data[0].ToString(), data[1].ToString());
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("seller", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        S_Home b_Home = new S_Home(data[0].ToString(), data[1].ToString());
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("agent", StringComparison.OrdinalIgnoreCase))
                    {
                        //this.Visible = false;
                        //S_Home b_Home = new S_Home();
                        //b_Home.Visible = true;
                    }
                    else if (r.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        //this.Visible = false;
                        //S_Home b_Home = new S_Home();
                        //b_Home.Visible = true;
                    }
                }
                else { 
                    MessageBox.Show("You are not allowed to log in.\n Wait for few hours if you are new.\n or else contact support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            } 

        }

        private void getstarted_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
        }
    }
}
