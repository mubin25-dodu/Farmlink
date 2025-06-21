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
    public partial class agent_products : UserControl
    {
        private string agent_id;    
        public agent_products(string agent_id)
        {
            InitializeComponent();
            this.agent_id = agent_id;
        }
        private void loadproducts(string query)
        {

           DataTable dt = new db().readAll(query);
            if (dt.Rows.Count > 0)
            {

                noti.Text = " Double-click on the table cells to edit the product information.\n " +
                            "                               Products found -> " + dt.Rows.Count;
                products.DataSource = dt;
                //products.Columns[0].HeaderText = "Product ID";
                products.Columns[6].ReadOnly = true;
                products.Columns[7].ReadOnly = true;
                products.Columns[1].HeaderText = "Product Name";
                products.Columns[2].HeaderText = "Description";
                products.Columns[3].HeaderText = "Price (BDT)";
                products.Columns[4].HeaderText = "Amount in Stock";
                products.Columns[5].HeaderText = "Image Path";
                products.Columns[6].HeaderText = "Seller ID";
                products.Columns[7].HeaderText = "Agent ID";

            }
            else
            {
                noti.Text = " No products found";
            }
        }

        private void agent_products_Load(object sender, EventArgs e)
        {
            loadproducts("select * from product where agent_id = '"+agent_id+"'");
        }

        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string productId = products.Rows[e.RowIndex].Cells[0].Value.ToString();
                string productName = products.Rows[e.RowIndex].Cells[1].Value.ToString();
                string description = products.Rows[e.RowIndex].Cells[2].Value.ToString();
                string price = products.Rows[e.RowIndex].Cells[3].Value.ToString();
                string amountInStock = products.Rows[e.RowIndex].Cells[4].Value.ToString();
                string imagePath = products.Rows[e.RowIndex].Cells[5].Value.ToString();
                string sellerId = products.Rows[e.RowIndex].Cells[6].Value.ToString();
                string agentId = products.Rows[e.RowIndex].Cells[7].Value.ToString();

                string query = " Update product set name = '" + productName + "' , description='" + description + "' , unit_price ='" + price + "' , available_unit='" + amountInStock + "' , image ='" + imagePath + "' , seller_id ='" + sellerId + "' ,agent_id = '" + agentId + "' WHERE product_id = '" + productId + "'";
                if (new db().write(query) > 0)
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
            loadproducts("SELECT * FROM product WHERE agent_id = '" + agent_id + "' AND name LIKE '%" + searchbox.Text + "%'");
        }
    }
}
