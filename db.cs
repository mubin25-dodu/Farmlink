using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Farmlink
{
    internal class db
    {
        // Address of the database server
        string constring = "Data Source = MUBIN\\SQLEXPRESS; Initial Catalog = Farmlink; Integrated Security = True;";

        public DataRow read(string q)
        {
            // Create a connection object
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            // query build
            string query = q;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count==1) {
                return dt.Rows[0]; ;
            }
            else{
                return null;
            }
           
        }
        public int write(string q)
        {
            // Create a connection object
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            // query build
            string query = q;
            // execute the query
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            // check if the query executed successfully
            con.Close();
            return i;
        }
    }

}
