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

namespace VitalPixels.CodeLab
{
    public partial class FBuildPlugin : Form
    {



        public FBuildPlugin(string FName)
        {
            DateTime dt = new DateTime();

            InitializeComponent();
            txTitle.Text = Path.GetFileNameWithoutExtension(FName).Trim();

            FileInfo fi = new FileInfo(FName);
            dt = fi.LastWriteTime;

            txVersion.Text = String.Format("{0:yyyy.MM.dd.hh.mm.ss}", dt);  // "8 08 008 2008"   year
                //fi.LastWriteTime.ToString();
            
        }

        private void FBuildPlugin_Load(object sender, EventArgs e)
        {

        }

        private void btnInstall_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowsIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog SV = new OpenFileDialog();
            SV.Filter = "Image files (*.ico) |*.ico";
            SV.DefaultExt = "ico";
            if (SV.ShowDialog() == DialogResult.OK)
            {
                txIcon.Text = SV.FileName;
                pictureBox1.Image = Image.FromFile(SV.FileName);
            }
                       
        }

    }
}
