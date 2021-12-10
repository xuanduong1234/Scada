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
    public partial class Register : Form
   {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PQ44GPT\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True");
            try
            {
                con.Open();
                string strcheckLogin = string.Empty;

                strcheckLogin += "SELECT * FROM LoginTbl ";
                strcheckLogin += "WHERE Username ='" + txtUserName.Text + "'";
                strcheckLogin += "AND Password = '" + txtPassword.Text + "'";
                
                SqlCommand cmd = new SqlCommand(strcheckLogin, con);
                SqlDataReader dta = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                

                if (dta.Read() == true)
                {                   
                    SCADA a = new SCADA();
                    a.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu sai. Xin thử lại.");
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    txtPassword.Clear();
                }
            }
            catch (Exception eww)
            {
                MessageBox.Show("Lỗi kết nối " + eww.Message);
            }
        }
    

   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
                   
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
                    
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        //Chỉ nhập số
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

