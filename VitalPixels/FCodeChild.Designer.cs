using FC = FastColoredTextBoxNS;
using FastColoredTextBoxNS;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace VitalPixels
{
    partial class FCodeChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCodeChild));
            this.panelMessage = new System.Windows.Forms.Panel();
            this.txMessage = new System.Windows.Forms.RichTextBox();
            this.ctxMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Codepanel = new System.Windows.Forms.Panel();
            this.splitContainerCodeImage = new System.Windows.Forms.SplitContainer();
            this.txProgram = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.commentSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OutputsaveImageAsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMessage.SuspendLayout();
            this.ctxMessages.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Codepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCodeImage)).BeginInit();
            this.splitContainerCodeImage.Panel1.SuspendLayout();
            this.splitContainerCodeImage.Panel2.SuspendLayout();
            this.splitContainerCodeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txProgram)).BeginInit();
            this.contextMenuEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.txMessage);
            this.panelMessage.Controls.Add(this.panel2);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMessage.Location = new System.Drawing.Point(0, 427);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Padding = new System.Windows.Forms.Padding(1);
            this.panelMessage.Size = new System.Drawing.Size(704, 100);
            this.panelMessage.TabIndex = 0;
            // 
            // txMessage
            // 
            this.txMessage.ContextMenuStrip = this.ctxMessages;
            this.txMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txMessage.Location = new System.Drawing.Point(1, 28);
            this.txMessage.Name = "txMessage";
            this.txMessage.ReadOnly = true;
            this.txMessage.Size = new System.Drawing.Size(702, 71);
            this.txMessage.TabIndex = 4;
            this.txMessage.Text = "";
            this.txMessage.WordWrap = false;
            this.txMessage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txMessage_MouseDoubleClick);
            // 
            // ctxMessages
            // 
            this.ctxMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveToFileToolStripMenuItem,
            this.toolStripMenuItem10,
            this.clearToolStripMenuItem1});
            this.ctxMessages.Name = "ctxMessages";
            this.ctxMessages.Size = new System.Drawing.Size(163, 104);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToFileToolStripMenuItem.Image")));
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveMessages_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(159, 6);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem1.Image")));
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.CleanMessage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(702, 27);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(611, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CleanMessage_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(642, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SaveMessages_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(673, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Messages";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 424);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(704, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Codepanel
            // 
            this.Codepanel.Controls.Add(this.splitContainerCodeImage);
            this.Codepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Codepanel.Location = new System.Drawing.Point(0, 0);
            this.Codepanel.Name = "Codepanel";
            this.Codepanel.Size = new System.Drawing.Size(704, 424);
            this.Codepanel.TabIndex = 2;
            // 
            // splitContainerCodeImage
            // 
            this.splitContainerCodeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCodeImage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCodeImage.Name = "splitContainerCodeImage";
            // 
            // splitContainerCodeImage.Panel1
            // 
            this.splitContainerCodeImage.Panel1.Controls.Add(this.txProgram);
            // 
            // splitContainerCodeImage.Panel2
            // 
            this.splitContainerCodeImage.Panel2.AutoScroll = true;
            this.splitContainerCodeImage.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerCodeImage.Panel2.Controls.Add(this.pbOutput);
            this.splitContainerCodeImage.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainerCodeImage.Size = new System.Drawing.Size(704, 424);
            this.splitContainerCodeImage.SplitterDistance = 412;
            this.splitContainerCodeImage.TabIndex = 0;
            // 
            // txProgram
            // 
            this.txProgram.AutoCompleteBrackets = true;
            this.txProgram.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txProgram.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txProgram.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txProgram.BackBrush = null;
            this.txProgram.BackColor = global::VitalPixels.Properties.Settings.Default.EditorBackColor;
            this.txProgram.BookmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txProgram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txProgram.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txProgram.CharHeight = 14;
            this.txProgram.CharWidth = 8;
            this.txProgram.ContextMenuStrip = this.contextMenuEdit;
            this.txProgram.CurrentLineColor = System.Drawing.Color.Gainsboro;
            this.txProgram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txProgram.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txProgram.IsReplaceMode = false;
            this.txProgram.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txProgram.LeftBracket = '(';
            this.txProgram.LeftBracket2 = '{';
            this.txProgram.LineNumberColor = System.Drawing.Color.Gray;
            this.txProgram.Location = new System.Drawing.Point(0, 0);
            this.txProgram.Name = "txProgram";
            this.txProgram.Paddings = new System.Windows.Forms.Padding(0);
            this.txProgram.RightBracket = ')';
            this.txProgram.RightBracket2 = '}';
            this.txProgram.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txProgram.ServiceLinesColor = System.Drawing.Color.DarkGray;
            this.txProgram.ShowFoldingLines = global::VitalPixels.Properties.Settings.Default.EditorShowFolding;
            this.txProgram.ShowLineNumbers = global::VitalPixels.Properties.Settings.Default.EditorShowline;
            this.txProgram.Size = new System.Drawing.Size(412, 424);
            this.txProgram.SourceTextBox = this.txProgram;
            this.txProgram.TabIndex = 0;
            this.txProgram.Zoom = 100;
            // 
            // contextMenuEdit
            // 
            this.contextMenuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sallToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem8,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem9,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem11,
            this.commentSelectedTextToolStripMenuItem});
            this.contextMenuEdit.Name = "contextMenuEdit";
            this.contextMenuEdit.Size = new System.Drawing.Size(261, 176);
            // 
            // sallToolStripMenuItem
            // 
            this.sallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sallToolStripMenuItem.Image")));
            this.sallToolStripMenuItem.Name = "sallToolStripMenuItem";
            this.sallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.sallToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.sallToolStripMenuItem.Text = "Select all";
            this.sallToolStripMenuItem.Click += new System.EventHandler(this.SellectAll_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem8.Text = "Copy";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.Copy_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem6.Text = "Past";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.Past_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem7.Text = "Cut";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.Cut_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(257, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem5.Text = "Undo";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Undo_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem4.Text = "Redo";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Red_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(257, 6);
            // 
            // commentSelectedTextToolStripMenuItem
            // 
            this.commentSelectedTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commentSelectedTextToolStripMenuItem.Image")));
            this.commentSelectedTextToolStripMenuItem.Name = "commentSelectedTextToolStripMenuItem";
            this.commentSelectedTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.commentSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.commentSelectedTextToolStripMenuItem.Text = "Un/Comment Selected Text";
            this.commentSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedTextToolStripMenuItem_Click);
            // 
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.Color.White;
            this.pbOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOutput.BackgroundImage")));
            this.pbOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.ContextMenuStrip = this.contextMenuStripImage;
            this.pbOutput.Location = new System.Drawing.Point(49, 110);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(200, 200);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOutput.TabIndex = 0;
            this.pbOutput.TabStop = false;
            this.pbOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOutput_Paint);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OutputsaveImageAsTool,
            this.toolStripMenuItem2,
            this.clearToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(158, 54);
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImage_Opening);
            // 
            // OutputsaveImageAsTool
            // 
            this.OutputsaveImageAsTool.Enabled = false;
            this.OutputsaveImageAsTool.Image = ((System.Drawing.Image)(resources.GetObject("OutputsaveImageAsTool.Image")));
            this.OutputsaveImageAsTool.Name = "OutputsaveImageAsTool";
            this.OutputsaveImageAsTool.Size = new System.Drawing.Size(157, 22);
            this.OutputsaveImageAsTool.Text = "Save Image as...";
            this.OutputsaveImageAsTool.Click += new System.EventHandler(this.saveImageAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // FCodeChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 527);
            this.Controls.Add(this.Codepanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCodeChild";
            this.Tag = "Code";
            this.Text = "FCodeChild";
            this.Activated += new System.EventHandler(this.FCodeChild_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCodeChild_FormClosing);
            this.Load += new System.EventHandler(this.FCodeChild_Load);
            this.panelMessage.ResumeLayout(false);
            this.ctxMessages.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Codepanel.ResumeLayout(false);
            this.splitContainerCodeImage.Panel1.ResumeLayout(false);
            this.splitContainerCodeImage.Panel2.ResumeLayout(false);
            this.splitContainerCodeImage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCodeImage)).EndInit();
            this.splitContainerCodeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txProgram)).EndInit();
            this.contextMenuEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel Codepanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.RichTextBox txMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OutputsaveImageAsTool;
        internal System.Windows.Forms.Panel panelMessage;
        internal System.Windows.Forms.SplitContainer splitContainerCodeImage;
        private System.Windows.Forms.ContextMenuStrip ctxMessages;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem commentSelectedTextToolStripMenuItem;



        // Colored Editor
        internal FC.FastColoredTextBox txProgram;


    }
}