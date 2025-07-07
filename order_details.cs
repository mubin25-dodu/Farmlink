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
       private string buyer_id;
       private int product_id;
       private int order_id;
       private static double  total_price;

        public order_details(double q , string n , double p ,int i,string bid )
        {
            InitializeComponent();
            this.pname.Text = n;
            this.price.Text = p.ToString() + " BDT -> "+q+"x";
            this.total.Text ="Total: "+ (q*p).ToString() + " BDT";
            this.product_id = i;
            this.buyer_id = bid;
            total_price= q * p;
            Console.WriteLine("asdasdasd" + product_id + "==" + buyer_id);
        }

        private void orderdetails1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                  
                string query = "DELETE FROM [order] WHERE (product_id = '" + product_id + "' and customer_id = '"+buyer_id+"')";
                if (new db().write(query) == 1)
                {
                   MessageBox.Show("Order removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   Control parent = this.Parent;
                while (parent != null && !(parent is Buyer_payment))
                    parent = parent.Parent;

                if (parent is Buyer_payment buyerPayment)
                {
                    buyerPayment.bill();
                    buyerPayment.LoadProducts("SELECT * FROM [order] WHERE customer_id = '" + buyer_id + "'");
                }

            }
                else
                {
                    MessageBox.Show("Failed to remove order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }

        private void order_details_Load(object sender, EventArgs e)
        {

        }
    }
}
