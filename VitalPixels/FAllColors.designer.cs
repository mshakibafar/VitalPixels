namespace VitalPixels
{
    partial class FAllColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAllColors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.contextMenuStripmage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbColors = new System.Windows.Forms.PictureBox();
            this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortColorsByRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortColorsByGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortColorsByBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortColorsByHueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortColorsByBrightmessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortColorsBySatuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.savePalleteAsAnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPaletteToExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelShowColor = new System.Windows.Forms.Panel();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.lblCntColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTipShowColor = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.contextMenuStripmage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColors)).BeginInit();
            this.contextMenuStripGrid.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.panelShowColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbTest);
            this.panel1.Location = new System.Drawing.Point(303, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 6;
            // 
            // pbTest
            // 
            this.pbTest.BackColor = System.Drawing.Color.Black;
            this.pbTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTest.ContextMenuStrip = this.contextMenuStripmage;
            this.pbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTest.Location = new System.Drawing.Point(0, 0);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(512, 512);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTest.TabIndex = 1;
            this.pbTest.TabStop = false;
            // 
            // contextMenuStripmage
            // 
            this.contextMenuStripmage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveImageAsToolStripMenuItem});
            this.contextMenuStripmage.Name = "contextMenuStripmage";
            this.contextMenuStripmage.Size = new System.Drawing.Size(161, 54);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveImageAsToolStripMenuItem.Image")));
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save Image as ...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(821, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 42);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(9, 1);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 13);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Count:0";
            // 
            // pbColors
            // 
            this.pbColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColors.ContextMenuStrip = this.contextMenuStripGrid;
            this.pbColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColors.Location = new System.Drawing.Point(0, 0);
            this.pbColors.Name = "pbColors";
            this.pbColors.Size = new System.Drawing.Size(180, 217);
            this.pbColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbColors.TabIndex = 12;
            this.pbColors.TabStop = false;
            this.pbColors.Click += new System.EventHandler(this.pbColors_Click);
            this.pbColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbColors_MouseMove);
            // 
            // contextMenuStripGrid
            // 
            this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortColorsByRedToolStripMenuItem,
            this.sortColorsByGreenToolStripMenuItem,
            this.sortColorsByBlueToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sortColorsByHueToolStripMenuItem,
            this.sortColorsByBrightmessToolStripMenuItem,
            this.sortColorsBySatuationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.savePalleteAsAnImageToolStripMenuItem,
            this.exportPaletteToExcellToolStripMenuItem});
            this.contextMenuStripGrid.Name = "contextMenuStrip1";
            this.contextMenuStripGrid.Size = new System.Drawing.Size(213, 192);
            // 
            // sortColorsByRedToolStripMenuItem
            // 
            this.sortColorsByRedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsByRedToolStripMenuItem.Image")));
            this.sortColorsByRedToolStripMenuItem.Name = "sortColorsByRedToolStripMenuItem";
            this.sortColorsByRedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsByRedToolStripMenuItem.Text = "Sort Colors By Red";
            this.sortColorsByRedToolStripMenuItem.Click += new System.EventHandler(this.sortColorsByRedToolStripMenuItem_Click);
            // 
            // sortColorsByGreenToolStripMenuItem
            // 
            this.sortColorsByGreenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsByGreenToolStripMenuItem.Image")));
            this.sortColorsByGreenToolStripMenuItem.Name = "sortColorsByGreenToolStripMenuItem";
            this.sortColorsByGreenToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsByGreenToolStripMenuItem.Text = "Sort Colors By Green";
            this.sortColorsByGreenToolStripMenuItem.Click += new System.EventHandler(this.sortColorsByGreenToolStripMenuItem_Click);
            // 
            // sortColorsByBlueToolStripMenuItem
            // 
            this.sortColorsByBlueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsByBlueToolStripMenuItem.Image")));
            this.sortColorsByBlueToolStripMenuItem.Name = "sortColorsByBlueToolStripMenuItem";
            this.sortColorsByBlueToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsByBlueToolStripMenuItem.Text = "Sort Colors By Blue";
            this.sortColorsByBlueToolStripMenuItem.Click += new System.EventHandler(this.sortColorsByBlueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // sortColorsByHueToolStripMenuItem
            // 
            this.sortColorsByHueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsByHueToolStripMenuItem.Image")));
            this.sortColorsByHueToolStripMenuItem.Name = "sortColorsByHueToolStripMenuItem";
            this.sortColorsByHueToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsByHueToolStripMenuItem.Text = "Sort Colors By Hue";
            this.sortColorsByHueToolStripMenuItem.Click += new System.EventHandler(this.sortColorsByHueToolStripMenuItem_Click);
            // 
            // sortColorsByBrightmessToolStripMenuItem
            // 
            this.sortColorsByBrightmessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsByBrightmessToolStripMenuItem.Image")));
            this.sortColorsByBrightmessToolStripMenuItem.Name = "sortColorsByBrightmessToolStripMenuItem";
            this.sortColorsByBrightmessToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsByBrightmessToolStripMenuItem.Text = "Sort Colors By Brightmess";
            this.sortColorsByBrightmessToolStripMenuItem.Click += new System.EventHandler(this.sortColorsByBrightmessToolStripMenuItem_Click);
            // 
            // sortColorsBySatuationToolStripMenuItem
            // 
            this.sortColorsBySatuationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortColorsBySatuationToolStripMenuItem.Image")));
            this.sortColorsBySatuationToolStripMenuItem.Name = "sortColorsBySatuationToolStripMenuItem";
            this.sortColorsBySatuationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sortColorsBySatuationToolStripMenuItem.Text = "Sort Colors By Satuation";
            this.sortColorsBySatuationToolStripMenuItem.Click += new System.EventHandler(this.sortColorsBySatuationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 6);
            // 
            // savePalleteAsAnImageToolStripMenuItem
            // 
            this.savePalleteAsAnImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("savePalleteAsAnImageToolStripMenuItem.Image")));
            this.savePalleteAsAnImageToolStripMenuItem.Name = "savePalleteAsAnImageToolStripMenuItem";
            this.savePalleteAsAnImageToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.savePalleteAsAnImageToolStripMenuItem.Text = "Save Palette as an Image...";
            this.savePalleteAsAnImageToolStripMenuItem.Click += new System.EventHandler(this.savePalleteAsAnImageToolStripMenuItem_Click);
            // 
            // exportPaletteToExcellToolStripMenuItem
            // 
            this.exportPaletteToExcellToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportPaletteToExcellToolStripMenuItem.Image")));
            this.exportPaletteToExcellToolStripMenuItem.Name = "exportPaletteToExcellToolStripMenuItem";
            this.exportPaletteToExcellToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exportPaletteToExcellToolStripMenuItem.Text = "Export Palette to Excell...";
            this.exportPaletteToExcellToolStripMenuItem.Click += new System.EventHandler(this.exportPaletteToExcellToolStripMenuItem_Click);
            // 
            // panelColor
            // 
            this.panelColor.AutoScroll = true;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Controls.Add(this.pbColors);
            this.panelColor.Location = new System.Drawing.Point(12, 15);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(263, 437);
            this.panelColor.TabIndex = 13;
            // 
            // panelShowColor
            // 
            this.panelShowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShowColor.Controls.Add(this.lblColorCode);
            this.panelShowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelShowColor.Location = new System.Drawing.Point(99, 458);
            this.panelShowColor.Name = "panelShowColor";
            this.panelShowColor.Size = new System.Drawing.Size(176, 66);
            this.panelShowColor.TabIndex = 14;
            this.panelShowColor.Click += new System.EventHandler(this.panelShowColor_Click);
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.BackColor = System.Drawing.Color.Transparent;
            this.lblColorCode.Location = new System.Drawing.Point(3, 0);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(59, 13);
            this.lblColorCode.TabIndex = 0;
            this.lblColorCode.Text = "Color Code";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(12, 460);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(27, 13);
            this.labelRed.TabIndex = 15;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelGreen.Location = new System.Drawing.Point(12, 485);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(36, 13);
            this.labelGreen.TabIndex = 16;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ForeColor = System.Drawing.Color.Navy;
            this.labelBlue.Location = new System.Drawing.Point(12, 510);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 17;
            this.labelBlue.Text = "Blue";
            // 
            // lblCntColor
            // 
            this.lblCntColor.AutoSize = true;
            this.lblCntColor.Location = new System.Drawing.Point(96, 530);
            this.lblCntColor.Name = "lblCntColor";
            this.lblCntColor.Size = new System.Drawing.Size(89, 13);
            this.lblCntColor.TabIndex = 18;
            this.lblCntColor.Text = "Number of Pixels:";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(278, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(18, 18);
            this.btnAdd.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnAdd, "Add this Color to Image");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Image = ((System.Drawing.Image)(resources.GetObject("btnSub.Image")));
            this.btnSub.Location = new System.Drawing.Point(278, 39);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(18, 18);
            this.btnSub.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSub, "Remove this Color from image");
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.Location = new System.Drawing.Point(278, 63);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(18, 18);
            this.btnShowAll.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnShowAll, "Show all image");
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(280, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(18, 18);
            this.btnClear.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnClear, "Clear image");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(281, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button1, "Mark this color on image");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(821, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 42);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(821, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "&Export\r\n Palette";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.savePalleteAsAnImageToolStripMenuItem_Click);
            // 
            // toolTipShowColor
            // 
            this.toolTipShowColor.IsBalloon = true;
            this.toolTipShowColor.ShowAlways = true;
            // 
            // FAllColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(954, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCntColor);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.panelShowColor);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAllColors";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Used Colors";
            this.Load += new System.EventHandler(this.FAllColors_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.contextMenuStripmage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColors)).EndInit();
            this.contextMenuStripGrid.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelShowColor.ResumeLayout(false);
            this.panelShowColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pbColors;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelShowColor;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
        private System.Windows.Forms.ToolStripMenuItem sortColorsByRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortColorsByGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortColorsByBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortColorsByHueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortColorsByBrightmessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortColorsBySatuationToolStripMenuItem;
        private System.Windows.Forms.Label lblCntColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripmage;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem savePalleteAsAnImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPaletteToExcellToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTipShowColor;
    }
}