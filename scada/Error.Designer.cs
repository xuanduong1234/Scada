
namespace scada
{
    partial class Error
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listBoxDanhMucLoi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvTenLoi = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listBoxDanhMucLoi
            // 
            this.listBoxDanhMucLoi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxDanhMucLoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDanhMucLoi.FormattingEnabled = true;
            this.listBoxDanhMucLoi.ItemHeight = 18;
            this.listBoxDanhMucLoi.Location = new System.Drawing.Point(12, 42);
            this.listBoxDanhMucLoi.Name = "listBoxDanhMucLoi";
            this.listBoxDanhMucLoi.Size = new System.Drawing.Size(187, 292);
            this.listBoxDanhMucLoi.TabIndex = 0;
            this.listBoxDanhMucLoi.SelectedIndexChanged += new System.EventHandler(this.listBoxDanhMucLoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục lỗi";
            // 
            // lvTenLoi
            // 
            this.lvTenLoi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lvTenLoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTenLoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTenLoi.FullRowSelect = true;
            this.lvTenLoi.GridLines = true;
            this.lvTenLoi.HideSelection = false;
            this.lvTenLoi.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvTenLoi.Location = new System.Drawing.Point(215, 42);
            this.lvTenLoi.Name = "lvTenLoi";
            this.lvTenLoi.Size = new System.Drawing.Size(629, 292);
            this.lvTenLoi.TabIndex = 2;
            this.lvTenLoi.UseCompatibleStateImageBehavior = false;
            this.lvTenLoi.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên lỗi";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã lỗi";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên lỗi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 400;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(856, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvTenLoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDanhMucLoi);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDanhMucLoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvTenLoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
    }
}