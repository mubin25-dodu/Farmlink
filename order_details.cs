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
    public partial class order_details : UserControl
    {   
        string buyer_id;
        int product_id;
        int order_id;
       static double  total_price;

        public order_details(double q , string n , double p ,int i,string bid )
        {
            InitializeComponent();
            this.pname.Text = n;
            this.price.Text = p.ToString() + " BDT -> "+q+"x";
            this.total.Text ="Total: "+ (q*p).ToString() + " BDT";
            this.product_id = i;
            this.buyer_id = bid;
            total_price= q * p;

        }

        private void orderdetails1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                  
                string query = "DELETE FROM [order] WHERE product_id = '" + product_id + "' and customer_id = '"+buyer_id+"'";
                Console.WriteLine("asdasdasd"+product_id);
                if (new db().write(query) != 0)
                {
                    MessageBox.Show("Order removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var parent = this.Parent as Buyer_payment;
                //parent.LoadProducts(" SELECT * FROM [order] WHERE  product_id = '" + product_id + "' and customer_id = '"+buyer_id+"'");
                //B_Home n = new B_Home(buyer_id);
                var parentForm = this.FindForm() as B_Home;
                if (parentForm != null && parentForm.paymentbtn != null)
                {
                    parentForm.paymentbtn.PerformClick();
                }
            }
                else
                {
                    MessageBox.Show("Failed to remove order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            this.Refresh();

        }

        private void order_details_Load(object sender, EventArgs e)
        {

        }
    }
}
