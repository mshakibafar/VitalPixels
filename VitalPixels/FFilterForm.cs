using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFP = VPFilter;


namespace VitalPixels
{
    public partial class FBrightnes : Form
    {
        private Image Mimage;
        private TypeChange MTP;
        public enum TypeChange
        {
            Brightness,
            Contrast,
            AddNoise,
            Mosaic,
            Filter1
        };

        public FBrightnes(Image img, TypeChange tp)
        {
            InitializeComponent();
            pbTest.Image = img;
            Mimage = img;
            if (tp == TypeChange.Brightness)
                label1.Text= this.Text = "Change Brightness";
            if (tp == TypeChange.Contrast)
                label1.Text = this.Text = "Change Contrast";
            if (tp == TypeChange.AddNoise)
                label1.Text = this.Text = "Change Noise Density";
            if (tp == TypeChange.Mosaic)
                label1.Text = this.Text = "Change Mosaic Size";
            if (tp == TypeChange.Filter1)
                label1.Text = this.Text = "Change Mosaic Size";

            pictureBox1.Image = img;

            MTP = tp;
        }

        private void brValue_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            brValue.Value = (int)numericValue.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MTP == TypeChange.Brightness)
                pbTest.Image = VFP.FilterImage.SetBrightness(Mimage, brValue.Value);
            if (MTP == TypeChange.Contrast)
                pbTest.Image = VFP.FilterImage.SetContrast(Mimage, brValue.Value);
            if (MTP == TypeChange.AddNoise)
                pbTest.Image = VFP.FilterImage.AddNoise(Mimage, brValue.Value);
            if (MTP == TypeChange.Mosaic)
                pbTest.Image = VFP.FilterImage.Mosaic(Mimage, brValue.Value);

            //if (MTP == TypeChange.Filter1)
            //    pbTest.Image = VFP.FilterImage.Filter1(Mimage, brValue.Value);

            numericValue.Value = brValue.Value;
        }

        private void FBrightnes_Load(object sender, EventArgs e)
        {

        }

        private void FBrightnes_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
