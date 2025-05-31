using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class sproduct : UserControl
    { 
        string imagepath = "";
        public sproduct()
        {
           
            InitializeComponent();
            listing.Visible = false;
        }

        private void desin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pname.Clear();
            price.Clear();
            amountin.Clear();
            desin.Clear();
        }

        private void addpro_Click(object sender, EventArgs e)
        {
            listing.Visible = true;
        }

        private void listing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            listing.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pname.Text) || string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(amountin.Text) || string.IsNullOrWhiteSpace(desin.Text))
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else if (!double.TryParse(price.Text, out _) || !double.TryParse(amountin.Text, out _))
            {
                MessageBox.Show("Please enter a valid number.");
                amountin.Clear();
                price.Clear();
            }
            else if (string.IsNullOrWhiteSpace(proimg.Text))
            {
                MessageBox.Show("Please select a valid image file.");
                return;
            }
            else
            {
                MessageBox.Show("Product added successfully!");
                pname.Clear();
                price.Clear();
                amountin.Clear();
                desin.Clear();
            }
            string destinationPath = Path.Combine(@"E:\OneDrive - American International University-Bangladesh\uni\7th sem\oop2\project\Farmlink\images\", Path.GetFileName(imagepath));
            File.Copy(imagepath, destinationPath, true);
        }

        private void photobtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load and display the selected image
                imagepath = openFileDialog.FileName;
                proimg.Image = new Bitmap(imagepath);
            }
        }

        private void proimg_Click(object sender, EventArgs e)
        {

        }
    }
}
