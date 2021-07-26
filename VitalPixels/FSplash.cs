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
    public partial class FSplash : Form
    {
        public FSplash()
        {
            InitializeComponent();
        }

        private void FSplash_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);

            InitalFirstRun();
        }

        private void InitalFirstRun()
        {
            string MyDoc = Path.Combine(Environment.ExpandEnvironmentVariables("%UserProfile%"),
                "Documents");

            if (!Directory.Exists(MyDoc + "\\VitalPixels"))
            {
                try
                {
                    string sampleimage =
                        Directory.CreateDirectory(Path.Combine(MyDoc, "VitalPixels", 
                        "Samples", "Images")).FullName;
                    string samplecodes =
                        Directory.CreateDirectory(Path.Combine(MyDoc,
                        "VitalPixels", "Samples", "Programs")).FullName;

                    Directory.CreateDirectory(Path.Combine(MyDoc, 
                        "VitalPixels", "Projects"));

                    foreach (string item in Directory.GetFiles(Application.StartupPath + "\\Samples", "*.png"))
                    {
                        FileInfo fi = new FileInfo(item);

                        File.Copy(
                               item,
                               sampleimage + "\\" + fi.Name, true);
                    }

                    foreach (string item in Directory.GetFiles(Application.StartupPath + "\\SamplesCode", "*.*"))
                    {
                        FileInfo fi = new FileInfo(item);

                        File.Copy(
                               item,
                               samplecodes + "\\" + fi.Name, true);
                    }

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
