using System;
using System.Data;
using System.Windows.Forms;

namespace Farmlink
{

    public partial class Buyer_payment : UserControl
    {
        private string buyer_id;
        private string pay_method;
        private double total_p;
        private int sellercount;
        private double deliveryamount;


        public void LoadProducts(string qu)
        {

            details.Controls.Clear();
            db db = new db();
            string query = qu;
            DataTable dr = db.readAll(query);

            if (dr.Rows.Count > 0)
            {
                for (int i = 0; i < dr.Rows.Count; i++)
                {
                    int product_id = int.Parse(dr.Rows[i][6].ToString());
                    Console.WriteLine("sdsassdsaasdas====" + buyer_id);

                    string get_product = "SELECT * FROM product Where product_id = '" + product_id + "' ";
                    DataRow gr = db.read(get_product);
                    if (db.read(get_product) != null)
                    {
                        details.Controls.Add(new order_details(double.Parse(dr.Rows[i][5].ToString()), gr[1].ToString(), double.Parse(gr[3].ToString()), product_id, buyer_id));
                    }

                }
            }
            else
            {
                MessageBox.Show("No products found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dr.Clear();
        }


        public Buyer_payment(string id)
        {
            InitializeComponent();
            this.buyer_id = id;
            bill();
        }

        public void bill()
        {
            string query1 = "SELECT SUM(unit_price * quantity) FROM [order] o join product p on p.product_id = o.product_id WHERE o.customer_id = '" + buyer_id + "'";
            db d = new db();
            DataRow dr = d.read(query1);
            if (dr != null)
            {
                total_p = double.Parse(dr[0].ToString());
            }
            else
            {
                MessageBox.Show("There is some error.\n report to admin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = "SELECT * FROM [order] WHERE customer_id ='" + buyer_id + "'";
            LoadProducts(query);

            // Count the number of sellers
            string q = "select  count(*) as sdsad from [order] where customer_id=  '" + buyer_id + "';";
            DataTable dr2 = d.readAll(q);
            if (dr2.Rows.Count > 0)
            {
                sellercount = dr2.Rows.Count;
            }
            else if (dr2.Rows.Count == 0)
            {
                sellercount = 1;
            }

           
            deliveryamount = (50 * sellercount);
            Console.WriteLine(deliveryamount + "amount" + "count" + sellercount);

            Console.WriteLine(sellercount + "sellers");
            Console.WriteLine("finding buyer payment" + buyer_id);

            if (total_p > (1000 * sellercount))
            {
                deliveryamount = 0;
                this.total_price.Text =
    "============================\n" +
    "         🧾 Invoice\n" +
    "============================\n" +
    $"🛒 Product Price :  {total_p,8:0.00} BDT\n" +
    $"🚚 Delivery Fee  :      0.00 BDT\n" +
    "----------------------------\n" +
    $"💰 Total Price   :  {total_p,8:0.00} BDT\n" +
    "----------------------------\n" +
    "🎉 You got Free Delivery!\n" +
    "============================";
            }
            else
            {
                this.total_price.Text =
    "============================\n" +
    "         🧾 Invoice\n" +
    "============================\n" +
    $"🛒 Product Price :  {total_p,8:0.00} BDT\n" +
    $"🚚 Delivery Fee  :  {deliveryamount,8:0.00} BDT\n" +
    "----------------------------\n" +
    $"💰 Total Price   :  {(total_p + deliveryamount),8:0.00} BDT\n" +
    "----------------------------\n" +
    $"⚠ Shop more {(1000 * sellercount) - total_p:0.00} BDT to get Free Delivery\n" +
    "============================";
            }
        }

        protected void Buyer_payment_Load(object sender, EventArgs e)
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
        private void methode(string m)
        {
            string que = "SELECT o.order_id, o.quantity, o.seller_id, o.agent_id, o.product_id , p.unit_price FROM [order] o join product p on p.product_id = o.product_id WHERE o.customer_id = '" + buyer_id + "'";
            db d = new db();
            DataTable dt = d.readAll(que);
            string q1 = "insert into delivery values('" + deliveryamount + "' , 'pending')";
            d.write(q1);
            DataRow ddd = d.read("select count(*) from delivery");
            int deliveryid = int.Parse(ddd[0].ToString());
            bool allSuccess = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int pid = int.Parse(dt.Rows[i][4].ToString());
                double quantity = double.Parse(dt.Rows[i][1].ToString());
                double price = double.Parse(dt.Rows[i][1].ToString()) * double.Parse(dt.Rows[i][5].ToString());

                string query = "INSERT INTO orderhistory (status, address, date, pay_meth, pay_stat, product_id, buyer_id, seller_id, agent_id , quantity,total_price ,delivery_id) " +
                               "VALUES ('processing', '" + label2.Text + "', GETDATE(), '" + m + "', 'pending', '" + pid + "', '" + buyer_id + "', '" + dt.Rows[i][2].ToString() + "', '" + dt.Rows[i][3].ToString() + "' , '" + quantity + "' , '" + price + "' , '" + deliveryid + "')";
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

        private void total_price_Click(object sender, EventArgs e)
        {

        }
    }
}
