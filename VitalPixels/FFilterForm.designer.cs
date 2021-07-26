namespace VitalPixels
{
    partial class FBrightnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBrightnes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brValue = new System.Windows.Forms.TrackBar();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericValue);
            this.groupBox1.Controls.Add(this.pbTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.brValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numericValue
            // 
            this.numericValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericValue.Location = new System.Drawing.Point(387, 60);
            this.numericValue.Name = "numericValue";
            this.numericValue.Size = new System.Drawing.Size(49, 22);
            this.numericValue.TabIndex = 6;
            this.numericValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pbTest
            // 
            this.pbTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTest.Location = new System.Drawing.Point(6, 118);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(430, 430);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTest.TabIndex = 5;
            this.pbTest.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Brightness";
            // 
            // brValue
            // 
            this.brValue.Location = new System.Drawing.Point(6, 55);
            this.brValue.Maximum = 100;
            this.brValue.Name = "brValue";
            this.brValue.Size = new System.Drawing.Size(375, 45);
            this.brValue.SmallChange = 10;
            this.brValue.TabIndex = 3;
            this.brValue.TickFrequency = 10;
            this.brValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.brValue.ValueChanged += new System.EventHandler(this.brValue_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(465, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 38);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(465, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(466, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Default Image:";
            // 
            // FBrightnes
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(613, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FBrightnes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Brightness";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBrightnes_FormClosing);
            this.Load += new System.EventHandler(this.FBrightnes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar brValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericValue;
        public System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;

    }
}