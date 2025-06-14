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
        int clicked = 0;
        public a_orders()
        {
            InitializeComponent();
            tablepanel.Visible = false;

        }
        private void populate(string stat, string notif)
        {
            table.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            tablepanel.Visible = true;
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
                                o.status = '" + stat + @"'  
                                AND (o.pay_meth = 'cod' OR o.pay_stat = 'paid')  
                            ORDER BY  
                                o.date DESC;";

            db d = new db();
            DataTable dr = d.readAll(query2);

            if (dr != null && dr.Rows.Count > 0)
            {
                if (stat == "on the way") { tablenoti.Text = noti2.Text = notif + " orders-> " + dr.Rows.Count; }
                else if (stat == "delivered") { tablenoti.Text = noti4.Text = notif + " orders-> " + dr.Rows.Count; }
                else if (stat == "cancelled") { tablenoti.Text = noti4.Text = notif + " orders-> " + dr.Rows.Count; }

                table.DataSource = dr;
                table.Columns[0].HeaderText = "Product Name";
                table.Columns[1].HeaderText = "Status";
                table.Columns[2].HeaderText = "Ordered Date";
                table.Columns[3].HeaderText = "Quantity";
            }
            else
            {
                if (stat == "on the way") { tablenoti.Text = noti2.Text = notif + " orders-> 0"; }
                else if (stat == "delivered") { tablenoti.Text = noti4.Text = notif + " orders-> 0"; }
                else if (stat == "cancelled") { tablenoti.Text = noti4.Text = notif + " orders-> 0"; }
                table.DataSource = null;
            }
        }
        private void a_orders_Load(object sender, EventArgs e)
        {
            populate("recived", "recived");
            populate("cancelled", "cancelled");
            populate("processing", "on the way");
            tablepanel.Visible = false;
            db d = new db();
            DataTable dt = d.readAll(" select history_id from orderhistory where status = 'Collection Request'");
            noti1.Text = "Collection Request-> " + (dt.Rows.Count.ToString());
            dt.Clear();
            DataTable dr = d.readAll(" select history_id from orderhistory where  status = 'on the way'");
            noti2.Text = "on the way orders-> " + (dt.Rows.Count.ToString());
            delev.Text = "on the way orders-> " + (dt.Rows.Count.ToString());
            dr.Clear();
            DataTable drr = d.readAll(" select history_id from orderhistory where status ='delivered'");
            noti3.Text = "delivered orders-> " + (drr.Rows.Count.ToString());
            drr.Clear();
            DataTable drrr = d.readAll(" select history_id from orderhistory where   status like '%cancele%'");
            noti4.Text = "cancelled orders-> " + (drrr.Rows.Count.ToString());
            drrr.Clear();
        }

        private void req_Click(object sender, EventArgs e)
        {
            clicked = 1;
            table.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            tablepanel.Visible = true;


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
                            and (o.pay_meth =  'cod' or   
                            o.pay_stat = 'paid' )
                        ORDER BY  
                            o.date DESC;";

            db d = new db();
            DataTable dt = d.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                tablenoti.Text = noti1.Text = "orders-> " + dt.Rows.Count;
                table.DataSource = dt;
                table.Columns[0].HeaderText = "History ID/Product";
                table.Columns[1].HeaderText = "Product Name";
                table.Columns[2].HeaderText = "Status";
                table.Columns[3].HeaderText = "Ordered Date";
                table.Columns[4].HeaderText = "Quantity";

                if (!table.Columns.Contains("CollectionRequest"))
                {
                    DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                    check.HeaderText = "Mark collected";
                    check.Name = "Mark collected";
                    check.Width = 150;
                    check.ReadOnly = false;
                    table.Columns.Insert(0, check);

                    foreach (DataGridViewRow row in table.Rows)
                    {
                        if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Delivered")
                        {
                            row.Cells["Mark Delivered"].Value = true;
                        }
                    }
                }


            }
            else
            {
                tablenoti.Text = noti1.Text = "No req Orders";
            }
        }

        private void Processing_Click(object sender, EventArgs e)
        {
            populate("on the way", "on the way");
        }

        private void success_Click(object sender, EventArgs e)
        {
            populate("recived", "Successfull");
        }

        private void failed_Click(object sender, EventArgs e)
        {
            table.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();


            tablepanel.Visible = true;
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
                                AND (o.pay_meth = 'cod' OR o.pay_stat = 'paid')  
                            ORDER BY  
                                o.date DESC;";

            db d = new db();
            DataTable dr = d.readAll(query2);

            if (dr != null && dr.Rows.Count > 0)
            {
                tablenoti.Text = noti4.Text = "cancelled orders-> " + dr.Rows.Count;
                table.DataSource = dr;
                table.Columns[0].HeaderText = "Product Name";
                table.Columns[1].HeaderText = "Status";
                table.Columns[2].HeaderText = "Ordered Date";
                table.Columns[3].HeaderText = "Quantity";
            }
            else
            {
                tablenoti.Text = noti4.Text = "No cancelled orders found.";
                table.DataSource = null;
            }
        }

        private void Delevred_Click(object sender, EventArgs e)
        {
            clicked = 2;
            table.DataSource = null;
            table.Rows.Clear();
            table.Columns.Clear();
            tablepanel.Visible = true;

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
                            and ( o.pay_meth =  'cod' or   
                            o.pay_stat = 'paid' ) 
                        ORDER BY  
                            o.date DESC;";

            db d = new db();
            DataTable dt = d.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                tablenoti.Text = noti1.Text = "orders-> " + dt.Rows.Count;
                table.DataSource = dt;
                table.Columns[0].Visible = false;
                table.Columns[1].HeaderText = "Product Name";
                table.Columns[2].HeaderText = "Status";
                table.Columns[3].HeaderText = "Ordered Date";
                table.Columns[4].HeaderText = "Quantity";

                if (!table.Columns.Contains("CollectionRequest"))
                {
                    DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                    check.HeaderText = "Mark Delivered";
                    check.Name = "Mark Delivered";
                    check.Width = 150;
                    check.ReadOnly = false;
                    table.Columns.Insert(0,check);
                }
            }
            else
            {
                tablenoti.Text = noti1.Text = "No Delivered Orders";
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && clicked == 1)
            {
                Console.WriteLine(e.ColumnIndex);
                string query = " Update orderhistory Set status ='on the way'  where history_id = '" + int.Parse(table.Rows[e.ColumnIndex].Cells["history_id"].Value.ToString()) + "'";
                db d = new db();
                if (d.write(query) > 0)
                {
                    noti1.Text = "on the way.";
                    req.PerformClick(); 

                }
                else
                {
                    noti1.Text = "Failed.";
                }
            }
            else if (e.ColumnIndex == 0 && clicked == 2)
            {
                Console.WriteLine(e.ColumnIndex);
                string query = " Update orderhistory Set status ='recived'  where history_id = '" + int.Parse(table.Rows[e.ColumnIndex].Cells["history_id"].Value.ToString()) + "'";
                db d = new db();
                if (d.write(query) > 0)
                {
                    noti1.Text = "on the way.";
                    Delevred.PerformClick();
                }
                else
                {
                    noti1.Text = "Failed.";
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            tablepanel.Visible = false;
        }
    }
}
