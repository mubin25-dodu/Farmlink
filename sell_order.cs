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
        private string id;
        private string role;
        public sell_order(string i, string r)
        {
            InitializeComponent();
            this.id = i;
            this.role = r;
            Console.WriteLine(id);
        }

        private void sell_order_Load(object sender, EventArgs e)
        {
            tablepanel.Hide();
            count.Hide();

            string q = "select * from orderhistory where "+role+" ='"+id+ "' and (status = 'processing' or status ='Collection Request')";
            db d = new db();
            DataTable t = d.readAll(q);
            if (t != null && t.Rows.Count > 0)
            {
                count.Show();
                count.Text = t.Rows.Count.ToString();
            }
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
                                o."+role+" = '" + id + @"'  
                                AND o.status = '" + stat + @"'  
                              
                            ORDER BY  
                                o.date DESC;";

            db d = new db();
            DataTable dr = d.readAll(query2);

            if (dr != null && dr.Rows.Count > 0)
            {
                tablenoti.Text = "Orders-> " + dr.Rows.Count;
                //if (stat == "on the way") { tablenoti.Text = noti2.Text = notif + " orders-> " + dr.Rows.Count; }
                //else if (stat == "delivered") {  tablenoti.Text = noti4.Text = notif + " orders-> " + dr.Rows.Count; }
                //else if (stat == "cancelled") { tablenoti.Text =  noti4.Text = notif + " orders-> " + dr.Rows.Count; }

                table.DataSource = dr;
                table.Columns[0].HeaderText = "Product Name";
                table.Columns[1].HeaderText = "Status";
                table.Columns[2].HeaderText = "Ordered Date";
                table.Columns[3].HeaderText = "Quantity";
            }
            else
            {
                tablenoti.Text = "Orders found ";
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
                int i = int.Parse(table.Rows[e.RowIndex].Cells["history_id"].Value.ToString());
                string check = "select status from orderhistory where history_id = '"+i+"'";
                db d = new db();
                Console.WriteLine(i+"sadas");
                DataRow dr = d.read(check);

                if (dr[0].ToString() == "processing")
                {

                    string query = " Update orderhistory Set status ='Collection Request'  where history_id = '" + i + "'";
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
                            o."+role+" = '"+id+ @"'  
                            and  (o.status = 'processing'
                            or o.status ='Collection Request')
                            
                        ORDER BY  
                            o.date DESC;";

            //and(o.pay_meth = 'cod' or

            //               o.pay_stat = 'paid')

            db d = new db();
            DataTable dt = d.readAll(query);

            if ( dt.Rows.Count > 0)
            {
                tablenoti.Text  = "pending orders-> " + dt.Rows.Count;
                table.DataSource = dt;
                table.Columns[0].Visible = false;
                table.Columns[1].HeaderText = "Product Name";
                table.Columns[2].HeaderText = "Status";
                table.Columns[3].HeaderText = "Ordered Date";
                table.Columns[4].HeaderText = "Quantity";

                if (table.Columns.Contains("Request"))
                {
                    table.Columns.Remove("Request");
                }
                DataGridViewButtonColumn profile = new DataGridViewButtonColumn();
                profile.HeaderText = "Collection Request";
                profile.Text = "Request";
                profile.UseColumnTextForButtonValue = true;
                profile.Name = "Request";
                table.Columns.Insert(0, profile);


            }
            else
            {
                tablenoti.Text = "No pending Orders";
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            table.DataSource = null;
            table.Rows.Clear();
            tablepanel.Visible = false;
            count.Hide();
            string q = "select * from orderhistory where "+role+" = '"+id+ "' and status ='processing'";
            db d = new db();
            DataTable t = d.readAll(q);
            if (t != null && t.Rows.Count > 0)
            {
                count.Show();
                count.Text = t.Rows.Count.ToString();
            }


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
                                o."+role+" = '" + id + @"'  
                               and o.status like '%cancel%' 
                            ORDER BY  
                                o.date DESC;";

            db d = new db();
            DataTable dr = d.readAll(query2);

            if (dr != null && dr.Rows.Count > 0)
            {
                tablenoti.Text = "cancelled orders-> " + dr.Rows.Count;
                table.DataSource = dr;
                table.Columns[0].HeaderText = "Product Name";
                table.Columns[1].HeaderText = "Status";
                table.Columns[2].HeaderText = "Ordered Date";
                table.Columns[3].HeaderText = "Quantity";
            }
            else
            {
               tablenoti.Text = "No cancelled orders found.";
                table.DataSource = null;
            }

        }
    }
}
