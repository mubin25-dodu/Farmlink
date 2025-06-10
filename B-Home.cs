using CefSharp.DevTools.FedCm;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Farmlink
{
    public partial class B_Home : Form
    {
        string uid;  
        string name;
        double payable = 0;
        string seller_id;
        string agent_id;
        double quanti,now_available;
        int buttonpress = 0;
        string propic;


        //int product_id;

        public void payment(double p,string id,string agent,double q,int pid, double av) { 
        this.payable =payable+ p;
        totalamount.Text = "Total Amount: " + payable.ToString() + " BDT";
        this.seller_id = agent;
        this.agent_id = agent;
        this.quanti = q;
        //this.product_id = pid;
        this.now_available =av;
        Console.WriteLine(totalamount);
        }
        public B_Home( string i)
        {
            InitializeComponent();
            DataRow dr = new db().read("SELECT * FROM userinfo WHERE uid = '" + i + "'");

            this.name = dr[1].ToString() ;
            id.Text = name;
            this.propic= dr[7].ToString();
            this.uid = i;
            profilepic.Image = Image.FromFile(propic); 

        }
        public void LoadProducts(string qu)
        {

            display_product.Controls.Clear();
            display_product.Visible = true; 
            cancelbtn.Hide();
            totalamount.Hide();
            paymentbtn.Hide();

            db db = new db();
            string query = qu;
            DataTable dr = db.readAll(query);

            if (dr.Rows.Count > -1)
            {
                for (int i = 0; i < dr.Rows.Count; i++)
                {
                    string name = dr.Rows[i][1].ToString();
                    double price = double.Parse(dr.Rows[i][3].ToString());
                    string des = dr.Rows[i][2].ToString();
                    string img = dr.Rows[i][5].ToString();
                    double av = double.Parse(dr.Rows[i][4].ToString());
                    int pid = int.Parse(dr.Rows[i][0].ToString());

                    display_product.Controls.Add(new bhome(name, price, des, img, av, pid, uid));
                 
                }
            }
            else
            {
                MessageBox.Show("No products found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Clear();
        }
        private void B_Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(1366, 768);
            totalamount.Text = "Total Amount: " + payable.ToString() + " BDT";
            LoadProducts("SELECT * FROM product");
            
            cancelbtn.Hide();
            note.Visible = false;
            empty_cart.Visible = false;
            
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
               
                intro form2 = new intro();
                form2.Show();
                this.Hide();
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
            bpanel.Controls.AddRange(new Control[] { totalamount, paymentbtn, note, empty_cart });
            display_product.Controls.Clear();
            //bpanel.Controls.Clear();
            searchbox.Visible = false;
            searchbtn.Visible = false;
            totalamount.Visible = true;
            paymentbtn.Visible = true;
            display_product.Visible = true;


            db n =new db();
            string query = "SELECT * FROM cart WHERE b_id = '"+uid+"'";
            DataTable d = n.readAll(query);
            if (d.Rows.Count > 0)
            {
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    int pid = int.Parse(d.Rows[i][2].ToString());
                    string qu = "SELECT * FROM product WHERE product_id = '" + pid + "'";
                    DataRow db = n.read(qu);

                    if (db == null)
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    else
                    {

                        string seller_id = db[6].ToString();
                        string name = db[1].ToString();
                        double price = double.Parse(db[3].ToString());
                        string des = db[2].ToString();
                        string img = db[5].ToString();
                        double av = double.Parse(db[4].ToString());
                        double count = double.Parse(d.Rows[i][3].ToString());
                        string agent_id = db[7].ToString();
                        //int prid = int.Parse(db[i].ToString());



                        display_product.Controls.Add(new bcart(uid , seller_id ,name, price, des, img, av, pid, count,agent_id));
                    }

                    
                }             
            }
            else
            { 
                note.Visible = true;
                empty_cart.Visible = true;
                totalamount.Hide();
                paymentbtn.Hide();
                //note.BringToFront();
                //empty_cart.BringToFront();
                display_product.Visible = false;
  

            }
            d.Clear();

        }

        private void home_Click(object sender, EventArgs e)
        {
            bpanel.Controls.Clear();
            bpanel.Controls.AddRange(new Control[] { display_product, searchbox, searchbtn });
            totalamount.Visible = false;
            paymentbtn.Visible = false;
            searchbox.Visible = true;
            searchbtn.Visible = true;
            display_product.Visible = true;

            LoadProducts("SELECT * FROM product");
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bhome1_Load(object sender, EventArgs e)
        {

        }

        private void display_product_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void display_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void display_product_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bpanel_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void display_product_Paint_2(object sender, PaintEventArgs e)
        {

            //display_product.Location = new Point(100, 50);
            //display_product.Dock = DockStyle.None; // Ensure manual positioning is used
        }

        private void empty_cart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadProducts("SELECT * FROM product");
            display_product.Visible = true;
            searchbox.Show();
            searchbtn.Show();
            
        }

        private void backpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void note_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void totalamount_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {   payable = 0;

            cancelbtn.Hide();
            cartbtn.Visible = true;
            home.Show();
            orderbtn.Show();
            bpanel.Controls.Clear();
            bpanel.Controls.AddRange(new Control[] { display_product, searchbox, searchbtn});
            LoadProducts("SELECT * FROM product");
        }

        private void paymentbtn_Click(object sender, EventArgs e) 
        { 
            cancelbtn.Show();
            if (payable <= 0)
            {
                totalamount.Text = "Select a Product";
                cancelbtn.Hide();

                return;
            }
            else
            {
                cartbtn.Visible = false;
                home.Hide();
                orderbtn.Hide();
                totalamount.Hide();
                paymentbtn.Hide();
                note.Hide();
                empty_cart.Hide();
                display_product.Controls.Clear();
                display_product.Hide();
                bpanel.BringToFront();
                Buyer_payment paymentControl = new Buyer_payment(uid);
                paymentControl.Visible = true;
                bpanel.Controls.Add(paymentControl);
                payable = 0;
                
            }

        }
    } 
}