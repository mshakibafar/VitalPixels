namespace VitalPixels
{
    partial class FColorLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FColorLab));
            System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation verticalLineAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.VerticalLineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbColor2B = new System.Windows.Forms.TextBox();
            this.tbColor2G = new System.Windows.Forms.TextBox();
            this.tbColor2R = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbColor2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbColor1B = new System.Windows.Forms.TextBox();
            this.tbColor1G = new System.Windows.Forms.TextBox();
            this.tbColor1R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbColor1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMinMax = new System.Windows.Forms.Label();
            this.labelgreen = new System.Windows.Forms.Label();
            this.labelblue = new System.Windows.Forms.Label();
            this.labelred = new System.Windows.Forms.Label();
            this.labeldif = new System.Windows.Forms.Label();
            this.labelXY = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chHsitogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStandard = new System.Windows.Forms.Label();
            this.cbStandard = new System.Windows.Forms.ComboBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHsitogram)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.panelColor2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.panelColor1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbColor2B);
            this.groupBox1.Controls.Add(this.tbColor2G);
            this.groupBox1.Controls.Add(this.tbColor2R);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbColor2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbColor1B);
            this.groupBox1.Controls.Add(this.tbColor1G);
            this.groupBox1.Controls.Add(this.tbColor1R);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbColor1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Inc RGB";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddRGBBut);
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Black;
            this.panelColor2.Location = new System.Drawing.Point(7, 204);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(274, 69);
            this.panelColor2.TabIndex = 13;
            this.panelColor2.BackColorChanged += new System.EventHandler(this.panelColor1_BackColorChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add 10000";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddTolerance);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Same";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SameButton);
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.Black;
            this.panelColor1.Location = new System.Drawing.Point(7, 62);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(274, 69);
            this.panelColor1.TabIndex = 12;
            this.panelColor1.BackColorChanged += new System.EventHandler(this.panelColor1_BackColorChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(258, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenColorDialogforColor2);
            // 
            // tbColor2B
            // 
            this.tbColor2B.Location = new System.Drawing.Point(217, 170);
            this.tbColor2B.MaxLength = 3;
            this.tbColor2B.Name = "tbColor2B";
            this.tbColor2B.Size = new System.Drawing.Size(37, 20);
            this.tbColor2B.TabIndex = 10;
            this.tbColor2B.Text = "0";
            this.tbColor2B.TextChanged += new System.EventHandler(this.tbColor2B_TextChanged);
            this.tbColor2B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // tbColor2G
            // 
            this.tbColor2G.Location = new System.Drawing.Point(174, 170);
            this.tbColor2G.MaxLength = 3;
            this.tbColor2G.Name = "tbColor2G";
            this.tbColor2G.Size = new System.Drawing.Size(37, 20);
            this.tbColor2G.TabIndex = 9;
            this.tbColor2G.Text = "0";
            this.tbColor2G.TextChanged += new System.EventHandler(this.tbColor2B_TextChanged);
            this.tbColor2G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // tbColor2R
            // 
            this.tbColor2R.Location = new System.Drawing.Point(131, 170);
            this.tbColor2R.MaxLength = 3;
            this.tbColor2R.Name = "tbColor2R";
            this.tbColor2R.Size = new System.Drawing.Size(37, 20);
            this.tbColor2R.TabIndex = 8;
            this.tbColor2R.Text = "0";
            this.tbColor2R.TextChanged += new System.EventHandler(this.tbColor2B_TextChanged);
            this.tbColor2R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color 2";
            // 
            // tbColor2
            // 
            this.tbColor2.Location = new System.Drawing.Point(8, 170);
            this.tbColor2.Name = "tbColor2";
            this.tbColor2.Size = new System.Drawing.Size(117, 20);
            this.tbColor2.TabIndex = 6;
            this.tbColor2.Text = "0";
            this.tbColor2.TextChanged += new System.EventHandler(this.tbColor2_TextChanged);
            this.tbColor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(258, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenColorDialgforColor1);
            // 
            // tbColor1B
            // 
            this.tbColor1B.Location = new System.Drawing.Point(216, 32);
            this.tbColor1B.MaxLength = 3;
            this.tbColor1B.Name = "tbColor1B";
            this.tbColor1B.Size = new System.Drawing.Size(37, 20);
            this.tbColor1B.TabIndex = 4;
            this.tbColor1B.Text = "0";
            this.tbColor1B.TextChanged += new System.EventHandler(this.tbColor1B_TextChanged);
            this.tbColor1B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // tbColor1G
            // 
            this.tbColor1G.Location = new System.Drawing.Point(173, 32);
            this.tbColor1G.MaxLength = 3;
            this.tbColor1G.Name = "tbColor1G";
            this.tbColor1G.Size = new System.Drawing.Size(37, 20);
            this.tbColor1G.TabIndex = 3;
            this.tbColor1G.Text = "0";
            this.tbColor1G.TextChanged += new System.EventHandler(this.tbColor1B_TextChanged);
            this.tbColor1G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // tbColor1R
            // 
            this.tbColor1R.Location = new System.Drawing.Point(130, 32);
            this.tbColor1R.MaxLength = 3;
            this.tbColor1R.Name = "tbColor1R";
            this.tbColor1R.Size = new System.Drawing.Size(37, 20);
            this.tbColor1R.TabIndex = 0;
            this.tbColor1R.Text = "0";
            this.tbColor1R.TextChanged += new System.EventHandler(this.tbColor1B_TextChanged);
            this.tbColor1R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color 1";
            // 
            // tbColor1
            // 
            this.tbColor1.Location = new System.Drawing.Point(7, 32);
            this.tbColor1.Name = "tbColor1";
            this.tbColor1.Size = new System.Drawing.Size(117, 20);
            this.tbColor1.TabIndex = 4;
            this.tbColor1.Text = "0";
            this.tbColor1.TextChanged += new System.EventHandler(this.tbColor1_TextChanged);
            this.tbColor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyKeys);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(309, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 389);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPer);
            this.groupBox2.Controls.Add(this.cbStandard);
            this.groupBox2.Controls.Add(this.lblStandard);
            this.groupBox2.Controls.Add(this.lbMinMax);
            this.groupBox2.Controls.Add(this.labelgreen);
            this.groupBox2.Controls.Add(this.labelblue);
            this.groupBox2.Controls.Add(this.labelred);
            this.groupBox2.Controls.Add(this.labeldif);
            this.groupBox2.Location = new System.Drawing.Point(12, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compare Colors";
            // 
            // lbMinMax
            // 
            this.lbMinMax.AutoSize = true;
            this.lbMinMax.Location = new System.Drawing.Point(6, 57);
            this.lbMinMax.Name = "lbMinMax";
            this.lbMinMax.Size = new System.Drawing.Size(56, 13);
            this.lbMinMax.TabIndex = 4;
            this.lbMinMax.Text = "MAX-MIN:";
            // 
            // labelgreen
            // 
            this.labelgreen.AutoSize = true;
            this.labelgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelgreen.ForeColor = System.Drawing.Color.Green;
            this.labelgreen.Location = new System.Drawing.Point(308, 42);
            this.labelgreen.Name = "labelgreen";
            this.labelgreen.Size = new System.Drawing.Size(41, 13);
            this.labelgreen.TabIndex = 3;
            this.labelgreen.Text = "Green";
            // 
            // labelblue
            // 
            this.labelblue.AutoSize = true;
            this.labelblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelblue.ForeColor = System.Drawing.Color.Blue;
            this.labelblue.Location = new System.Drawing.Point(308, 69);
            this.labelblue.Name = "labelblue";
            this.labelblue.Size = new System.Drawing.Size(36, 13);
            this.labelblue.TabIndex = 2;
            this.labelblue.Text = "Blue:";
            // 
            // labelred
            // 
            this.labelred.AutoSize = true;
            this.labelred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelred.ForeColor = System.Drawing.Color.Red;
            this.labelred.Location = new System.Drawing.Point(308, 16);
            this.labelred.Name = "labelred";
            this.labelred.Size = new System.Drawing.Size(34, 13);
            this.labelred.TabIndex = 1;
            this.labelred.Text = "Red:";
            // 
            // labeldif
            // 
            this.labeldif.AutoSize = true;
            this.labeldif.Location = new System.Drawing.Point(5, 28);
            this.labeldif.Name = "labeldif";
            this.labeldif.Size = new System.Drawing.Size(67, 13);
            this.labeldif.TabIndex = 0;
            this.labeldif.Text = "Differences :";
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(455, 6);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(39, 13);
            this.labelXY.TabIndex = 5;
            this.labelXY.Text = "lablexy";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pbTest);
            this.panel2.Location = new System.Drawing.Point(455, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 520);
            this.panel2.TabIndex = 6;
            // 
            // pbTest
            // 
            this.pbTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTest.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbTest.Location = new System.Drawing.Point(-2, 0);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(512, 512);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTest.TabIndex = 5;
            this.pbTest.TabStop = false;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            this.pbTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTest_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(979, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(661, 17);
            this.StatusLabel.Text = "Move mouse on picture to select the color/Click to choose second color/Keep middl" +
    "e click to choose color in horizontal line";
            // 
            // chHsitogram
            // 
            verticalLineAnnotation4.EndCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            verticalLineAnnotation4.LineColor = System.Drawing.Color.Red;
            verticalLineAnnotation4.LineWidth = 2;
            verticalLineAnnotation4.Name = "LINEVER";
            verticalLineAnnotation4.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            verticalLineAnnotation4.X = 2D;
            verticalLineAnnotation4.Y = 0D;
            this.chHsitogram.Annotations.Add(verticalLineAnnotation4);
            this.chHsitogram.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Interval = 1D;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.MajorGrid.Interval = 0D;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea4.BorderColor = System.Drawing.Color.Gray;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chHsitogram.ChartAreas.Add(chartArea4);
            this.chHsitogram.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chHsitogram.Location = new System.Drawing.Point(0, 539);
            this.chHsitogram.Margin = new System.Windows.Forms.Padding(0);
            this.chHsitogram.Name = "chHsitogram";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series13.Name = "Histogram";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series14.Name = "RED";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series15.Name = "GREEN";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series16.Name = "BLUE";
            this.chHsitogram.Series.Add(series13);
            this.chHsitogram.Series.Add(series14);
            this.chHsitogram.Series.Add(series15);
            this.chHsitogram.Series.Add(series16);
            this.chHsitogram.Size = new System.Drawing.Size(970, 131);
            this.chHsitogram.SuppressExceptions = true;
            this.chHsitogram.TabIndex = 8;
            this.chHsitogram.Text = "Histogram";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            title4.DockedToChartArea = "ChartArea1";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Red;
            title4.Name = "Tolerance";
            title4.Text = "0";
            title4.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chHsitogram.Titles.Add(title4);
            this.chHsitogram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chHsitogram_MouseDown);
            this.chHsitogram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chHsitogram_MouseMove);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(8, 88);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(98, 13);
            this.lblStandard.TabIndex = 5;
            this.lblStandard.Text = "Standard for YCbCr";
            this.lblStandard.Visible = false;
            // 
            // cbStandard
            // 
            this.cbStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStandard.FormattingEnabled = true;
            this.cbStandard.Items.AddRange(new object[] {
            "ITU601 / ITU-T 709 1250/50/2:1",
            "ITU709 / ITU-T 709 1250/60/2:1",
            "SMPTE 240M (1999)"});
            this.cbStandard.Location = new System.Drawing.Point(112, 85);
            this.cbStandard.Name = "cbStandard";
            this.cbStandard.Size = new System.Drawing.Size(177, 21);
            this.cbStandard.TabIndex = 6;
            this.cbStandard.Visible = false;
            this.cbStandard.SelectedIndexChanged += new System.EventHandler(this.cbStandard_SelectedIndexChanged);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPer.ForeColor = System.Drawing.Color.Black;
            this.lblPer.Location = new System.Drawing.Point(309, 92);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(66, 13);
            this.lblPer.TabIndex = 7;
            this.lblPer.Text = "Brightness";
            this.lblPer.Visible = false;
            // 
            // FColorLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 692);
            this.Controls.Add(this.chHsitogram);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelXY);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FColorLab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Lab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHsitogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbColor2B;
        private System.Windows.Forms.TextBox tbColor2G;
        private System.Windows.Forms.TextBox tbColor2R;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbColor2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbColor1B;
        private System.Windows.Forms.TextBox tbColor1G;
        private System.Windows.Forms.TextBox tbColor1R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbColor1;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labeldif;
        private System.Windows.Forms.Label labelgreen;
        private System.Windows.Forms.Label labelblue;
        private System.Windows.Forms.Label labelred;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHsitogram;
        private System.Windows.Forms.Label lbMinMax;
        private System.Windows.Forms.ComboBox cbStandard;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblPer;
    }
}