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
    public partial class a_orders : UserControl
    {
        string clicked = " ";
        double p_share = 0.05; // Platform share percentage
        public a_orders()
        {
            InitializeComponent();
            tablepanel.Visible = false;

        }
        private void populate(string query)
        {
            table.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            tablepanel.Visible = true;

            db d = new db();
            DataTable dt = d.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                tablenoti.Text = "orders-> " + dt.Rows.Count;
                table.DataSource = dt;
               
                table.AutoGenerateColumns = true;

                if ((clicked == "req" ) && !table.Columns.Contains("CollectionRequest"))
                {
                    DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                    check.HeaderText = "Mark collected";
                    check.Name = "Mark collected";
                    check.Width = 150;
                    check.ReadOnly = false;
                    table.Columns.Insert(0, check);
                }
                else if (clicked == "delevred" && !table.Columns.Contains("CollectionRequest"))
                {
                        DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                        check.HeaderText = "Mark Delivered";
                        check.Name = "Mark Delivered";
                        check.Width = 150;
                        check.ReadOnly = false;
                        table.Columns.Insert(0, check);
                    
                }


            }
            else
            {
                tablenoti.Text = "No orders Found ";
                table.DataSource = null;
            }
        }
        private void a_orders_Load(object sender, EventArgs e)
        {
            count.Hide();
            string q = "select * from orderhistory where status ='collection request'";
            db d = new db();
            DataTable t = d.readAll(q);
            if (t != null && t.Rows.Count > 0)
            { 
                count.Show(); 
                count.Text = t.Rows.Count.ToString();
            }

            //populate("received", "received");
            //populate("cancelled", "cancelled");
            //populate("processing", "on the way");
            tablepanel.Visible = false;
            //db d = new db();
            //DataTable dt = d.readAll("select history_id from orderhistory where status = 'Collection Request'");
            //noti1.Text = "Collection Request-> " + (dt.Rows.Count.ToString());
            //dt.Clear();
            //DataTable dr = d.readAll(" select history_id from orderhistory where  status = 'on the way'");
            //noti2.Text = "on the way orders-> " + (dt.Rows.Count.ToString());
            //delev.Text = "on the way orders-> " + (dt.Rows.Count.ToString());
            //dr.Clear();
            //DataTable drr = d.readAll(" select history_id from orderhistory where status ='delivered'");
            //noti3.Text = "delivered orders-> " + (drr.Rows.Count.ToString());
            //drr.Clear();
            //DataTable drrr = d.readAll(" select history_id from orderhistory where   status like '%cancele%'");
            //noti4.Text = "cancelled orders-> " + (drrr.Rows.Count.ToString());
            //drrr.Clear();
        }

        private void req_Click(object sender, EventArgs e)
        {
            clicked = "req";

            string query = @"SELECT   
                            o.history_id,
                            p.name AS product_name,  
                            o.status,  
                            o.date,  
                            o.quantity
                        FROM  
                            orderhistory o  
                        JOIN  
                            product p ON o.product_id = p.product_id  
                        WHERE  
                             o.status = 'Collection Request'
                           
                        ORDER BY  
                            o.date DESC;";
            populate(query);

            //and(o.pay_meth = 'cod' or

            //               o.pay_stat = 'paid')
        }

        private void Processing_Click(object sender, EventArgs e)
        {
            clicked = "Processing";
            populate(" select  p.name AS product_name, o.status,o.date, o.quantity FROM orderhistory o JOIN product p ON o.product_id = p.product_id WHERE o.status = 'on the way' ORDER BY o.date DESC; ");
            
        }

        private void success_Click(object sender, EventArgs e)
        {
            clicked = "success";
            populate(" select  p.name AS product_name, o.status,o.date, o.quantity FROM orderhistory o JOIN product p ON o.product_id = p.product_id WHERE o.status = 'received' ORDER BY o.date DESC; ");

        }

        private void failed_Click(object sender, EventArgs e)
        {

            string query2 = @"SELECT   
                                p.name AS product_name,  
                                o.status,  
                                o.date,  
                                o.quantity  
                            FROM  
                                orderhistory o  
                            JOIN  
                                product p ON o.product_id = p.product_id  
                            WHERE  
                                 o.status like '%cancel%' 
                           
                            ORDER BY  
                                o.date DESC;";

            populate(query2);
            //AND(o.pay_meth = 'cod' OR o.pay_stat = 'paid')
        }

        private void Delevred_Click(object sender, EventArgs e)
        {
            clicked = "delevred";


            string query = @"SELECT   
                            o.history_id,
                            p.name AS product_name,  
                            o.status,   
                            o.date,  
                            o.quantity,
                            o.total_price
                            FROM  
                            orderhistory o  
                        JOIN  
                            product p ON o.product_id = p.product_id  
                         WHERE  
                             o.status = 'on the way'
                           
                        ORDER BY  
                            o.date DESC;";

            populate(query);
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && clicked == "req")
            {
                Console.WriteLine(e.ColumnIndex);
                string query = "Update orderhistory Set status ='on the way'  where history_id = '" + int.Parse(table.Rows[e.ColumnIndex].Cells["history_id"].Value.ToString()) + "'";
                db d = new db();
                if (d.write(query) > 0)
                {
         
                    req.PerformClick();

                }
                else
                {
                    count.Text = "Failed.";
                }
            }
            else if (e.ColumnIndex == 0 && clicked == "delevred")
            {
                int rowIndex = e.RowIndex;

                int historyId = int.Parse(table.Rows[rowIndex].Cells["history_id"].Value.ToString());
                double price = double.Parse(table.Rows[rowIndex].Cells["total_price"].Value.ToString());

                string query = "UPDATE orderhistory SET status = 'received' , pay_stat ='paid' WHERE history_id = '"+historyId+"'";
               //if agent exist
                string q2 = "SELECT a.comm_percent FROM agent a JOIN orderhistory o ON o.agent_id = a.agent_id WHERE o.history_id = '"+historyId+"'";

                db d = new db();

                if (d.write(query) > 0)
                {
                    DataRow dr = d.read(q2);
                    if (dr != null)
                    {
                        double comm = double.Parse(dr[0].ToString());
                        double agent_share = (price * comm) / 100;
                        double platform_share = price * p_share;
                        double seller_share = price - (agent_share + platform_share);

                        string q3 = "INSERT INTO pay_history (history_id, agent_share, platform_share, seller_share) " +
                                    "VALUES ('" + historyId + "', '" + agent_share + "', '" + platform_share + "', '" + seller_share + "')";

                        d.write(q3);
                    }
                    else {

                        double platform_share = price * p_share;
                        double seller_share = price -  platform_share;

                        string q3 = "INSERT INTO pay_history (history_id, platform_share, seller_share) " +
                                    "VALUES ('" + historyId + "', '" + platform_share + "', '" + seller_share + "')";

                        d.write(q3);
                    }

                        count.Text = "Delevred.";
                    Delevred.PerformClick();
                }

            }
            else
            {
                count.Text = "Failed.";
            }
            }
        

        private void backbtn_Click(object sender, EventArgs e)
        {
            tablepanel.Visible = false;
            string q = "select * from orderhistory where status ='collection request'";
            db d = new db();
            DataTable t = d.readAll(q);
            if (t != null && t.Rows.Count > 0)
            {
                count.Show();
                count.Text = t.Rows.Count.ToString();
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (clicked == "req")
            {
                string query = @"SELECT   
                                    o.history_id,  
                                    p.name AS product_name,  
                                    o.status,  
                                    o.date,  
                                    o.quantity  
                                FROM  
                                    orderhistory o  
                                JOIN  
                                    product p ON o.product_id = p.product_id  
                                WHERE  
                                    o.status = 'Collection Request'  
                                    AND o.history_id LIKE '%" + searchbox.Text + @"%'  
                                ORDER BY  
                                    o.date DESC;";
                populate(query);
            }
            else if (clicked == "delevred")
            {
                string query = @"SELECT   
                                    o.history_id,  
                                    p.name AS product_name,  
                                    o.status,  
                                    o.date,  
                                    o.quantity,
                                    o.total_price
                                FROM  
                                    orderhistory o  
                                JOIN  
                                    product p ON o.product_id = p.product_id  
                                WHERE  
                                    o.status = 'on the way' 
                                    AND o.history_id LIKE '%" + searchbox.Text + @"%'  
                                ORDER BY  
                                    o.date DESC;";
                populate(query);
            }else if (clicked == "Processing")
            {
                string query = @"SELECT   
                                    o.history_id,  
                                    p.name AS product_name,  
                                    o.status,  
                                    o.date,  
                                    o.quantity  
                                FROM  
                                    orderhistory o  
                                JOIN  
                                    product p ON o.product_id = p.product_id  
                                WHERE  
                                    o.status = 'on the way' 
                                    AND o.history_id LIKE '%" + searchbox.Text + @"%'  
                                ORDER BY  
                                    o.date DESC;";
                populate(query);
            }
            else if (clicked == "success")
            {
                string query = @"SELECT   
                                    o.history_id,  
                                    p.name AS product_name,  
                                    o.status,  
                                    o.date,  
                                    o.quantity  
                                FROM  
                                    orderhistory o  
                                JOIN  
                                    product p ON o.product_id = p.product_id  
                                WHERE  
                                    o.status = 'received' 
                                    AND o.history_id LIKE '%" + searchbox.Text + @"%'  
                                ORDER BY  
                                    o.date DESC;";
                populate(query);
            }
            else if (clicked == "failed")
            {
                string query = @"SELECT   
                                    o.history_id,  
                                    p.name AS product_name,  
                                    o.status,  
                                    o.date,  
                                    o.quantity
                                FROM  
                                    orderhistory o  
                                JOIN  
                                    product p ON o.product_id = p.product_id  
                                WHERE  
                                     o.status like '%cancel%' 
                           
                                     AND o.history_id LIKE '%" + searchbox.Text + @"%' 
                                ORDER BY  
                                     o.date DESC;";
                populate(query);
            }

        }
    }
}
