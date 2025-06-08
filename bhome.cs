using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class bhome : UserControl 
    {
        double ava = 0;
        double price = 0;
        string uid;
        double count = 0;
        int pid;
        string query;
        bool added_tocart = false;
        public bhome( string name , double pr ,string des,string img,double av,int p,string i)
        {
            InitializeComponent();
            // Set the product details
            pname.Text = name;
            selected.Text = " ";
            amount.Text = " ";
            abouttext.Text = des;
            avelibility.Text = av.ToString() + " kg available";
            price_l.Text= "Price: " + pr.ToString() + " BDT/Unit";
            pictureBox.Image = Image.FromFile(img);
            ava = av;
            price = pr;
            uid = i;
            pid = p;
        }

        private void bhome_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abouttext_Click(object sender, EventArgs e)
        {

        }

        private void increment_Click(object sender, EventArgs e)
        {
            count++;
            selected.Text = (count + " unit").ToString();
            amount.Text = "Total Price: " + (price * count).ToString() + " BDT";
            if (ava < count ) { 
                    MessageBox.Show("Not enough product available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selected.Text = ava.ToString();
                    count = (int)ava;
            }
                else if (count < 0)
                {
                    count = 0;
            }
        }

        private void decrement_Click(object sender, EventArgs e)
        {

            if (count < 1)
            {
                count = 0;
            }
            else {
                count--;
                selected.Text = (count + " unit").ToString();
                amount.Text = "Total Price: " + (price * count).ToString() + " BDT";
            }
            
        }

        private void addcart_Click(object sender, EventArgs e)
        {
             db b = new db();

            if (b.read("SELECT * FROM cart WHERE b_id = '" + uid + "' AND product_id = '" + pid + "'") == null)
            {
                query = "INSERT INTO cart values ('" + uid + "', '" + pid + "','" + count + "')";

                if (count > 0)
                {
                    if (b.write(query) == 1)
                    {
                        MessageBox.Show("Product added to cart successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //var parentForm = this.FindForm() as B_Home;
                        //parentForm.LoadProducts("SELECT * FROM product"); ;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                query = "UPDATE cart SET quantity = '" + count + "' WHERE b_id = '" + uid + "' AND product_id = '" + pid + "'";
                if (count > 0)
                {
                    if (b.write(query) == 1)
                    {
                        MessageBox.Show("Product added to cart successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //var parentForm = this.FindForm() as B_Home;
                        //parentForm.LoadProducts("SELECT * FROM product"); ;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
