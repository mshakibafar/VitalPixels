namespace VitalPixels.VPUserControls
{
    partial class UCColors
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
            this.dataGridIndex = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIndex
            // 
            this.dataGridIndex.AllowUserToAddRows = false;
            this.dataGridIndex.AllowUserToDeleteRows = false;
            this.dataGridIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Code,
            this.Color,
            this.ColorCode});
            this.dataGridIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIndex.Location = new System.Drawing.Point(0, 0);
            this.dataGridIndex.Name = "dataGridIndex";
            this.dataGridIndex.ReadOnly = true;
            this.dataGridIndex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIndex.Size = new System.Drawing.Size(667, 310);
            this.dataGridIndex.TabIndex = 6;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // Code
            // 
            this.Code.HeaderText = "RGB";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 200;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 50;
            // 
            // ColorCode
            // 
            this.ColorCode.HeaderText = "Code";
            this.ColorCode.Name = "ColorCode";
            this.ColorCode.ReadOnly = true;
            // 
            // UCColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridIndex);
            this.Name = "UCColors";
            this.Size = new System.Drawing.Size(667, 310);
            this.Load += new System.EventHandler(this.UCColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
    }
}
