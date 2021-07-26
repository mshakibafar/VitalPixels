using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPFilter;
using fft = VitalPixels;

namespace VitalPixels
{
    public partial class FFFT : Form
    {
        private Image inputImg, outputImg;
        public FFFT(Image inp,Image outp)
        {
            InitializeComponent();
            inputImg = inp;
            outputImg = outp;
        }

        private void FFFT_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = (splitContainer1.Width - splitContainer1.SplitterWidth) / 2;
            if(inputImg==outputImg)
                MessageBox.Show("Test");
            try
            {
                Bitmap bmp = new Bitmap(inputImg);
                fft.FFT ImgFFT = new fft.FFT(bmp);

                ImgFFT.ForwardFFT();         // Finding 2D FFT of Image
                ImgFFT.FFTShift();
                ImgFFT.FFTPlot(ImgFFT.FFTShifted);
                pbFFTInput.Image= (Image)ImgFFT.FourierPlot;


                if (outputImg == null) return;

                Bitmap bmp2 = new Bitmap(outputImg);
                fft.FFT ImgFFT2 = new fft.FFT(bmp2);

                ImgFFT2.ForwardFFT();        // Finding 2D FFT of Image
                ImgFFT2.FFTShift();
                ImgFFT2.FFTPlot(ImgFFT2.FFTShifted);
                pbFFTOutput.Image = (Image)ImgFFT2.FourierPlot;                             
            }
            catch
            {
                MessageBox.Show("FFT has some error in this image");
            }
        }

        private void pbFFTOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFFTAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();

            sv.DefaultExt = ".png";
            sv.FileName = "FFT";
            sv.Filter = "PNG File(*.png)|*.png";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                ((PictureBox)contextMenuStripFFT.SourceControl).Image.Save(sv.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
