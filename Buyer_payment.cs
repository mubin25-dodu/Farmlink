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
        string pay_method;
        double total_p;


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


        public Buyer_payment( string id , double tp )
        {
            InitializeComponent();
            string query = "SELECT * FROM [order] WHERE customer_id ='" + id+"'";
            LoadProducts(query);
            this.buyer_id = id;
            if (tp > 1000) {
                this.total_price.Text ="Payment Details\n"+"Free Delevery \n"+ "Total Price: " + tp.ToString() + " BDT";
            }
            else
            {
                this.total_price.Text = "Delevery Fee +50 \nShop more " + (1000 - tp) + "BDT to Get Free Delevery" + "\nProduct Price: " + tp.ToString() + " BDT" + "\nDelevery Fee +50 = " + "\nTotal Price: " + (tp + 100);
                tp += 50;
            }
            this.total_p = tp;
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
            string que = "SELECT order_id, quantity, seller_id, agent_id, product_id FROM [order] WHERE customer_id = '" + buyer_id + "'";
            db d = new db();
            DataTable dt = d.readAll(que);

            bool allSuccess = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int pid = int.Parse(dt.Rows[i][4].ToString());
                double quantity = double.Parse(dt.Rows[i][1].ToString());

                string query = "INSERT INTO orderhistory (status, address, date, pay_meth, pay_stat, product_id, buyer_id, seller_id, agent_id , quantity,total_price) " +
                               "VALUES ('processing', '" + label2.Text + "', GETDATE(), '" + m + "', 'pending', '" + pid + "', '" + buyer_id + "', '" + dt.Rows[i][2].ToString() + "', '" + dt.Rows[i][3].ToString() + "' , '"+ quantity + "' , '"+ total_p+"')";
                string query2 = "DELETE FROM [order] WHERE order_id = '" + int.Parse(dt.Rows[i][0].ToString()) + "'";
                string query3 = "DELETE FROM [cart] WHERE product_id = '" + pid + "' AND b_id = '" + buyer_id + "'";
                string q4 = "UPDATE product SET available_unit = available_unit - '" + quantity + "' WHERE product_id = '" + pid + "'";

                d.write(q4);
                d.write(query2);
                d.write(query3);

                int result = d.write(query);
                if (result <= 0)
                {
                    allSuccess = false;
                    break;
                }
            }

            if (allSuccess)
            {
                if (m != "cod" && !string.IsNullOrEmpty(num.Text) && !string.IsNullOrEmpty(pin_.Text))
                {
                    mobilepay.Hide();
                }

                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts("SELECT * FROM [order] WHERE customer_id = '" + buyer_id + "'");

                var parentForm = this.FindForm() as B_Home;
                if (parentForm != null)
                {
                    parentForm.home_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Failed to place order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }
    }
}
