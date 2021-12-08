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

        private void btnVitximang_Click(object sender, EventArgs e)
        {
            btnVitximang.BackColor = Color.Green;
        }

        private void btnVitCat_Click(object sender, EventArgs e)
        {
            btnVitCat.BackColor = Color.Green;
        }

        private void btnMaytron_Click(object sender, EventArgs e)
        {
            btnMaytron.BackColor = Color.Green;
        }

        private void btnVitTroBay_Click(object sender, EventArgs e)
        {
            btnVitTroBay.BackColor = Color.Green;
        }

        private void btnVitKhoang_Click(object sender, EventArgs e)
        {
            btnVitKhoang.BackColor = Color.Green;
        }

        private void btnMangTai_Click(object sender, EventArgs e)
        {
            btnMangTai.BackColor = Color.Green;
        }
    }
}
