using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    public partial class FNewWin : Form
    {
        public string FileName;
        private int childFormNumber;
        private string DirName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + "\\VitalPixels\\Projects";
        public FNewWin()
        {
            InitializeComponent();
        }

        public FNewWin(int argchildFormNumber)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            childFormNumber = argchildFormNumber;
        }

        private void FNewWin_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(DirName))
                Directory.CreateDirectory(DirName);
          // txFname.Text = DirName+"\\Program"+childFormNumber.ToString() + ".vp";
            listViewFile.Items[0].Selected = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FileName = txFname.Text;
            txFname.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.InitialDirectory = DirName;
            sv.DefaultExt = "vp";
            sv.Filter = "Vital Pixels files (*.vp) |*.vp";
            FileInfo fi = new FileInfo(FileName);
            sv.FileName = fi.Name ;
            sv.InitialDirectory = fi.Directory.ToString();
            if(sv.ShowDialog()==DialogResult.OK)
            {
                FileName = sv.FileName;
                txFname.Text = FileName;
            }
        }

        private void listViewFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listViewFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MyDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string vpname = DirName + "\\SemiCode"+ childFormNumber.ToString() + ".vp";
            string pgname = DirName + "\\FullCode" + childFormNumber.ToString() + ".cs";

            if(listViewFile.SelectedItems.Count>0)
                if (listViewFile.SelectedItems[0].Index == 1)
                {
                    txHelp.Text = "Plug-in C# Code" + Environment.NewLine +
                                "-------------" + Environment.NewLine +
                                "You can design a plug-in with input and analysis your program with chart ,SNR ,PSNR and Histogram" +
                                Environment.NewLine;
                    FileName = txFname.Text = pgname;
                }
                else
                {
                    txHelp.Text = "C# Semi code" + Environment.NewLine +
                              "-------------" + Environment.NewLine +
                              "This item used for programming for image processing" + Environment.NewLine;
                    FileName = txFname.Text = vpname;

                }
        }



        private void FNewWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult==DialogResult.OK)
            if (File.Exists(FileName))
            {
                MessageBox.Show(FileName+  Environment.NewLine+
                    "  already exists. please choose another filename." ,"Warning",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);

                txFname.BackColor = Color.PaleVioletRed;
                e.Cancel = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }



    }
}
