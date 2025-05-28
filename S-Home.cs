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
        private Panel mainpanel; // Added definition for 'mainpanel'

        public S_Home()
        {
            InitializeComponent();
            mainpanel = new Panel(); // Initialize 'mainpanel'
            mainpanel.Dock = DockStyle.Fill; // Optional: Set properties for 'mainpanel'
            this.Controls.Add(mainpanel); // Add 'mainpanel' to the form's controls
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
