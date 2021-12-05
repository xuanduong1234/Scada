using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class connection
    {
        public static SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E3TE8BA\SQLEXPRESS;Initial Catalog=QuanLyXeAGV;Integrated Security=True");
            return conn;

        }
    }
}
