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
        string id; // User ID

        public S_Home(string i , string name)
        {
            InitializeComponent();
            uid.Text = name;
            id = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spanel.Controls.Clear();
            sproduct signinControl = new sproduct(id);
            signinControl.Dock = DockStyle.Fill;
            spanel.Controls.Add(signinControl);
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void S_Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
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
                form2.Show();this.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spanel.Controls.Clear();
            sell_order signinControl = new sell_order();
            signinControl.Dock = DockStyle.Fill;
            spanel.Controls.Add(signinControl);
        }

        private void payment_Click(object sender, EventArgs e)
        {
            spanel.Controls.Clear();
            s_payment a = new s_payment();
            a.Dock = DockStyle.Fill;
            spanel.Controls.Add(a);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}