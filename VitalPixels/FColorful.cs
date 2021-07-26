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
    public partial class FColorful : Form
    {
        public FColorful()
        {
            InitializeComponent();
        }

        private void FColorful_Load(object sender, EventArgs e)
        {
            comStyle.SelectedIndex = 0;

            pbBox.Image= MadeColorfulBox(16);
        }

        private Image MadeColorfulBox(int Scale,int Style=0)
        {
            Bitmap bmp = new Bitmap(512, 512);
            Graphics gr = Graphics.FromImage((Image)bmp);
            int red = 255, green = 255, blue = 255;
            Random r = new Random( DateTime.Now.Millisecond);
            Random g = new Random( DateTime.Now.Millisecond/2);
            Random b = new Random( DateTime.Now.Millisecond/4);


            for (int x = 0; x < 512; x += Scale)
            {
                for (int y = 0; y < 512; y += Scale)
                {
                    switch(Style)
                    { 
                        case 0:     // Rainbow
                            red = x /2;
                            green = y / 2;
                            blue = 255-(red + green) / 2;
                            break;
                        case 1:     // 
                            red = x /2;
                            green = y / 2;
                            blue = (red + green) / 2;
                            break;
                        case 2:
                            blue= x / 2;
                            green = y / 2;
                            red = (blue + green) / 2;
                            break;
                        case 3:
                            blue = x / 2;
                            red = y / 2;
                            green = (red + blue) / 2;
                            break;
                        case 4:     // Random
                            blue = b.Next(0,255);
                            red = r.Next(0,255);
                            green = g.Next(0, 255);
        
                            break;

                        case 5:     // Greystyle
                            blue = (x+y)/4;
                            red = blue;
                            green = red;
                            break;

                    }

                    Color cl = new Color();
                    cl = Color.FromArgb(255, red, green, blue);
                    Brush br = new SolidBrush(cl);
                    gr.FillRectangle(br, x, y, Scale, Scale);                                     
                }
            }

            return (Image)bmp;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pbBox.Image=MadeColorfulBox((int)numValue.Value,comStyle.SelectedIndex);
            int EachRow = 512 / (int)numValue.Value;
            if (EachRow < 512.0 / (double)numValue.Value)
                EachRow++;
            double NumberofBoxes=(int) Math.Pow(EachRow,2);
            lblColors.Text = "Boxes: " + NumberofBoxes.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
