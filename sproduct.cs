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
        private int timer = 0;
        private string imagepath = "";
        private string seller_id;
         
        private string agent ,query;
        public sproduct(string s)
        {

            InitializeComponent();
            this.seller_id = s;
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
            searchbox.Hide();
            searchbtn.Hide();
            products.Hide();
            noti.Text = "";
            listing.Visible = true;
        }

        private void listing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            listing.Visible = false;
            products.Show();
            searchbox.Show();
            searchbtn.Show();
            noti.Text = " Double-click on the table cells to edit the product information.";
            string query = "SELECT * FROM product WHERE seller_id = '" + seller_id + "'";
            loadproducts(query);
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
                Console.WriteLine("asa-"+seller_id+"-sdfdsfdsfds");
                string imagepath = path.Text; 
                string destinationPath = Path.Combine(
                    @"E:\OneDrive - American International University-Bangladesh\uni\7th sem\oop2\project\Farmlink\images\",
                    Path.GetFileName(imagepath)
                );
                File.Copy(imagepath, destinationPath, true);

                     query = "INSERT INTO product VALUES ('" + pname.Text + "' , '" + desin.Text + "' , '" + price.Text + "' , '" + amountin.Text + "' , '" + imagepath + "' ,'" + seller_id + "' , '"+agent+"')";



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
        private void loadproducts(string query) {
            
            
               
            DataTable dt = new db().readAll(query);
            if (dt.Rows.Count > 0)
            {

                noti.Text = " Double-click on the table cells to edit the product information. ";
                products.DataSource = dt;
                count.Text = "Number of products -> " + dt.Rows.Count.ToString();
                products.Columns[0].Visible=false;
                products.Columns[6].ReadOnly = true;
                products.Columns[7].ReadOnly = true;
                products.Columns[1].HeaderText = "Product Name";
                products.Columns[2].HeaderText = "Description";
                products.Columns[3].HeaderText = "Price (BDT)";
                products.Columns[4].HeaderText = "Amount in Stock";
                products.Columns[5].HeaderText = "Image Path";
                products.Columns[6].HeaderText = "Seller ID";
                products.Columns[7].HeaderText = "Agent ID";

                if (products.Columns.Contains("Remove"))
                {
                    products.Columns.Remove("Remove");
                }
                DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
                removeButton.HeaderText = "Remove";
                removeButton.Text = "Remove";
                removeButton.Name = "Remove";
                removeButton.UseColumnTextForButtonValue = true;
                removeButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                products.Columns.Insert(8 ,removeButton);
            }
            else
            {
               noti.Text= " No products found";
            }
        }

        private void sproduct_Load(object sender, EventArgs e)
        {  
            //noti.Text = "";
            string query = "SELECT * FROM product WHERE seller_id = '"+seller_id+"'";
            loadproducts(query);

        }

        private void agent_ass_CheckedChanged(object sender, EventArgs e)
        {
            if (agent_ass.Checked)
            {
                string query = "SELECT agent_id FROM commission WHERE seller_id ='"+seller_id+"'";
                db n =new db();
                DataRow dt = n.read(query);
                if (n.read(query) != null)
                {
                    noti.Text = "You'r agent assigned " ;
                    this.agent = dt[0].ToString();
                }
                else {
                    timer1.Start();
                    noti.Text = "You don't have any agent select from agent section";

                   agent_ass.Checked = false;
                }
            }
            else
            {
                agent = " ";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            Console.WriteLine(timer);
            if (timer == 30)
            {
                timer1.Stop();
                timer = 0;
                noti.Text = " Double-click on the table cells to edit the product information.\n ";
                   
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }


        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                // Remove button clicked
                string productId = products.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(productId);
                string query = "DELETE FROM product WHERE product_id = '" + productId + "'";
                if (new db().write(query) > 0)
                {
                    timer1.Start();
                    noti.Text = "Product removed successfully!";
                    loadproducts("SELECT * FROM product WHERE seller_id = '" + seller_id + "'");
                }
                else
                {
                    timer1.Start();
                    noti.Text = "Failed to remove product. Please try again.";
                }
            }
        }

       
        private void products_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1) {
                string productId = products.Rows[e.RowIndex].Cells[0].Value.ToString();
                string productName = products.Rows[e.RowIndex].Cells[1].Value.ToString();
                string description = products.Rows[e.RowIndex].Cells[2].Value.ToString();
                string price = products.Rows[e.RowIndex].Cells[3].Value.ToString();
                string amountInStock = products.Rows[e.RowIndex].Cells[4].Value.ToString();
                string imagePath = products.Rows[e.RowIndex].Cells[5].Value.ToString();
                string sellerId = products.Rows[e.RowIndex].Cells[6].Value.ToString();
                string agentId = products.Rows[e.RowIndex].Cells[7].Value.ToString();

                string query = " Update product set name = '"+productName+"' , description='"+description+ "' , unit_price ='" + price+ "' , available_unit='"+amountInStock+ "' , image ='"+imagePath+"' , seller_id ='"+sellerId+"' ,agent_id = '"+agentId+ "' WHERE product_id = '" + productId + "'";
                if (new db().write(query)  > 0)
                {
                    timer1.Start();

                    noti.Text = "Product updated successfully!";
                }
                else
                {
                    timer1.Start();
                    noti.Text = "Failed to update product. Please try again.";
                }
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            loadproducts("SELECT * FROM product WHERE seller_id = '" + seller_id + "' AND name LIKE '%" + searchbox.Text + "%'");
        }

        private void noti_Click(object sender, EventArgs e)
        {

        }
    }
}