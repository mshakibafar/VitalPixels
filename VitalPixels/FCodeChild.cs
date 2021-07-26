using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FC = FastColoredTextBoxNS;
using FastColoredTextBoxNS;


namespace VitalPixels
{
    public partial class FCodeChild : Form
    {

        internal string FileName="";
   //     internal FC.FastColoredTextBox txProgram = new FC.FastColoredTextBox();
        private MDIMainForm ParentForm;
        private TextStyle VPSyntax = new TextStyle(Brushes.DarkRed, null, FontStyle.Bold);
        private TextStyle CSharpGraphics = new TextStyle(Brushes.DarkCyan, null, FontStyle.Bold);
        private TextStyle imgStyle = new TextStyle(Brushes.DarkBlue, Brushes.Khaki, FontStyle.Bold);

        private string[] VPKeyword = new string[] { "argMessage", "InputImage", "OutputImage", "MyPlugin","VPPlugin" };
        private string[] GraphKeyword = new string[] { "Image", "Graphics", "Bitmap","Color","Brush" };

        private string RegexVP = "\\b(";
        private string RegexGraphics = "\\b(";


        public FCodeChild()
        {
            InitializeComponent();

        }

        private void FillSyntaxHighLight()
        {
            foreach (string item in VPKeyword)
            {
                RegexVP += item + "|";
            }
            RegexVP += "VitalPixelsSyntaxCode)\\b";

            foreach (string item in GraphKeyword)
            {
                RegexGraphics += item + "|";
            }
            RegexGraphics += "CSharpGraphicsSyntaxCode)\\b";
        }


        public FCodeChild(string fname, MDIMainForm argmDIMainForm)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            FileName = fname;
            this.ParentForm = argmDIMainForm;
        }

        private void FCodeChild_Load(object sender, EventArgs e)
        {
            FillSyntaxHighLight();

            txProgram.Name = "EditCode";
            
            txProgram.TextChanged += CodeChange;
            txProgram.ZoomChanged += ZoomChange;
            txProgram.Enter+=txProgram_Enter;                    


            txProgram.ShowLineNumbers = Properties.Settings.Default.EditorShowline;
            txProgram.BackColor = Properties.Settings.Default.EditorBackColor;

            txProgram.ShowFoldingLines = Properties.Settings.Default.EditorShowFolding;
            txMessage.Text = "Filename: " + FileName + " has opened" + Environment.NewLine;
            
            txProgram.OpenFile(FileName);
            
            panelMessage.Visible = Properties.Settings.Default.WindowMessage;


            //if (Properties.Settings.Default.CodeLabFile.Length > 0)
            //{
            //    FileName = Properties.Settings.Default.CodeLabFile;
            //    txProgram.OpenFile(FileName);
            //    this.Text = "Vital Points-CodeLab [" + FileName + "]";
            //    toolSave.Enabled = false;
            //}          
        }

        private void txProgram_Enter(object sender, EventArgs e)
        {
            txProgram.CurrentLineColor = ChangeLightness(txProgram.BackColor, 0.05);
        }

        private void ZoomChange(object sender, EventArgs e)
        {
            ParentForm.toolStripStatusLabel.Text = "Zoom: " + txProgram.Zoom+"%";
        }


        /// <summary>
        /// Print the Code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void PrintCode(object sender, EventArgs e)
        {
            FC.PrintDialogSettings pset = new FC.PrintDialogSettings();
            pset.Header = "Vital Pixels Lab 4.0 ["+FileName+"]";
            pset.IncludeLineNumbers = true;
            pset.ShowPrintDialog = true;
            pset.Title = FileName;
            pset.Footer = "http://www.vitalpixels.com";

            txProgram.Print(pset);
        }
        private void CodeChange(object sender,FastColoredTextBoxNS.TextChangedEventArgs e)
        {
          //  MainCode = txProgram.Text;
            ParentForm.toolSave.Enabled = true;
            ParentForm.toolStripStatusLabel.Text = " Total Lines: " + txProgram.LinesCount.ToString();
            Text = this.Text.Replace("*", "") + "*";
            

            // Highlight VP Syntax
            e.ChangedRange.ClearStyle(VPSyntax);
            //e.ChangedRange.SetStyle(VPSyntax, "\b(argMessage|InputImage|OutputImage|VitalPixelsSyntaxCode)\b");
            e.ChangedRange.SetStyle(VPSyntax,@RegexVP);

            // Highlight C# Graphics Syntax
            e.ChangedRange.ClearStyle(CSharpGraphics);
            //e.ChangedRange.SetStyle(CSharpGraphics, @"\b(Color|Graphics|Bitmap|Image)\b");
            e.ChangedRange.SetStyle(CSharpGraphics, @RegexGraphics);

            e.ChangedRange.ClearStyle(imgStyle);

            e.ChangedRange.SetStyle(imgStyle, @"#(.*?)>");

        }

        internal void SaveCode(object sender, EventArgs e)
        {
            if (FileName == "")
            {
                SaveFileDialog op = new SaveFileDialog();
                op.Filter = "Image Code Labe (*.vp) |*.vp;";
                op.Title = "Save code ";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    txProgram.SaveToFile(op.FileName, Encoding.ASCII);
                    FileName = op.FileName;
                }
                else
                    return;

            }
            else
                txProgram.SaveToFile(FileName, Encoding.ASCII);

            ParentForm.toolSave.Enabled = false;
            AppendText("Program has Saved successfully.", Color.Black);
            Text = this.Text.Replace("*", "");
        }
        internal void AppendText(string text, Color color,bool TimeTag=true)
        {
            String msg = text ;
            RichTextBox box = txMessage;
            // Clear richedit if it is full
            if (box.TextLength + text.Length >= box.MaxLength)
                box.Text = "";

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            if (TimeTag)
            {
                string dt = DateTime.Now.ToString("yyyy/MM/dd - hh:mm:ss");
                msg += "[ " + dt + " ]";
            }
            box.AppendText(msg + Environment.NewLine);
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
        }


        #region Edit Menu
        private void Copy_Click(object sender, EventArgs e)
        {
            txProgram.Copy();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            txProgram.Cut();
        }

        private void Past_Click(object sender, EventArgs e)
        {
            txProgram.Paste();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            txProgram.Undo();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            txProgram.Redo();
        }

        private void SellectAll_Click(object sender, EventArgs e)
        {
            if (txProgram.Focused)
                txProgram.SelectAll();

            if (txMessage.Focused)
                txMessage.SelectAll();
        }
        #endregion



        private void button1_Click(object sender, EventArgs e)
        {
            ParentForm.ToolWinMessage.Checked = false;
            panelMessage.Visible = false;
        }

        private void SaveMessages_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(FileName);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Log file (*.txt) |*.txt;";
            sf.Title = "Save log file";
            sf.FileName ="Log_"+DateTime.Now.Year.ToString()
                +"_"+DateTime.Now.Month+"_"+DateTime.Now.Day.ToString()
                +"_"+fi.Name.Replace(fi.Extension, ".txt");
            sf.InitialDirectory = fi.Directory.ToString();
            if(sf.ShowDialog()==DialogResult.OK)
            {
                txMessage.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void CleanMessage_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to clear all messages?","Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                txMessage.Text = "";
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
          //  splitContainerCodeImage.Panel2
            pbOutput.Top =  splitContainerCodeImage.Panel2.Height / 2 - pbOutput.Height / 2;
            pbOutput.Left = splitContainerCodeImage.Panel2.Width / 2 - pbOutput.Width / 2;
        }

        private void saveImageAs_Click(object sender, EventArgs e)
        {
            if(pbOutput.Image == null) return;

            FileInfo fi = new FileInfo(FileName);
            
            SaveFileDialog SV = new SaveFileDialog();
            SV.Filter = "Image files (*.png) |*.png";
            SV.FileName = "Result_" + fi.Name.Replace( fi.Extension, "");
            SV.DefaultExt = "PNG";
            if (SV.ShowDialog() == DialogResult.OK)
            {
                pbOutput.Image.Save(SV.FileName , System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbOutput.Image = null;
            OutputsaveImageAsTool.Enabled = false;
        }

        private void contextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            if (pbOutput.Image == null) contextMenuStripImage.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txProgram.OpenFile(FileName);
        }

        private void FCodeChild_Activated(object sender, EventArgs e)
        {
            panelMessage.Visible = Properties.Settings.Default.WindowMessage;
            splitContainerCodeImage.Panel2Collapsed = !Properties.Settings.Default.WindowOuput;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txMessage.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txMessage.Copy();
        }

        private void commentSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txProgram.CommentSelected();
        }

        

        public static Color ChangeLightness(Color color, double coef)
        {
            return Color.FromArgb((int)(color.R * coef), (int)(color.G * coef),
                (int)(color.B * coef));
        }

        

        private void txMessage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int cursorPosition = txMessage.SelectionStart;
                string CurrentText = txMessage.Lines[txMessage.GetLineFromCharIndex(cursorPosition)];
                cursorPosition=GetLindeError(CurrentText);

                // Go to line number that error occurred
                if (cursorPosition > 0)
                {
                    txProgram.CurrentLineColor = Color.Red;
                    txProgram.Navigate(cursorPosition - 1);
                }
                
            }
            catch
            {

            }
        }
        /// <summary>
        /// Extract Line number from txt error
        /// </summary>
        /// <param name="txt">error text</param>
        /// <returns></returns>
        private int GetLindeError(string txt)
        {
            if (txt.Contains("Line") == false) return 0;

            string[] ar = txt.Split(' ');

            return Int16.Parse(ar[1]);
        }

        private void FCodeChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ParentForm.toolSave.Enabled)
            {
                DialogResult dr= MessageBox.Show("Do you want to save changes to "+FileName+" ?",
                    "Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    SaveCode(sender, e);
                }
                if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
            
        }

        private void pbOutput_Paint(object sender, PaintEventArgs e)
        {
            if (pbOutput.Image != null) pbOutput.BackgroundImage = null;
        }
    }
}
