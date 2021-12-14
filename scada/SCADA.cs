using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using System.Data.SqlClient;

namespace scada
{
    public partial class SCADA : Form
    {
        private int boderSize = 2;
        private About about;
        private Form activeForm = null;

        string Username = "", Password = "", Quyen = "";
        //Kết nối CSDL
        SqlConnection conec = new SqlConnection(@"Data Source=DESKTOP-PQ44GPT\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True");    
        

        public SCADA(string id, string Username, string Password, string Quyen)
        {
            this.about = new About();
            InitializeComponent();
            this.Text = string.Empty;
            this.Padding = new Padding(boderSize);//boder size           
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Username = Username;
            this.Password = Password;
            this.Quyen = Quyen;
        }
        //Mơ childform
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null) activeForm.Close();            
            if (activeForm != null) activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Thời gian thực
        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblTime.Text = date;
        }
        //Kết nối PLC S7.1200
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Plc plcc = new Plc(CpuType.S71200, txtAdressPLC.Text, 0, 1);
            plcc.Open();
            if (plcc.IsConnected == true)
            {
                lblCon.BackColor = Color.Green;
            }                
        }
        //Phân quyền
        private void SCADA_Load(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
                lblQuyen.Text = "ADMIN";
            else
            {
                lblQuyen.Text = "USER";
                btnManual.Enabled = false;  // Quyền User không sd được
            }
                
        }
        // Chỉ nhập số không nhập chữ( địa chỉ PLC)
        private void txtAdressPLC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void standardControl8_Load(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
        }

        // Hiển thị form Auto
        private void btnRecipe_Click(object sender, EventArgs e)
        {
            FormAuto f = new FormAuto();
            f.ShowDialog();
            this.Show();
        }
        // Hiển thi form Error
        private void btnOffSet_Click(object sender, EventArgs e)
        {
            Error f = new Error();
            f.ShowDialog();
            this.Show();
        }

        private void standardControl5_Load(object sender, EventArgs e)
        {

        }

        private void standardControl13_Load(object sender, EventArgs e)
        {

        }
        // Hiển thị form Chart
        private void btnTrend_Click(object sender, EventArgs e)
        {
            Chart f = new Chart();
            f.ShowDialog();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void standardControl40_Load(object sender, EventArgs e)
        {

        }

        private void btnWeigh_Click(object sender, EventArgs e)
        {
            // this.openChildForm(about);
            About f = new About();
            f.ShowDialog();
            this.Show();
            
        }

        private void lblCon_Click(object sender, EventArgs e)
        {

        }
        


        private void btnManual_Click(object sender, EventArgs e)
        {
            if( Quyen == "Admin")
            {
                Manual f = new Manual();
                f.ShowDialog();
                this.Show();
            }                       
        }       
    }
}
