namespace VitalPixels
{
    partial class FImageSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImageSource));
            this.splitContainerImages = new System.Windows.Forms.SplitContainer();
            this.panelInput = new System.Windows.Forms.Panel();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.splitterInput = new System.Windows.Forms.Splitter();
            this.panelMainSettingInut = new System.Windows.Forms.Panel();
            this.panelSettingInput = new System.Windows.Forms.Panel();
            this.panelTopInput = new System.Windows.Forms.Panel();
            this.btnInputTypeSetting = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCollapseInput = new System.Windows.Forms.Button();
            this.imageListBtn = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.MenuOutputImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.swapWithSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitterOutput = new System.Windows.Forms.Splitter();
            this.panelMainSettingOutput = new System.Windows.Forms.Panel();
            this.panelSettingOutput = new System.Windows.Forms.Panel();
            this.panelTopOutput = new System.Windows.Forms.Panel();
            this.btnOutputTypeSetting = new System.Windows.Forms.Button();
            this.btnCollapseOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuSettingType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).BeginInit();
            this.splitContainerImages.Panel1.SuspendLayout();
            this.splitContainerImages.Panel2.SuspendLayout();
            this.splitContainerImages.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.panelMainSettingInut.SuspendLayout();
            this.panelTopInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.MenuOutputImage.SuspendLayout();
            this.panelMainSettingOutput.SuspendLayout();
            this.panelTopOutput.SuspendLayout();
            this.MenuSettingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerImages
            // 
            this.splitContainerImages.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImages.Name = "splitContainerImages";
            // 
            // splitContainerImages.Panel1
            // 
            this.splitContainerImages.Panel1.AutoScroll = true;
            this.splitContainerImages.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitContainerImages.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainerImages.Panel1.Controls.Add(this.panelInput);
            this.splitContainerImages.Panel1.Controls.Add(this.splitterInput);
            this.splitContainerImages.Panel1.Controls.Add(this.panelMainSettingInut);
            this.splitContainerImages.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // splitContainerImages.Panel2
            // 
            this.splitContainerImages.Panel2.AutoScroll = true;
            this.splitContainerImages.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainerImages.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainerImages.Panel2.Controls.Add(this.panelOutput);
            this.splitContainerImages.Panel2.Controls.Add(this.splitterOutput);
            this.splitContainerImages.Panel2.Controls.Add(this.panelMainSettingOutput);
            this.splitContainerImages.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainerImages.Size = new System.Drawing.Size(808, 623);
            this.splitContainerImages.SplitterDistance = 364;
            this.splitContainerImages.TabIndex = 0;
            this.splitContainerImages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainerImages_MouseDoubleClick);
            // 
            // panelInput
            // 
            this.panelInput.AutoScroll = true;
            this.panelInput.AutoSize = true;
            this.panelInput.BackColor = System.Drawing.Color.DimGray;
            this.panelInput.Controls.Add(this.pbInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(364, 543);
            this.panelInput.TabIndex = 3;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // pbInput
            // 
            this.pbInput.BackColor = System.Drawing.SystemColors.Control;
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbInput.Location = new System.Drawing.Point(57, 139);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(277, 277);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInput.TabIndex = 1;
            this.pbInput.TabStop = false;
            this.pbInput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbInput_Paint);
            this.pbInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbInput_MouseDown);
            this.pbInput.MouseLeave += new System.EventHandler(this.pbInput_MouseLeave);
            this.pbInput.MouseHover += new System.EventHandler(this.pbInput_MouseHover);
            this.pbInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbInput_MouseMove);
            this.pbInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbInput_MouseUp);
            // 
            // splitterInput
            // 
            this.splitterInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterInput.Location = new System.Drawing.Point(0, 543);
            this.splitterInput.Name = "splitterInput";
            this.splitterInput.Size = new System.Drawing.Size(364, 3);
            this.splitterInput.TabIndex = 2;
            this.splitterInput.TabStop = false;
            this.splitterInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitterInput_MouseDoubleClick);
            // 
            // panelMainSettingInut
            // 
            this.panelMainSettingInut.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainSettingInut.Controls.Add(this.panelSettingInput);
            this.panelMainSettingInut.Controls.Add(this.panelTopInput);
            this.panelMainSettingInut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainSettingInut.Location = new System.Drawing.Point(0, 546);
            this.panelMainSettingInut.Name = "panelMainSettingInut";
            this.panelMainSettingInut.Size = new System.Drawing.Size(364, 77);
            this.panelMainSettingInut.TabIndex = 1;
            // 
            // panelSettingInput
            // 
            this.panelSettingInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingInput.Location = new System.Drawing.Point(0, 27);
            this.panelSettingInput.Margin = new System.Windows.Forms.Padding(5);
            this.panelSettingInput.Name = "panelSettingInput";
            this.panelSettingInput.Size = new System.Drawing.Size(364, 50);
            this.panelSettingInput.TabIndex = 3;
            this.panelSettingInput.Resize += new System.EventHandler(this.panelSettingInput_Resize);
            // 
            // panelTopInput
            // 
            this.panelTopInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTopInput.Controls.Add(this.btnInputTypeSetting);
            this.panelTopInput.Controls.Add(this.btnRefresh);
            this.panelTopInput.Controls.Add(this.btnCollapseInput);
            this.panelTopInput.Controls.Add(this.label1);
            this.panelTopInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopInput.Location = new System.Drawing.Point(0, 0);
            this.panelTopInput.Name = "panelTopInput";
            this.panelTopInput.Padding = new System.Windows.Forms.Padding(2);
            this.panelTopInput.Size = new System.Drawing.Size(364, 27);
            this.panelTopInput.TabIndex = 2;
            // 
            // btnInputTypeSetting
            // 
            this.btnInputTypeSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputTypeSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInputTypeSetting.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnInputTypeSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputTypeSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInputTypeSetting.Location = new System.Drawing.Point(212, 2);
            this.btnInputTypeSetting.Name = "btnInputTypeSetting";
            this.btnInputTypeSetting.Size = new System.Drawing.Size(105, 23);
            this.btnInputTypeSetting.TabIndex = 6;
            this.btnInputTypeSetting.TabStop = false;
            this.btnInputTypeSetting.Text = "Zoom Settings";
            this.btnInputTypeSetting.UseVisualStyleBackColor = true;
            this.btnInputTypeSetting.Click += new System.EventHandler(this.ChooseTypeInput_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(317, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnCollapseInput
            // 
            this.btnCollapseInput.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapseInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapseInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCollapseInput.FlatAppearance.BorderSize = 0;
            this.btnCollapseInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapseInput.ImageIndex = 0;
            this.btnCollapseInput.ImageList = this.imageListBtn;
            this.btnCollapseInput.Location = new System.Drawing.Point(342, 2);
            this.btnCollapseInput.Name = "btnCollapseInput";
            this.btnCollapseInput.Size = new System.Drawing.Size(20, 23);
            this.btnCollapseInput.TabIndex = 3;
            this.btnCollapseInput.TabStop = false;
            this.btnCollapseInput.UseVisualStyleBackColor = false;
            this.btnCollapseInput.Click += new System.EventHandler(this.Collapse_Click);
            // 
            // imageListBtn
            // 
            this.imageListBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtn.ImageStream")));
            this.imageListBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtn.Images.SetKeyName(0, "r6OD6.png");
            this.imageListBtn.Images.SetKeyName(1, "1WdEk.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Image ";
            // 
            // panelOutput
            // 
            this.panelOutput.AutoScroll = true;
            this.panelOutput.Controls.Add(this.pbOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 0);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(440, 543);
            this.panelOutput.TabIndex = 3;
            this.panelOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOutput_Paint);
            this.panelOutput.MouseLeave += new System.EventHandler(this.panelOutput_MouseLeave);
            // 
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.Color.White;
            this.pbOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOutput.BackgroundImage")));
            this.pbOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.ContextMenuStrip = this.MenuOutputImage;
            this.pbOutput.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbOutput.Location = new System.Drawing.Point(75, 139);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(277, 277);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            this.pbOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOutput_Paint);
            this.pbOutput.MouseLeave += new System.EventHandler(this.pbInput_MouseLeave);
            this.pbOutput.MouseHover += new System.EventHandler(this.pbOutput_MouseHover);
            this.pbOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseMove);
            this.pbOutput.Move += new System.EventHandler(this.pbOutput_Move);
            // 
            // MenuOutputImage
            // 
            this.MenuOutputImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveImageAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.swapWithSourceToolStripMenuItem});
            this.MenuOutputImage.Name = "MenuOutputImage";
            this.MenuOutputImage.Size = new System.Drawing.Size(170, 82);
            this.MenuOutputImage.Opening += new System.ComponentModel.CancelEventHandler(this.MenuOutputImage_Opening);
            // 
            // copyImageToolStripMenuItem
            // 
            this.copyImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyImageToolStripMenuItem.Image")));
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            this.copyImageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyImageToolStripMenuItem.Text = "Copy Image";
            this.copyImageToolStripMenuItem.Click += new System.EventHandler(this.copyImageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveImageAsToolStripMenuItem.Image")));
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save image as...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.SaveImageAs);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // swapWithSourceToolStripMenuItem
            // 
            this.swapWithSourceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("swapWithSourceToolStripMenuItem.Image")));
            this.swapWithSourceToolStripMenuItem.Name = "swapWithSourceToolStripMenuItem";
            this.swapWithSourceToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.swapWithSourceToolStripMenuItem.Text = "Chage as an input";
            this.swapWithSourceToolStripMenuItem.Click += new System.EventHandler(this.swapWithSourceToolStripMenuItem_Click);
            // 
            // splitterOutput
            // 
            this.splitterOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterOutput.Location = new System.Drawing.Point(0, 543);
            this.splitterOutput.Name = "splitterOutput";
            this.splitterOutput.Size = new System.Drawing.Size(440, 3);
            this.splitterOutput.TabIndex = 2;
            this.splitterOutput.TabStop = false;
            this.splitterOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitterOutput_MouseDoubleClick);
            // 
            // panelMainSettingOutput
            // 
            this.panelMainSettingOutput.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainSettingOutput.Controls.Add(this.panelSettingOutput);
            this.panelMainSettingOutput.Controls.Add(this.panelTopOutput);
            this.panelMainSettingOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainSettingOutput.Location = new System.Drawing.Point(0, 546);
            this.panelMainSettingOutput.Name = "panelMainSettingOutput";
            this.panelMainSettingOutput.Size = new System.Drawing.Size(440, 77);
            this.panelMainSettingOutput.TabIndex = 1;
            // 
            // panelSettingOutput
            // 
            this.panelSettingOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingOutput.Location = new System.Drawing.Point(0, 27);
            this.panelSettingOutput.Name = "panelSettingOutput";
            this.panelSettingOutput.Size = new System.Drawing.Size(440, 50);
            this.panelSettingOutput.TabIndex = 6;
            this.panelSettingOutput.Resize += new System.EventHandler(this.panelSettingInput_Resize);
            // 
            // panelTopOutput
            // 
            this.panelTopOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTopOutput.Controls.Add(this.btnOutputTypeSetting);
            this.panelTopOutput.Controls.Add(this.btnCollapseOutput);
            this.panelTopOutput.Controls.Add(this.label2);
            this.panelTopOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOutput.Location = new System.Drawing.Point(0, 0);
            this.panelTopOutput.Name = "panelTopOutput";
            this.panelTopOutput.Padding = new System.Windows.Forms.Padding(2);
            this.panelTopOutput.Size = new System.Drawing.Size(440, 27);
            this.panelTopOutput.TabIndex = 5;
            // 
            // btnOutputTypeSetting
            // 
            this.btnOutputTypeSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutputTypeSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutputTypeSetting.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnOutputTypeSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputTypeSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOutputTypeSetting.Location = new System.Drawing.Point(306, 2);
            this.btnOutputTypeSetting.Name = "btnOutputTypeSetting";
            this.btnOutputTypeSetting.Size = new System.Drawing.Size(105, 23);
            this.btnOutputTypeSetting.TabIndex = 4;
            this.btnOutputTypeSetting.TabStop = false;
            this.btnOutputTypeSetting.Text = "Zoom Settings";
            this.btnOutputTypeSetting.UseVisualStyleBackColor = true;
            this.btnOutputTypeSetting.Click += new System.EventHandler(this.ChooseTypeOutput_Click);
            // 
            // btnCollapseOutput
            // 
            this.btnCollapseOutput.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapseOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapseOutput.FlatAppearance.BorderSize = 0;
            this.btnCollapseOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapseOutput.ImageIndex = 0;
            this.btnCollapseOutput.ImageList = this.imageListBtn;
            this.btnCollapseOutput.Location = new System.Drawing.Point(411, 2);
            this.btnCollapseOutput.Name = "btnCollapseOutput";
            this.btnCollapseOutput.Size = new System.Drawing.Size(27, 23);
            this.btnCollapseOutput.TabIndex = 3;
            this.btnCollapseOutput.TabStop = false;
            this.btnCollapseOutput.UseVisualStyleBackColor = false;
            this.btnCollapseOutput.Click += new System.EventHandler(this.CollapseOutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Image ";
            // 
            // MenuSettingType
            // 
            this.MenuSettingType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.MenuSettingType.Name = "MenuSettingType";
            this.MenuSettingType.Size = new System.Drawing.Size(131, 70);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomToolStripMenuItem.Image")));
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.ZoomSettingShow);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("histogramToolStripMenuItem.Image")));
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.HistogramSettingsShow);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorsToolStripMenuItem.Image")));
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // FImageSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.splitContainerImages);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FImageSource";
            this.Tag = "Image";
            this.Text = "Filename";
            this.Activated += new System.EventHandler(this.FImageSource_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FImageSource_FormClosing);
            this.Load += new System.EventHandler(this.FImageSource_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FImageSource_Paint);
            this.splitContainerImages.Panel1.ResumeLayout(false);
            this.splitContainerImages.Panel1.PerformLayout();
            this.splitContainerImages.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImages)).EndInit();
            this.splitContainerImages.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.panelMainSettingInut.ResumeLayout(false);
            this.panelTopInput.ResumeLayout(false);
            this.panelTopInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.MenuOutputImage.ResumeLayout(false);
            this.panelMainSettingOutput.ResumeLayout(false);
            this.panelTopOutput.ResumeLayout(false);
            this.panelTopOutput.PerformLayout();
            this.MenuSettingType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainSettingInut;
        private System.Windows.Forms.Panel panelMainSettingOutput;
        private System.Windows.Forms.Splitter splitterInput;
        private System.Windows.Forms.Splitter splitterOutput;
        public System.Windows.Forms.PictureBox pbInput;
        public System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.ContextMenuStrip MenuSettingType;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelTopInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSettingInput;
        private System.Windows.Forms.Button btnCollapseInput;
        private System.Windows.Forms.Panel panelSettingOutput;
        private System.Windows.Forms.Panel panelTopOutput;
        private System.Windows.Forms.Button btnOutputTypeSetting;
        private System.Windows.Forms.Button btnCollapseOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInputTypeSetting;
        private System.Windows.Forms.ImageList imageListBtn;
        internal System.Windows.Forms.SplitContainer splitContainerImages;
        private System.Windows.Forms.ContextMenuStrip MenuOutputImage;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem swapWithSourceToolStripMenuItem;
        public System.Windows.Forms.Panel panelInput;
        public System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyImageToolStripMenuItem;



    }
}