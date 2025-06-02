using System;
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
            // address of the database server
            string constring = "Data Source = MUBIN\\SQLEXPRESS; Initial Catalog = Farmlink; Integrated Security = True;";

            // create a connection object
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            //query build 
            string email = mail.Text;
            string password = pass.Text;

            // Check if email already exists
            string checkEmailQuery = "SELECT COUNT(*) FROM userinfo WHERE mail = @Email AND pass = @Password";
            SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
            checkEmailCmd.Parameters.AddWithValue("@Email", email);
            checkEmailCmd.Parameters.AddWithValue("@Password", password);
            int emailExists = (int)checkEmailCmd.ExecuteScalar();
            if (this.mail.Text == "" && this.pass.Text == "")
            {
                MessageBox.Show("Please fill the boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(emailExists < 0)
            {
                MessageBox.Show("Wrong password or mail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mail.Clear();
                pass.Clear();
            }
            else if (emailExists > 0)
            {
                string roleq = "SELECT roles FROM userinfo WHERE mail like @Email";
                SqlCommand ckrole = new SqlCommand(roleq, con);
                ckrole.Parameters.AddWithValue("@Email", email);
                object roles = ckrole.ExecuteScalar();

                if (roles != null)
                {
                    string r = roles.ToString();
                    if (r.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        B_Home b_Home = new B_Home(email);
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("seller", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        S_Home b_Home = new S_Home();
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("agent", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        S_Home b_Home = new S_Home();
                        b_Home.Visible = true;
                    }
                    else if (r.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Visible = false;
                        S_Home b_Home = new S_Home();
                        b_Home.Visible = true;
                    }

                }
               
            } 
            con.Close();

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
