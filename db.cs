using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Farmlink
{
    internal class db
    {
        // Address of the database server
        string constring = "Data Source = MUBIN\\SQLEXPRESS; Initial Catalog = Farmlink; Integrated Security = True;";

        public DataRow read(string q)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(q, con);
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database read error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int write(string q)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(q, con);
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database write error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public DataTable readAll(string q)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(q, con);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database readAll error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}
