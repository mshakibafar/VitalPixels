using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalPixels;


namespace VitalPixels
{
    public partial class FHistogram : Form
    {
        Image InputImage, OutputImage;
        public FHistogram(Image argin, Image argout)
        {
            InitializeComponent();
            InputImage = argin;
            OutputImage = argout;
            
        }

        private void FHistogram_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = (splitContainer1.Width - splitContainer1.SplitterWidth) / 2;

            UCHistogram UCZ = new UCHistogram(InputImage,"Input Image");

            splitContainer1.Panel1.Controls.Clear();
            UCZ.Width = splitContainer1.Panel1.Width;
            UCZ.Height = splitContainer1.Panel1.Height;
            splitContainer1.Panel1.Controls.Add(UCZ);


            UCHistogram UCZout = new UCHistogram(OutputImage,"Output Image");
            splitContainer1.Panel2.Controls.Clear();
            UCZout.Width = splitContainer1.Panel2.Width;
            UCZout.Height = splitContainer1.Panel2.Height;
            splitContainer1.Panel2.Controls.Add(UCZout);
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            foreach (Control item in ((Panel)sender).Controls)
            {
                item.Width = ((Panel)sender).Width;
                item.Height = ((Panel)sender).Height;
            }
        }

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = (splitContainer1.Width - splitContainer1.SplitterWidth) / 2;

        }
    }
}
