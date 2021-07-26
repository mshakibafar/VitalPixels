using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace VitalPixels
{
    public partial class UCHistogram : UserControl
    {
        private Image MainImage;
        public enum RGB
        {
            RGB,
            Red,
            Green,
            Blue,
            Grey
        }

        public UCHistogram(Image img,string argTitle="Histogram")
        {
            this.MainImage = img;

            InitializeComponent();
            chHsitogram.Titles[0].Text = argTitle;
           // chHsitogram.ChartAreas[0].BackColor = Properties.Settings.Default.HistogramBackColor;
        }

        private void UCHistogram_Load(object sender, EventArgs e)
        {
            if(MainImage!=null)
                DrawColorHistogram(sender, e);
            
        }



        private void SaveChartAsImage(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.Title = "Save Histogram";
            sv.DefaultExt = "PNG";
            sv.Filter = "PNG Files(*.png)|*.png";
            sv.FileName = "Histogram";

            if(sv.ShowDialog()==DialogResult.OK)
                chHsitogram.SaveImage(sv.FileName, ChartImageFormat.Png);
        }


        private void DrawColorHistogram(object sender, EventArgs e)
        {
            Color BRColor = new Color();
            Color TempColor = new Color();
            Bitmap bitmap = (Bitmap)MainImage;
            List<Color> ls = new List<Color>();

            int[] Reds=new int[256];
            int[] Greens = new int[256];
            int[] Blues = new int[256];

            int max = 0;
            string ChartStr = "RED";

            // Clear all series of Histogram
            foreach (var itemSer in chHsitogram.Series)
                    itemSer.Points.Clear();

            // Collecting the colors from image
            for (int x = 0; x < MainImage.Width; x++)
                for (int y = 0; y < MainImage.Height; y++)
                {
                    TempColor = bitmap.GetPixel(x, y);

                    Reds[TempColor.R]++;
                    Greens[TempColor.G]++;
                    Blues[TempColor.B]++;

                    //ls.Add(TempColor);
                }
           

            // Draw Histogram RGB and Grey

            for (int i = 0; i <= 255;i++)
            {
                int a;

                //int Red = ls.FindAll(delegate(Color x)
                //{
                //    return x.R == i;
                //}).Count;

                ChartStr = "RED";
                a = chHsitogram.Series[ChartStr].Points.AddXY(i, Reds[i]);
                chHsitogram.Series[ChartStr].Points[a].Color = Color.FromArgb(190,Color.FromArgb(i,0,0));
                chHsitogram.Series[ChartStr].Points[a].BorderColor = BRColor;
                chHsitogram.Series[ChartStr].Points[a].BorderDashStyle = ChartDashStyle.Solid;
                chHsitogram.Series[ChartStr].Points[a].ToolTip = i.ToString("X")
                    + ":" +(0).ToString("X") + ":" +(0).ToString("X");

                ChartStr = "GREEN";
                a = chHsitogram.Series[ChartStr].Points.AddXY(i, Greens[i]);
                chHsitogram.Series[ChartStr].Points[a].Color = Color.FromArgb(190, Color.FromArgb(0, i, 0));
                chHsitogram.Series[ChartStr].Points[a].BorderColor = BRColor;
                chHsitogram.Series[ChartStr].Points[a].BorderDashStyle = ChartDashStyle.Solid;
                chHsitogram.Series[ChartStr].Points[a].ToolTip = i.ToString("X")
                    + ":" + (0).ToString("X") + ":" + (0).ToString("X");

                ChartStr = "BLUE";
                a = chHsitogram.Series[ChartStr].Points.AddXY(i, Blues[i]);
                chHsitogram.Series[ChartStr].Points[a].Color = Color.FromArgb(190, Color.FromArgb(0, 0, i));
                chHsitogram.Series[ChartStr].Points[a].BorderColor = BRColor;
                chHsitogram.Series[ChartStr].Points[a].BorderDashStyle = ChartDashStyle.Solid;
                chHsitogram.Series[ChartStr].Points[a].ToolTip = i.ToString("X")
                    + ":" + (0).ToString("X") + ":" + (0).ToString("X");

                ChartStr = "Histogram";
                a = chHsitogram.Series[ChartStr].Points.AddXY(i, (Blues[i]+Greens[i]+Reds[i])/3);
                chHsitogram.Series[ChartStr].Points[a].Color = Color.FromArgb(190, Color.FromArgb(i, i, i));
                chHsitogram.Series[ChartStr].Points[a].BorderColor = BRColor;
                chHsitogram.Series[ChartStr].Points[a].BorderDashStyle = ChartDashStyle.Solid;
                chHsitogram.Series[ChartStr].Points[a].ToolTip = i.ToString("X")
                    + ":" + (0).ToString("X") + ":" + (0).ToString("X");

                //this.Refresh();
            }
            if (chHsitogram.ChartAreas[0].AxisY.Maximum < max)
                chHsitogram.ChartAreas[0].AxisY.Maximum = max;
        }

      
        private void ShowHideColors(object sender, EventArgs e)
        {
            string argTag = ((Button)sender).Tag.ToString();
            chHsitogram.Series[argTag].Enabled = !chHsitogram.Series[argTag].Enabled;

            if (chHsitogram.Series[argTag].Enabled)
            {
                ((Button)sender).FlatStyle = FlatStyle.Flat;
            }
            else
            {
                ((Button)sender).FlatStyle = FlatStyle.Standard;
            }

        }

        private void ChangBGColor(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog()==DialogResult.OK)
            {
                chHsitogram.ChartAreas[0].BackColor = cd.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chHsitogram.ChartAreas[0].AxisX.Maximum -= 10;
            chHsitogram.ChartAreas[0].AxisY.Maximum -= 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chHsitogram.ChartAreas[0].AxisX.Maximum += 10;
            chHsitogram.ChartAreas[0].AxisY.Maximum += 10;
        }

        private void printHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chHsitogram.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            chHsitogram.Printing.Print(true);
        }

        private void chHsitogram_Click(object sender, EventArgs e)
        {

        }

    }
}
