using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Farmlink
{
    public partial class bcart : UserControl
    {
        double ava;
        double price;
        string uid;
        double count;
        string seller_id,agent_id;
        double totalprice;
        int product_id;
        public bcart(string id ,string name, double pr, string des, string img, double av, int p, double c, string agent)
        {
            InitializeComponent();
            this.count = c;
            this.price = pr;
            this.ava = av;
            this.seller_id = id;
            this.agent_id = agent;
            this.product_id = p;
            pname.Text = name;
            selected.Text = c.ToString();
            amount.Text = "Total Price: " + (count*price).ToString() + " BDT";
            abouttext.Text = des;
            avelibility.Text = av.ToString() + " kg available";
            price_l.Text = "Price: " + pr.ToString() + " BDT/Unit";
            pictureBox.Image = Image.FromFile(img);
            Console.WriteLine(amount.Text);
        }

        private void bcart_Load(object sender, EventArgs e)
        {

        }



        private void increment_Click(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            count++;
            Console.WriteLine(selected.Text);
            Console.WriteLine(amount.Text);
            if (ava < count)
            {
               
                MessageBox.Show("Not enough product available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selected.Text = ava.ToString();
                count--;
            }
            else if (count < 0)
            {
                count = 0;
            }
            selected.Text = (count + " unit").ToString();
            amount.Text = "Total Price: " + (price * count).ToString() + " BDT";
        }

        private void decrement_Click_1(object sender, EventArgs e)
        {
            checkBox.Checked = false;
            if (count < 1)
            {
                count = 0;
            }
            else
            {

                count--;
                selected.Text = (count + " unit").ToString();
                amount.Text = "Total Price: " + (price * count).ToString() + " BDT";
            }

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            totalprice = count * price;

            if (checkBox.Checked == true)
            {
                var parentForm = this.FindForm() as B_Home;
                parentForm.payment(totalprice,seller_id,agent_id,count,product_id , ava-count);
            }
            else
            {
                var parentForm = this.FindForm() as B_Home;
                parentForm.payment(-(totalprice), seller_id, agent_id, count, product_id, ava - count);
                parentForm.paymentbtn.PerformClick(); 
            }
        }

        private void abouttext_Click(object sender, EventArgs e)
        {

        }
    }
}
