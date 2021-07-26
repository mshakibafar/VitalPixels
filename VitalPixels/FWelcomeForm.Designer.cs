namespace VitalPixels
{
    partial class FWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWelcomeForm));
            this.btnSampleCode = new System.Windows.Forms.Button();
            this.btnSampleImage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipGuide = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSampleCode
            // 
            this.btnSampleCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSampleCode.Image = ((System.Drawing.Image)(resources.GetObject("btnSampleCode.Image")));
            this.btnSampleCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSampleCode.Location = new System.Drawing.Point(10, 5);
            this.btnSampleCode.Name = "btnSampleCode";
            this.btnSampleCode.Padding = new System.Windows.Forms.Padding(5);
            this.btnSampleCode.Size = new System.Drawing.Size(216, 64);
            this.btnSampleCode.TabIndex = 0;
            this.btnSampleCode.Text = "Sample &Code";
            this.btnSampleCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSampleCode.UseVisualStyleBackColor = true;
            this.btnSampleCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSampleImage
            // 
            this.btnSampleImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSampleImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSampleImage.Image")));
            this.btnSampleImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSampleImage.Location = new System.Drawing.Point(10, 75);
            this.btnSampleImage.Name = "btnSampleImage";
            this.btnSampleImage.Padding = new System.Windows.Forms.Padding(5);
            this.btnSampleImage.Size = new System.Drawing.Size(216, 64);
            this.btnSampleImage.TabIndex = 1;
            this.btnSampleImage.Text = "Sample Ima&ge...";
            this.btnSampleImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSampleImage.UseVisualStyleBackColor = true;
            this.btnSampleImage.Click += new System.EventHandler(this.btnSampleImage_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(10, 285);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(216, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "&New C# Code ...";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPFile
            // 
            this.btnPFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPFile.Image = ((System.Drawing.Image)(resources.GetObject("btnPFile.Image")));
            this.btnPFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPFile.Location = new System.Drawing.Point(10, 145);
            this.btnPFile.Name = "btnPFile";
            this.btnPFile.Padding = new System.Windows.Forms.Padding(5);
            this.btnPFile.Size = new System.Drawing.Size(216, 64);
            this.btnPFile.TabIndex = 3;
            this.btnPFile.Text = "Open P&revious File\r\n";
            this.btnPFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPFile.UseVisualStyleBackColor = true;
            this.btnPFile.Click += new System.EventHandler(this.btnPFile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 107);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO VITAL PIXELS\r\nFree Software for Image Processing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnPFile);
            this.panel1.Controls.Add(this.btnSampleCode);
            this.panel1.Controls.Add(this.btnSampleImage);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 358);
            this.panel1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(10, 215);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(216, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "&Open Image/Code...";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 124);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTipGuide
            // 
            this.toolTipGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipGuide.IsBalloon = true;
            this.toolTipGuide.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGuide.ToolTipTitle = "Notice";
            // 
            // FWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(479, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FWelcomeForm";
            this.Opacity = 0.9D;
            this.Tag = "Welcome";
            this.Text = "Welcome to Vital Pixels";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FWelcomeForm_Load);
            this.Resize += new System.EventHandler(this.FWelcomeForm_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSampleCode;
        private System.Windows.Forms.Button btnSampleImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTipGuide;
    }
}