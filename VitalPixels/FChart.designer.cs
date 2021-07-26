namespace VitalPixels
{
    partial class FChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPSNR = new System.Windows.Forms.CheckBox();
            this.chOutput = new System.Windows.Forms.CheckBox();
            this.cnSNR = new System.Windows.Forms.CheckBox();
            this.chColors = new System.Windows.Forms.CheckBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.numInc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbParameters = new System.Windows.Forms.ComboBox();
            this.Parameter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMajorY = new System.Windows.Forms.CheckBox();
            this.cbMajorx = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnSaveChart = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.cbPlugin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChangeImage = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Xchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipTrend = new System.Windows.Forms.ToolTip(this.components);
            this.bwDrawChart = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xchart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.grpData);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnImages);
            this.panel1.Controls.Add(this.btnSaveChart);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Controls.Add(this.cbPlugin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbChangeImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 853);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPSNR);
            this.groupBox3.Controls.Add(this.chOutput);
            this.groupBox3.Controls.Add(this.cnSNR);
            this.groupBox3.Controls.Add(this.chColors);
            this.groupBox3.Location = new System.Drawing.Point(8, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 111);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart Series";
            // 
            // cbPSNR
            // 
            this.cbPSNR.AutoSize = true;
            this.cbPSNR.Location = new System.Drawing.Point(5, 42);
            this.cbPSNR.Name = "cbPSNR";
            this.cbPSNR.Size = new System.Drawing.Size(56, 17);
            this.cbPSNR.TabIndex = 14;
            this.cbPSNR.Text = "PSNR";
            this.cbPSNR.UseVisualStyleBackColor = true;
            this.cbPSNR.CheckedChanged += new System.EventHandler(this.cnSNR_CheckedChanged);
            // 
            // chOutput
            // 
            this.chOutput.AutoSize = true;
            this.chOutput.Location = new System.Drawing.Point(6, 88);
            this.chOutput.Name = "chOutput";
            this.chOutput.Size = new System.Drawing.Size(58, 17);
            this.chOutput.TabIndex = 26;
            this.chOutput.Text = "Output";
            this.chOutput.UseVisualStyleBackColor = true;
            this.chOutput.CheckedChanged += new System.EventHandler(this.cnSNR_CheckedChanged);
            // 
            // cnSNR
            // 
            this.cnSNR.AutoSize = true;
            this.cnSNR.Location = new System.Drawing.Point(5, 19);
            this.cnSNR.Name = "cnSNR";
            this.cnSNR.Size = new System.Drawing.Size(49, 17);
            this.cnSNR.TabIndex = 13;
            this.cnSNR.Text = "SNR";
            this.cnSNR.UseVisualStyleBackColor = true;
            this.cnSNR.CheckedChanged += new System.EventHandler(this.cnSNR_CheckedChanged);
            // 
            // chColors
            // 
            this.chColors.AutoSize = true;
            this.chColors.Location = new System.Drawing.Point(5, 65);
            this.chColors.Name = "chColors";
            this.chColors.Size = new System.Drawing.Size(55, 17);
            this.chColors.TabIndex = 25;
            this.chColors.Text = "Colors";
            this.chColors.UseVisualStyleBackColor = true;
            this.chColors.CheckedChanged += new System.EventHandler(this.cnSNR_CheckedChanged);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.numInc);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.cbParameters);
            this.grpData.Controls.Add(this.Parameter);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.numTo);
            this.grpData.Controls.Add(this.numFrom);
            this.grpData.Location = new System.Drawing.Point(8, 154);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(179, 193);
            this.grpData.TabIndex = 5;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data Settings";
            // 
            // numInc
            // 
            this.numInc.DecimalPlaces = 1;
            this.numInc.Location = new System.Drawing.Point(15, 155);
            this.numInc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInc.Name = "numInc";
            this.numInc.Size = new System.Drawing.Size(57, 20);
            this.numInc.TabIndex = 28;
            this.numInc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Increament";
            // 
            // cbParameters
            // 
            this.cbParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParameters.FormattingEnabled = true;
            this.cbParameters.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbParameters.Location = new System.Drawing.Point(66, 28);
            this.cbParameters.Name = "cbParameters";
            this.cbParameters.Size = new System.Drawing.Size(107, 21);
            this.cbParameters.TabIndex = 24;
            // 
            // Parameter
            // 
            this.Parameter.AutoSize = true;
            this.Parameter.Location = new System.Drawing.Point(6, 31);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(55, 13);
            this.Parameter.TabIndex = 23;
            this.Parameter.Text = "Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "from";
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(15, 114);
            this.numTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(57, 20);
            this.numTo.TabIndex = 2;
            this.numTo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(15, 75);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(57, 20);
            this.numFrom.TabIndex = 1;
            this.numFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMajorY);
            this.groupBox2.Controls.Add(this.cbMajorx);
            this.groupBox2.Location = new System.Drawing.Point(5, 533);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart Setting";
            // 
            // cbMajorY
            // 
            this.cbMajorY.AutoSize = true;
            this.cbMajorY.Checked = true;
            this.cbMajorY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMajorY.Location = new System.Drawing.Point(8, 51);
            this.cbMajorY.Name = "cbMajorY";
            this.cbMajorY.Size = new System.Drawing.Size(114, 17);
            this.cbMajorY.TabIndex = 1;
            this.cbMajorY.Text = "Show Major Y Grid";
            this.cbMajorY.UseVisualStyleBackColor = true;
            this.cbMajorY.CheckedChanged += new System.EventHandler(this.cbMajorY_CheckedChanged);
            // 
            // cbMajorx
            // 
            this.cbMajorx.AutoSize = true;
            this.cbMajorx.Checked = true;
            this.cbMajorx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMajorx.Location = new System.Drawing.Point(8, 23);
            this.cbMajorx.Name = "cbMajorx";
            this.cbMajorx.Size = new System.Drawing.Size(114, 17);
            this.cbMajorx.TabIndex = 0;
            this.cbMajorx.Text = "Show Major X Grid";
            this.cbMajorx.UseVisualStyleBackColor = true;
            this.cbMajorx.CheckedChanged += new System.EventHandler(this.cbMajorx_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(5, 80);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 27);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Chart...";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnImages
            // 
            this.btnImages.Enabled = false;
            this.btnImages.Location = new System.Drawing.Point(19, 375);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(147, 23);
            this.btnImages.TabIndex = 11;
            this.btnImages.Text = "Select images..";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // btnSaveChart
            // 
            this.btnSaveChart.Enabled = false;
            this.btnSaveChart.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChart.Image")));
            this.btnSaveChart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChart.Location = new System.Drawing.Point(5, 46);
            this.btnSaveChart.Name = "btnSaveChart";
            this.btnSaveChart.Size = new System.Drawing.Size(181, 27);
            this.btnSaveChart.TabIndex = 7;
            this.btnSaveChart.Text = "Save Chart...";
            this.btnSaveChart.UseVisualStyleBackColor = true;
            this.btnSaveChart.Click += new System.EventHandler(this.btnSaveChart_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDraw.Image")));
            this.btnDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDraw.Location = new System.Drawing.Point(5, 11);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(181, 27);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw Chart";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 659);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(192, 192);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // cbPlugin
            // 
            this.cbPlugin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlugin.FormattingEnabled = true;
            this.cbPlugin.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbPlugin.Location = new System.Drawing.Point(44, 121);
            this.cbPlugin.Name = "cbPlugin";
            this.cbPlugin.Size = new System.Drawing.Size(142, 21);
            this.cbPlugin.TabIndex = 22;
            this.cbPlugin.SelectedIndexChanged += new System.EventHandler(this.cbPlugin_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Plugin";
            // 
            // cbChangeImage
            // 
            this.cbChangeImage.AutoSize = true;
            this.cbChangeImage.Location = new System.Drawing.Point(17, 353);
            this.cbChangeImage.Name = "cbChangeImage";
            this.cbChangeImage.Size = new System.Drawing.Size(95, 17);
            this.cbChangeImage.TabIndex = 10;
            this.cbChangeImage.Text = "Change Image";
            this.cbChangeImage.UseVisualStyleBackColor = true;
            this.cbChangeImage.CheckedChanged += new System.EventHandler(this.cbChangeImage_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Xchart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 853);
            this.panel2.TabIndex = 1;
            // 
            // Xchart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Xchart.ChartAreas.Add(chartArea1);
            this.Xchart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Xchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Xchart.Legends.Add(legend1);
            this.Xchart.Location = new System.Drawing.Point(0, 0);
            this.Xchart.Name = "Xchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "VPCHART";
            this.Xchart.Series.Add(series1);
            this.Xchart.Size = new System.Drawing.Size(526, 853);
            this.Xchart.TabIndex = 0;
            this.Xchart.Text = "chartMain";
            this.Xchart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Xchart_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(194, 831);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Values";
            // 
            // toolTipTrend
            // 
            this.toolTipTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolTipTrend.IsBalloon = true;
            // 
            // FChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 853);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FChart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis of compression";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FChart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Xchart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Xchart;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.CheckBox cbChangeImage;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.CheckBox cbPSNR;
        private System.Windows.Forms.CheckBox cnSNR;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnSaveChart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMajorY;
        private System.Windows.Forms.CheckBox cbMajorx;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTipTrend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlugin;
        private System.Windows.Forms.CheckBox chColors;
        private System.Windows.Forms.ComboBox cbParameters;
        private System.Windows.Forms.Label Parameter;
        private System.Windows.Forms.CheckBox chOutput;
        private System.Windows.Forms.NumericUpDown numInc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker bwDrawChart;
    }
}