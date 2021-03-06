
namespace scada
{
    partial class Chart
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
            this.components = new System.ComponentModel.Container();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lvChartAppBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lvChartAppBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lvChartAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.elementHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementHost1.ForeColor = System.Drawing.Color.Orange;
            this.elementHost1.Location = new System.Drawing.Point(12, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(901, 202);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Lime;
            this.btnLoad.Location = new System.Drawing.Point(786, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 32);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 178);
            this.dataGridView1.TabIndex = 4;
            // 
            // lvChartAppBindingSource2
            // 
            this.lvChartAppBindingSource2.DataSource = typeof(scada.LvChartApp);
            // 
            // lvChartAppBindingSource1
            // 
            this.lvChartAppBindingSource1.DataSource = typeof(scada.LvChartApp);
            // 
            // lvChartAppBindingSource
            // 
            this.lvChartAppBindingSource.DataSource = typeof(scada.LvChartApp);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.elementHost1);
            this.Name = "Chart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvChartAppBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource lvChartAppBindingSource;
        private System.Windows.Forms.BindingSource lvChartAppBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lvChartAppBindingSource2;
    }
}