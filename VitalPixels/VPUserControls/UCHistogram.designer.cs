//using System.Windows.Controls;
namespace VitalPixels
{
    partial class UCHistogram
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistogram));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.rMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveChartAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chHsitogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHsitogram)).BeginInit();
            this.SuspendLayout();
            // 
            // rMenu
            // 
            this.rMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChartAsImageToolStripMenuItem,
            this.printHistogramToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backColorToolStripMenuItem});
            this.rMenu.Name = "rMenu";
            this.rMenu.Size = new System.Drawing.Size(217, 76);
            // 
            // saveChartAsImageToolStripMenuItem
            // 
            this.saveChartAsImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveChartAsImageToolStripMenuItem.Image")));
            this.saveChartAsImageToolStripMenuItem.Name = "saveChartAsImageToolStripMenuItem";
            this.saveChartAsImageToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveChartAsImageToolStripMenuItem.Text = "Save Histogram as Image...";
            this.saveChartAsImageToolStripMenuItem.Click += new System.EventHandler(this.SaveChartAsImage);
            // 
            // printHistogramToolStripMenuItem
            // 
            this.printHistogramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printHistogramToolStripMenuItem.Image")));
            this.printHistogramToolStripMenuItem.Name = "printHistogramToolStripMenuItem";
            this.printHistogramToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.printHistogramToolStripMenuItem.Text = "Print Histogram";
            this.printHistogramToolStripMenuItem.Click += new System.EventHandler(this.printHistogramToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backColorToolStripMenuItem.Image")));
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.backColorToolStripMenuItem.Text = "Back Color...";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.ChangBGColor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(26, 277);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(2, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(2, 71);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2);
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 3;
            this.button4.Tag = "BLUE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ShowHideColors);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(2, 48);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2);
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 2;
            this.button3.Tag = "GREEN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ShowHideColors);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(2, 25);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 1;
            this.button2.Tag = "RED";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ShowHideColors);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 0;
            this.button1.Tag = "Histogram";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowHideColors);
            // 
            // chHsitogram
            // 
            this.chHsitogram.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 255D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chHsitogram.ChartAreas.Add(chartArea1);
            this.chHsitogram.ContextMenuStrip = this.rMenu;
            this.chHsitogram.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chHsitogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chHsitogram.Location = new System.Drawing.Point(26, 0);
            this.chHsitogram.Margin = new System.Windows.Forms.Padding(0);
            this.chHsitogram.Name = "chHsitogram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Histogram";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Name = "RED";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Name = "GREEN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Name = "BLUE";
            this.chHsitogram.Series.Add(series1);
            this.chHsitogram.Series.Add(series2);
            this.chHsitogram.Series.Add(series3);
            this.chHsitogram.Series.Add(series4);
            this.chHsitogram.Size = new System.Drawing.Size(725, 277);
            this.chHsitogram.SuppressExceptions = true;
            this.chHsitogram.TabIndex = 3;
            this.chHsitogram.Text = "Histogram";
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            title1.Name = "Title1";
            title1.Text = "Histogram";
            this.chHsitogram.Titles.Add(title1);
            this.chHsitogram.Click += new System.EventHandler(this.chHsitogram_Click);
            // 
            // UCHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chHsitogram);
            this.Controls.Add(this.panel1);
            this.Name = "UCHistogram";
            this.Size = new System.Drawing.Size(751, 277);
            this.Load += new System.EventHandler(this.UCHistogram_Load);
            this.rMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chHsitogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip rMenu;
        private System.Windows.Forms.ToolStripMenuItem saveChartAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem printHistogramToolStripMenuItem;
        public System.Windows.Forms.DataVisualization.Charting.Chart chHsitogram;
    }
}
