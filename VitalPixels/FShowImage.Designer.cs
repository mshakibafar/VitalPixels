namespace VitalPixels
{
    partial class FShowImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FShowImage));
            this.pbFullSizeImage = new System.Windows.Forms.PictureBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelColorname = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullSizeImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFullSizeImage
            // 
            this.pbFullSizeImage.BackColor = System.Drawing.Color.White;
            this.pbFullSizeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFullSizeImage.ContextMenuStrip = this.contextMenuStrip1;
            this.pbFullSizeImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbFullSizeImage.Location = new System.Drawing.Point(1, 1);
            this.pbFullSizeImage.Name = "pbFullSizeImage";
            this.pbFullSizeImage.Size = new System.Drawing.Size(517, 544);
            this.pbFullSizeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFullSizeImage.TabIndex = 2;
            this.pbFullSizeImage.TabStop = false;
            this.pbFullSizeImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbFullSizeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(524, 36);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(95, 87);
            this.panelColor.TabIndex = 3;
            // 
            // labelColorname
            // 
            this.labelColorname.BackColor = System.Drawing.Color.White;
            this.labelColorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorname.Location = new System.Drawing.Point(524, 126);
            this.labelColorname.Name = "labelColorname";
            this.labelColorname.Size = new System.Drawing.Size(95, 20);
            this.labelColorname.TabIndex = 0;
            this.labelColorname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveImageToolStripMenuItem.Image")));
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(525, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // FShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(676, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelColorname);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.pbFullSizeImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FShowImage";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FShowImage";
            this.Load += new System.EventHandler(this.FShowImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullSizeImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFullSizeImage;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelColorname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}