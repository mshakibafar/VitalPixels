using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    public partial class FShowImage : Form
    {
        public FShowImage(Image img,string argTitle="Image")
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            pbFullSizeImage.Image= img;
            this.Width = img.Width+130;
            this.Height = img.Height;

            this.panelColor.Left = this.pbFullSizeImage.Left + this.pbFullSizeImage.Width + 10;
            labelColorname.Left = this.panelColor.Left;
            Text = argTitle;
            label1.Text = argTitle;
            label1.Left = labelColorname.Left;
        }

      


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Color cl = ((Bitmap)(pbFullSizeImage.Image)).GetPixel(e.X, e.Y);
                panelColor.BackColor = cl;
                labelColorname.Text =string.Format("#{0:X2}{1:X2}{2:X2}", cl.R, cl.G, cl.B);
            }
            catch
            {
                panelColor.BackColor = Color.Black;
                labelColorname.Text = "Unknown";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.DefaultExt = ".png";
            sv.FileName=Text;
            sv.Filter = "PNG File(*.png)|*.png";

            if(sv.ShowDialog()==DialogResult.OK)
            {
                pbFullSizeImage.Image.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void FShowImage_Load(object sender, EventArgs e)
        {

        }


    }
}
