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

namespace scada
{
    public partial class SCADA : Form
    {
        public SCADA()
        {
            InitializeComponent();
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

        private void SCADA_Load(object sender, EventArgs e)
        {
         
        }
        // Chỉ nhập số không nhập chữ
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
    }
}
