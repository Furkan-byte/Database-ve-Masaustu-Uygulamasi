using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace Database_Systems_Project.CODE_SOURCES
{
    public class DataAccess

    {
        public static string dbp = "Data Source=DESKTOP-84MBG8P;Initial Catalog=TTTProject;Integrated Security=True";
        public static DataTable ExecuteQuery(string query)
        {
            // connection
            // command 
            // adapter
            // datatable
            SqlConnection con = new SqlConnection(dbp);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // INSERT, DELETE, UPDATE
        public static int ExecuteNonQuery(string query)
        {
            // connection
            // command 
            // adapter
            // datatable
            SqlConnection con = new SqlConnection(dbp);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }
        public static bool ExecuteReader(string query)
        {
            SqlConnection con = new SqlConnection(dbp);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }
    }
    
}

