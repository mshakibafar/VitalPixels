using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPFilter;
using fft=VitalPixels;
using upd=UpdateVP;


namespace VitalPixels
{

    public partial class MDIMainForm : Form
    {
        #region Properties
        //   private Config.PluginProperty OwnPlugin = new Config.PluginProperty();

        private int childFormNumber = 0;
        internal ModeEdit CurrentMode = ModeEdit.None;
        List<Control> ImageButtons= new List<Control>();
        private FFind findForm;
        private FSplash fs;
        private string SampleFile = "Sample.jpg";
        private string InitalOpenFolder = Path.Combine(
                Environment.ExpandEnvironmentVariables("%UserProfile%"),
                "Documents", "VitalPixels", "Samples");

      //  private System.Drawing.Imaging.ImageFormat ImageFormat;

        public enum ModeEdit
        {
            None,
            Crop,
            StartDrag
        }

        public enum PageType
        {
            Photo,
            SemiCode,
            FullCode
        }

        #endregion


        #region Constructors
        public MDIMainForm()
        {
            InitializeComponent();

        }

        public MDIMainForm(string[] fname,FSplash fs)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            foreach (string f in fname)
            {
                OpenFile(f);
            }
            this.fs = fs;

        }

        public MDIMainForm(FSplash fs)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            this.fs = fs;
        }
        #endregion

        #region FIELMENU

        #region OPEN
        public void OpenFileClick(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = InitalOpenFolder;

            op.Filter = "All supported file:(*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP,*.vp,*.cs)|*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp;*.vp;*.cs" +
                "|Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP) |*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp"+
                "|Semi code file (*.vp)|*.vp"+
                "|C# code file (*.cs)|*.cs";

            op.Title = "Open file";

            if (op.ShowDialog() == DialogResult.OK)
            {
                foreach (string fname in op.FileNames)
                {
                    OpenFile(fname);
                    Properties.Settings.Default.LastFile = fname;
                }
                FillEmptySample();
                InitalOpenFolder = Path.GetDirectoryName(op.FileName);
            }
           
        }


        /// <summary>
        /// Open File in Code and image
        /// </summary>
        /// <param name="fname">Filename</param>
        public void OpenFile(string fname,bool JustSample=false)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text.Replace("*", "") == "File: " + fname)
                {
                    toolStripStatusLabel.Text = fname + " has opened before and software active it again";
                    item.Activate();
                    return;
                }
            }

            FCodeChild fcc;
            FileInfo fi = new FileInfo(fname);

            if (fi.Extension.ToLower() == ".vp" || fi.Extension.ToLower() == ".cs")
            {
                fcc = OpenCodeFile(fname);
            }
            else
            {
                if (JustSample == false)
                {
                    FImageSource childForm = new FImageSource(fname, this);

                    childForm.MdiParent = this;
                    childForm.Text = "File: " + fname + "";
                    childForm.Show();
                    childForm.AllAlignCenter();
                }
                else
                {
                    ImageProperty imgPro = new ImageProperty(fname);
                    propertyGridMain.SelectedObject = imgPro;
                }
                pbTinySource.Image = Image.FromFile(fname);
            }
            toolSave.Enabled = false;
            ToolPrint.Enabled = true;
        }
        /// <summary>
        /// Open Code file VP or CS
        /// </summary>
        /// <param name="fname">FileName</param>
        /// <returns></returns>
        private FCodeChild OpenCodeFile(string fname)
        {
            FCodeChild fcc;
            string TitleText = "File: " + fname;
            FileInfo fi = new FileInfo(fname);

            try
            {
                if (!File.Exists(fname))
                {
                    if (fi.Extension.ToLower() == ".cs")
                    {
                        string CodeText =
                           "using System.Reflection;" + Environment.NewLine +
                           "using System.Drawing;" + Environment.NewLine +
                           "using System.Drawing.Imaging;" + Environment.NewLine +
                           "using System.Drawing.Drawing2D;" + Environment.NewLine +
                           "using System;" + Environment.NewLine +
                           "using System.Collections.Generic;" + Environment.NewLine +
                           "using System.Text;" + Environment.NewLine +
                           "using System.Threading.Tasks;" + Environment.NewLine +
                            "   " + Environment.NewLine +
                           "namespace VPPlugin" + Environment.NewLine +
                           "{" + Environment.NewLine +
                           "    public class MyPlugin" + Environment.NewLine +
                           "   {" + Environment.NewLine +
                           "      public Image OutPlugin(Image InputImage,out string argMessage)" + Environment.NewLine +
                           "     {" + Environment.NewLine +
                           "    " + Environment.NewLine +
                           "          Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);" + Environment.NewLine +
                           "         /// TO DO Program" + Environment.NewLine +
                           "     " + Environment.NewLine +
                           "" + Environment.NewLine +
                           "" + Environment.NewLine +
                           "" + Environment.NewLine +
                           "         argMessage =\"Message\"; // TO DO External Message" + Environment.NewLine +
                           "         return (Image)OutputImage;" + Environment.NewLine +
                           "     }" + Environment.NewLine +
                           "" + Environment.NewLine +
                           "    }" + Environment.NewLine +
                           "}";

                        File.WriteAllText(fname, CodeText);
                    }
                    else
                    {
                        File.WriteAllText(fname, "// TODO Semi-code");
                    }

                    //  tx.Close();
                }
                else
                {
                    string AllFile = File.ReadAllText(fname);
                    string imgfile=ExtractImageFileName(AllFile);

                    if(imgfile.Trim().Length>0)
                    if (Path.GetDirectoryName(imgfile).Length == 0)
                        imgfile = Path.GetDirectoryName(fname) + "\\" + imgfile;

                    if (imgfile != "")
                    {
                        if (imgfile == fname)
                            MessageBox.Show("Image File and Filename are same","Warning",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
                        else
                        {
                            if (File.Exists(imgfile))
                            {
                                OpenFile(imgfile, true);
                                propertyGridMain.Refresh();
                            }
                            else
                            {
                                MessageBox.Show(
                                    imgfile + 
                                    " couldn't be found. Please change or remove image address in #image <filename>",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                fcc = new FCodeChild(fname, this);

                fcc.MdiParent = this;
                fcc.Text = TitleText;

                if (fi.Extension.ToLower() == ".cs")
                    fcc.Tag = (object)"Plugin";
                else
                    fcc.Tag = (object)"Code";

                //toolSave.Enabled

                fcc.Show();

               
                toolStripStatusLabel.Text = fname + " has opened";

            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = ex.ToString();
                fcc = null;
            }

            return fcc;
        }

        private string ExtractImageFileName(string code)
        {
            string result = "";

            if (code.IndexOf("#image") < 0) return "";

            for (int i = code.IndexOf("#image") + 7; i < code.Length; i++)
            {
                if ((code[i]) == '>') break;

                result += code[i];

            }

            result = result.Replace("<", "");

            return result;
        }
        private void OpenWelcomeForm()
        {
            FWelcomeForm fcc = new FWelcomeForm(this);

            fcc.MdiParent = this;

            fcc.Show();

            statusStrip.Text = "Welcome to Vital Pixels";
        }

        public void FillEmptySample()
        {
            if (Properties.Settings.Default.OpenSampleImage == false) return;

            if (pbTinySource.Image == null)
                if (File.Exists(SampleFile) == true)
                {
                    OpenFile(SampleFile, true);
                    propertyGridMain.Refresh();
                }
        }
        #endregion
        private void toolSave_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image")
                //  ||((Form)(this.ActiveMdiChild)).Tag.ToString() == "Plugin")
                ((FCodeChild)(this.ActiveMdiChild)).SaveCode(sender, e);

            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image")
            {
                SaveFileDialog SV = new SaveFileDialog();
                SV.Filter = "Image files (*.png) |*.png";
                SV.DefaultExt = "PNG";
                if (SV.ShowDialog() == DialogResult.OK)
                {
                    ((FImageSource)(this.ActiveMdiChild)).pbInput.Image.Save(SV.FileName,
                        System.Drawing.Imaging.ImageFormat.Png);
                }
            }

        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sv = new SaveFileDialog();

            if (((Form)this.ActiveMdiChild).Tag.ToString() == "Image")
            {
                Sv.Filter = "All Image files:(*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP)|*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp;";
                if (Sv.ShowDialog() == DialogResult.OK)
                    ((FImageSource)this.ActiveMdiChild).pbInput.Image.Save(Sv.FileName);
            }
            else
            {
                Sv.Filter = "VP File(*.vp)|*.vp;|C Sharp file (*.cs)|*.cs";
                FileInfo fi = new FileInfo(((FCodeChild)this.ActiveMdiChild).FileName);


                if (fi.Extension.ToUpper() == ".CS")
                {
                    Sv.FilterIndex = 2;
                }

                if (Sv.ShowDialog() == DialogResult.OK)
                    ((FCodeChild)this.ActiveMdiChild).txProgram.SaveToFile(Sv.FileName, Encoding.ASCII);
            }

        }

        // Print Images
        private void printImages_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fn = new Font("Tahoma", 8);
            e.Graphics.DrawString("Input Image",
              fn, Brushes.Gray, 20, 5, StringFormat.GenericDefault);

            e.Graphics.DrawString("Output Image",
              fn, Brushes.Gray, 20, 535, StringFormat.GenericDefault);

            e.Graphics.DrawImage(((FImageSource)(this.ActiveMdiChild)).pbInput.Image, 20, 20, 512, 512);

            if (((FImageSource)(this.ActiveMdiChild)).pbOutput.Image != null)
                e.Graphics.DrawImage(((FImageSource)(this.ActiveMdiChild)).pbOutput.Image, 20, 550, 512, 512);

            e.Graphics.DrawRectangle(Pens.Gray, 20, 20, 512, 512);
            e.Graphics.DrawRectangle(Pens.Gray, 20, 550, 512, 512);

            StringFormat drawFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            fn = new Font("Times New Roman", 8, FontStyle.Bold);
            e.Graphics.DrawString(
                ((FImageSource)(this.ActiveMdiChild)).Text + Environment.NewLine +
                "Vital Pixels - http://www.vitalpixels.com ", fn, Brushes.Gray, 750, 20, drawFormat);
        }
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void NewMenu_Click(object sender, EventArgs e)
        {
            FNewWin fn = new FNewWin(childFormNumber);
            childFormNumber++;

            if (fn.ShowDialog() == DialogResult.OK)
            {
                OpenFile(fn.FileName);
            }
        }
        // Print Button CLick
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image")
                ((FCodeChild)(this.ActiveMdiChild)).PrintCode(sender, e);
            else
            {
                PrintDialog pd = new PrintDialog();

                if (pd.ShowDialog() == DialogResult.OK)
                {
                    PrintDocument printDocument1 = new PrintDocument();

                    printDocument1.PrintPage += new PrintPageEventHandler(printImages_PrintPage);
                    printDocument1.Print();
                }
            }
        }

        #endregion
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripContainer1.Visible = toolBarToolStripMenuItem.Checked;
        }

        #region WindowMenu
        private void AllCenter_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            ((FImageSource)(this.ActiveMdiChild)).AllAlignCenter();
        }

        private void FitToScreen_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            ((FImageSource)(this.ActiveMdiChild)).FitToScreen("Input");
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

        #endregion
        // Align property grid to down
        #region ControlWindows
        private void splitterLeft_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                double W = ((FImageSource)(this.ActiveMdiChild)).InputImage.Width;
                double H = ((FImageSource)(this.ActiveMdiChild)).InputImage.Height;
                double Scale = ((double)pbTinySource.Height) / ((double)H);
                int S = (int)(Scale * W);

                splitterLeft.SplitPosition = S;
                ((FImageSource)(this.ActiveMdiChild)).AllAlignCenter();
            }
            catch
            {

            }
        }


        // Align property grid to left
        private void splitterPreview_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                double W = ((FImageSource)(this.ActiveMdiChild)).InputImage.Width;
                double H = ((FImageSource)(this.ActiveMdiChild)).InputImage.Height;
                double Scale = ((double)pbTinySource.Width) / ((double)W);
                int S = (int)(Scale * H);

              //  splitterPreview.SplitPosition = S;
            }
            catch
            {

            }
        }

        internal void CommitChange(object sender, EventArgs e)
        {
             ((FImageSource)(this.ActiveMdiChild)).InputImage =
             ((FImageSource)(this.ActiveMdiChild)).pbInput.Image;

             toolCommit.Enabled = false;
             toolResetImage.Enabled = false;
             ((FImageSource)(this.ActiveMdiChild)).RefreshData();
    
             propertyGridMain.Refresh();
        }

        // NEW File Click


        private void ChangeChildActivated(object sender, EventArgs e)
        {
            try
            {
                if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Welcome")
                {
                    NoWindowOpen();
                    return;
                }

                if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image")
                {
                    // if its is code
                    foreach (ToolStripItem item in ImageMenu.DropDownItems)
                        item.Enabled = false;
                    foreach (ToolStripItem item in FilterMenu.DropDownItems)
                        item.Enabled = false;
                    foreach (ToolStripItem item in BuildMenu.DropDownItems)
                        item.Enabled = true;
                    foreach (ToolStripItem item in PluginMenu.DropDownItems)
                        if (item.Name != "addPluginToolStripMenuItem")
                            item.Enabled = false;

                    toolStripCommit.Enabled = false;
                    toolStripCompile.Enabled = true;
                    toolStripAnalysis.Enabled = true;
                    toolStripPlugin.Enabled = false;

                    toolMoveCenter.Enabled = false;
                    toolFittoScreen.Enabled = false;
                    findToolStripMenuItem.Enabled = true;
                    gotoLineNumberToolStripMenuItem.Enabled = true;
                    clearBookmarksToolStripMenuItem.Enabled = true;

                    //foreach (Control btns  in this.Controls.Find("tool",true))
                    //{
                    //    try
                    //    {
                    //        if (btns.Tag.ToString().ToUpper() != "IMAGEBUTTON")
                    //        {
                    //            btns.Enabled = true;
                    //        }
                    //        else
                    //        {
                    //            btns.Enabled = false;
                    //        }
                    //    }
                    //    catch
                    //    { 
                    //        // if has not any tag
                    //    }
                    //}

                }
                else
                {
                    // if it is image
                    foreach (ToolStripItem item in ImageMenu.DropDownItems)
                        item.Enabled = true;
                    foreach (ToolStripItem item in FilterMenu.DropDownItems)
                        item.Enabled = true;
                    foreach (ToolStripItem item in BuildMenu.DropDownItems)
                        item.Enabled = false;

                    foreach (ToolStripItem item in PluginMenu.DropDownItems)
                        if (item.Name != "addPluginToolStripMenuItem")
                            item.Enabled = true;

                    toolStripCompile.Enabled = false;
                    toolStripAnalysis.Enabled = true;
                    toolStripCommit.Enabled = true;
                    toolStripPlugin.Enabled = true;
                    toolMoveCenter.Enabled = true;
                    toolFittoScreen.Enabled = true;
                    findToolStripMenuItem.Enabled = false;
                    gotoLineNumberToolStripMenuItem.Enabled = false;
                    clearBookmarksToolStripMenuItem.Enabled = false;

                    //foreach (Control btns in this.men)
                    //{
                    //    try
                    //    {
                    //        if (btns.Tag.ToString().ToUpper() == "IMAGEBUTTON")
                    //        {
                    //            btns.Enabled = true;
                    //        }
                    //        else
                    //        {
                    //            btns.Enabled = false;
                    //        }
                    //    }
                    //    catch
                    //    {
                    //        // if has not any tag
                    //    }
                    //}
                }
                // Common button

                //foreach (Control btns in this.Controls)
                //{
                //    try
                //    {
                //        if (btns.Tag.ToString().ToUpper() == "COMMONBUTTON")
                //        {
                //            btns.Enabled = true;
                //        }
                //    }
                //    catch
                //    {
                //        // if has not any tag
                //    }
                //}
                MenuPrintItem.Enabled = true;
                MenuSaveasItem.Enabled = true;
                MenuSaveItem.Enabled = true;
                foreach (ToolStripItem item in analysisMenu.DropDownItems)
                    item.Enabled = true;

            }
            catch
            {
                // if no window opened
                foreach (ToolStripItem item in ImageMenu.DropDownItems)
                    item.Enabled = false;
                foreach (ToolStripItem item in FilterMenu.DropDownItems)
                    item.Enabled = false;
                foreach (ToolStripItem item in BuildMenu.DropDownItems)
                    item.Enabled = false;
                foreach (ToolStripItem item in analysisMenu.DropDownItems)
                    item.Enabled = false;

                foreach (ToolStripItem item in PluginMenu.DropDownItems)
                    if (item.Name != "addPluginToolStripMenuItem")
                        item.Enabled = false;

                toolStripCompile.Enabled = false;
                toolStripAnalysis.Enabled = false;
                toolStripCommit.Enabled = false;
                toolStripPlugin.Enabled = false;
                ToolPrint.Enabled = false;


                MenuPrintItem.Enabled = false;
                MenuSaveasItem.Enabled = false;
                MenuSaveItem.Enabled=false;

                toolMoveCenter.Enabled = false;
                toolFittoScreen.Enabled = false;

                pbTinySource.Image = null;
                propertyGridMain.SelectedObject = null;

            }
        }
        //if source image change this method will be run
        internal void SourceChanged()
        {
            toolCommit.Enabled = true;
            toolSave.Enabled = true;
            toolResetImage.Enabled = true;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image;
        }
        #endregion

        #region ImageMenu
        private void InvertColor_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.InvertColor(((FImageSource)(this.ActiveMdiChild)).InputImage);
            SourceChanged();

        }
        private void greyStyle_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.GreyStyle(((FImageSource)(this.ActiveMdiChild)).InputImage);

            SourceChanged();
        }

        private void colorsToRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.ColorRGBImage(((FImageSource)(this.ActiveMdiChild)).InputImage
             ,VPFilter.FilterImage.RGB.Red);


            SourceChanged();
        }

        private void colorsToGreen_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.ColorRGBImage(((FImageSource)(this.ActiveMdiChild)).InputImage
             , VPFilter.FilterImage.RGB.Green);

            SourceChanged();
        }

        private void colorsToBlue_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.ColorRGBImage(((FImageSource)(this.ActiveMdiChild)).InputImage
             , VPFilter.FilterImage.RGB.Blue);


            SourceChanged();
        }

        private void changeBrighness_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FBrightnes fb = new VitalPixels.FBrightnes(pbTinySource.Image,
                VitalPixels.FBrightnes.TypeChange.Brightness);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.SetBrightness(((FImageSource)(this.ActiveMdiChild)).pbInput.Image
                 , fb.brValue.Value);

                //pbMain.Image = VPF.FilterImage.SetBrightness(CurrentSourceImage.MainImage,
                //        fb.brValue.Value);
                SourceChanged();
            }
        }
       

        private void ResetImagetoDefault(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                ((FImageSource)(this.ActiveMdiChild)).InputImage;
            toolCommit.Enabled = false;
            toolResetImage.Enabled = false;
            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image;
        }

        private void ChangeContrast_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FBrightnes fb = new VitalPixels.FBrightnes(pbTinySource.Image,
                VitalPixels.FBrightnes.TypeChange.Contrast);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.SetContrast(((FImageSource)(this.ActiveMdiChild)).pbInput.Image
                 , fb.brValue.Value);

                SourceChanged();
            }
        }

        private void gamma_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FGamma fb = new VitalPixels.FGamma(pbTinySource.Image,
                VitalPixels.FGamma.FormTask.GammaChange);
            if (fb.ShowDialog() == DialogResult.OK)
            {

                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.SetGamma(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
                  ((double)fb.trackBarRed.Value) / 10, 
                  ((double)fb.trackBarGreen.Value) / 10,
                  ((double)fb.trackBarBlue.Value / 10));

                SourceChanged();
            }
        }

        private void degreeVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

           pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
             VPFilter.FilterImage.RotateFlip(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
             RotateFlipType.Rotate180FlipX);

           SourceChanged();
        }

        private void degreeHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
              VPFilter.FilterImage.RotateFlip(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
              RotateFlipType.Rotate180FlipY);

            SourceChanged();
        }

        private void degreeRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
              VPFilter.FilterImage.RotateFlip(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
              RotateFlipType.Rotate90FlipX);

            SourceChanged();
        }

        private void degreeLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
              VPFilter.FilterImage.RotateFlip(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
              RotateFlipType.Rotate270FlipX);

            SourceChanged();
        }

        private void setTargetAsASource_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            if (((FImageSource)(this.ActiveMdiChild)).pbOutput.Image == null) return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                  ((FImageSource)(this.ActiveMdiChild)).pbOutput.Image;
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image")
            {
                FHistogram fh = new FHistogram(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
                    ((FImageSource)(this.ActiveMdiChild)).pbOutput.Image);
                fh.ShowDialog();
            }
            else
            {
                FHistogram fh = new FHistogram(pbTinySource.Image,
                    ((FCodeChild)(this.ActiveMdiChild)).pbOutput.Image);
                fh.ShowDialog();
            }
        }

        private void toolStripCrop_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;
            
            if(toolCommit.Enabled)
            {
                if (MessageBox.Show("Do you want to commit changes?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    CommitChange(sender, e);
                else
                    return;
            }
            ((FImageSource)(this.ActiveMdiChild)).pbInput.Width =
                ((FImageSource)(this.ActiveMdiChild)).InputImage.Width;

            ((FImageSource)(this.ActiveMdiChild)).pbInput.Height =
               ((FImageSource)(this.ActiveMdiChild)).InputImage.Height;

            
            if (toolStripCrop.Checked)
            {
                CurrentMode = ModeEdit.Crop;
                ((FImageSource)(this.ActiveMdiChild)).pbInput.Cursor = Cursors.Cross;
            }
            else
            {
                CurrentMode = ModeEdit.None;
                ((FImageSource)(this.ActiveMdiChild)).pbInput.Cursor = Cursors.Arrow;
            }
        }
      
        private void findEdge_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;
            Image img=VPFilter.FilterImage.FindEdges(((FImageSource)(this.ActiveMdiChild)).pbInput.Image);

            if (img != null)
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image=img;
            else
                MessageBox.Show("Error");
                

            SourceChanged();
        }

        private void addNoise_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FBrightnes fb = new VitalPixels.FBrightnes(pbTinySource.Image,
                VitalPixels.FBrightnes.TypeChange.AddNoise);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.AddNoise(((FImageSource)(this.ActiveMdiChild)).pbInput.Image
                 , fb.brValue.Value);

                SourceChanged();
            }
        }

        private void Mosaic_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FBrightnes fb = new VitalPixels.FBrightnes(pbTinySource.Image,
                VitalPixels.FBrightnes.TypeChange.Mosaic);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.Mosaic(((FImageSource)(this.ActiveMdiChild)).pbInput.Image
                 , fb.brValue.Value);

                SourceChanged();
            }
        }

        /// <summary>
        /// Blur Image Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlurImage_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image =
            ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                VPFilter.FilterImage.BlurImage(((FImageSource)(this.ActiveMdiChild)).pbInput.Image);

            SourceChanged();
        }

        private void colorsAnalysis_Click(object sender, EventArgs e)
        {
            if (pbTinySource.Image != null)
            {
                VitalPixels.FColorLab fLab = new VitalPixels.FColorLab(
                    pbTinySource.Image,false);
                fLab.ShowDialog();
            }
        }

        private void allColors_Click(object sender, EventArgs e)
        {
            if (pbTinySource.Image != null)
            {
                VitalPixels.FAllColors fa = new VitalPixels.FAllColors(pbTinySource.Image);
                fa.ShowDialog();
            }
        }

        private void chartAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VitalPixels.FChart fc = new VitalPixels.FChart(pbTinySource.Image);
            fc.ShowDialog();
        }
        #endregion


        #region CompileMenu
        private void toolCompile_Click(object sender, EventArgs e)
        {
            // it is not supported for Images
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image") return;

            // Clear message window
            ((FCodeChild)(this.ActiveMdiChild)).txMessage.Text = "";

            //Save Code
            toolSave_Click(sender, e);
            ((FCodeChild)(this.ActiveMdiChild)).AppendText("Compile has started.", Color.Black);


            StringBuilder MainCode= new StringBuilder(((FCodeChild)(this.ActiveMdiChild)).txProgram.Text) ;
            StringBuilder ErrorMsg= new StringBuilder();
            VPCompile.Compiler VCompiler = new VPCompile.Compiler(MainCode,
                    Properties.Settings.Default.MatLabImportFile);

            StringBuilder ErrMessage= new StringBuilder();
            Color ERRColor = new Color();
            
            /* //FOR TEST
            MessageBox.Show(
            VCompiler.GetUsingString());  */

            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Code")
            {
                if (VCompiler.CompileSemiCode(out ErrMessage))
                    ERRColor = Color.Red;
                else
                    ERRColor = Color.Blue;

                ((FCodeChild)(this.ActiveMdiChild)).AppendText(ErrMessage.ToString() , ERRColor);
            }
            else
            {
                string fname = ((FCodeChild)(this.ActiveMdiChild)).FileName;

                if (Properties.Settings.Default.MatLabImportFile)
                {
                    MainCode.Insert(0, "using MatLab;"+Environment.NewLine);
                    MainCode.Insert(0, "using MathWorks.MATLAB.NET.Arrays;" + Environment.NewLine);
                    MainCode.Insert(0, "using MathWorks.MATLAB.NET.Utility;" + Environment.NewLine);
                }

                if(VCompiler.CompileFullCode(out MainCode, Application.StartupPath+"\\CodeLab.cs"))
                    ERRColor = Color.Red;
                else
                    ERRColor = Color.Blue;

                ((FCodeChild)(this.ActiveMdiChild)).AppendText(MainCode.ToString(), ERRColor);
            }

        }
        // Run Program
        private void toolRun_Click(object sender, EventArgs e)
        {
            bool Result=false;
            StringBuilder MainCode;
            Color ERRColor = new Color();
            VPCompile.Compiler VCompiler ;
            StringBuilder ErrMessage = new StringBuilder();

            //  if active window is a code
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image")
            {
                // Clear message window
                ((FCodeChild)(this.ActiveMdiChild)).txMessage.Text = "";

                // Save code
               // toolSave_Click(sender, e);
                if (File.Exists(Application.StartupPath + "\\CodeLab.dll"))
                    File.Delete(Application.StartupPath + "\\CodeLab.dll");

                toolCompile_Click(sender, e);

                if (File.Exists(Application.StartupPath + "\\CodeLab.dll") == false)
                    return;

                //if (File.Exists(Application.StartupPath + "\\MatLab\\src\\MatLab.dll"))
                //    File.Copy(Application.StartupPath + "\\MatLab\\src\\MatLab.dll",
                //        Application.StartupPath + "\\MatLab.dll",true);

                MainCode= new StringBuilder(((FCodeChild)(this.ActiveMdiChild)).txProgram.Text);

                VCompiler=new VPCompile.Compiler(MainCode,Properties.Settings.Default.MatLabImportFile);
                ((FCodeChild)(this.ActiveMdiChild)).AppendText(ErrMessage.ToString(), ERRColor);

                //if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Code")
                //     Result = VCompiler.CompileSemiCode(out ErrMessage);
                //else
                //     Result = VCompiler.CompileFullCode(out ErrMessage,
                //        ((FCodeChild)(this.ActiveMdiChild)).FileName);


                //if (Result)
                //{
                //    ERRColor = Color.Red;
                //    ((FCodeChild)(this.ActiveMdiChild)).pbOutput.Image = null;
                //}
                //else
                //    ERRColor = Color.Blue;

                //((FCodeChild)(this.ActiveMdiChild)).AppendText(ErrMessage.ToString(), ERRColor);
            }
            else
                VCompiler = new VPCompile.Compiler();


            if (Result == false)
            {
                // if no image has selected
                if (propertyGridMain.SelectedObject == null)
                {
                    MessageBox.Show("No image has selected yet! please click on preview image to choose.",
                        "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ((FCodeChild)(this.ActiveMdiChild)).AppendText(
                        "No image has selected yet! please click on preview image to choose."
                        , Color.Red);

                    return;
                }

                //Continue if image has selected
                string MSG;
                string OutMessage = "";
                Image Output=null;
                string fname=((FCodeChild)(this.ActiveMdiChild)).FileName;
                FileInfo fi= new FileInfo(((FCodeChild)(this.ActiveMdiChild)).FileName);

                Stopwatch sww = new Stopwatch();
                sww.Start();
                Image img =(Image) pbTinySource.Image.Clone();

                if(((Form)(this.ActiveMdiChild)).Tag.ToString()=="Code")
                    Output = VCompiler.RunCodeLabProgram(Application.StartupPath + "\\CodeLab.dll",
                        img, out MSG, out OutMessage);
                else
                    Output = VCompiler.RunCodeLabProgram(
                       Application.StartupPath + "\\CodeLab.dll",
                        img, out MSG, out OutMessage);

                sww.Stop();

                ((FCodeChild)(this.ActiveMdiChild)).OutputsaveImageAsTool.Enabled = true;
                if (Output == null)
                    ERRColor = Color.Red;
                else
                    ERRColor = Color.Green;

                if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image")
                {
                    ((FCodeChild)(this.ActiveMdiChild)).AppendText(MSG.ToString(), ERRColor);

                    if (Output != null)
                        ((FCodeChild)(this.ActiveMdiChild)).pbOutput.Image = Output;
                    else
                        ((FCodeChild)(this.ActiveMdiChild)).pbOutput.Image = null;

                    // Property grid
                    ImageProperty.ImageInfoResult ii=ImageProperty.CalculateImageInfo(pbTinySource.Image,
                        ((FCodeChild)(this.ActiveMdiChild)).pbOutput.Image, ImageProperty.RGB.RGB);

                    ((ImageProperty)propertyGridMain.SelectedObject)._SNR = ii.SNR;
                    ((ImageProperty)propertyGridMain.SelectedObject)._PSNR = ii.PSNR;
                    ((ImageProperty)propertyGridMain.SelectedObject)._ColorOutput = ii.NumberofColors;
                    ((ImageProperty)propertyGridMain.SelectedObject)._RunTime = sww.ElapsedMilliseconds;

                    if (OutMessage.Trim().Length > 0)
                    {
                        ((FCodeChild)(this.ActiveMdiChild)).AppendText(OutMessage,
                            Color.DarkOrchid, false);
                        string[] str = OutMessage.Split('=');
                        ImageProperty.MyCustomName = str[0];
                        if(str.Length>1)
                            ((ImageProperty)propertyGridMain.SelectedObject)._MyProperty = str[1];
                    }

                    propertyGridMain.Refresh();
                }
                else
                    ((FImageSource)(this.ActiveMdiChild)).pbOutput.Image=Output;
            }
        }

        private void toolPlugin_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image") return;

            toolSave_Click(sender, e);

            StringBuilder sb = new StringBuilder();
            sb.Append(((FCodeChild)(this.ActiveMdiChild)).txProgram.Text);
                        string fname = ((FCodeChild)(this.ActiveMdiChild)).FileName;

            VPCompile.Compiler VCompiler = new VPCompile.Compiler(sb,Properties.Settings.Default.MatLabImportFile);

            VitalPixels.CodeLab.FBuildPlugin fbp = new VitalPixels.CodeLab.FBuildPlugin(fname);

            if (fbp.ShowDialog() == DialogResult.OK)
            {
                StringBuilder msg= new StringBuilder();
                bool Res=false;
                string CodeFileName=((FCodeChild)(this.ActiveMdiChild)).FileName;
                string FdllName = Application.StartupPath + "\\Plugins\\" + fbp.txTitle.Text;

                // Check if file exists
                if (File.Exists(FdllName + ".dll"))
                {
                    if (MessageBox.Show("Plugin \""+fbp.txTitle.Text.Trim() +
                        "\" is already exits . Are you sure to replace it?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                /// Compile here
                if (((FCodeChild)(this.ActiveMdiChild)).Tag.ToString() == "Code")
                {
                     Res = VCompiler.CompileSemiCode(out msg,
                        fbp.txTitle.Text, fbp.txDescription.Text,
                        fbp.txProduct.Text, fbp.txVersion.Text,
                        Application.StartupPath + "\\Plugins\\" + fbp.txTitle.Text);
                   
                }
                else
                {
                     Res = VCompiler.CompileFullCode(out msg,
                        Application.StartupPath + "\\Plugins\\" + fbp.txTitle.Text, fbp.txDescription.Text,
                         fbp.txDescription.Text, fbp.txProduct.Text,
                        fbp.txVersion.Text);
                }
                // end of compile


                // Show and extract result and errors
                if (Res == true)
                {
                    ((FCodeChild)(this.ActiveMdiChild)).AppendText(msg.ToString(), Color.Red);
                    ((FCodeChild)(this.ActiveMdiChild)).AppendText("Some error occurred in building the plug-in",
                        Color.Red);
                }
                else
                {
                    ((FCodeChild)(this.ActiveMdiChild)).AppendText("Plug-in has installed in "+
                       FdllName, Color.Green);

                    if (File.Exists(fbp.txIcon.Text))
                        File.Copy(fbp.txIcon.Text,
                           FdllName + ".ico");
                    

                    LoadPlugin();

                    MessageBox.Show("This plug-in has installed successfully."+Environment.NewLine+
                        "You can use it in Plugin menu and you can uninstall it in Plugin Management.", "Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void LoadPlugin()
        {
            LoadPlugin(PluginMenu, toolStripPlugin,ClickPlugin);
        }
        #endregion
        private void MDIMainForm_Load(object sender, EventArgs e)
        {
            // Load configuration...
            LoadPlugin();
            LoadSettings();

            // open last File
            if (Properties.Settings.Default.StartupReopen &&
                File.Exists(Properties.Settings.Default.LastFile))
            {
                OpenFile(Properties.Settings.Default.LastFile);
                FillEmptySample();
            }
            else
            {
                OpenWelcomeForm();
            }



            Application.Idle += MainFormIdeal;
        }



        /// <summary>
        /// IDEAL EVENT OF FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormIdeal(object sender, EventArgs e)
        {
            try
            {
                // Check Save all enable or disable
                if (this.MdiChildren.Count<Form>() > 0)
                {
                    if (((Form)ActiveMdiChild).Tag.ToString() != "Welcome")
                    {
                        saveAllToolStripMenuItem.Enabled = true;
                        foreach (ToolStripItem item in editMenu.DropDownItems)
                            item.Enabled = true;
                    }
                    else
                    {
                        NoWindowOpen();
                        return;

                    }
                }
                else
                {
                    NoWindowOpen();
                    return;
                }
            }
            catch
            {
                NoWindowOpen();
                return;
            }
            
           //if(((Form)ActiveMdiChild).Tag.ToString()=="Image")
           //{
           //    // Disable all analysis button
           //    foreach (ToolStripItem item in analysisMenu.DropDownItems)
           //        item.Enabled = false;
           //    toolStripAnalysis.Enabled = false;
           //    addResultToXMLFileToolStripMenuItem.Enabled = false;
           //    saveResultAsXMLToolStripMenuItem.Enabled = false;
           //    cxMenyPropertyGrid.Enabled = false;
           //}
           // else
           //{
           //    // Enable all analysis button
           //    foreach (ToolStripItem item in analysisMenu.DropDownItems)
           //        item.Enabled = true;
           //    toolStripAnalysis.Enabled = true;

           //    addResultToXMLFileToolStripMenuItem.Enabled = true;
           //    saveResultAsXMLToolStripMenuItem.Enabled = true;
           //    cxMenyPropertyGrid.Enabled = true;
           //}

          

        }

        private void NoWindowOpen()
        {
            foreach (ToolStripItem item in editMenu.DropDownItems)
                item.Enabled = false;

            foreach (ToolStripItem item in BuildMenu.DropDownItems)
                item.Enabled = false;

            foreach (ToolStripItem item in analysisMenu.DropDownItems)
                item.Enabled = false;

            foreach (ToolStripItem item in FilterMenu.DropDownItems)
                item.Enabled = false;

            foreach (ToolStripItem item in ImageMenu.DropDownItems)
                item.Enabled = false;

            saveAllToolStripMenuItem.Enabled = false;
            MenuSaveasItem.Enabled = false;
            MenuSaveItem.Enabled = false;
            toolStripAnalysis.Enabled = false;
            toolStripCommit.Enabled = false;
            toolStripPlugin.Enabled = false;
            toolStripCompile.Enabled = false;
            toolSave.Enabled = false;
            ToolPrint.Enabled = false;
        }

       

        // Load Settings
        private void LoadSettings()
        {
           //  ToolWinZoom.Checked = Properties.Settings.Default.DefaultZoom;
           //  ToolWinHistogram.Checked = Properties.Settings.Default.DefaultHistogram;
           //  ToolWinColors.Checked = Properties.Settings.Default.DefaultColorsList;

            ToolWinOutput.Checked = Properties.Settings.Default.WindowOuput;
            ToolWinPropertygrid.Checked = Properties.Settings.Default.WindowPropertygrid;
            ToolWinPreview.Checked = !Properties.Settings.Default.WindowPreview;
            ToolWinMessage.Checked = Properties.Settings.Default.WindowMessage;
            ToolWinSource.Checked = Properties.Settings.Default.WindowSource;
            ToolWinVerHor.Checked= Properties.Settings.Default.ImageSplitVertical;
            ToolShowGrid.Checked = Properties.Settings.Default.ShowGrid;
            ToolShowRulers.Checked = Properties.Settings.Default.ShowRulers;
            splitContainer1.Panel2Collapsed = Properties.Settings.Default.WindowPreview;


        }

        /// <summary>
        /// Load Plug-in
        /// </summary>
        public void LoadPlugin(ToolStripMenuItem pluginMenu,ToolStrip toolstripPlugin
         , EventHandler TargetMethod ,bool _enable=false )
        {
            int Skey = 1;

            pluginMenu.DropDownItems.Clear();
            pluginMenu.DropDownItems.Add(addPluginToolStripMenuItem);
            pluginMenu.DropDownItems.Add(new ToolStripSeparator());

            try
            {
                string MainPath = Application.StartupPath;

                if (!Directory.Exists(MainPath + "\\Plugins\\"))
                    Directory.CreateDirectory(MainPath + "\\Plugins\\");

                toolstripPlugin.Items.Clear();

                foreach (string f in Directory.GetFiles(MainPath + "\\Plugins\\", "*.dll"))
                {
                    // ICON
                    FileInfo fi = new FileInfo(f);
                    string IconFileName=MainPath + "\\Plugins\\"+fi.Name.Replace(fi.Extension,".ico");
                    System.Drawing.Icon ico;

                    if(File.Exists(IconFileName))
                         ico= new System.Drawing.Icon(IconFileName);
                    else
                         ico= Icon.ExtractAssociatedIcon(f);

                    //***********************

                    ToolStripMenuItem PlugMenuItem = new ToolStripMenuItem();
                    string extension = Path.GetExtension(f);
                    FileVersionInfo fDLL = FileVersionInfo.GetVersionInfo(f);

                    // Short Key
                    PlugMenuItem.ShortcutKeys = ((Keys)((Keys.Alt | (Keys)Skey+95)));
                    PlugMenuItem.Tag = fDLL.InternalName;
                    
                    // Add to menu
                    PlugMenuItem.Click += new EventHandler(TargetMethod);

                    if (fDLL.FileDescription.Trim().Length > 0)
                        PlugMenuItem.Text = fDLL.FileDescription;
                    else
                        PlugMenuItem.Text = fDLL.InternalName;

                    PlugMenuItem.Image = ico.ToBitmap();
                    PlugMenuItem.Enabled = _enable;
                    int it=pluginMenu.DropDownItems.Add(PlugMenuItem);


                    // add to toolbar
                    ToolStripItem tool= toolstripPlugin.Items.Add(ico.ToBitmap());
                    tool.Text = fDLL.FileDescription;
                    tool.Tag = fDLL.InternalName;
                    tool.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    tool.TextDirection = ToolStripTextDirection.Horizontal;
                    tool.Click += new EventHandler(TargetMethod);
                    Skey++;
                }
            }
            catch
            {
                MessageBox.Show("Error in loading the plug-in!");
            }
        }
        /// <summary>
        /// Run Plug-in
        /// </summary>
        /// <param name="sender">Menu or toolbar</param>
        /// <param name="e"></param>
        private void ClickPlugin(object sender, EventArgs e)
        {
            if (((Form)this.ActiveMdiChild).Tag.ToString() != "Image") return;

            string PluginName= Application.StartupPath + "\\Plugins\\";

            PluginName+=((ToolStripItem)sender).Tag.ToString();

            VPCompile.Compiler vc = new VPCompile.Compiler();

            FRunPlugin fr = new FRunPlugin(PluginName);
            
            if (fr.ShowDialog() == DialogResult.OK)
            {
                 string ErrorMessage;
                 Stopwatch sww = new Stopwatch();

                 sww.Start();
                ((FImageSource)this.ActiveMdiChild).pbOutput.Image=
                //Run Code
                    vc.RunCodePlugin(PluginName, pbTinySource.Image, fr.MainParameters, out  ErrorMessage);

                if (ErrorMessage.Length>0)
                {
                    MessageBox.Show(ErrorMessage);
                }

                sww.Stop();

                 ((FImageSource)(this.ActiveMdiChild)).RefreshOutput();
                 ImageProperty.ImageInfoResult ii = ImageProperty.CalculateImageInfo(pbTinySource.Image,
                     ((FImageSource)(this.ActiveMdiChild)).pbOutput.Image, ImageProperty.RGB.RGB);

                 ((ImageProperty)propertyGridMain.SelectedObject)._SNR = ii.SNR;
                 ((ImageProperty)propertyGridMain.SelectedObject)._PSNR = ii.PSNR;
                 ((ImageProperty)propertyGridMain.SelectedObject)._ColorOutput = ii.NumberofColors;
                 ((ImageProperty)propertyGridMain.SelectedObject)._RunTime = sww.ElapsedMilliseconds;

                 propertyGridMain.Refresh();
            }
        }

        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VitalPixels.FPlugins fp = new VitalPixels.FPlugins();

            fp.ShowDialog();
            LoadPlugin();
        }


        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vitalpixels.com/help/");
        }

        // Before Exit
        private void MDIMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings before exit
            Properties.Settings.Default.WindowOuput = ToolWinOutput.Checked;
            Properties.Settings.Default.WindowPropertygrid = ToolWinPropertygrid.Checked;
            Properties.Settings.Default.WindowPreview = !ToolWinPreview.Checked; 
            Properties.Settings.Default.WindowMessage = ToolWinMessage.Checked;
            Properties.Settings.Default.WindowSource = ToolWinSource.Checked;
            Properties.Settings.Default.ImageSplitVertical = ToolWinVerHor.Checked;
            Properties.Settings.Default.ShowRulers = ToolShowRulers.Checked;
            Properties.Settings.Default.ShowGrid = ToolShowGrid.Checked;

            Properties.Settings.Default.Save();

            // Check Save before exit
            //if(toolSave.Enabled)
            //{
            //    DialogResult dr = MessageBox.Show("Do you want to save code before exit?"
            //        , "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //    if (dr == DialogResult.Yes) toolSave_Click(sender, e);
            //    if (dr == DialogResult.Cancel) e.Cancel=true;
            //}
        }

        // Check and Uncheck 
        private void ToolWinHistogram_Click(object sender, EventArgs e)
        {
            //ToolWinZoom.Checked = false;
            //  ToolWinHistogram.Checked = false;
            // ToolWinColors.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void ToolWinPreview_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed=!ToolWinPreview.Checked;
        }

        private void ToolWinPropertygrid_CheckedChanged(object sender, EventArgs e)
        {
            panelPropertugrid.Visible = ToolWinPropertygrid.Checked;
        }

        // Show Hide output image
        private void ToolWinOutput_Click(object sender, EventArgs e)
        {
            if (ToolWinSource.Checked == false && ToolWinOutput.Checked == false) ToolWinSource.Checked = true;

            try
            {
                if (((Form)this.ActiveMdiChild).Tag.ToString() == "Image")
                {
                    ((FImageSource)this.ActiveMdiChild).splitContainerImages.Panel2Collapsed = !ToolWinOutput.Checked;
                    ((FImageSource)this.ActiveMdiChild).AllAlignCenter();

                }
                else
                {
                    ((FCodeChild)this.ActiveMdiChild).splitContainerCodeImage.Panel2Collapsed = !ToolWinOutput.Checked;
                }

            }
            catch
            {
                //
            }

            Properties.Settings.Default.WindowOuput = ToolWinOutput.Checked;
            Properties.Settings.Default.Save();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout fa = new FAbout();

            fa.ShowDialog();
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vitalpixels.com/REPORTBUG");
        }

        private void propertyGridMain_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (((Form)this.ActiveMdiChild).Tag.ToString() == "Image")
            {
                ((FImageSource)this.ActiveMdiChild).InputImage=
                         ((FImageSource)this.ActiveMdiChild).pbInput.Image =
                         ((FImageSource)this.ActiveMdiChild).imgPro.MainImage;

                pbTinySource.Image = ((FImageSource)this.ActiveMdiChild).imgPro.MainImage;
                ((FImageSource)this.ActiveMdiChild).AllAlignCenter();
            }
            else
            {
                pbTinySource.Image = Image.FromFile(((ImageProperty)(propertyGridMain.SelectedObject)).FileName);
            }
          //  MessageBox.Show("Test");
        }

        private void ToolWinSource_Click(object sender, EventArgs e)
        {
            if (ToolWinSource.Checked == false && ToolWinOutput.Checked == false) ToolWinOutput.Checked = true;

            try
            {
                if (((Form)this.ActiveMdiChild).Tag.ToString() == "Image")
                {
                    ((FImageSource)this.ActiveMdiChild).splitContainerImages.Panel1Collapsed = !ToolWinSource.Checked;
                    ((FImageSource)this.ActiveMdiChild).AllAlignCenter();
                }

            }
            catch
            {
                //
            }
            Properties.Settings.Default.WindowSource = ToolWinSource.Checked;
            Properties.Settings.Default.Save();
        }

        private void ToolWinVerHor_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Form)this.ActiveMdiChild).Tag.ToString() == "Image")
                {
                    if (Properties.Settings.Default.ImageSplitVertical==false)
                        ((FImageSource)this.ActiveMdiChild).splitContainerImages.Orientation = 
                            Orientation.Vertical;
                    else
                        ((FImageSource)this.ActiveMdiChild).splitContainerImages.Orientation = 
                            Orientation.Horizontal;

                    ((FImageSource)this.ActiveMdiChild).AllAlignCenter();
                }

            }
            catch
            {
                //
            }

            Properties.Settings.Default.ImageSplitVertical = ToolWinVerHor.Checked;
            Properties.Settings.Default.Save();
        }

        private void ToolWinMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Form)this.ActiveMdiChild).Tag.ToString() != "Image")
                {
                    ((FCodeChild)this.ActiveMdiChild).panelMessage.Visible = ToolWinMessage.Checked;

                }
            }
            catch
            {
                //
            }

            Properties.Settings.Default.WindowMessage = ToolWinMessage.Checked;
            Properties.Settings.Default.Save();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSettings fs = new FSettings();
            fs.ShowDialog();
        }

        private void MDIMainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Test");
        }

        private void cropToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //toolStripCrop.Checked = cropToolStripMenuItem1.Checked;
            toolStripCrop_Click(sender, e);
        }

        private void toolStripCrop_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void toolStripCrop_CheckedChanged(object sender, EventArgs e)
        {
         // cropToolStripMenuItem1.Checked = toolStripCrop.Checked;
        }

        private void pbTinySource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pbTinySource.Image == null) return;
            VitalPixels.FShowImage fs = new VitalPixels.FShowImage(pbTinySource.Image);

            fs.ShowDialog();
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image") return;

            OpenFileDialog op = new OpenFileDialog();

            op.Multiselect = false;
            op.Filter = "All Image files:(*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP)|*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp;";
            ;

            op.Title = "Open file";

            if (op.ShowDialog() == DialogResult.OK)
            {
                OpenFile(op.FileName, true);
                propertyGridMain.Refresh();
                // pbTinySource.Image = Image.FromFile(op.FileName);
            }
        }

        private void MenuTinyImage_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild.Tag.ToString() == "Image")
                {
                    changeImageToolStripMenuItem.Enabled = false;
                    pictocodeTool.Enabled = false;
                }
                else
                {
                    changeImageToolStripMenuItem.Enabled = true;
                    pictocodeTool.Enabled = true;
                }


                if (pbTinySource.Image == null)
                {
                    showFullSizeToolStripMenuItem.Enabled = false;
                    pictocodeTool.Enabled = false;

                }
                else
                    showFullSizeToolStripMenuItem.Enabled = true;
            }
            catch
            {
                changeImageToolStripMenuItem.Enabled = false;
            }
        }

        private void showFullSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbTinySource.Image == null) return;
            FShowImage fi = new FShowImage(pbTinySource.Image);

            fi.ShowDialog();
        }

        private void brignessLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbTinySource.Image != null)
            {
                VitalPixels.FColorLab fLab = new VitalPixels.FColorLab(pbTinySource.Image,true);
                fLab.ShowDialog();
            }
        }

        private void ToolShowGrid_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowGrid = ToolShowGrid.Checked;
            Properties.Settings.Default.Save();

            if (this.ActiveMdiChild.Tag.ToString() == "Image")
            {
                ((FImageSource)ActiveMdiChild).pbInput.Refresh();
                ((FImageSource)ActiveMdiChild).pbOutput.Refresh();
            }

        }

        private void ToolShowRulers_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowRulers = ToolShowRulers.Checked;
            Properties.Settings.Default.Save();

            if (this.ActiveMdiChild.Tag.ToString() == "Image")
            {
                ((FImageSource)ActiveMdiChild).panelInput.Refresh();
                ((FImageSource)ActiveMdiChild).panelOutput.Refresh();
            }
        }

        private void toolCommit_EnabledChanged(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild.Tag.ToString() == "Image")
            //{
            //    if (toolCommit.Enabled)
            //    {
            //        ((FImageSource)ActiveMdiChild).pbInput.BorderStyle = BorderStyle.FixedSingle;
            //        ((FImageSource)ActiveMdiChild).BackColor = Color.Red;

            //        ((FImageSource)ActiveMdiChild).Padding = new Padding(2);
            //    }
            //    else
            //    {
            //        ((FImageSource)ActiveMdiChild).pbInput.BorderStyle = BorderStyle.FixedSingle;
            //        ((FImageSource)ActiveMdiChild).BackColor = Color.Transparent;

            //        ((FImageSource)ActiveMdiChild).Padding = new Padding(2);
            //    }
            //}
        }

        private void compilerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompilerSettings fc = new FCompilerSettings();

            fc.ShowDialog();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDonate fd = new FDonate();
            fd.ShowDialog();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            // if code
            ((FCodeChild)ActiveMdiChild).txProgram.SelectAll();

        }

        private void past_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() != "Image")
            {
                // if code
                ((FCodeChild)ActiveMdiChild).txProgram.Paste();
            }
            else
            {
                if (Clipboard.GetImage() == null) return;

                Image  img=  ((FImageSource)ActiveMdiChild).pbInput.Image;

                Graphics gr= Graphics.FromImage(img);

                gr.DrawImage(Clipboard.GetImage(), 0, 0);
                ((FImageSource)ActiveMdiChild).pbInput.Image = img;

                gr.Dispose();

                SourceChanged();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild.Tag.ToString() != "Image")
            {
                // if Active child is a code
                ((FCodeChild)ActiveMdiChild).txProgram.Copy();
            }
            else
            {
                // If active chal
                Image img = ((FImageSource)ActiveMdiChild).pbInput.Image;
                Clipboard.SetImage(img);
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            // if code
            ((FCodeChild)ActiveMdiChild).txProgram.Cut();
        }

        private void redo_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            // if code
            ((FCodeChild)ActiveMdiChild).txProgram.Redo();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            // if code
            ((FCodeChild)ActiveMdiChild).txProgram.Undo();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            string sel=((FCodeChild)ActiveMdiChild).txProgram.SelectedText;

            if(findForm==null)
                findForm = new FFind(((FCodeChild)ActiveMdiChild), sel);
            
            if(sel.Length>0)
                findForm.txFind.Text = ((FCodeChild)ActiveMdiChild).txProgram.SelectedText;
            findForm.ShowDialog();
        }

        private void gotoLineNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            ((FCodeChild)ActiveMdiChild).txProgram.ShowGoToDialog();
        }

        private void ToolWinPropertygrid_Click(object sender, EventArgs e)
        {

        }

        private void clearBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Tag.ToString() == "Image") return;

            for (int i = 0; i < ((FCodeChild)ActiveMdiChild).txProgram.LinesCount; i++)
            {
                ((FCodeChild)ActiveMdiChild).txProgram.UnbookmarkLine(i);    
            }
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSplash fs = new FSplash();
            fs.Show();
        }

        private void MDIMainForm_Shown(object sender, EventArgs e)
        {
            // Check Last update
            if (Properties.Settings.Default.StartupUpdate)
            {

                // Check New Version
                UpdateVP.FUpdate fu = new UpdateVP.FUpdate(Application.ProductVersion);
                string newver = fu.CheckUpdate();

                // Close Splash Screen
                if (fs != null)
                    fs.Close();

                if (newver == "") return;

                if (newver != Application.ProductVersion)
                {
                    DialogResult dr = MessageBox.Show("You are using old version [" + Application.ProductVersion + "]."
                        + Environment.NewLine +
                        "New version is available. Do you want to update [" + newver
                        + "]?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("UpdateVP.exe");
                        Application.Exit();
                    }
                }
            }
            else
            {
                // Close Splash Screen
                if (fs != null)
                    fs.Close();
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Tag.ToString() != "Image" && child.Tag.ToString() != "Welcome")
                {
                    ((FCodeChild)child).SaveCode(sender, e);
                    counter++;
                }
            }

            MessageBox.Show(counter.ToString()+" files has been saved. ","Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information 
              );

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upd.FUpdate ud = new upd.FUpdate(Application.ProductVersion.ToString());
            ud.ShowDialog();

        }

        private void useMatlabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMatlabSettings fm = new FMatlabSettings();
            fm.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            SavePropertyGridToXML();
        }

        private void SavePropertyGridToXML()
        {
            object obj=propertyGridMain.SelectedObject;

            if (obj == null)
            {
                MessageBox.Show("Result is empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string body = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"+Environment.NewLine+
                "<AlgorithmResult>";

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "XML files (*.xml) |*.xml";
            sv.DefaultExt = "xml";
            sv.Title = "Save to XML";          
            sv.FileName = "XMLResult";


            if (sv.ShowDialog() != DialogResult.OK) return;

            foreach (var item in obj.GetType().GetProperties())
            {
                string n = "", v;
                try
                {
                    n = item.Name;
                    v = item.GetValue(obj).ToString();
                }
                catch
                {
                    v = "null";
                }
                if (n.ToUpper() != "FILENAME")
                    body += Environment.NewLine + "   <" + n +">" + v + "</"+n+">";
                else
                {
                    body += Environment.NewLine + " <Result>";
                    body += Environment.NewLine + "   <Filename>" + v + "</Filename>";
                }
            }
          //  body += Environment.NewLine + "   <DateTime "+"\"+" + DateTime.Now.ToString() + "\"/>";

            body += Environment.NewLine + " </Result>";
            body += Environment.NewLine + "</AlgorithmResult>";
            

            File.WriteAllText(sv.FileName, body);
            MessageBox.Show("Data has saved successfully","Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool GetResults()
        {
           // throw new NotImplementedException();
            return true;
        }



        private void saveResultAsXMLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SavePropertyGridToXML();

        }

        private void addToXMLCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataTOXML();
        }

        private void AddDataTOXML()
        {
            object obj = propertyGridMain.SelectedObject;

            if (obj == null)
            {
                MessageBox.Show("Result is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "XML files (*.xml) |*.xml";
            sv.DefaultExt = "xml";
            sv.Title = "Add to XML";
            sv.Multiselect=false;

            sv.FileName = "XMLResult";

            if (sv.ShowDialog() != DialogResult.OK) return;

            string body = File.ReadAllText(sv.FileName, Encoding.ASCII);
            body = body.Replace(("</AlgorithmResult>"),"")+Environment.NewLine;

            foreach (var item in obj.GetType().GetProperties())
            {
                string n = "", v;
                try
                {
                    n = item.Name;
                    v = item.GetValue(obj).ToString();
                }
                catch
                {
                    v = "null";
                }
                if (n.ToUpper() != "FILENAME")
                    body += Environment.NewLine + "   <" + n + ">" + v + "</" + n + ">";
                else
                {
                    body += Environment.NewLine + " <Result>";
                    body += Environment.NewLine + "   <Filename>" + v + "</Filename>";
                }
            }
            //  body += Environment.NewLine + "   <DateTime "+"\"+" + DateTime.Now.ToString() + "\"/>";

            body += Environment.NewLine + " </Result>";
            body += Environment.NewLine + "</AlgorithmResult>";

            File.WriteAllText(sv.FileName, body);

            MessageBox.Show("Data has added to file successfully","Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void addResultToXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataTOXML();
        }

        // Edit preview image
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propertyGridMain.SelectedObject == null) return;
            string fname = ((VitalPixels.ImageProperty)propertyGridMain.SelectedObject).FileName;
            
            OpenFile(fname);
        }

        public void openSampleImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOpenSampleImage fo = new FOpenSampleImage();
            if(fo.ShowDialog()==DialogResult.OK)
            {
                OpenFile(Application.StartupPath+"\\Samples\\"+fo.FileName);
            }
        }



        private void MixTwoImages(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            OpenFileDialog op = new OpenFileDialog();
            FilterImage.MixType mt = new FilterImage.MixType();

            string MenuTitle = ((ToolStripMenuItem)sender).Text;

            mt = FilterImage.MixType.Add;
            if (MenuTitle.ToUpper().Contains("XOR")) mt = FilterImage.MixType.XOR;
            if (MenuTitle.ToUpper().Contains("AND")) mt = FilterImage.MixType.AND;
            if (MenuTitle.ToUpper().Contains("OR")) mt = FilterImage.MixType.OR;

            if (MenuTitle.ToUpper().Contains("ADD")) mt = FilterImage.MixType.Add;
            if (MenuTitle.ToUpper().Contains("SUB")) mt = FilterImage.MixType.Sub;
            if (MenuTitle.ToUpper().Contains("AVERAGE")) mt = FilterImage.MixType.Average;

            if (MenuTitle.ToUpper().Contains("MAX")) mt = FilterImage.MixType.Max;
            if (MenuTitle.ToUpper().Contains("MIN")) mt = FilterImage.MixType.Min;


            op.Multiselect = false;
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP) |*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp";

            op.Title = "Open file";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.MixImage(pbTinySource.Image, Image.FromFile(op.FileName),
                 mt);

                SourceChanged();
            }
        }

        private void showWelcomeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in MdiChildren)
            {
                if (item.Tag.ToString() == "Welcome")
                {
                    item.Activate();
                    return;
                }

            }
            OpenWelcomeForm();

        }

        private void bitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                VPFilter.FilterImage.ChangeImageType(pbTinySource.Image,
                System.Drawing.Imaging.PixelFormat.Format16bppArgb1555);

            SourceChanged();
        }

        private void bitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                VPFilter.FilterImage.ChangeImageType(pbTinySource.Image,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            SourceChanged();
        }

        private void bitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                VPFilter.FilterImage.ChangeImageType(pbTinySource.Image,
                System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            SourceChanged();
        }

        private void captureScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Image sc = VPFilter.FilterImage.GetScreenCapture();

                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Image files (*.png) |*.png";
                sv.FileName = "Screenshot_" + DateTime.Now.ToShortDateString().Replace("/","_");
                sv.Title = "Save Screen shot";

                if (sv.ShowDialog() == DialogResult.OK)
                {
                    sc.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    FImageSource childForm = new FImageSource(sv.FileName, this);

                    childForm.MdiParent = this;
                    childForm.Text = "File: " + sv.FileName + "";
                    childForm.Show();
                    childForm.AllAlignCenter();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error is saving...");
            }
        }

        private void openColorfullBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FColorful dc = new FColorful();
                if (dc.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog sv = new SaveFileDialog();
                    sv.Filter = "Image files (*.png) |*.png";

                    sv.FileName = "ColorfulBox_" + dc.comStyle.Text + "_" + dc.numValue.Value.ToString();
                    sv.Title = "Save Colorful Box";

                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        dc.pbBox.Image.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        FImageSource childForm = new FImageSource(sv.FileName, this);

                        childForm.MdiParent = this;
                        childForm.Text = "File: " + sv.FileName + "";
                        childForm.Show();
                        childForm.AllAlignCenter();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error is saving...");
            }
        }

        private void convertTextToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConvertText fctext = new FConvertText();

            if(fctext.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    SaveFileDialog sv = new SaveFileDialog();
                    sv.Filter = "Image files (*.png) |*.png";

                    FileInfo fi = new FileInfo(fctext.filename);

                    sv.FileName = fi.Name.Replace(fi.Extension, "");
                    sv.Title = "Save Colorful Box";

                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        fctext.pbImageText.Image.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        FImageSource childForm = new FImageSource(sv.FileName, this);

                        childForm.MdiParent = this;
                        childForm.Text = "File: " + sv.FileName + "";
                        childForm.Show();
                        childForm.AllAlignCenter();
                    }
                }
                catch
                {
                    MessageBox.Show("Error in saving..");
                }
            }

        }

        private void thresholdRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FGamma fb = new VitalPixels.FGamma(pbTinySource.Image,
                VitalPixels.FGamma.FormTask.ThresholdRGB);
            if (fb.ShowDialog() == DialogResult.OK)
            {

                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.ThresholdRGB(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
                  ((int)fb.trackBarRed.Value) ,
                  ((int)fb.trackBarGreen.Value) ,
                  ((int)fb.trackBarBlue.Value ));

                SourceChanged();
            }
        }

        private void splitedThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;

            VitalPixels.FGamma fb = new VitalPixels.FGamma(pbTinySource.Image,
                VitalPixels.FGamma.FormTask.SplittedThreshold);
            if (fb.ShowDialog() == DialogResult.OK)
            {

                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image =
                 VPFilter.FilterImage.SplittedThresholdRGB(((FImageSource)(this.ActiveMdiChild)).pbInput.Image,
                  ((int)fb.trackBarRed.Value),
                  ((int)fb.trackBarGreen.Value),
                  ((int)fb.trackBarBlue.Value));

                SourceChanged();
            }
        }

        private void fFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Welcome") return;

            if (((Form)(this.ActiveMdiChild)).Tag.ToString() == "Image")
            {
                FImageSource fi = (FImageSource)ActiveMdiChild;

                FFFT ft = new FFFT(fi.pbInput.Image, fi.pbOutput.Image);
                ft.ShowDialog();
            }
            else
            {
                if(pbTinySource.Image==null)
                {
                    MessageBox.Show("Input image has not been selected ,yet!");
                    return;
                }

                FCodeChild fi = (FCodeChild)ActiveMdiChild;

                FFFT ft = new FFFT(pbTinySource.Image, fi.pbOutput.Image);
                ft.ShowDialog();
            }


            //try
            //{
            //    Bitmap bmp = new Bitmap(pbTinySource.Image);
            //    fft.FFT ImgFFT = new fft.FFT(bmp);

            //    ImgFFT.ForwardFFT();// Finding 2D FFT of Image
            //    ImgFFT.FFTShift();
            //    ImgFFT.FFTPlot(ImgFFT.FFTShifted);

            //    FShowImage fi = new FShowImage((Image)ImgFFT.FourierPlot, "FFT");

            //    fi.ShowDialog();
            //}
            //catch
            //{
            //    MessageBox.Show("FFT has some error in this image");
            //}
           // pbTinySource.Image = (Image)ImgFFT.FourierPlot;
           // FourierMag.Image = (Image)ImgFFT.FourierPlot;
          //  FourierPhase.Image = (Image)ImgFFT.PhasePlot; 
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbTinySource.Image == null) return;
            Bitmap bmp = new Bitmap(pbTinySource.Image);
            fft.FFT ImgFFT = new fft.FFT(bmp);

            ImgFFT.InverseFFT();// Finding 2D FFT of Image
            //ImgFFT.FFTShift();
            //ImgFFT.FFTPlot(ImgFFT.FFTShifted);

            FShowImage fi = new FShowImage((Image)ImgFFT.Obj);

            fi.ShowDialog();
        }

        private void pictocodeTool_Click(object sender, EventArgs e)
        {
            string AllCode = ((FCodeChild)(this.ActiveMdiChild)).txProgram.Text;
            string fname = ((VitalPixels.ImageProperty)propertyGridMain.SelectedObject).FileName;
            string last = ExtractImageFileName(AllCode);
            if (last.Length > 0)
                ((FCodeChild)(this.ActiveMdiChild)).txProgram.Text = AllCode.Replace(
                    last,fname);
            else
                ((FCodeChild)(this.ActiveMdiChild)).txProgram.Text =
                    "#image <"+fname+">"+Environment.NewLine+
                    ((FCodeChild)(this.ActiveMdiChild)).txProgram.Text;
        }

        // if click on all AForge Filter
        private void AforgeFilter_Click(object sender, EventArgs e)
        {
            string MenuTitle = ((ToolStripMenuItem)sender).Text;


            if (((Form)(this.ActiveMdiChild)).Tag.ToString() != "Image") return;
            Image img = VPFilter.FilterImage.VPAForgFilter((
                (FImageSource)(this.ActiveMdiChild)).pbInput.Image,MenuTitle.ToUpper());

            if (img != null)
                pbTinySource.Image = ((FImageSource)(this.ActiveMdiChild)).pbInput.Image = img;
            else
                MessageBox.Show("Error");


            SourceChanged();
        }

        // Remove Background if image would be apeared
        private void pbTinySource_Paint(object sender, PaintEventArgs e)
        {
            if (pbTinySource.Image != null)
                pbTinySource.BackgroundImage = null;
        }
    }
}
