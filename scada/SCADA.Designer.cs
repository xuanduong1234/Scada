
namespace scada
{
    partial class SCADA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCADA));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtAdressPLC = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEStop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnTrend = new System.Windows.Forms.Button();
            this.btnWeigh = new System.Windows.Forms.Button();
            this.btnOffSet = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.standardControl7 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl6 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl4 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl8 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl3 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl2 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl5 = new SymbolFactoryDotNet.StandardControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Lime;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 17);
            this.lblTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(526, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ THỐNG SẢN XUẤT VỮA KHÔ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(458, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 59);
            this.panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(215, 56);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(33, 1, 0, 0);
            this.label6.Size = new System.Drawing.Size(172, 53);
            this.label6.TabIndex = 0;
            this.label6.Text = "HUST";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblCon);
            this.panel4.Controls.Add(this.txtAdressPLC);
            this.panel4.Controls.Add(this.btnConnect);
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 58);
            this.panel4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(64, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kết nối PLC";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Red;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(204, 26);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(14, 16);
            this.lblCon.TabIndex = 11;
            this.lblCon.Text = "  ";
            this.lblCon.Click += new System.EventHandler(this.lblCon_Click);
            // 
            // txtAdressPLC
            // 
            this.txtAdressPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdressPLC.Location = new System.Drawing.Point(6, 23);
            this.txtAdressPLC.Name = "txtAdressPLC";
            this.txtAdressPLC.Size = new System.Drawing.Size(99, 22);
            this.txtAdressPLC.TabIndex = 2;
            this.txtAdressPLC.Text = "192.268.0.0";
            this.txtAdressPLC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdressPLC_KeyPress);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Cyan;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(111, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 37);
            this.panel5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bảng điều khiển và khảo sát";
            // 
            // btnAuto
            // 
            this.btnAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.Color.Red;
            this.btnAuto.Location = new System.Drawing.Point(0, 0);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(218, 45);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.TabStop = false;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.btnEStop);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnRecipe);
            this.panel3.Controls.Add(this.btnTrend);
            this.panel3.Controls.Add(this.btnWeigh);
            this.panel3.Controls.Add(this.btnOffSet);
            this.panel3.Controls.Add(this.btnManual);
            this.panel3.Controls.Add(this.btnAuto);
            this.panel3.Location = new System.Drawing.Point(3, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 411);
            this.panel3.TabIndex = 15;
            // 
            // btnEStop
            // 
            this.btnEStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEStop.ForeColor = System.Drawing.Color.Red;
            this.btnEStop.Location = new System.Drawing.Point(0, 360);
            this.btnEStop.Name = "btnEStop";
            this.btnEStop.Size = new System.Drawing.Size(218, 45);
            this.btnEStop.TabIndex = 8;
            this.btnEStop.TabStop = false;
            this.btnEStop.Text = "EStop";
            this.btnEStop.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(0, 315);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(218, 45);
            this.btnStop.TabIndex = 7;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(0, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 45);
            this.btnStart.TabIndex = 6;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnRecipe
            // 
            this.btnRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipe.ForeColor = System.Drawing.Color.Red;
            this.btnRecipe.Location = new System.Drawing.Point(0, 225);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(218, 45);
            this.btnRecipe.TabIndex = 5;
            this.btnRecipe.TabStop = false;
            this.btnRecipe.Text = "Recipe";
            this.btnRecipe.UseVisualStyleBackColor = true;
            // 
            // btnTrend
            // 
            this.btnTrend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrend.ForeColor = System.Drawing.Color.Red;
            this.btnTrend.Location = new System.Drawing.Point(0, 180);
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.Size = new System.Drawing.Size(218, 45);
            this.btnTrend.TabIndex = 4;
            this.btnTrend.TabStop = false;
            this.btnTrend.Text = "Trend";
            this.btnTrend.UseVisualStyleBackColor = true;
            // 
            // btnWeigh
            // 
            this.btnWeigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeigh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeigh.ForeColor = System.Drawing.Color.Red;
            this.btnWeigh.Location = new System.Drawing.Point(0, 135);
            this.btnWeigh.Name = "btnWeigh";
            this.btnWeigh.Size = new System.Drawing.Size(218, 45);
            this.btnWeigh.TabIndex = 3;
            this.btnWeigh.TabStop = false;
            this.btnWeigh.Text = "Set Weigh";
            this.btnWeigh.UseVisualStyleBackColor = true;
            // 
            // btnOffSet
            // 
            this.btnOffSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOffSet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffSet.ForeColor = System.Drawing.Color.Red;
            this.btnOffSet.Location = new System.Drawing.Point(0, 90);
            this.btnOffSet.Name = "btnOffSet";
            this.btnOffSet.Size = new System.Drawing.Size(218, 45);
            this.btnOffSet.TabIndex = 2;
            this.btnOffSet.TabStop = false;
            this.btnOffSet.Text = "Set Offset";
            this.btnOffSet.UseVisualStyleBackColor = true;
            // 
            // btnManual
            // 
            this.btnManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.Red;
            this.btnManual.Location = new System.Drawing.Point(0, 45);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(218, 45);
            this.btnManual.TabIndex = 1;
            this.btnManual.TabStop = false;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(224, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 552);
            this.panel2.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.standardControl7);
            this.panel6.Controls.Add(this.standardControl6);
            this.panel6.Controls.Add(this.standardControl4);
            this.panel6.Controls.Add(this.standardControl8);
            this.panel6.Controls.Add(this.standardControl3);
            this.panel6.Controls.Add(this.standardControl2);
            this.panel6.Controls.Add(this.standardControl1);
            this.panel6.Controls.Add(this.standardControl5);
            this.panel6.Location = new System.Drawing.Point(476, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 206);
            this.panel6.TabIndex = 0;
            // 
            // standardControl7
            // 
            this.standardControl7.AnalogIntValue1 = ((short)(0));
            this.standardControl7.AnalogValue1 = 0D;
            this.standardControl7.BackColor = System.Drawing.Color.Transparent;
            this.standardControl7.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl7.BlinkColor = System.Drawing.Color.Red;
            this.standardControl7.Category = "1MTR.cat2";
            this.standardControl7.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl7.DebugData"));
            this.standardControl7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl7.Location = new System.Drawing.Point(391, 93);
            this.standardControl7.Name = "standardControl7";
            this.standardControl7.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate180;
            this.standardControl7.Size = new System.Drawing.Size(50, 21);
            this.standardControl7.SymbolHandle = ((long)(1946842866));
            this.standardControl7.TabIndex = 11;
            // 
            // standardControl6
            // 
            this.standardControl6.AnalogIntValue1 = ((short)(0));
            this.standardControl6.AnalogValue1 = 0D;
            this.standardControl6.BackColor = System.Drawing.Color.Transparent;
            this.standardControl6.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl6.BlinkColor = System.Drawing.Color.Red;
            this.standardControl6.Category = "1MTR.cat2";
            this.standardControl6.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl6.DebugData"));
            this.standardControl6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl6.Location = new System.Drawing.Point(312, 93);
            this.standardControl6.Name = "standardControl6";
            this.standardControl6.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate180;
            this.standardControl6.Size = new System.Drawing.Size(50, 21);
            this.standardControl6.SymbolHandle = ((long)(1946842866));
            this.standardControl6.TabIndex = 10;
            // 
            // standardControl4
            // 
            this.standardControl4.AnalogIntValue1 = ((short)(0));
            this.standardControl4.AnalogValue1 = 0D;
            this.standardControl4.BackColor = System.Drawing.Color.Transparent;
            this.standardControl4.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl4.BlinkColor = System.Drawing.Color.Red;
            this.standardControl4.Category = "1MTR.cat2";
            this.standardControl4.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl4.DebugData"));
            this.standardControl4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.standardControl4.Location = new System.Drawing.Point(132, 93);
            this.standardControl4.Name = "standardControl4";
            this.standardControl4.Size = new System.Drawing.Size(50, 21);
            this.standardControl4.SymbolHandle = ((long)(1946842866));
            this.standardControl4.TabIndex = 9;
            // 
            // standardControl8
            // 
            this.standardControl8.AnalogIntValue1 = ((short)(0));
            this.standardControl8.AnalogValue1 = 0D;
            this.standardControl8.BackColor = System.Drawing.Color.Transparent;
            this.standardControl8.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl8.BlinkColor = System.Drawing.Color.Red;
            this.standardControl8.Category = "1MTR.cat2";
            this.standardControl8.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl8.DebugData"));
            this.standardControl8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl8.Location = new System.Drawing.Point(38, 93);
            this.standardControl8.Name = "standardControl8";
            this.standardControl8.Size = new System.Drawing.Size(50, 21);
            this.standardControl8.SymbolHandle = ((long)(1946842866));
            this.standardControl8.TabIndex = 8;
            this.standardControl8.Load += new System.EventHandler(this.standardControl8_Load);
            // 
            // standardControl3
            // 
            this.standardControl3.AnalogIntValue1 = ((short)(0));
            this.standardControl3.AnalogValue1 = 0D;
            this.standardControl3.BackColor = System.Drawing.Color.Transparent;
            this.standardControl3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl3.BlinkColor = System.Drawing.Color.Red;
            this.standardControl3.Category = "1MH.cat2";
            this.standardControl3.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl3.DebugData"));
            this.standardControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl3.Location = new System.Drawing.Point(19, 0);
            this.standardControl3.Name = "standardControl3";
            this.standardControl3.Size = new System.Drawing.Size(121, 121);
            this.standardControl3.SymbolHandle = ((long)(1161653739));
            this.standardControl3.TabIndex = 4;
            // 
            // standardControl2
            // 
            this.standardControl2.AnalogIntValue1 = ((short)(0));
            this.standardControl2.AnalogValue1 = 0D;
            this.standardControl2.BackColor = System.Drawing.Color.Transparent;
            this.standardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl2.BlinkColor = System.Drawing.Color.Red;
            this.standardControl2.Category = "1MH.cat2";
            this.standardControl2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl2.DebugData"));
            this.standardControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl2.Location = new System.Drawing.Point(111, 0);
            this.standardControl2.Name = "standardControl2";
            this.standardControl2.Size = new System.Drawing.Size(121, 121);
            this.standardControl2.SymbolHandle = ((long)(1161653739));
            this.standardControl2.TabIndex = 3;
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.BackColor = System.Drawing.Color.Transparent;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl1.BlinkColor = System.Drawing.Color.Red;
            this.standardControl1.Category = "1MH.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl1.Location = new System.Drawing.Point(278, 0);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(121, 121);
            this.standardControl1.SymbolHandle = ((long)(1161653739));
            this.standardControl1.TabIndex = 2;
            // 
            // standardControl5
            // 
            this.standardControl5.AnalogIntValue1 = ((short)(0));
            this.standardControl5.AnalogValue1 = 0D;
            this.standardControl5.BackColor = System.Drawing.Color.Transparent;
            this.standardControl5.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(70D, 70, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkSolid, System.Drawing.Color.Green, "Band3"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(50D, 50, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Yellow, "Band4"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(30D, 30, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band5"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(20D, 20, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band6"));
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band7"));
            this.standardControl5.BlinkColor = System.Drawing.Color.Red;
            this.standardControl5.Category = "1MH.cat2";
            this.standardControl5.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl5.DebugData"));
            this.standardControl5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl5.Location = new System.Drawing.Point(351, 0);
            this.standardControl5.Name = "standardControl5";
            this.standardControl5.Size = new System.Drawing.Size(121, 121);
            this.standardControl5.SymbolHandle = ((long)(1161653739));
            this.standardControl5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblQuyen);
            this.panel7.Location = new System.Drawing.Point(3, 158);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 36);
            this.panel7.TabIndex = 18;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.Lime;
            this.lblQuyen.Location = new System.Drawing.Point(70, 9);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(78, 19);
            this.lblQuyen.TabIndex = 0;
            this.lblQuyen.Text = "   QUYỀN";
            // 
            // SCADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1159, 636);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "SCADA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm sản xuất vữa khô";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SCADA_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox txtAdressPLC;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnTrend;
        private System.Windows.Forms.Button btnWeigh;
        private System.Windows.Forms.Button btnOffSet;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnEStop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private SymbolFactoryDotNet.StandardControl standardControl3;
        private SymbolFactoryDotNet.StandardControl standardControl2;
        private SymbolFactoryDotNet.StandardControl standardControl1;
        private SymbolFactoryDotNet.StandardControl standardControl5;
        private SymbolFactoryDotNet.StandardControl standardControl8;
        private SymbolFactoryDotNet.StandardControl standardControl7;
        private SymbolFactoryDotNet.StandardControl standardControl6;
        private SymbolFactoryDotNet.StandardControl standardControl4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblQuyen;
    }
}