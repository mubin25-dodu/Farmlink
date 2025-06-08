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
using System.Data.SqlClient;

namespace Farmlink
{
    public partial class sproduct : UserControl
    {
        string imagepath = "";
        string seller;
        int a = 1;
        public sproduct(string s)
        {

            InitializeComponent();
            seller = s;
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
            db db = new db();
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
            else
            {
                string imagepath = path.Text; // or use from OpenFileDialog
                string destinationPath = Path.Combine(
                    @"E:\OneDrive - American International University-Bangladesh\uni\7th sem\oop2\project\Farmlink\images\",
                    Path.GetFileName(imagepath)
                );
                File.Copy(imagepath, destinationPath, true);
                string query = "INSERT INTO product VALUES ('" + pname.Text + "' , '" + desin.Text + "' , '" + price.Text + "' , '" + amountin.Text + "' , '" + imagepath + "' ,'" + seller + "' )";


                if (db.write(query) == 1)
                        {
                            MessageBox.Show("Product added successfully!");
                            pname.Clear();
                            price.Clear();
                            amountin.Clear();
                            desin.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product. Please try again.");
                        }
                    }
                }
            
        

        private void photobtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select an image";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Load and display the selected image
                imagepath = open.FileName;
                path.Text = imagepath;
                proimg.Image = new Bitmap(imagepath);
            }
        }

        private void proimg_Click(object sender, EventArgs e)
        {

        }

        private void sproduct_Load(object sender, EventArgs e)
        {

        }
    }
}
