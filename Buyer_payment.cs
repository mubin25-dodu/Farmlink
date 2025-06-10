using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Farmlink
{
    
    public partial class Buyer_payment : UserControl
    {
        string buyer_id;
        //int product_id;
        string pay_method;
        List<int> product = new List<int>();


        public void LoadProducts(string qu)
        {
            details.Controls.Clear();

            db db = new db();
            string query = qu;
            DataTable dr = db.readAll(query);

            if (dr.Rows.Count > -1)
            {
                for (int i = 0; i < dr.Rows.Count; i++)
                {
                    int product_id = int.Parse(dr.Rows[i][6].ToString());

                    string get_product = "SELECT * FROM product Where product_id = '" + product_id + "' ";
                    product.Add(product_id);
                    DataRow gr = db.read(get_product);
                    if (db.read(get_product) != null ) {
                        details.Controls.Add(new order_details(double.Parse(dr.Rows[i][5].ToString()) , gr[1].ToString(), double.Parse(gr[3].ToString()) , product_id, buyer_id ));
                    }

                }
            }
            else
            {
                MessageBox.Show("No products found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dr.Clear();
        }


        public Buyer_payment( string id )
        {
            InitializeComponent();
            string query = "SELECT * FROM [order] WHERE customer_id ='" + id+"'";
            this.buyer_id = id;
            //this.product_id = pid;
            LoadProducts(query);
        }

        private void Buyer_payment_Load(object sender, EventArgs e)
        {
            donebtn.Visible = false;
            mobilepay.Visible = false;
            addressbox.Visible = false;
            //loading address
            string query = "select fulladdress from userinfo where uid ='" + buyer_id + "'";
            new db();

            DataRow dr = new db().read(query);
            if (dr != null)
            { label2.Text = dr[0].ToString(); }
            else
            {
                label2.Text = "No address found.";
            }
        }

        private void orderdetails1_Load(object sender, EventArgs e)
        {

        }

        private void details_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listing_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void donebtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //string query = "UPDATE orderhistory set address where  ";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {  
           
        }

        private void donebtn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            label2.Text = addressbox.Text;
            addressbox.Visible = false;
            donebtn.Visible = false;
        }

        private void address_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addressbox.Visible = true;
            donebtn.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mobilepay.Visible = true;

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            mobilepay.Visible = false;

        }

        private void donep_Click(object sender, EventArgs e)
        {
            methode(("phone->" + num.Text).ToString());
        }

        private void cod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //pay_method = "cod";
            methode("cod");
        }

        private void cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void methode(string m ) {
            string que = "SELECT order_id , quantity  FROM [order] WHERE customer_id = '" + buyer_id + "'";
            db d = new db();
            DataTable dt = d.readAll(que);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string query = "INSERT INTO orderhistory (order_id, status, address, date, pay_meth ,pay_stat ) VALUES ('" + int.Parse(dt.Rows[i][0].ToString()) + "', 'processing', '" + label2.Text + "', GETDATE(), '" + m + "','pending')";
                string query2 = "DELETE FROM [order] WHERE order_id = '" + int.Parse(dt.Rows[i][0].ToString()) + "'";
                int pid = product[i];
                string query3 = "DELETE FROM [cart] WHERE product_id = '" + pid + "' AND b_id = '" + buyer_id + "'";
                string q4 = " update product set available_unit = available_unit - '"+double.Parse(dt.Rows[i][1].ToString())+"' where product_id = '"+pid+"'";
                d.write(q4);
                d.write(query2);
                d.write(query3);
                Console.WriteLine(dt.Rows[i][0].ToString());
                if (m !="cod" && new db().write(query) > 0 && num.Text != null && pin_.Text != null)
                {
                    mobilepay.Hide();
                }
                else if (m == "cod" && new db().write(query) > 0)
                {
                    MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts("SELECT * FROM [order] WHERE customer_id = '" + buyer_id + "'");
                    var parentForm = this.FindForm() as B_Home;

                    //parentForm.home_Click(null, EventArgs.Empty);

                    return;
                }
                else
                {
                    MessageBox.Show("Failed to place order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}
