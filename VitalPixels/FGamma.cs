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
    public partial class FGamma : Form
    {
        private Image MImage;
        
        public enum FormTask
        {
            GammaChange,
            ThresholdRGB,
            SplittedThreshold
        };

        private FormTask fTask;

        public FGamma(Image img,FormTask ft)
        {
            InitializeComponent();
            pbTest.Image = img;
            MImage = img;
            pictureBox1.Image = img;

            fTask = ft;
            switch (ft)
            {
                case FormTask.GammaChange:
                    trackBarBlue.Value = 0;
                    trackBarGreen.Value = 0;
                    trackBarRed.Value = 0;
                    break;
                case FormTask.ThresholdRGB:
                    trackBarBlue.Maximum = 255;
                    trackBarGreen.Maximum = 255;
                    trackBarRed.Maximum = 255;
                    trackBarRGB.Maximum = 255;


                    numBlue.Maximum = 255;
                    numRed.Maximum = 255;
                    numGreen.Maximum = 255;
                    numRGB.Maximum = 255;


                    numGreen.Value = 128;
                    numBlue.Value = 128;
                    numRed.Value = 128;
                    numRGB.Value = 100;


                    trackBarBlue.Value = 128;
                    trackBarGreen.Value = 128;
                    trackBarRed.Value = 128;
                    trackBarRGB.Value = 100;

                    break;

                case FormTask.SplittedThreshold:
                    trackBarBlue.Maximum = 255;
                    trackBarGreen.Maximum = 255;
                    trackBarRed.Maximum = 255;
                    trackBarRGB.Maximum = 255;

                    numBlue.Maximum = 255;
                    numRed.Maximum = 255;
                    numGreen.Maximum = 255;
                    numRGB.Maximum = 255;

                    numGreen.Value = 100;
                    numBlue.Value = 100;
                    numRed.Value = 100;
                    numRGB.Value = 100;

                    trackBarBlue.Value = 100;
                    trackBarGreen.Value = 100;
                    trackBarRed.Value = 100;
                    trackBarRGB.Value=100;
                    break;

                default:
                    break;
            }



        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
                timer1.Enabled = true;

        }

        private void numRed_ValueChanged(object sender, EventArgs e)
        {
            //trackBarRed.Value = (int)numRed.Value;
            //trackBarGreen.Value = (int)numGreen.Value;
            //trackBarBlue.Value = (int)numBlue.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (fTask)
            {
                case FormTask.GammaChange:
                    pbTest.Image = VFP.FilterImage.SetGamma(MImage, 
                        ((double)trackBarRed.Value) / 10f,
                        ((double)trackBarGreen.Value) / 10f, 
                        ((double)trackBarBlue.Value) / 10f);

                    numBlue.Value = (int)trackBarBlue.Value;
                    numGreen.Value = (int)trackBarGreen.Value;
                    numRed.Value = (int)trackBarRed.Value;
                    numRGB.Value = (int)trackBarRGB.Value;

                    break;
                case FormTask.ThresholdRGB:
                    pbTest.Image = VFP.FilterImage.ThresholdRGB(MImage, 
                        ((int)trackBarRed.Value) ,
                        ((int)trackBarGreen.Value), 
                        ((int)trackBarBlue.Value));

                    numBlue.Value = (int)trackBarBlue.Value;
                    numGreen.Value = (int)trackBarGreen.Value;
                    numRed.Value = (int)trackBarRed.Value;
                    numRGB.Value = (int)trackBarRGB.Value;

                    break;

                case FormTask.SplittedThreshold:
                    pbTest.Image = VFP.FilterImage.SplittedThresholdRGB(MImage,
                        ((int)trackBarRed.Value),
                        ((int)trackBarGreen.Value), 
                        ((int)trackBarBlue.Value));

                    numBlue.Value = (int)trackBarBlue.Value;
                    numGreen.Value = (int)trackBarGreen.Value;
                    numRed.Value = (int)trackBarRed.Value;
                    numRGB.Value = (int)trackBarRGB.Value;
                    break;
                default:
                    break;
            }

        }

        private void FGamma_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            numBlue.Value = 0;
            numGreen.Value = 0;
            numRed.Value = 0;

            timer1.Enabled = false;
            pbTest.Image = pictureBox1.Image;
        }

        private void FGamma_Load(object sender, EventArgs e)
        {
            switch (fTask)
            {
                case FormTask.GammaChange:
                    Text = "Change Gamma in RGB";
                    break;
                case FormTask.ThresholdRGB:
                    Text = "Change Threshold in RGB";
                    break;
                case FormTask.SplittedThreshold:
                    Text = "Change Divided Threshold in RGB";
                    break;
                default:
                    break;
            }
        }

        private void trackBarRGB_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            trackBarBlue.Value = trackBarRGB.Value;
            trackBarGreen.Value = trackBarRGB.Value;
            trackBarRed.Value = trackBarRGB.Value;
            trackBarRGB.Value = trackBarRGB.Value;
            timer1.Enabled = true;
        }
    }
}
