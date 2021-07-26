namespace VitalPixels
{
    partial class FFFT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFFT));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbFFTInput = new System.Windows.Forms.PictureBox();
            this.contextMenuStripFFT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFFTAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFFTOutput = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFFTInput)).BeginInit();
            this.contextMenuStripFFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFFTOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbFFTInput);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Panel2.Controls.Add(this.pbFFTOutput);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(773, 571);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 1;
            // 
            // pbFFTInput
            // 
            this.pbFFTInput.BackColor = System.Drawing.Color.Black;
            this.pbFFTInput.ContextMenuStrip = this.contextMenuStripFFT;
            this.pbFFTInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFFTInput.Location = new System.Drawing.Point(0, 23);
            this.pbFFTInput.Name = "pbFFTInput";
            this.pbFFTInput.Size = new System.Drawing.Size(383, 548);
            this.pbFFTInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFFTInput.TabIndex = 2;
            this.pbFFTInput.TabStop = false;
            // 
            // contextMenuStripFFT
            // 
            this.contextMenuStripFFT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFFTAsImageToolStripMenuItem});
            this.contextMenuStripFFT.Name = "contextMenuStrip1";
            this.contextMenuStripFFT.Size = new System.Drawing.Size(180, 48);
            // 
            // saveFFTAsImageToolStripMenuItem
            // 
            this.saveFFTAsImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFFTAsImageToolStripMenuItem.Image")));
            this.saveFFTAsImageToolStripMenuItem.Name = "saveFFTAsImageToolStripMenuItem";
            this.saveFFTAsImageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveFFTAsImageToolStripMenuItem.Text = "Save FFT as Image...";
            this.saveFFTAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveFFTAsImageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input FFT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFFTOutput
            // 
            this.pbFFTOutput.BackColor = System.Drawing.Color.Black;
            this.pbFFTOutput.ContextMenuStrip = this.contextMenuStripFFT;
            this.pbFFTOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFFTOutput.Location = new System.Drawing.Point(0, 23);
            this.pbFFTOutput.Name = "pbFFTOutput";
            this.pbFFTOutput.Size = new System.Drawing.Size(386, 548);
            this.pbFFTOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFFTOutput.TabIndex = 3;
            this.pbFFTOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output FFT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FFFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 571);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "FFFT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFT of Input and Output Image";
            this.Load += new System.EventHandler(this.FFFT_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFFTInput)).EndInit();
            this.contextMenuStripFFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFFTOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFFTInput;
        private System.Windows.Forms.PictureBox pbFFTOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFFT;
        private System.Windows.Forms.ToolStripMenuItem saveFFTAsImageToolStripMenuItem;
    }
}