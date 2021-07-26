using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VPCompile;
using VitalPixels;

namespace RunVitalPixels
{
    public partial class MDIParentRunForm : Form
    {
        private int childFormNumber = 0;

        public MDIParentRunForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = 
                "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP) |*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp" +
                "|All Files (*.*)|*.*";

            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string item in openFileDialog.FileNames)
	            {
                    OpenImageFile(item);
	            }
            }
        }

        private void OpenImageFile(string fname)
        {
            FImageForm fimg = new FImageForm(fname);
            fimg.MdiParent = this;
            fimg.Text = "File: " + fname + "";
            fimg.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region WindowMenu
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           toolStripContainer1.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion WindowMenu

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild!=null)
            {
                if(MessageBox.Show("Are you sure to reset all program in image?","Warning",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    ((FImageForm)ActiveMdiChild).ResetImage();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ((FImageForm)ActiveMdiChild).SaveImage();
            }
        }

        private void PluginManagement_Click(object sender, EventArgs e)
        {
            VitalPixels.FPlugins fplug = new VitalPixels.FPlugins();
            fplug.ShowDialog();
        }

        #region HelpMenu
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            VitalPixels.FAbout fa = new VitalPixels.FAbout();
            fa.richTextBox1.Text = fa.richTextBox1.Text.Replace("Design Environment",
                "Runtime Environment");;
            fa.ShowDialog();
        }



        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vitalpixels.com/REPORTBUG");

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vitalpixels.com/help/");

        }
        #endregion HelpMenu

        private void MDIParentRunForm_Load(object sender, EventArgs e)
        {
            VitalPixels.MDIMainForm ide = new VitalPixels.MDIMainForm();
            ide.LoadPlugin(PluginMenu, toolStripPlugin,ClickPlugin,true);
        }

        /// <summary>
        /// Run Plug-in
        /// </summary>
        /// <param name="sender">Menu or toolbar</param>
        /// <param name="e"></param>
        private void ClickPlugin(object sender, EventArgs e)
        {
            if (ActiveMdiChild==null) return;

            FImageForm imageForm = (FImageForm)ActiveMdiChild;

            string PluginName = Application.StartupPath + "\\Plugins\\";

            PluginName += ((ToolStripItem)sender).Tag.ToString();

            VPCompile.Compiler vc = new VPCompile.Compiler();

            VitalPixels.FRunPlugin fr = new VitalPixels.FRunPlugin(PluginName);

            if (fr.ShowDialog() == DialogResult.OK)
            {
                string ErrorMessage;
                Stopwatch sww = new Stopwatch();

                sww.Start();
                imageForm.pbImage.Image =
                    //Run Code
                    vc.RunCodePlugin(PluginName, ((FImageForm)(ActiveMdiChild)).pbImage.Image, 
                    fr.MainParameters, out  ErrorMessage);


                sww.Stop();

                imageForm.pbImage.Refresh();
                imageForm.StatusRunMessage.Text = ErrorMessage;
                imageForm.toolStripStatusTime.Text = "Run in : " + sww.ElapsedMilliseconds + "ms";

               
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild))== null) return;

            PrintDialog pd = new PrintDialog();

            if (pd.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument1 = new PrintDocument();

                printDocument1.PrintPage += new PrintPageEventHandler(printImages_PrintPage);
                printDocument1.Print();
            }
        }
        private void printImages_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image img = ((FImageForm)ActiveMdiChild).pbImage.Image;

            Font fn = new Font("Tahoma", 8);
            //e.Graphics.DrawString("Input Image",
            //  fn, Brushes.Gray, 20, 5, StringFormat.GenericDefault);

            //e.Graphics.DrawString("Output Image",
            //  fn, Brushes.Gray, 20, 535, StringFormat.GenericDefault);

          //  e.Graphics.DrawImage(img, 20, 20, img.Width, img.Height);

            if (img != null)
                e.Graphics.DrawImage(img, 20, 20, img.Width, img.Height);

            //e.Graphics.DrawRectangle(Pens.Gray, 20, 20, 512, 512);
            //e.Graphics.DrawRectangle(Pens.Gray, 20, 550, 512, 512);

            StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            fn = new Font("Times New Roman", 8, FontStyle.Bold);
            e.Graphics.DrawString(
                ((FImageForm)(this.ActiveMdiChild)).Text + Environment.NewLine +
                "Vital Pixels - http://www.vitalpixels.com ", fn, Brushes.Gray, 750, 20, drawFormat);
        }
    }
}
