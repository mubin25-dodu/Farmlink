using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class B_Home : Form
    {
        private int page = 0;
        public B_Home( string email,string n )
        {
            InitializeComponent();
            string name = n;
            id.Text = name;
            //// address of the database server
            //string constring = "Data Source = MUBIN\\SQLEXPRESS; Initial Catalog = Farmlink; Integrated Security = True;";

            //// create a connection object
            //SqlConnection con = new SqlConnection(constring);
            //con.Open();
            ////query build 

            //// Check if email already exists
            //string checkEmailQuery = "SELECT COUNT(*) FROM userinfo WHERE mail = @Email AND pass = @Password";
            //SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
            //checkEmailCmd.Parameters.AddWithValue("@Email", email);
            //checkEmailCmd.Parameters.AddWithValue("@Password", password);
            //int emailExists = (int)checkEmailCmd.ExecuteScalar();
            //con.Close();
        }

        private void B_Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);

            bpanel.Controls.Clear();
            bhome signinControl = new bhome();
            signinControl.Dock = DockStyle.Fill;
            bpanel.Controls.Add(signinControl);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                intro form2 = new intro();
                form2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bpanel.Controls.Clear(); 
            bcart signinControl = new bcart();
            signinControl.Dock = DockStyle.Fill;
            bpanel.Controls.Add(signinControl);
        }

        private void home_Click(object sender, EventArgs e)
        {
            bpanel.Controls.Clear();
            bhome signinControl = new bhome();
            signinControl.Dock = DockStyle.Fill;
            bpanel.Controls.Add(signinControl);

        }
    }
}
