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
    public partial class FWelcomeForm : Form
    {
        MDIMainForm parentform;
        public FWelcomeForm(MDIMainForm mdip)
        {
            InitializeComponent();
            parentform = mdip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (parentform).OpenFile(Application.StartupPath + "\\Sample.vp");
            (parentform).FillEmptySample();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSampleImage_Click(object sender, EventArgs e)
        {
            (parentform).openSampleImageToolStripMenuItem_Click(sender, e);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            (parentform).OpenFileClick(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (parentform).NewMenu_Click(sender, e);
        }

        private void FWelcomeForm_Load(object sender, EventArgs e)
        {
            string lname= Properties.Settings.Default.LastFile;
            
            //  this.Width = parentform.
            //this.Height = parentform.Height-20;

            if (File.Exists(lname))
            {
                FileInfo fi = new FileInfo(lname);
                //MessageBox.Show(fi.Directory.FullName);
                btnPFile.Text += Environment.NewLine + fi.Directory.FullName.Remove(6) + "..\\" + fi.Name;
            }
            else
            {
                btnPFile.Enabled = false;
                toolTipGuide.Show("Click here to build and run the sample code" + Environment.NewLine +
                    "After that you can change this sample and develop you algorithm in Image Processing"
                    , btnSampleCode);
            }


        }

        private void btnPFile_Click(object sender, EventArgs e)
        {
            string lname = Properties.Settings.Default.LastFile;

            if (File.Exists(lname))
            {
                parentform.OpenFile(lname);
            }
        }

        private void FWelcomeForm_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
