
namespace scada
{
    partial class Manual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVitximang = new System.Windows.Forms.Button();
            this.btnVitCat = new System.Windows.Forms.Button();
            this.btnMaytron = new System.Windows.Forms.Button();
            this.btnVitTroBay = new System.Windows.Forms.Button();
            this.btnVitKhoang = new System.Windows.Forms.Button();
            this.btnMangTai = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.brnVanPheuPG1 = new System.Windows.Forms.Button();
            this.btnVanCanPG = new System.Windows.Forms.Button();
            this.btnVanMayTronMo = new System.Windows.Forms.Button();
            this.btnVanPheuPG2 = new System.Windows.Forms.Button();
            this.btnVanCanXiCat = new System.Windows.Forms.Button();
            this.btnVanMayTronDong = new System.Windows.Forms.Button();
            this.btnVanPheuPG3 = new System.Windows.Forms.Button();
            this.btnVanTroKhoang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng điều khiển bằng tay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 259);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnMangTai, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnVitKhoang, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnVitTroBay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMaytron, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVitCat, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVitximang, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(509, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnVitximang
            // 
            this.btnVitximang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitximang.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVitximang.Location = new System.Drawing.Point(3, 3);
            this.btnVitximang.Name = "btnVitximang";
            this.btnVitximang.Size = new System.Drawing.Size(163, 52);
            this.btnVitximang.TabIndex = 0;
            this.btnVitximang.Text = "Vít xi măng";
            this.btnVitximang.UseVisualStyleBackColor = true;
            this.btnVitximang.Click += new System.EventHandler(this.btnVitximang_Click);
            // 
            // btnVitCat
            // 
            this.btnVitCat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitCat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVitCat.Location = new System.Drawing.Point(172, 3);
            this.btnVitCat.Name = "btnVitCat";
            this.btnVitCat.Size = new System.Drawing.Size(163, 52);
            this.btnVitCat.TabIndex = 1;
            this.btnVitCat.Text = "Vít cát";
            this.btnVitCat.UseVisualStyleBackColor = true;
            this.btnVitCat.Click += new System.EventHandler(this.btnVitCat_Click);
            // 
            // btnMaytron
            // 
            this.btnMaytron.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaytron.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMaytron.Location = new System.Drawing.Point(341, 3);
            this.btnMaytron.Name = "btnMaytron";
            this.btnMaytron.Size = new System.Drawing.Size(163, 52);
            this.btnMaytron.TabIndex = 2;
            this.btnMaytron.Text = "Máy trộn";
            this.btnMaytron.UseVisualStyleBackColor = true;
            this.btnMaytron.Click += new System.EventHandler(this.btnMaytron_Click);
            // 
            // btnVitTroBay
            // 
            this.btnVitTroBay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitTroBay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVitTroBay.Location = new System.Drawing.Point(3, 61);
            this.btnVitTroBay.Name = "btnVitTroBay";
            this.btnVitTroBay.Size = new System.Drawing.Size(163, 52);
            this.btnVitTroBay.TabIndex = 3;
            this.btnVitTroBay.Text = "Vít tro bay";
            this.btnVitTroBay.UseVisualStyleBackColor = true;
            this.btnVitTroBay.Click += new System.EventHandler(this.btnVitTroBay_Click);
            // 
            // btnVitKhoang
            // 
            this.btnVitKhoang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitKhoang.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVitKhoang.Location = new System.Drawing.Point(172, 61);
            this.btnVitKhoang.Name = "btnVitKhoang";
            this.btnVitKhoang.Size = new System.Drawing.Size(163, 52);
            this.btnVitKhoang.TabIndex = 4;
            this.btnVitKhoang.Text = "Vít khoáng";
            this.btnVitKhoang.UseVisualStyleBackColor = true;
            this.btnVitKhoang.Click += new System.EventHandler(this.btnVitKhoang_Click);
            // 
            // btnMangTai
            // 
            this.btnMangTai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangTai.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMangTai.Location = new System.Drawing.Point(341, 61);
            this.btnMangTai.Name = "btnMangTai";
            this.btnMangTai.Size = new System.Drawing.Size(163, 52);
            this.btnMangTai.TabIndex = 5;
            this.btnMangTai.Text = "Máng tải";
            this.btnMangTai.UseVisualStyleBackColor = true;
            this.btnMangTai.Click += new System.EventHandler(this.btnMangTai_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.btnVanTroKhoang, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnVanPheuPG3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnVanMayTronDong, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnVanCanXiCat, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnVanPheuPG2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnVanMayTronMo, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnVanCanPG, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.brnVanPheuPG1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(509, 111);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // brnVanPheuPG1
            // 
            this.brnVanPheuPG1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.brnVanPheuPG1.Location = new System.Drawing.Point(3, 3);
            this.brnVanPheuPG1.Name = "brnVanPheuPG1";
            this.brnVanPheuPG1.Size = new System.Drawing.Size(163, 30);
            this.brnVanPheuPG1.TabIndex = 0;
            this.brnVanPheuPG1.Text = "Van phễu PG1";
            this.brnVanPheuPG1.UseVisualStyleBackColor = true;
            // 
            // btnVanCanPG
            // 
            this.btnVanCanPG.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanCanPG.Location = new System.Drawing.Point(172, 3);
            this.btnVanCanPG.Name = "btnVanCanPG";
            this.btnVanCanPG.Size = new System.Drawing.Size(163, 30);
            this.btnVanCanPG.TabIndex = 1;
            this.btnVanCanPG.Text = "Van cân PG";
            this.btnVanCanPG.UseVisualStyleBackColor = true;
            // 
            // btnVanMayTronMo
            // 
            this.btnVanMayTronMo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanMayTronMo.Location = new System.Drawing.Point(341, 3);
            this.btnVanMayTronMo.Name = "btnVanMayTronMo";
            this.btnVanMayTronMo.Size = new System.Drawing.Size(163, 30);
            this.btnVanMayTronMo.TabIndex = 2;
            this.btnVanMayTronMo.Text = "Van máy trộn mở";
            this.btnVanMayTronMo.UseVisualStyleBackColor = true;
            // 
            // btnVanPheuPG2
            // 
            this.btnVanPheuPG2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanPheuPG2.Location = new System.Drawing.Point(3, 39);
            this.btnVanPheuPG2.Name = "btnVanPheuPG2";
            this.btnVanPheuPG2.Size = new System.Drawing.Size(163, 30);
            this.btnVanPheuPG2.TabIndex = 3;
            this.btnVanPheuPG2.Text = "Van phễu PG2";
            this.btnVanPheuPG2.UseVisualStyleBackColor = true;
            // 
            // btnVanCanXiCat
            // 
            this.btnVanCanXiCat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanCanXiCat.Location = new System.Drawing.Point(172, 39);
            this.btnVanCanXiCat.Name = "btnVanCanXiCat";
            this.btnVanCanXiCat.Size = new System.Drawing.Size(163, 30);
            this.btnVanCanXiCat.TabIndex = 4;
            this.btnVanCanXiCat.Text = "Van cân xi cát";
            this.btnVanCanXiCat.UseVisualStyleBackColor = true;
            // 
            // btnVanMayTronDong
            // 
            this.btnVanMayTronDong.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanMayTronDong.Location = new System.Drawing.Point(341, 39);
            this.btnVanMayTronDong.Name = "btnVanMayTronDong";
            this.btnVanMayTronDong.Size = new System.Drawing.Size(163, 30);
            this.btnVanMayTronDong.TabIndex = 5;
            this.btnVanMayTronDong.Text = "Van máy trộn đóng";
            this.btnVanMayTronDong.UseVisualStyleBackColor = true;
            // 
            // btnVanPheuPG3
            // 
            this.btnVanPheuPG3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanPheuPG3.Location = new System.Drawing.Point(3, 75);
            this.btnVanPheuPG3.Name = "btnVanPheuPG3";
            this.btnVanPheuPG3.Size = new System.Drawing.Size(163, 30);
            this.btnVanPheuPG3.TabIndex = 6;
            this.btnVanPheuPG3.Text = "Van phễu PG3";
            this.btnVanPheuPG3.UseVisualStyleBackColor = true;
            // 
            // btnVanTroKhoang
            // 
            this.btnVanTroKhoang.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnVanTroKhoang.Location = new System.Drawing.Point(172, 75);
            this.btnVanTroKhoang.Name = "btnVanTroKhoang";
            this.btnVanTroKhoang.Size = new System.Drawing.Size(163, 30);
            this.btnVanTroKhoang.TabIndex = 7;
            this.btnVanTroKhoang.Text = " Van tro khoáng";
            this.btnVanTroKhoang.UseVisualStyleBackColor = true;
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(515, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVitximang;
        private System.Windows.Forms.Button btnMangTai;
        private System.Windows.Forms.Button btnVitKhoang;
        private System.Windows.Forms.Button btnVitTroBay;
        private System.Windows.Forms.Button btnMaytron;
        private System.Windows.Forms.Button btnVitCat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnVanTroKhoang;
        private System.Windows.Forms.Button btnVanPheuPG3;
        private System.Windows.Forms.Button btnVanMayTronDong;
        private System.Windows.Forms.Button btnVanCanXiCat;
        private System.Windows.Forms.Button btnVanPheuPG2;
        private System.Windows.Forms.Button btnVanMayTronMo;
        private System.Windows.Forms.Button btnVanCanPG;
        private System.Windows.Forms.Button brnVanPheuPG1;
    }
}