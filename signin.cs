using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmlink
{

    public partial class signin : Form
    {
        private static int count = 0000;
        public signin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login form2 = new login();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            intro intro = new intro();
            intro.Visible = true;
        }

        private void signin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
        }

        private void button4_Click(object sender, EventArgs e)
        {
                        if (fullname.Text == "" || mail.Text == "" || address.Text == "" || role.Text == "" || pass.Text == "" || conpass.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                        // address of the database server
            string constring = "Data Source = MUBIN\\SQLEXPRESS; Initial Catalog = Farmlink; Integrated Security = True;";

            // create a connection object
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            //query build 
            string name = fullname.Text;
            string email = mail.Text;
            string fulladdress = address.Text;
            string qpass = null;
            string roles = role.Text;
            string stat = "pending";
            string prefix = "";

            if (role.Text == "Admin") { prefix = "ad-"; }
            else if (role.Text == "Agent") { prefix = "ag-"; }
            else if (role.Text == "Seller") { prefix = "se-"; }
            else if (role.Text == "Customer") { prefix = "cu-"; }

            // Check if email already exists
            string checkEmailQuery = "SELECT COUNT(*) FROM userinfo WHERE mail = @Email";
            SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con);
            checkEmailCmd.Parameters.AddWithValue("@Email", email);
            int emailExists = (int)checkEmailCmd.ExecuteScalar();



            if (emailExists > 0)
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            // Get data from database
            string countQuery = $"SELECT COUNT(*) FROM userinfo WHERE roles = '{roles}'";
            SqlCommand countCmd = new SqlCommand(countQuery, con);
            int currentCount = (int)countCmd.ExecuteScalar();

            // Generate ID with padding
            string id = prefix + currentCount.ToString("D4");

            if (pass.Text == conpass.Text ) { 
               qpass = pass.Text ;
            }

            else
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            string query = "INSERT INTO userinfo (id,fullname, mail, fulladdress, pass, roles, status_ ) VALUES ('" + id + "', '" + name + "', '" + email + "', '" + fulladdress + "', '" + qpass + "', '" + roles + "',' "+ stat + "');";
           
            // execute the query
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            // check if the query executed successfully
            con.Close();

            if ( i > 0)
            {
                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count++;
                this.Visible = false;
                login form2 = new login();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Account creation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    } 
    }
}
