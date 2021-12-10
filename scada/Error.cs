 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace scada
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-PQ44GPT\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True";

        private void Error_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM DanhMucLoi ";
            command.Connection = conn;           
            listBoxDanhMucLoi.Items.Clear();
            SqlDataReader raeder = command.ExecuteReader();
            while (raeder.Read())
            {
                string line = raeder.GetInt32(0) +"-"+ raeder.GetString(1);
                listBoxDanhMucLoi.Items.Add(line);
            }
            raeder.Close();                                     
        }

        private void listBoxDanhMucLoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDanhMucLoi.SelectedIndex == -1)
                return;
            string line = listBoxDanhMucLoi.SelectedItem.ToString();
            string[] arr = line.Split('-');
            int madm = int.Parse(arr[0]);

            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM TenLoi WHERE MaDanhMucLoi = @madm ";
            command.Connection = conn;

            SqlParameter parMaDanhMuc = new SqlParameter("@madm", SqlDbType.Int);
            parMaDanhMuc.Value = madm;
            command.Parameters.Add(parMaDanhMuc);

            lvTenLoi.Items.Clear();
            SqlDataReader raeder = command.ExecuteReader();
            while(raeder.Read())
            {
                int ma = raeder.GetInt32(0);
                DateTime time = raeder.GetDateTime(1);
                string tenLoi = raeder.GetString(2);
                ListViewItem lvi = new ListViewItem(ma + "");
                lvi.SubItems.Add(time +"");
                lvi.SubItems.Add(tenLoi);

                lvTenLoi.Items.Add(lvi);
            }
            raeder.Close(); 


        }
    }
}
