using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class B_Home : Form
    {
        private int page = 0;
        public B_Home()
        {
            InitializeComponent();
           
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
