namespace VitalPixels
{
    partial class FCompilerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompilerSettings));
            this.MenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addDLLFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDLL = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbRef = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chGAC = new System.Windows.Forms.DataGridView();
            this.colGlobalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGlobalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGlobalComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDLL = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.GridDLL = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colGACComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGACChech = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuGrid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbRef.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGAC)).BeginInit();
            this.tbDLL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGrid
            // 
            this.MenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addDLLFilesToolStripMenuItem});
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(150, 54);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeFileToolStripMenuItem.Image")));
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeFileToolStripMenuItem.Text = "Remove file";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // addDLLFilesToolStripMenuItem
            // 
            this.addDLLFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDLLFilesToolStripMenuItem.Image")));
            this.addDLLFilesToolStripMenuItem.Name = "addDLLFilesToolStripMenuItem";
            this.addDLLFilesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addDLLFilesToolStripMenuItem.Text = "Add DLL files..";
            this.addDLLFilesToolStripMenuItem.Click += new System.EventHandler(this.AddDLL_Click);
            // 
            // btnAddDLL
            // 
            this.btnAddDLL.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDLL.Image")));
            this.btnAddDLL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDLL.Location = new System.Drawing.Point(277, 255);
            this.btnAddDLL.Name = "btnAddDLL";
            this.btnAddDLL.Size = new System.Drawing.Size(170, 43);
            this.btnAddDLL.TabIndex = 1;
            this.btnAddDLL.Text = "Add DLL file...";
            this.btnAddDLL.UseVisualStyleBackColor = true;
            this.btnAddDLL.Click += new System.EventHandler(this.AddDLL_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(7, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "&Default";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Default_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbRef);
            this.tabControl1.Controls.Add(this.tbDLL);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 330);
            this.tabControl1.TabIndex = 9;
            // 
            // tbRef
            // 
            this.tbRef.Controls.Add(this.panel1);
            this.tbRef.Location = new System.Drawing.Point(4, 22);
            this.tbRef.Name = "tbRef";
            this.tbRef.Padding = new System.Windows.Forms.Padding(3);
            this.tbRef.Size = new System.Drawing.Size(453, 304);
            this.tbRef.TabIndex = 0;
            this.tbRef.Text = "Global Assemblies";
            this.tbRef.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chGAC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 295);
            this.panel1.TabIndex = 0;
            // 
            // chGAC
            // 
            this.chGAC.AllowUserToAddRows = false;
            this.chGAC.AllowUserToDeleteRows = false;
            this.chGAC.AllowUserToResizeRows = false;
            this.chGAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.chGAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGlobalUse,
            this.colGlobalName,
            this.colGlobalComment});
            this.chGAC.Location = new System.Drawing.Point(0, 19);
            this.chGAC.MultiSelect = false;
            this.chGAC.Name = "chGAC";
            this.chGAC.RowHeadersVisible = false;
            this.chGAC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.chGAC.RowTemplate.DefaultCellStyle.NullValue = "-";
            this.chGAC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chGAC.Size = new System.Drawing.Size(447, 273);
            this.chGAC.TabIndex = 7;
            this.chGAC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.chGAC_CellValueChanged);
            // 
            // colGlobalUse
            // 
            this.colGlobalUse.FalseValue = "unused";
            this.colGlobalUse.HeaderText = "";
            this.colGlobalUse.Name = "colGlobalUse";
            this.colGlobalUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGlobalUse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGlobalUse.TrueValue = "used";
            this.colGlobalUse.Width = 20;
            // 
            // colGlobalName
            // 
            this.colGlobalName.HeaderText = "Name";
            this.colGlobalName.Name = "colGlobalName";
            this.colGlobalName.ReadOnly = true;
            this.colGlobalName.Width = 280;
            // 
            // colGlobalComment
            // 
            this.colGlobalComment.HeaderText = "Comment";
            this.colGlobalComment.Name = "colGlobalComment";
            this.colGlobalComment.Width = 120;
            // 
            // tbDLL
            // 
            this.tbDLL.Controls.Add(this.label2);
            this.tbDLL.Controls.Add(this.GridDLL);
            this.tbDLL.Controls.Add(this.btnAddDLL);
            this.tbDLL.Location = new System.Drawing.Point(4, 22);
            this.tbDLL.Name = "tbDLL";
            this.tbDLL.Padding = new System.Windows.Forms.Padding(3);
            this.tbDLL.Size = new System.Drawing.Size(453, 304);
            this.tbDLL.TabIndex = 3;
            this.tbDLL.Text = "Add Refrences";
            this.tbDLL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add DLL for adding refrence of compiler";
            // 
            // GridDLL
            // 
            this.GridDLL.AllowUserToAddRows = false;
            this.GridDLL.AllowUserToDeleteRows = false;
            this.GridDLL.AllowUserToResizeRows = false;
            this.GridDLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridDLL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDLL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.colName,
            this.colVersion,
            this.colCompany,
            this.colComment,
            this.colLocation});
            this.GridDLL.ContextMenuStrip = this.MenuGrid;
            this.GridDLL.Location = new System.Drawing.Point(3, 23);
            this.GridDLL.MultiSelect = false;
            this.GridDLL.Name = "GridDLL";
            this.GridDLL.RowHeadersVisible = false;
            this.GridDLL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridDLL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDLL.Size = new System.Drawing.Size(447, 228);
            this.GridDLL.TabIndex = 2;
            this.GridDLL.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDLL_CellValueChanged);
            // 
            // ColCheck
            // 
            this.ColCheck.FalseValue = "unused";
            this.ColCheck.HeaderText = "";
            this.ColCheck.IndeterminateValue = "";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCheck.TrueValue = "used";
            this.ColCheck.Width = 20;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 120;
            // 
            // colVersion
            // 
            this.colVersion.HeaderText = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.ReadOnly = true;
            this.colVersion.Width = 50;
            // 
            // colCompany
            // 
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.HeaderText = "Description";
            this.colComment.Name = "colComment";
            this.colComment.Width = 150;
            // 
            // colLocation
            // 
            this.colLocation.FillWeight = 50F;
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Visible = false;
            this.colLocation.Width = 150;
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "url.png");
            this.imageListTree.Images.SetKeyName(1, "namespace.png");
            this.imageListTree.Images.SetKeyName(2, "1426166641_dll.png");
            this.imageListTree.Images.SetKeyName(3, "icon_matlab.png");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(172, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(344, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // colGACComment
            // 
            this.colGACComment.HeaderText = "Comment";
            this.colGACComment.Name = "colGACComment";
            this.colGACComment.ReadOnly = true;
            // 
            // colGACChech
            // 
            this.colGACChech.FalseValue = "unused";
            this.colGACChech.HeaderText = "";
            this.colGACChech.Name = "colGACChech";
            this.colGACChech.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGACChech.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGACChech.TrueValue = "used";
            this.colGACChech.Width = 20;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 16);
            this.label3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select GAC Assembly to Add to Compiler";
            // 
            // FCompilerSettings
            // 
            this.AcceptButton = this.btnAddDLL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(640, 399);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCompilerSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler Settings";
            this.Load += new System.EventHandler(this.FCompilerSettings_Load);
            this.MenuGrid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbRef.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chGAC)).EndInit();
            this.tbDLL.ResumeLayout(false);
            this.tbDLL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuGrid;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
        private System.Windows.Forms.Button btnAddDLL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.TabPage tbDLL;
        private System.Windows.Forms.DataGridView GridDLL;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbRef;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGACComment;
        //private System.Windows.Forms.DataGridViewTextBoxColumn colGACNAme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGACChech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView chGAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addDLLFilesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGlobalUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGlobalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGlobalComment;
        private System.Windows.Forms.Label label1;
    }
}