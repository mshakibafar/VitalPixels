namespace VitalPixels
{
    partial class FConvertText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConvertText));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImageText = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chAutoSize = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageText)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbImageText);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 529);
            this.panel1.TabIndex = 1;
            // 
            // pbImageText
            // 
            this.pbImageText.BackColor = System.Drawing.Color.White;
            this.pbImageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageText.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImageText.Location = new System.Drawing.Point(3, 3);
            this.pbImageText.Name = "pbImageText";
            this.pbImageText.Size = new System.Drawing.Size(512, 512);
            this.pbImageText.TabIndex = 0;
            this.pbImageText.TabStop = false;
            this.pbImageText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImageText_MouseDown);
            this.pbImageText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImageText_MouseMove);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(553, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import Text File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(553, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fonts...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FontClick);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(553, 191);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Save and Close";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(553, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numLeft);
            this.groupBox1.Controls.Add(this.numTop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numHeight);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(554, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // numLeft
            // 
            this.numLeft.Location = new System.Drawing.Point(62, 134);
            this.numLeft.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(70, 20);
            this.numLeft.TabIndex = 7;
            this.numLeft.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLeft.ValueChanged += new System.EventHandler(this.numTop_ValueChanged);
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(62, 104);
            this.numTop.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(70, 20);
            this.numTop.TabIndex = 6;
            this.numTop.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTop.ValueChanged += new System.EventHandler(this.numTop_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Top";
            // 
            // numHeight
            // 
            this.numHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHeight.Location = new System.Drawing.Point(61, 60);
            this.numHeight.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(70, 20);
            this.numHeight.TabIndex = 3;
            this.numHeight.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWidth.Location = new System.Drawing.Point(61, 30);
            this.numWidth.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(70, 20);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width";
            // 
            // chAutoSize
            // 
            this.chAutoSize.AutoSize = true;
            this.chAutoSize.Checked = true;
            this.chAutoSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAutoSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chAutoSize.Location = new System.Drawing.Point(628, 373);
            this.chAutoSize.Name = "chAutoSize";
            this.chAutoSize.Size = new System.Drawing.Size(69, 17);
            this.chAutoSize.TabIndex = 8;
            this.chAutoSize.Text = "Auto Size";
            this.chAutoSize.UseVisualStyleBackColor = true;
            this.chAutoSize.CheckedChanged += new System.EventHandler(this.chAutoSize_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(553, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back Color...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "X=0,Y=0";
            // 
            // FConvertText
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(724, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chAutoSize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FConvertText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Text File to an Image";
            this.Load += new System.EventHandler(this.FConvertText_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageText)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numLeft;
        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pbImageText;
        private System.Windows.Forms.CheckBox chAutoSize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}