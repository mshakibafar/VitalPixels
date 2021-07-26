namespace VitalPixels
{
    partial class FMatlabSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMatlabSettings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txMatAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUseProgram = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpProgram = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txMFile = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuild = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txMatAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(229, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MatLab Settings";
            // 
            // txClassName
            // 
            this.txClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txClassName.Location = new System.Drawing.Point(26, 108);
            this.txClassName.Name = "txClassName";
            this.txClassName.Size = new System.Drawing.Size(333, 20);
            this.txClassName.TabIndex = 4;
            this.txClassName.Text = "MatlabVPClass";
            this.txClassName.TextChanged += new System.EventHandler(this.txClassName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class Name ";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(365, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 36);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txMatAddress
            // 
            this.txMatAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txMatAddress.Location = new System.Drawing.Point(26, 54);
            this.txMatAddress.Name = "txMatAddress";
            this.txMatAddress.Size = new System.Drawing.Size(333, 20);
            this.txMatAddress.TabIndex = 1;
            this.txMatAddress.Text = "E:\\Program Files\\MATLAB\\R2013a\\bin";
            this.txMatAddress.TextChanged += new System.EventHandler(this.txMatAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matlab Installation Address";
            // 
            // chkUseProgram
            // 
            this.chkUseProgram.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUseProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkUseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUseProgram.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkUseProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkUseProgram.ImageIndex = 1;
            this.chkUseProgram.ImageList = this.imageList1;
            this.chkUseProgram.Location = new System.Drawing.Point(229, 12);
            this.chkUseProgram.Name = "chkUseProgram";
            this.chkUseProgram.Padding = new System.Windows.Forms.Padding(5);
            this.chkUseProgram.Size = new System.Drawing.Size(405, 38);
            this.chkUseProgram.TabIndex = 6;
            this.chkUseProgram.Text = "Import MATLAB Script to Compiler";
            this.chkUseProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseProgram.UseVisualStyleBackColor = false;
            this.chkUseProgram.CheckedChanged += new System.EventHandler(this.chkUseProgram_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "delete-icon2.png");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(640, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOK.Location = new System.Drawing.Point(640, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 42);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpProgram
            // 
            this.grpProgram.Controls.Add(this.label3);
            this.grpProgram.Controls.Add(this.button2);
            this.grpProgram.Controls.Add(this.txMFile);
            this.grpProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpProgram.Location = new System.Drawing.Point(229, 213);
            this.grpProgram.Name = "grpProgram";
            this.grpProgram.Size = new System.Drawing.Size(405, 99);
            this.grpProgram.TabIndex = 4;
            this.grpProgram.TabStop = false;
            this.grpProgram.Text = "Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select M-File";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(365, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 36);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txMFile
            // 
            this.txMFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txMFile.Location = new System.Drawing.Point(26, 51);
            this.txMFile.Name = "txMFile";
            this.txMFile.Size = new System.Drawing.Size(333, 20);
            this.txMFile.TabIndex = 5;
            this.txMFile.Text = "MatlabVPClass";
            this.txMFile.TextChanged += new System.EventHandler(this.txMFile_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Image = ((System.Drawing.Image)(resources.GetObject("btnBuild.Image")));
            this.btnBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuild.Location = new System.Drawing.Point(640, 65);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(140, 42);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "&Import";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.Build_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richMessage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(7, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(773, 128);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // richMessage
            // 
            this.richMessage.BackColor = System.Drawing.Color.LightGray;
            this.richMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.richMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richMessage.Location = new System.Drawing.Point(5, 18);
            this.richMessage.Margin = new System.Windows.Forms.Padding(5);
            this.richMessage.Name = "richMessage";
            this.richMessage.ReadOnly = true;
            this.richMessage.Size = new System.Drawing.Size(763, 105);
            this.richMessage.TabIndex = 0;
            this.richMessage.Text = "";
            this.richMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richMessage_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printLogToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 54);
            // 
            // saveAsLogToolStripMenuItem
            // 
            this.saveAsLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsLogToolStripMenuItem.Image")));
            this.saveAsLogToolStripMenuItem.Name = "saveAsLogToolStripMenuItem";
            this.saveAsLogToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveAsLogToolStripMenuItem.Text = "Save as log...";
            this.saveAsLogToolStripMenuItem.Click += new System.EventHandler(this.saveAsLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // printLogToolStripMenuItem
            // 
            this.printLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printLogToolStripMenuItem.Image")));
            this.printLogToolStripMenuItem.Name = "printLogToolStripMenuItem";
            this.printLogToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.printLogToolStripMenuItem.Text = "Clear log";
            this.printLogToolStripMenuItem.Click += new System.EventHandler(this.printLogToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 114);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMatlabSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(792, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkUseProgram);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.grpProgram);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMatlabSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatLab Compiler Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMatlabSettings_FormClosing);
            this.Load += new System.EventHandler(this.FMatlabSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpProgram.ResumeLayout(false);
            this.grpProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txMatAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProgram;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txMFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUseProgram;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richMessage;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printLogToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}