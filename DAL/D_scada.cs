using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class D_scada
    {
        public static DataTable GetData(string TableName)
        {
            string LinkConn = "sp_GetAll" + TableName;
            SqlConnection conn = connectiondata.connection();
            SqlCommand cmd = new SqlCommand(LinkConn, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            conn.Close();
            return table;
        }



        public static string stringConnection = @"Data Source=LAPTOP-396TJ0MT\SQLEXPRESS;Initial Catalog=Data_Login;Integrated Security=True";
        public static DataTable executeSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);

                connection.Close();
                connection = null;
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error orccured:" + ex.Message,
                    "SQL Server Connection Failed : iBasskung Tutorial",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;

        }
    }
}
