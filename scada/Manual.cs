using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scada
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }
        private bool check = true;
        private bool check1 = true;
        private bool check2 = true;
        private bool check3 = true;
        private bool check4 = true;
        private bool check5 = true;
        private bool check6 = true;
        private bool check7 = true;
        private bool check8 = true;
        private bool check9 = true;
        private bool check10 = true;
        private bool check11 = true;
        private bool check12 = true;
        private bool check13 = true;
        

        private void btnVitximang_Click(object sender, EventArgs e)
        {
            this.check = !this.check;
            btnVitximang.BackColor = this.check ? Color.Silver : Color.Green;
        }

        private void btnVitCat_Click(object sender, EventArgs e)
        {
            this.check1 = !this.check1;
            btnVitCat.BackColor = this.check1 ? Color.Silver : Color.Green;
        }

        private void btnMaytron_Click(object sender, EventArgs e)
        {
            this.check2 = !this.check2;
            btnMaytron.BackColor = this.check2 ? Color.Silver : Color.Green;
        }

        private void btnVitTroBay_Click(object sender, EventArgs e)
        {
            this.check3 = !this.check3;
            btnVitTroBay.BackColor = this.check3 ? Color.Silver : Color.Green;
        }

        private void btnVitKhoang_Click(object sender, EventArgs e)
        {
            this.check4 = !this.check4;
            btnVitKhoang.BackColor = this.check4 ? Color.Silver : Color.Green;
        }

        private void btnMangTai_Click(object sender, EventArgs e)
        {
            this.check5 = !this.check5;
            btnMangTai.BackColor = this.check5 ? Color.Silver : Color.Green;
        }

        private void btnVanPheuPG1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVanPheuPG2_Click(object sender, EventArgs e)
        {
            this.check7 = !this.check7;
            btnVanPheuPG2.BackColor = this.check7 ? Color.Silver : Color.Green;
        }

        private void btnVanPheuPG3_Click(object sender, EventArgs e)
        {
            this.check8 = !this.check8;
            btnVanPheuPG3.BackColor = this.check8 ? Color.Silver : Color.Green;
        }

        private void btnVanCanPG_Click(object sender, EventArgs e)
        {
            this.check9 = !this.check9;
            btnVanCanPG.BackColor = this.check9 ? Color.Silver : Color.Green;
        }

        private void btnVanCanXiCat_Click(object sender, EventArgs e)
        {
            this.check10 = !this.check10;
            btnVanCanXiCat.BackColor = this.check10 ? Color.Silver : Color.Green;
        }

        private void btnVanTroKhoang_Click(object sender, EventArgs e)
        {
            this.check11 = !this.check11;
            btnVanTroKhoang.BackColor = this.check11 ? Color.Silver : Color.Green;
        }

        private void btnVanMayTronMo_Click(object sender, EventArgs e)
        {
            this.check12 = !this.check12;
            btnVanMayTronMo.BackColor = this.check12 ? Color.Silver : Color.Green;
        }

        private void btnVanMayTronDong_Click(object sender, EventArgs e)
        {
            this.check13 = !this.check13;
            btnVanMayTronDong.BackColor = this.check13 ? Color.Silver : Color.Green;
        }

        private void btnVanPheuPG1_Click_1(object sender, EventArgs e)
        {
            this.check6 = !this.check6;
            btnVanPheuPG1.BackColor = this.check6 ? Color.Silver : Color.Green;
        }
    }
}
