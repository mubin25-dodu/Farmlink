using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Farmlink
{
    public partial class B_order_stat : UserControl
    {
        string buyer_id;

        public B_order_stat( string id)
        {
            InitializeComponent();
            this.buyer_id = id;
            Console.WriteLine(id);
        }

        private void userinfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void userinfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void details_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordrhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void B_order_stat_Load(object sender, EventArgs e )
        {
            //history
            string query = @"SELECT   
                        p.name AS product_name,  
                        o.status,  
                        o.address,  
                        o.date,  
                        o.pay_meth
                    FROM  
                        orderhistory o  
                    JOIN  
                        product p ON o.product_id = p.product_id  
                    WHERE  
                        o.buyer_id = '" + buyer_id + @"'
                        and o.status <>  'processing'
                    ORDER BY  
                        o.date DESC;";
            db d = new db();
            DataTable dt = d.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                his_notifi.Text = "Number Of Orders -> "+ dt.Rows.Count;
                orderhistory.AutoGenerateColumns = true;
                orderhistory.DataSource = dt;
                orderhistory.Columns[0].HeaderText = "Product Name";
                orderhistory.Columns[1].HeaderText = "Status";
                orderhistory.Columns[2].HeaderText = "Address";
                orderhistory.Columns[3].HeaderText = "Date";
                orderhistory.Columns[4].HeaderText = "Payment Method";


            }
            else
            {
                his_notifi.Text = "No order history found.";
            }
            //dt.Clear();

            //order
            string qu = @"SELECT  
                        o.history_id,
                        p.name AS product_name,  
                        o.status,  
                        o.address,  
                        o.date,  
                        o.pay_meth
                    FROM  
                        orderhistory o  
                    JOIN  
                        product p ON o.product_id = p.product_id  
                    WHERE  
                        o.buyer_id = '" + buyer_id + @"'
                        and ( o.status =  'processing' OR o.status = 'on the way')
                    ORDER BY  
                        o.date DESC;";
       
            DataTable dr = d.readAll(qu);

            if (dr != null && dr.Rows.Count > 0)
            {
                ordr.Text = "Number Of Orders -> " + dr.Rows.Count;
                //order.ColumnCount = 6;
                order.AutoGenerateColumns = true;
                order.DataSource = dr;
                order.Columns[0].Visible = false; // history_id
                order.Columns[1].HeaderText = "Product Name";
                order.Columns[2].HeaderText = "Status";
                order.Columns[3].HeaderText = "Address";
                order.Columns[4].HeaderText = "Date";
                order.Columns[5].HeaderText = "Payment Method";

                if (order.Columns.Contains("cancel_order"))
                {
                    order.Columns.Remove("cancel_order");
                }

                DataGridViewButtonColumn cancel = new DataGridViewButtonColumn();
                    cancel.HeaderText = " Cancel Order ";
                    cancel.Text = "cancel order";
                    cancel.Name = "cancel_order";
                    cancel.UseColumnTextForButtonValue = true;
                    cancel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //cancel.InheritedStyle.ForeColor = Color.Red;

                order.Columns.Insert(0, cancel);


                foreach (DataGridViewRow row in order.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "processing")
                    {
                        Console.WriteLine(row.Cells[1].Value.ToString());
                        row.Cells["cancel_order"].ReadOnly = true;
                        row.Cells["cancel_order"].Style.BackColor = Color.Red;
                    }
                }

            }
            else
            {
                ordr.Text = "No order found.";
            }
            //dr.Clear();



        }

        private void ordered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_CellClick(object sender, DataGridViewCellEventArgs e)
        {   Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex==0) {
            
                int trycancel = e.RowIndex;
                int history_id = int.Parse(order.Rows[trycancel].Cells["history_id"].Value.ToString());
                string q = "select * from orderhistory where history_id = '"+ history_id + "' and status = 'processing' ";
                DataRow dt = new db().read(q);
                if (dt == null)
                {
                    ordr.ForeColor = Color.Red;
                    ordr.Text = "order can not be canceled it's being send";
                    return;
                }
                else { 
                  string query = "Update orderhistory set status = 'canceled -> customer' WHERE history_id  = '" + history_id + "'";
                if (new db().write(query) != 0)
                {
                        ordr.ForeColor = Color.Green;
                        ordr.Text = "Order Canceled Successfully";
                        B_order_stat_Load(sender, e);
                }
                }


            }
        }

        private void order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
