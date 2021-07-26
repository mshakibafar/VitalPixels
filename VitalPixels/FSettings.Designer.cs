namespace VitalPixels
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkLastOpened = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFoldingLine = new System.Windows.Forms.CheckBox();
            this.chkLineNumber = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkColorOutput = new System.Windows.Forms.CheckBox();
            this.chkColorInput = new System.Windows.Forms.CheckBox();
            this.chkinfoPanel = new System.Windows.Forms.CheckBox();
            this.chOpenSample = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(374, 324);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 33);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(177, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chOpenSample);
            this.groupBox1.Controls.Add(this.chkUpdate);
            this.groupBox1.Controls.Add(this.chkLastOpened);
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starup";
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Checked = true;
            this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdate.Location = new System.Drawing.Point(24, 44);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(105, 17);
            this.chkUpdate.TabIndex = 1;
            this.chkUpdate.Text = "Check fo update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkLastOpened
            // 
            this.chkLastOpened.AutoSize = true;
            this.chkLastOpened.Checked = true;
            this.chkLastOpened.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLastOpened.Location = new System.Drawing.Point(24, 21);
            this.chkLastOpened.Name = "chkLastOpened";
            this.chkLastOpened.Size = new System.Drawing.Size(188, 17);
            this.chkLastOpened.TabIndex = 0;
            this.chkLastOpened.Text = "Reopen last opened file on startup";
            this.chkLastOpened.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkFoldingLine);
            this.groupBox2.Controls.Add(this.chkLineNumber);
            this.groupBox2.Location = new System.Drawing.Point(153, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(22, 78);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(26, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BackColor";
            // 
            // chkFoldingLine
            // 
            this.chkFoldingLine.AutoSize = true;
            this.chkFoldingLine.Checked = true;
            this.chkFoldingLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFoldingLine.Location = new System.Drawing.Point(24, 52);
            this.chkFoldingLine.Name = "chkFoldingLine";
            this.chkFoldingLine.Size = new System.Drawing.Size(106, 17);
            this.chkFoldingLine.TabIndex = 1;
            this.chkFoldingLine.Text = "Show folding line";
            this.chkFoldingLine.UseVisualStyleBackColor = true;
            // 
            // chkLineNumber
            // 
            this.chkLineNumber.AutoSize = true;
            this.chkLineNumber.Checked = true;
            this.chkLineNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLineNumber.Location = new System.Drawing.Point(24, 27);
            this.chkLineNumber.Name = "chkLineNumber";
            this.chkLineNumber.Size = new System.Drawing.Size(110, 17);
            this.chkLineNumber.TabIndex = 0;
            this.chkLineNumber.Text = "Show line number";
            this.chkLineNumber.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkColorOutput);
            this.groupBox4.Controls.Add(this.chkColorInput);
            this.groupBox4.Controls.Add(this.chkinfoPanel);
            this.groupBox4.Location = new System.Drawing.Point(153, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 99);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image";
            // 
            // chkColorOutput
            // 
            this.chkColorOutput.AutoSize = true;
            this.chkColorOutput.Checked = true;
            this.chkColorOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColorOutput.Location = new System.Drawing.Point(24, 69);
            this.chkColorOutput.Name = "chkColorOutput";
            this.chkColorOutput.Size = new System.Drawing.Size(236, 17);
            this.chkColorOutput.TabIndex = 2;
            this.chkColorOutput.Text = "Show code of color in staus for output image";
            this.chkColorOutput.UseVisualStyleBackColor = true;
            // 
            // chkColorInput
            // 
            this.chkColorInput.AutoSize = true;
            this.chkColorInput.Checked = true;
            this.chkColorInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColorInput.Location = new System.Drawing.Point(24, 45);
            this.chkColorInput.Name = "chkColorInput";
            this.chkColorInput.Size = new System.Drawing.Size(229, 17);
            this.chkColorInput.TabIndex = 1;
            this.chkColorInput.Text = "Show code of color in staus for input image";
            this.chkColorInput.UseVisualStyleBackColor = true;
            // 
            // chkinfoPanel
            // 
            this.chkinfoPanel.AutoSize = true;
            this.chkinfoPanel.Checked = true;
            this.chkinfoPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkinfoPanel.Location = new System.Drawing.Point(24, 21);
            this.chkinfoPanel.Name = "chkinfoPanel";
            this.chkinfoPanel.Size = new System.Drawing.Size(136, 17);
            this.chkinfoPanel.TabIndex = 0;
            this.chkinfoPanel.Text = "Show information panel";
            this.chkinfoPanel.UseVisualStyleBackColor = true;
            // 
            // chOpenSample
            // 
            this.chOpenSample.AutoSize = true;
            this.chOpenSample.Checked = true;
            this.chOpenSample.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chOpenSample.Location = new System.Drawing.Point(24, 67);
            this.chOpenSample.Name = "chOpenSample";
            this.chOpenSample.Size = new System.Drawing.Size(209, 17);
            this.chOpenSample.TabIndex = 2;
            this.chOpenSample.Text = "Open Sample Image if preview is blank";
            this.chOpenSample.UseVisualStyleBackColor = true;
            // 
            // FSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(518, 362);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLastOpened;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLineNumber;
        private System.Windows.Forms.CheckBox chkFoldingLine;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkinfoPanel;
        private System.Windows.Forms.CheckBox chkColorOutput;
        private System.Windows.Forms.CheckBox chkColorInput;
        private System.Windows.Forms.CheckBox chOpenSample;
    }
}