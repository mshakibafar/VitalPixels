namespace VitalPixels
{
    partial class FGamma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGamma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numRGB = new System.Windows.Forms.NumericUpDown();
            this.trackBarRGB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRGB);
            this.groupBox1.Controls.Add(this.trackBarRGB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numBlue);
            this.groupBox1.Controls.Add(this.numGreen);
            this.groupBox1.Controls.Add(this.numRed);
            this.groupBox1.Controls.Add(this.trackBarBlue);
            this.groupBox1.Controls.Add(this.trackBarGreen);
            this.groupBox1.Controls.Add(this.trackBarRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numBlue
            // 
            this.numBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numBlue.Location = new System.Drawing.Point(337, 187);
            this.numBlue.Name = "numBlue";
            this.numBlue.ReadOnly = true;
            this.numBlue.Size = new System.Drawing.Size(56, 22);
            this.numBlue.TabIndex = 8;
            this.numBlue.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // numGreen
            // 
            this.numGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numGreen.Location = new System.Drawing.Point(337, 140);
            this.numGreen.Name = "numGreen";
            this.numGreen.ReadOnly = true;
            this.numGreen.Size = new System.Drawing.Size(56, 22);
            this.numGreen.TabIndex = 7;
            this.numGreen.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // numRed
            // 
            this.numRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numRed.Location = new System.Drawing.Point(337, 93);
            this.numRed.Name = "numRed";
            this.numRed.ReadOnly = true;
            this.numRed.Size = new System.Drawing.Size(56, 22);
            this.numRed.TabIndex = 6;
            this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.trackBarBlue.Location = new System.Drawing.Point(44, 179);
            this.trackBarBlue.Maximum = 100;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(287, 45);
            this.trackBarBlue.TabIndex = 5;
            this.trackBarBlue.TickFrequency = 10;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trackBarGreen.Location = new System.Drawing.Point(44, 132);
            this.trackBarGreen.Maximum = 100;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(287, 45);
            this.trackBarGreen.TabIndex = 4;
            this.trackBarGreen.TickFrequency = 10;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackBarRed.Location = new System.Drawing.Point(44, 85);
            this.trackBarRed.Maximum = 100;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(287, 45);
            this.trackBarRed.TabIndex = 3;
            this.trackBarRed.TickFrequency = 10;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            this.trackBarRed.ValueChanged += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // pbTest
            // 
            this.pbTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTest.Location = new System.Drawing.Point(12, 255);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(400, 400);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTest.TabIndex = 1;
            this.pbTest.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(421, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 41);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(421, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Default Image:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(419, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(421, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numRGB
            // 
            this.numRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numRGB.Location = new System.Drawing.Point(337, 19);
            this.numRGB.Name = "numRGB";
            this.numRGB.ReadOnly = true;
            this.numRGB.Size = new System.Drawing.Size(56, 22);
            this.numRGB.TabIndex = 11;
            // 
            // trackBarRGB
            // 
            this.trackBarRGB.Location = new System.Drawing.Point(44, 19);
            this.trackBarRGB.Maximum = 100;
            this.trackBarRGB.Name = "trackBarRGB";
            this.trackBarRGB.Size = new System.Drawing.Size(287, 45);
            this.trackBarRGB.TabIndex = 10;
            this.trackBarRGB.TickFrequency = 10;
            this.trackBarRGB.ValueChanged += new System.EventHandler(this.trackBarRGB_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RGB";
            // 
            // FGamma
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(572, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FGamma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Gamma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FGamma_FormClosing);
            this.Load += new System.EventHandler(this.FGamma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TrackBar trackBarRed;
        public System.Windows.Forms.TrackBar trackBarBlue;
        public System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numRGB;
        public System.Windows.Forms.TrackBar trackBarRGB;
        private System.Windows.Forms.Label label5;
    }
}