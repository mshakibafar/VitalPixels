namespace VitalPixels
{
    partial class FRunPlugin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRunPlugin));
            this.groupParams = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.Label();
            this.panelParam = new System.Windows.Forms.Panel();
            this.groupParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupParams
            // 
            this.groupParams.Controls.Add(this.panelParam);
            this.groupParams.Location = new System.Drawing.Point(12, 87);
            this.groupParams.Margin = new System.Windows.Forms.Padding(50);
            this.groupParams.Name = "groupParams";
            this.groupParams.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupParams.Size = new System.Drawing.Size(365, 212);
            this.groupParams.TabIndex = 0;
            this.groupParams.TabStop = false;
            this.groupParams.Text = "Parameters";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(383, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(383, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Info
            // 
            this.Info.ForeColor = System.Drawing.Color.Gray;
            this.Info.Location = new System.Drawing.Point(92, 11);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(285, 68);
            this.Info.TabIndex = 3;
            this.Info.Text = "label1";
            // 
            // panelParam
            // 
            this.panelParam.AutoScroll = true;
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParam.Location = new System.Drawing.Point(5, 13);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(355, 194);
            this.panelParam.TabIndex = 0;
            // 
            // FRunPlugin
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(518, 308);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupParams);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRunPlugin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRunPlugin";
            this.Load += new System.EventHandler(this.FRunPlugin_Load);
            this.groupParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParams;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel panelParam;
    }
}