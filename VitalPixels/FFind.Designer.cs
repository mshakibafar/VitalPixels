namespace VitalPixels
{
    partial class FFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFind));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txReplace = new System.Windows.Forms.TextBox();
            this.txFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btBookmark = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txReplace);
            this.groupBox1.Controls.Add(this.txFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txReplace
            // 
            this.txReplace.Location = new System.Drawing.Point(6, 140);
            this.txReplace.Multiline = true;
            this.txReplace.Name = "txReplace";
            this.txReplace.Size = new System.Drawing.Size(323, 67);
            this.txReplace.TabIndex = 3;
            this.txReplace.TextChanged += new System.EventHandler(this.txReplace_TextChanged);
            // 
            // txFind
            // 
            this.txFind.Location = new System.Drawing.Point(6, 34);
            this.txFind.Multiline = true;
            this.txFind.Name = "txFind";
            this.txFind.Size = new System.Drawing.Size(323, 62);
            this.txFind.TabIndex = 2;
            this.txFind.TextChanged += new System.EventHandler(this.txFind_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(362, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 38);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "&Find Next";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Image = ((System.Drawing.Image)(resources.GetObject("btnReplace.Image")));
            this.btnReplace.Location = new System.Drawing.Point(362, 104);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(108, 38);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // btBookmark
            // 
            this.btBookmark.Enabled = false;
            this.btBookmark.Image = ((System.Drawing.Image)(resources.GetObject("btBookmark.Image")));
            this.btBookmark.Location = new System.Drawing.Point(362, 147);
            this.btBookmark.Name = "btBookmark";
            this.btBookmark.Size = new System.Drawing.Size(108, 38);
            this.btBookmark.TabIndex = 3;
            this.btBookmark.Text = "&Bookmark All";
            this.btBookmark.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btBookmark.UseVisualStyleBackColor = true;
            this.btBookmark.Click += new System.EventHandler(this.BookMark_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(362, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(362, 61);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(108, 38);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Find &Previous";
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.FindPrevious_Click);
            // 
            // FFind
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(476, 242);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btBookmark);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FFind";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btBookmark;
        private System.Windows.Forms.TextBox txReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrev;
        internal System.Windows.Forms.TextBox txFind;
    }
}