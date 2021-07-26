using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VitalPixels
{
    public partial class FColorLab : Form
    {
        private const  int MaxColor=16777215;
        private int Tol = 10000;
        private float x1=0, y1=0,x2=0,y2=0;
        private double RBr = 0.2126, GBr = 0.7152, BBR = 0.0722;
        private double Kry=.299,Kby=.114;


        enum MouseMoveMode
        {
            NoOne,
            Color1,
            Color2
        }
        private MouseMoveMode mmm = MouseMoveMode.Color1;
      //  private Image image;
       // private bool p;
        private bool IsBrightness = false;

        //Constructor
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mimage">Input image</param>
        /// <param name="argIsBrightness">Show brightness or show colors</param>
        public FColorLab(Image mimage, bool argIsBrightness=false)
        {
            // TODO: Complete member initialization
            InitializeComponent();

            pbTest.Image = mimage;
            IsBrightness = argIsBrightness;

            if (argIsBrightness)
            {
                Text = "Brightness Lab";
                label1.Text = "Brightness 1";
                label2.Text = "Brightness 2";

                lblStandard.Visible = true;
                cbStandard.Visible = true;
                cbStandard.SelectedIndex = 0;

                labelred.Text = "Y:";
                labelgreen.Text = "Cb";
                labelred.Text = "Cr";
                lblPer.Visible = true;
            }
        }

        private void OpenColorDialgforColor1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            
            cd.Color = Color.FromArgb(255, Int32.Parse(tbColor1R.Text),
               Int32.Parse(tbColor1G.Text), Int32.Parse(tbColor1B.Text));

            if(cd.ShowDialog()==DialogResult.OK)
            {
                tbColor1R.Text = cd.Color.R.ToString();
                tbColor1G.Text = cd.Color.G.ToString();
                tbColor1B.Text = cd.Color.B.ToString();
                tbColor1.Text= (cd.Color.R*65536+cd.Color.G*256+cd.Color.B).ToString();
                panelColor1.BackColor = cd.Color;
            }
        }

        private void OpenColorDialogforColor2(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.Color = panelColor2.BackColor;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                tbColor2R.Text = cd.Color.R.ToString();
                tbColor2G.Text = cd.Color.G.ToString();
                tbColor2B.Text = cd.Color.B.ToString();
                tbColor2.Text = (cd.Color.R * 65536 + cd.Color.G * 256 + cd.Color.B).ToString();
                panelColor2.BackColor = cd.Color;
            }
        }
        // OnChange Back color of ColorPanels
        private void panelColor1_BackColorChanged(object sender, EventArgs e)
        {
            Brush brush = new LinearGradientBrush(panel1.ClientRectangle, panelColor1.BackColor, panelColor2.BackColor,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            panel1.CreateGraphics().FillRectangle(brush, panel1.ClientRectangle);

            if (tbColor1.Focused == false)
                tbColor1.Text = (panelColor1.BackColor.R * 65536 +
                    panelColor1.BackColor.G * 256 + panelColor1.BackColor.B).ToString();
            label1.Text = "Color: " + panelColor1.BackColor.Name.ToUpper(); ;

            if (tbColor2.Focused == false)
                tbColor2.Text = (panelColor2.BackColor.R * 65536 +
                        panelColor2.BackColor.G * 256 + panelColor2.BackColor.B).ToString();
            label2.Text = "Color: " + panelColor2.BackColor.Name.ToUpper(); ;

            labeldif.Text ="Differences:"+ Math.Abs(panelColor1.BackColor.ToArgb() - 
                panelColor2.BackColor.ToArgb()).ToString();

            if (IsBrightness == false)
            {
                labelred.Text = "Red:" + Math.Abs(panelColor1.BackColor.R -
                    panelColor2.BackColor.R).ToString();
                labelgreen.Text = "Green:" + Math.Abs(panelColor1.BackColor.G -
                    panelColor2.BackColor.G).ToString();
                labelblue.Text = "Blue:" + Math.Abs(panelColor1.BackColor.B -
                    panelColor2.BackColor.B).ToString();
            }
        }

        private double GetY(Color argcolor)
        {
            double Kgy=1-Kby-Kry;
            double Result = Kry * argcolor.R + Kgy * argcolor.G + Kby * argcolor.B;

            return Math.Floor(Result*10000)/10000;
        }

        private double GetCb(Color argcolor)
        {

            return argcolor.B-GetY(argcolor);
        }
        private double GetCr(Color argcolor)
        {   
            return argcolor.R - GetY(argcolor);
        }

        
        private void tbColor1B_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0) ((TextBox)sender).Text = "0";
            if (Int32.Parse(((TextBox)sender).Text)>255)  ((TextBox)sender).Text="255";
            panelColor1.BackColor = Color.FromArgb(255, Int32.Parse(tbColor1R.Text),
               Int32.Parse(tbColor1G.Text), Int32.Parse(tbColor1B.Text));
        }

        private void tbColor1_TextChanged(object sender, EventArgs e)
        {
            int a = Int32.Parse(tbColor1.Text);
            if (a > MaxColor) 
                tbColor1.Text = MaxColor.ToString();
            else
            {
                int R = a / 65536;
                int G = (a - R * 65536) / 256;
                int B = a % 256;

               // if (IsBrightness == false)
                panelColor1.BackColor = Color.FromArgb(255, R, G, B);
                //else
                //{
                //    Color cl = new Color();
                //    cl = Color.FromArgb(R, G, B);
                //    int luma = (int)GetBrightness(cl);
                //    panelColor1.BackColor = Color.FromArgb(luma, luma, luma);
                //} 

                tbColor1R.Text = R.ToString();
                tbColor1G.Text = G.ToString();
                tbColor1B.Text = B.ToString();
            }
        }

        // Verify valid keys for all textboxes
        private void VerifyKeys(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar)==false)
                if (((TextBox)sender).Text.Length == 0)
                    ((TextBox)sender).Text = "0"; 
                else
                    e.KeyChar = '0';
        }

        private void tbColor2B_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0) ((TextBox)sender).Text = "0";
            if (Int32.Parse(((TextBox)sender).Text) > 255) ((TextBox)sender).Text = "255";
            panelColor2.BackColor = Color.FromArgb(255, Int32.Parse(tbColor2R.Text),
               Int32.Parse(tbColor2G.Text), Int32.Parse(tbColor2B.Text));
        }

        private void tbColor2_TextChanged(object sender, EventArgs e)
        {
            int a = Int32.Parse(tbColor2.Text);
            if (a > MaxColor) tbColor2.Text = MaxColor.ToString();
            else
            {
                int R = a / 65536;
                int G = (a - R * 65536) / 256;
                int B = a % 256;

                panelColor2.BackColor = Color.FromArgb(255, R, G, B);

                tbColor2R.Text = R.ToString();
                tbColor2G.Text = G.ToString();
                tbColor2B.Text = B.ToString();
            }
        }

        private void AddTolerance(object sender, EventArgs e)
        {
            tbColor2.Text = (Int32.Parse(tbColor2.Text) + Tol).ToString();
        }

        private void SameButton(object sender, EventArgs e)
        {
            tbColor2.Text = tbColor1.Text;
        }

        private void AddRGBBut(object sender, EventArgs e)
        {
            tbColor2R.Text = (Int16.Parse(tbColor2R.Text) + 1).ToString();
            tbColor2G.Text = (Int16.Parse(tbColor2G.Text) + 1).ToString();
            tbColor2B.Text = (Int16.Parse(tbColor2B.Text) + 1).ToString();
        }

        private void pbTest_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                float X = e.X, Y = e.Y;
                if (e.Button == MouseButtons.Middle) Y = y1;

                Color cl = ((Bitmap)(pbTest.Image)).GetPixel((int)X, (int)Y);

                if(IsBrightness)
                {
                    labelred.Text = "Y: " + GetY(cl).ToString();
                    labelgreen.Text = "Cb: " + GetCb(cl).ToString();
                    labelblue.Text = "Cr: " + GetCr(cl).ToString();
                    lblPer.Text = "Brightness: " + GetBrightness(cl, 100).ToString() + "%";
                }

                Font fnt = new Font("Tahoma", 8);
                Pen br = new Pen(Brushes.Red);
                Brush fbr = new SolidBrush(Color.Red);

                if (cl.R != cl.G || cl.G != cl.B)
                    br.Color = Color.FromArgb(255, 255 - cl.R, 255 - cl.G, 255 - cl.B);

                labelXY.Text = "X=" + X.ToString() + ", Y=" + Y.ToString();

                if (mmm == MouseMoveMode.Color1)
                {
                  //  if (IsBrightness == false)
                        panelColor1.BackColor = cl;
                    //else
                    //{
                    //    int luma = (int)GetBrightness(cl);
                    //    panelColor2.BackColor = Color.FromArgb(luma, luma, luma);
                    //} 
                    x1 = X;
                    y1 = Y;
                }
                if (mmm == MouseMoveMode.Color2)
                {
                    pbTest.Refresh();
                    pbTest.CreateGraphics().DrawEllipse(br, x1 - 3, y1 - 3, 6, 6);
                    pbTest.CreateGraphics().DrawLine(br, x1, y1, X, Y);
                    fbr = new SolidBrush(br.Color);
                    pbTest.CreateGraphics().DrawString(labeldif.Text.Replace("Differences:", ""),
                        fnt, fbr, (x1 + X) / 2, (y1 + Y) / 2);
                    pbTest.CreateGraphics().DrawEllipse(br, X - 3, Y - 3, 6, 6);

                    //if (IsBrightness == false)
                        panelColor2.BackColor = cl;
                    //else
                    //{
                    //    int luma=(int)GetBrightness(cl);
                    //    panelColor2.BackColor = Color.FromArgb(luma, luma, luma);
                    //}

                    x2 = e.X;
                    y2 = e.Y;
                    if (e.Button == MouseButtons.Middle) y2 = y1;
                }
            }
            catch
            {
                StatusLabel.Text = "Color could not be detected!";
            }
        }

        private void pbTest_Click(object sender, EventArgs e)
        {
            if (mmm == MouseMoveMode.Color1)
            {
                mmm = MouseMoveMode.Color2;
                pbTest.Cursor = Cursors.Cross;
                StatusLabel.Text = "Click to choose Color2 and Keep Middle Click to select in horizontal line";
                chHsitogram.Series[0].Points.Clear();
            }
            else
                if (mmm == MouseMoveMode.Color2)
                {
                    mmm = MouseMoveMode.NoOne;
                    pbTest.Cursor = Cursors.Arrow;
                    StatusLabel.Text = "Click on image to select color";
                    DrawHistogram();
                }
                else
                    if (mmm == MouseMoveMode.NoOne)
                    {
                        mmm = MouseMoveMode.Color1;
                        pbTest.Cursor = Cursors.Cross;
                        pbTest.Refresh();
                        StatusLabel.Text = "Click to choose Color1";
                    }
        }



        private void DrawHistogram()
        {
            float y, m;
            int MAX = 0, MIN = 255;
            

            chHsitogram.Series[0].Points.Clear();
            chHsitogram.Annotations.Clear();

            Color cl= new Color();

            if (x2 != x1)
            {
                m = (y2 - y1) / (x2 - x1);
                float XStart = ((x1 < x2) ? x1 : x2), XEnd = ((x1 < x2) ? x2 : x1);

                for (float x = XStart; x <= XEnd; x++)
                {
                    int a;
                    y =Math.Abs(m * (x - x1) + y1);
                    cl = ((Bitmap)(pbTest.Image)).GetPixel((int)x, (int)y);


                    // Calculate brightness
                    double Avg = GetBrightness(cl);


                    if (IsBrightness == false)
                    {
                        a = chHsitogram.Series[0].Points.AddY((cl.R + cl.G + cl.B) / 3);
                        chHsitogram.Series[0].Points[a].Color = Color.FromArgb(255, cl.R, cl.G, cl.B);
                        chHsitogram.Series[0].Points[a].ToolTip = cl.R.ToString("X")
                              + ":" + cl.G.ToString("X") + ":" + cl.B.ToString("X");

                        if (((int)(cl.R + cl.G + cl.B) / 3) > MAX) MAX = (cl.R + cl.G + cl.B) / 3;
                        if (((int)(cl.R + cl.G + cl.B) / 3) < MIN) MIN = (cl.R + cl.G + cl.B) / 3;
                    }
                    else
                    {
                        a = chHsitogram.Series[0].Points.AddY(Avg);

                        int luma = (int)(Avg );
                        chHsitogram.Series[0].Points[a].Color = Color.FromArgb(255, luma, luma, luma);
                        chHsitogram.Series[0].Points[a].ToolTip = cl.R.ToString("X")
                              + ":" + cl.G.ToString("X") + ":" + cl.B.ToString("X");

                        if (Avg > MAX) MAX = (int)Avg;
                        if (Avg < MIN) MIN = (int)Avg;
                    }


                }
                lbMinMax.Text = "MAX-MIN: "+(MAX - MIN).ToString();


                LineAnnotation annotation = new VerticalLineAnnotation();
                annotation.IsSizeAlwaysRelative = false;
                annotation.LineColor = Color.Red;
                annotation.AxisX = chHsitogram.ChartAreas[0].AxisX;
                annotation.AxisY = chHsitogram.ChartAreas[0].AxisY;
                annotation.AnchorX =0;
                annotation.AnchorY = MIN;
                annotation.EndCap = LineAnchorCapStyle.Arrow;
                annotation.StartCap = LineAnchorCapStyle.Arrow;
                annotation.Height = MAX-MIN;
                annotation.LineWidth = 2;
                chHsitogram.Annotations.Add(annotation);

                LineAnnotation MinAnno = new HorizontalLineAnnotation();
                MinAnno.IsSizeAlwaysRelative = false;
                MinAnno.LineColor = Color.FromArgb(128, 255, 0, 0);
                MinAnno.LineDashStyle = ChartDashStyle.Dash;
                MinAnno.AxisX = chHsitogram.ChartAreas[0].AxisX;
                MinAnno.AxisY = chHsitogram.ChartAreas[0].AxisY;
                MinAnno.AnchorX = 0;
                MinAnno.AnchorY = MIN;
                MinAnno.Width= XEnd;
                MinAnno.LineWidth = 1;

                chHsitogram.Annotations.Add(MinAnno);

                LineAnnotation MaxAnno = new HorizontalLineAnnotation();
                MaxAnno.IsSizeAlwaysRelative = false;
                MaxAnno.LineColor = Color.FromArgb(128, 255, 0, 0);
                MaxAnno.LineDashStyle = ChartDashStyle.Dash;
                MaxAnno.AxisX = chHsitogram.ChartAreas[0].AxisX;
                MaxAnno.AxisY = chHsitogram.ChartAreas[0].AxisY;
                MaxAnno.AnchorX = 0;
                MaxAnno.AnchorY = MAX;
                MaxAnno.Width = XEnd;
                MaxAnno.LineWidth = 1;
                chHsitogram.Annotations.Add(MaxAnno);
                chHsitogram.Titles[0].Text = (MAX - MIN).ToString();
                
            }
            else
            {
                float YStart = ((y1 < y2) ? y1 : y2), YEnd = ((y1 < y2) ? y2 : y1);

                for (y = YStart; y <= YEnd; y++)
                {
                    cl = ((Bitmap)(pbTest.Image)).GetPixel((int)x1, (int)y);
                    int a = chHsitogram.Series[0].Points.AddY((cl.R + cl.G + cl.B) / 3);
                    chHsitogram.Series[0].Points[a].Color = Color.FromArgb(255, cl.R, cl.G, cl.B);
                    chHsitogram.Series[0].Points[a].ToolTip = cl.R.ToString("X")
                          + ":" + cl.G.ToString("X") + ":" + cl.B.ToString("X");
                }
            }
        }

        private double GetBrightness(Color cl,int Limit=255)
        {
            double Brightness = (RBr * cl.R + GBr * cl.G + BBR * cl.B);
            double MaxBr = 255 * RBr + 255 * GBr + 255 * BBR;
            double Avg = Math.Floor((Brightness * Limit) / MaxBr);
            return Avg;
        }

        private void chHsitogram_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult result = chHsitogram.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
               // double x = result.Series.Points[result.PointIndex].XValue;
                panelColor2.BackColor = result.Series.Points[result.PointIndex].Color;
            }
        }

        private void chHsitogram_MouseMove(object sender, MouseEventArgs e)
        {
            StatusLabel.Text = "Click on chart to choose second color";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            LineAnnotation annotation = new VerticalLineAnnotation();
            annotation.IsSizeAlwaysRelative = false;
            annotation.LineColor = Color.Red;
            annotation.AxisX = chHsitogram.ChartAreas[0].AxisX;
            annotation.AxisY = chHsitogram.ChartAreas[0].AxisY;
            annotation.AnchorX = 5;
            annotation.AnchorY = 100;
            annotation.Height = 25;
            annotation.LineWidth = 2;
            annotation.StartCap = LineAnchorCapStyle.None;
            annotation.EndCap = LineAnchorCapStyle.None;
            chHsitogram.Annotations.Add(annotation);

        }

        private void cbStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbStandard.SelectedIndex)
            {
                case 0:
                    Kry = .299;
                    Kby = .114;
                    break;
                case 1:
                    Kry = .2126;
                    Kby = .0722;
                    break;
                case 2:
                    Kry = .212;
                    Kby = .087;
                    break;
            }
        }

    }
}
