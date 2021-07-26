namespace VitalPixels.User_Controls
{
    partial class UCZoomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.labelZoomPer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.AutoSize = false;
            this.trackBarZoom.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBarZoom.LargeChange = 50;
            this.trackBarZoom.Location = new System.Drawing.Point(336, 0);
            this.trackBarZoom.Maximum = 500;
            this.trackBarZoom.Minimum = 1;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(231, 56);
            this.trackBarZoom.SmallChange = 10;
            this.trackBarZoom.TabIndex = 5;
            this.trackBarZoom.Tag = "Input";
            this.trackBarZoom.TickFrequency = 50;
            this.trackBarZoom.Value = 100;
            this.trackBarZoom.ValueChanged += new System.EventHandler(this.trackBarZoom_ValueChanged);
            // 
            // labelZoomPer
            // 
            this.labelZoomPer.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelZoomPer.Location = new System.Drawing.Point(236, 0);
            this.labelZoomPer.Name = "labelZoomPer";
            this.labelZoomPer.Padding = new System.Windows.Forms.Padding(10);
            this.labelZoomPer.Size = new System.Drawing.Size(100, 56);
            this.labelZoomPer.TabIndex = 6;
            this.labelZoomPer.Text = "Zoom:100%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Fit to Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FitToScreen);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Original Size";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OriginalSize_Click);
            // 
            // UCZoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelZoomPer);
            this.Controls.Add(this.trackBarZoom);
            this.Name = "UCZoomControl";
            this.Size = new System.Drawing.Size(567, 56);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelZoomPer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TrackBar trackBarZoom;
    }
}
