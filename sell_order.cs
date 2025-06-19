using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Farmlink
{
    public partial class sell_order : UserControl
    {
        private string seller_id;
        public sell_order(string id)
        {
            InitializeComponent();
            this.seller_id = id;
        }

        private void sell_order_Load(object sender, EventArgs e)
        {
            populate("received", "received");
            populate("cancelled", "cancelled");
            populate("processing", "on the way");
            tablepanel.Visible = false;
            db d = new db();
            DataTable dt = d.readAll(" select history_id from orderhistory where seller_id = '" + seller_id + "' and ( status ='processing' or status = 'Collection Request')");
            noti1.Text = "pending orders-> " + (dt.Rows.Count.ToString());
            dt.Clear();
            DataTable dr = d.readAll(" select history_id from orderhistory where seller_id = '" + seller_id + "' and status ='on the way'");
            noti2.Text = "on the way orders-> " + (dt.Rows.Count.ToString());
            dr.Clear();
            DataTable drr = d.readAll(" select history_id from orderhistory where seller_id = '" + seller_id + "' and status ='delivered'");
            noti3.Text = "delivered orders-> " + (drr.Rows.Count.ToString());
            drr.Clear();
            DataTable drrr = d.readAll(" select history_id from orderhistory where seller_id = '" + seller_id + "' and (status ='canceled -> customer' or status = 'canceled -> seller' or status = 'canceled -> agent')");
            noti4.Text = "cancelled orders-> " + (drrr.Rows.Count.ToString());
            drrr.Clear();
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
                                o.seller_id = '" + seller_id + @"'  
                                AND o.status = '" + stat + @"'  
                                AND (o.pay_meth = 'cod' OR o.pay_stat = 'paid')  
                            ORDER BY  
                                o.date DESC;";

            db d = new db();
            DataTable dr = d.readAll(query2);

            if (dr != null && dr.Rows.Count > 0)
            {
                if (stat == "on the way") { tablenoti.Text = noti2.Text = notif + " orders-> " + dr.Rows.Count; }
                else if (stat == "delivered") {  tablenoti.Text = noti4.Text = notif + " orders-> " + dr.Rows.Count; }
                else if (stat == "cancelled") { tablenoti.Text =  noti4.Text = notif + " orders-> " + dr.Rows.Count; }

                table.DataSource = dr;
                table.Columns[0].HeaderText = "Product Name";
                table.Columns[1].HeaderText = "Status";
                table.Columns[2].HeaderText = "Ordered Date";
                table.Columns[3].HeaderText = "Quantity";
            }
            else
            {
                if (stat == "on the way") { tablenoti.Text = noti2.Text = notif + " orders-> 0"; }
                else if (stat == "delivered") {  tablenoti.Text =noti4.Text = notif + " orders-> 0"; }
                else if (stat == "cancelled") { tablenoti.Text = noti4.Text = notif + " orders-> 0"; }
                table.DataSource = null;
            }


        }

        private void pending_odr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pending_odr_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                Console.WriteLine(e.ColumnIndex);
                int id = int.Parse(table.Rows[e.RowIndex].Cells["history_id"].Value.ToString());
                string check = "select status from orderhistory where history_id = '"+id+"'";
                db d = new db();
                DataRow dr = d.read(check);

                if (dr[0].ToString() == "processing")
                {

                    string query = " Update orderhistory Set status ='Collection Request'  where history_id = '" + id + "'";
                    if (d.write(query) > 0)
                    {
                        tablenoti.Text = "Collection request sent successfully.";
                        pending.PerformClick();
                    }
                    else
                    {
                        tablenoti.Text = "Failed to send collection request.";
                    }
                }
                else if (dr[0].ToString() == "Collection Request")
                {
                    tablenoti.Text = "Collection request already sent for this order.";
                    return;
                } 
                }
            
        }

        private void processing_odr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void failed_Click(object sender, EventArgs e)
        {

        }

        private void pending_Click(object sender, EventArgs e)
        {
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
                            o.seller_id = 'se-0001'  
                            and  (o.status = 'processing'
                            or o.status ='Collection Request')
                            and( o.pay_meth =  'cod' or   
                            o.pay_stat = 'paid')  
                        ORDER BY  
                            o.date DESC;";

            db d = new db();
            DataTable dt = d.readAll(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                tablenoti.Text = noti1.Text = "pending orders-> " + dt.Rows.Count;
                table.DataSource = dt;
                table.Columns[0].Visible = false;
                table.Columns[1].HeaderText = "Product Name";
                table.Columns[2].HeaderText = "Status";
                table.Columns[3].HeaderText = "Ordered Date";
                table.Columns[4].HeaderText = "Quantity";

                if (!table.Columns.Contains("CollectionRequest"))
                {
                    DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                    check.HeaderText = "Collection Request";
                    check.Name = "CollectionRequest";
                    check.Width = 150;
                    check.ReadOnly = false;
                    table.Columns.Insert(0, check);

                }


            }
            else
            {
                tablenoti.Text = noti1.Text = "No pending Orders";
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            table.DataSource = null;
            table.Rows.Clear();
            tablepanel.Visible = false;
          

        }

        private void Processing_Click(object sender, EventArgs e)
        {
            populate("on the way", "processing");
        }

        private void success_Click(object sender, EventArgs e)
        {
            populate("received", "received");


        }

        private void failed_Click_1(object sender, EventArgs e)
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
                                o.seller_id = '" + seller_id + @"'  
                               and o.status like '%cancel%' 
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
    }
}
