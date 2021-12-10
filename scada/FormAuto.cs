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
    public partial class FormAuto : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-PQ44GPT\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //Load data lên gridview
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CongThuc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public FormAuto()
        {
            InitializeComponent();
        }

          
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
        // Nhấn vào hiện lên textbox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtCongThuc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtXiMang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString()+ " Kg" ;
            txtCat.Text = dataGridView1.Rows[i].Cells[3].Value.ToString() + " Kg";
            txtKhoang.Text = dataGridView1.Rows[i].Cells[4].Value.ToString() + " Kg";
            txtTroBay.Text = dataGridView1.Rows[i].Cells[5].Value.ToString() + " Kg";
            txtPG1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString() + " Kg";
            txtPG2.Text = dataGridView1.Rows[i].Cells[7].Value.ToString() + " Kg";
            txtPG3.Text = dataGridView1.Rows[i].Cells[8].Value.ToString() + " Kg";

        }

        //Thêm CSDL
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO CongThuc VALUES( '" + txtCongThuc.Text + "', '" + txtXiMang.Text + "', '" + txtCat.Text + "', '" + txtKhoang.Text + "', '" + txtTroBay.Text + "', '" + txtPG1.Text + "', '" + txtPG2.Text + "', '" + txtPG3.Text + "' )";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM CongThuc WHERE id = '"+txtID.Text+"'" ;
            command.ExecuteNonQuery();
            LoadData();
    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CongThuc SET CongThuc = '" + txtCongThuc.Text + "', XiMang_kg ='" + txtXiMang.Text + "', Cat_kg = '" + txtCat.Text + "', Khoang_kg = '" + txtKhoang.Text + "', TroBay_kg = '" + txtTroBay.Text + "', PhuGia1_kg = '" + txtPG1.Text + "', PhuGia2_kg = '" + txtPG2.Text + "', PhuGia3_kg ='" + txtPG3.Text + "' WHERE  id = "+txtID.Text+"";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCongThuc.Text = "";
            txtXiMang.Text = "";
            txtCat.Text = "";
            txtKhoang.Text = "";
            txtTroBay.Text = "";
            txtPG1.Text = "";
            txtPG2.Text = "";
            txtPG3.Text = "";
        }
        // Chỉ nhập số không nhập chũ
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCongThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtXiMang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtKhoang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTroBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhuGia1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhuGia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPhuGia3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SCADA f = new SCADA();
            f.ShowDialog();
            this.Show();
        }
    }
    
}
