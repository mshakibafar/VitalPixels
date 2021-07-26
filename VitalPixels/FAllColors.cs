using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VitalPixels
{
    public partial class FAllColors : Form
    {
        private Image MainImage;
        private HashSet<Color> hs = new HashSet<Color>();
        int curX=0, curY=0;
        enum SortColorMethod
        {
            ByRed,
            ByGreen,
            ByBlue,
            ByRGB,
            ByBrightness,
            ByHue,
            BuSatuation
        }


        public FAllColors(Image img)
        {
            InitializeComponent();
            MainImage = img;
        }

        private void FAllColors_Load(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            List<Color> ls = new List<Color>();
            Color TempColor = new Color();
            Bitmap bitmap = (Bitmap)MainImage;
            pbTest.Image = MainImage;
            try
            {
                for (int x = 0; x < MainImage.Width; x++)
                    for (int y = 0; y < MainImage.Height; y++)
                    {
                        TempColor = bitmap.GetPixel(x, y);

                        hs.Add(TempColor);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lblCount.Text = "count: " + hs.Count.ToString();
            FillColors();

            curX = 2;
            curY = 2;
            pbColors_Click(sender, e);
        }

        private void FillColors(SortColorMethod sc = SortColorMethod.ByRGB)
        {
            int XMax = 24;
            int Scale = (panelColor.Width-5)/XMax;
            pbColors.Width = Scale * XMax;

           // pbColors.Width = panelColor.Width -3;
            pbColors.Height = ((hs.Count / XMax) * Scale)+Scale;

            Bitmap bm = new Bitmap(pbColors.Width, pbColors.Height);
            Graphics gr = Graphics.FromImage(bm);
            int x = 0, y = 0;
            IEnumerable<Color> query = SortColor(sc);

            //  Scale /= pbColors.Width;
            //  lst.OrderBy(c=>c.ToArgb());
            
            try
            {
                foreach (Color item in query)
                {
                   // bm.SetPixel(x, y, item);
                    gr.FillRectangle(new SolidBrush(item), x * Scale , y*Scale , Scale, Scale);
                    gr.DrawRectangle(new Pen(Color.Black), x * Scale, y*Scale, Scale, Scale);
                    
                    if (x <XMax-1) x++; else { x = 0; y++; }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            pbColors.Image = (Image)(bm);
        }

        private IOrderedEnumerable<Color> SortColor(SortColorMethod sc=SortColorMethod.ByRGB)
        {
            switch (sc)
            {
                case SortColorMethod.ByHue:
                    return hs.OrderBy(c => c.GetHue());

                case SortColorMethod.BuSatuation:
                    return hs.OrderBy(c => c.GetSaturation());

                case SortColorMethod.ByBrightness:
                    return hs.OrderBy(c => c.GetBrightness());

                case SortColorMethod.ByBlue:
                    return hs.OrderBy(c => c.B);

                case SortColorMethod.ByGreen:
                    return hs.OrderBy(c => c.G);

                case SortColorMethod.ByRed:
                    return hs.OrderBy(c => c.R);

                case SortColorMethod.ByRGB:
                default:
                    return hs.OrderBy(c => c.ToArgb());
            }
        }

        private void ShowColor(Color cl)
        {
            using(Image img = (Image)MainImage.Clone())
            {
                int count = MarkColor(img, cl);

                pbTest.Image = img;
                pbTest.Refresh();
                lblCntColor.Text = "Count: " + count.ToString();
            }


        }


        public int MarkColor(Image img, Color RemoveColor)
        {
            Bitmap bmp = new Bitmap(MainImage);
            Color cl = new Color();
            int count = 0;

            try
            {
                Graphics gr = Graphics.FromImage(img);

                for (int x = 0; x < MainImage.Width; x++)
                    for (int y = 0; y < MainImage.Height; y++)
                    {
                        cl = bmp.GetPixel(x, y);

                        if (cl == RemoveColor)
                        {
                            ((Bitmap)img).SetPixel(x, y, Color.Red);

                            gr.DrawLine(new Pen(Color.Red), x - 5, y, x + 5, y);

                            gr.DrawLine(new Pen(Color.Red), x, y - 5, x, y + 5);
                            count++;
                        }
                    }
            }
            catch (OutOfMemoryException oex)
            {

                for (int x = 0; x < MainImage.Width; x++)
                    for (int y = 0; y < MainImage.Height; y++)
                    {
                        cl = bmp.GetPixel(x, y);

                        if (cl == RemoveColor)
                        {
                            ((Bitmap)img).SetPixel(x, y, Color.Red);


                            count++;
                        }
                    }
            }

            return count;
        }


        private void pbColors_MouseMove(object sender, MouseEventArgs e)
        {
            curX = e.X;
            curY = e.Y;

            try
            {
                float position = panelColor.VerticalScroll.Value / panelColor.VerticalScroll.Maximum;
                position *= pbColors.Height;
                Color cl = ((Bitmap)(pbColors.Image)).GetPixel(curX, curY + (int)position);
                toolTipShowColor.BackColor = cl;

               // toolTipShowColor.Show(cl.ToString(), pbColors, e.X, e.Y);
            }
            catch (Exception ex)
            {
                
                
            } 

        }


        private void pbColors_Click(object sender, EventArgs e)
        {
            try
            {
                float position = panelColor.VerticalScroll.Value / panelColor.VerticalScroll.Maximum;
                position *= pbColors.Height;
                Color cl = ((Bitmap)(pbColors.Image)).GetPixel(curX, curY + (int)position);

                panelShowColor.BackColor = cl;

                labelRed.Text = "Red: " + cl.R.ToString();
                labelGreen.Text = "Green: " + cl.G.ToString();
                labelBlue.Text = "Blue: " + cl.B.ToString();

                lblColorCode.Text ="#"+ cl.R.ToString("X2") + cl.G.ToString("X2") + cl.B.ToString("X2");
                    //String.Format("#{0:X}{0:X}{0:X}", cl.R, cl.G, cl.B);
                lblColorCode.ForeColor = Color.FromArgb(Color.White.ToArgb() - cl.ToArgb());

                lblCntColor.Text = "";
            }
            catch (Exception ex)
            {
                panelShowColor.BackColor = Color.Black;
                MessageBox.Show(ex.ToString());
            } 
        }

        private void sortColorsByRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.ByRed);
        }

        private void sortColorsByGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.ByGreen);

        }

        private void sortColorsByBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.ByBlue);

        }

        private void sortColorsByHueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.ByHue);

        }

        private void sortColorsByBrightmessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.ByBrightness);
        }

        private void sortColorsBySatuationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillColors(SortColorMethod.BuSatuation);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbTest.Image = MainImage;
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SV = new SaveFileDialog();
            SV.Filter = "Image files (*.png) |*.png";
            SV.DefaultExt = "PNG";
            SV.Title = "Save output image";
            if (SV.ShowDialog() == DialogResult.OK)
            {
                pbTest.Image.Save(SV.FileName, ImageFormat.Png);                   
            }
        }

        private void panelShowColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog()==DialogResult.OK)
            {
                if (hs.Contains(cd.Color))
                {
                    Color cl = new Color();
                    cl = cd.Color;
                    panelShowColor.BackColor = cl;
                    labelBlue.Text = "Blue: " + cl.B.ToString();
                    labelGreen.Text = "Green: " + cl.G.ToString();
                    labelRed.Text = "Red: " + cl.R.ToString();
                    lblColorCode.Text = String.Format("#{0:X}{0:X}{0:X}{0:X}", cl.B, cl.G, cl.R);
                    lblColorCode.ForeColor = Color.FromArgb(Color.White.ToArgb() - cl.ToArgb());

                    ShowColor(cl);
                }
                else
                    MessageBox.Show(cd.Color.ToString() + " doesn't exists");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Bitmap b= new Bitmap(MainImage.Width,MainImage.Height);
            pbTest.Image = (Image)b;;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pbTest.Image=(Image)ShowOnlyColor(panelShowColor.BackColor);
        }

        private Bitmap ShowOnlyColor(Color color)
        {
            Bitmap bmp = new Bitmap(pbTest.Image);
            Color cl = new Color();

            for (int x = 0; x < MainImage.Width; x++)
                for (int y = 0; y < MainImage.Height; y++)
                {
                    cl = ((Bitmap)MainImage).GetPixel(x, y);

                    if (cl == color)
                    {
                        bmp.SetPixel(x, y, color);
                    }
                }

            return bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowColor(panelShowColor.BackColor);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            pbTest.Image = (Image)RemoveColor(panelShowColor.BackColor);
        }

        private Bitmap RemoveColor(Color color)
        {

            Bitmap bmp = new Bitmap(pbTest.Image);
            Color cl = new Color();

            for (int x = 0; x < MainImage.Width; x++)
                for (int y = 0; y < MainImage.Height; y++)
                {
                    cl = ((Bitmap)MainImage).GetPixel(x, y);

                    if (cl == color)
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }

            return bmp;
        }

        private void savePalleteAsAnImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SV = new SaveFileDialog();
            SV.Filter = "Image files (*.png) |*.png";
            SV.DefaultExt = "PNG";
            SV.FileName = "Palette_Color";
            SV.Title = "Save output image";
            if (SV.ShowDialog() == DialogResult.OK)
            {
                pbColors.Image.Save(SV.FileName, ImageFormat.Png);                   
            }
        }
        public void ExportToExcel(string fileName)
        {
            // Load Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create empty workbook
            excel.Workbooks.Add();

            // Create Worksheet from active sheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;

            // I created Application and Worksheet objects before try/catch,
            // so that i can close them in finally block.
            // It's IMPORTANT to release these COM objects!!
            try
            {
                // ------------------------------------------------
                // Creation of header cells
                // ------------------------------------------------
                
                workSheet.Cells[1, "A"] = "Red";
                workSheet.Cells[1, "B"] = "Green";
                workSheet.Cells[1, "C"] = "Blue";
                workSheet.Cells[1, "D"] = "Code";

                // ------------------------------------------------
                // Populate sheet with some real data from "cars" list
                // ------------------------------------------------
                int row = 2; // start row (in row 1 are header cells)
                foreach (Color c in hs)
                {
                    workSheet.Cells[row, "A"] = c.R;
                    workSheet.Cells[row, "B"] = c.G;
                    workSheet.Cells[row, "C"] = c.B;
                    workSheet.Cells[row, "D"] = String.Format("#{0:X}{0:X}{0:X}", c.R, c.G, c.B);
                    row++;
                }

                // Apply some predefined styles for data to look nicely :)
                workSheet.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                //  Define filename
                //  string fileName = fname;

                // Save this data as a file
                workSheet.SaveAs(fileName);


                // Display SUCCESS message
                MessageBox.Show(string.Format("The file '{0}' is saved successfully!", fileName));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception",
                    "There was a PROBLEM saving Excel file!\n" + exception.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Quit Excel application
                excel.Quit();

                // Release COM objects (very important!)
                if (excel != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);

                if (workSheet != null)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);

                // Empty variables
                excel = null;
                workSheet = null;

                // Force garbage collector cleaning
                GC.Collect();
            }
        }

        private void exportPaletteToExcellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SV = new SaveFileDialog();
            SV.Filter = "Image files (*.xlsx) |*.xlsx";
            SV.DefaultExt = "xlsx";
            SV.FileName = "Palette_Color";
            SV.Title = "Save output Palette";
            if (SV.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(SV.FileName);
            }
        }
 
    }
}
