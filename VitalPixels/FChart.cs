using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VitalPixels;

namespace VitalPixels
{
    public partial class FChart : Form
    {
        private Image MainImage;
        private string MainPath = Application.StartupPath;
        private ParameterInfo[] MainParameters;
        private int CountArg = 0;
        string PluginName ;
        string argPara;
        ImageProperty.ImageInfoResult ii;
        private string FileNameDir = "";

        public FChart(Image img)
        {
            InitializeComponent();

            MainImage = img;
            pbMain.Image = img;
        }
        private void FChart_Load(object sender, EventArgs e)
        {
            LoadPlugin();
            if(cbPlugin.Items.Count==0)
            {
                MessageBox.Show("there is no plug-in for analysis.","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();
            }

            try
            {
                cbPlugin.SelectedIndex = 0;
            }
            catch
            {
                Close();
            }
        }

        private void LoadPlugin()
        {
            cbPlugin.Items.Clear();
            
            try
            {

                if (!Directory.Exists(MainPath + "\\Plugins\\"))
                    Directory.CreateDirectory(MainPath + "\\Plugins\\");


                foreach (string f in Directory.GetFiles(MainPath + "\\Plugins\\", "*.dll"))
                {
                    ToolStripItem PlugMenuItem = new ToolStripMenuItem();
                    string extension = Path.GetExtension(f);

                    FileInfo fDLL = new FileInfo(f);
                    //PlugMenuItem.Tag = f;
                    cbPlugin.Items.Add(fDLL.Name.Replace(".dll",""));
                }
            }
            catch
            {
                MessageBox.Show("Error in loading the plug-in!");
                Close();
            }
        }



    

        private void pbMain_Click(object sender, EventArgs e)
        {
            VitalPixels.FShowImage fs = new VitalPixels.FShowImage(pbMain.Image);

            fs.ShowDialog();

            fs.Dispose();
        }


        // Fill parameters for any plug-in
        private void cbPlugin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParameterInfo[] par = GetParamsPlugin(MainPath + "\\Plugins\\"+cbPlugin.Text+".dll");

            cbParameters.Items.Clear();
            chOutput.Text = "No Output";
            chOutput.Enabled = false;

            grpData.Enabled = false;
            cbChangeImage.Checked = true;
            cbChangeImage.Enabled = false;
            btnImages.Enabled = true;
            chOutput.Checked = false;
            btnDraw.Enabled = false;

            CountArg = 0;
            foreach (ParameterInfo item in par)
            {
                // Check or input
                if (item.IsOut == false && item.ParameterType == typeof(double))
                {
                    int row=cbParameters.Items.Add(item.Name);

                    try
                    {
                        numFrom.Value = decimal.Parse(item.DefaultValue.ToString());
                    }
                    catch
                    {
                        numFrom.Value = 0;
                    }

                    grpData.Enabled = true;



                    // CHnage Image button
                    cbChangeImage.Checked = false;
                    cbChangeImage.Enabled = true;
                    btnImages.Enabled = false;
                    btnDraw.Enabled = true;
                }
               

                //check for output
                if (item.IsOut == true)
                {
                    chOutput.Text = item.Name;
                    chOutput.Enabled = true;
                }
                CountArg++;
            }

            // check for Disable and enable input parameters
            if (cbParameters.Items.Count < 1)
            {
                cbParameters.Enabled = false;
            }
            else
            {
                cbParameters.Enabled = true;
                cbParameters.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Get Parameter info of any plug-in
        /// </summary>
        /// <param name="DllName"></param>
        /// <returns></returns>
        private ParameterInfo[] GetParamsPlugin(string DllName)
        {
            FileStream fs = File.Open(DllName, FileMode.Open);
            ParameterInfo[] pars = null;

            try
            {
                AppDomainSetup ads = new AppDomainSetup();
                AppDomain ad = AppDomain.CreateDomain("RunCodeDomain", null, ads);
                AssemblyName assemblyName = new AssemblyName();
                assemblyName.CodeBase = DllName;
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                Assembly DLL = Assembly.Load(data);

                Type tp = DLL.GetType("VPPlugin.MyPlugin");

                MethodInfo Method = DLL.GetTypes()[0].GetMethod("OutPlugin");
                pars = Method.GetParameters();

                fs.Close();

                // Unload Domain
                AppDomain.Unload(ad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fs.Close();
            }

            return pars;
        }

        private void cbChangeImage_CheckedChanged(object sender, EventArgs e)
        {
            btnImages.Enabled = cbChangeImage.Checked;
            grpData.Enabled = !btnImages.Enabled;
        }

        private void cnSNR_CheckedChanged(object sender, EventArgs e)
        {
            if (cnSNR.Checked == false &&
                chOutput.Checked == false &&
                cbPSNR.Checked == false &&
                chColors.Checked == false)
            {
                toolStripStatusLabel1.Text = "Please select on of chart series!";
                toolStripStatusLabel1.ForeColor = Color.Red;
                btnDraw.Enabled = false;
            }
            else
            {
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel1.ForeColor = Color.Black;
                btnDraw.Enabled = true;
            }
        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
            pbMain.Image = MainImage;
            //bwDrawChart.RunWorkerAsync();
            PluginName = Application.StartupPath + "\\Plugins\\"+ cbPlugin.Text + ".dll";
            argPara = cbParameters.Text;
            FileNameDir = "";
            Size sz= new Size(MainImage.Width,MainImage.Height);

            ThreadPool.QueueUserWorkItem(DrawChart,sz);
        }


        private delegate void InvokChartValue(string SeriesName, string X, double Y);

        private void InvokChart(string SeriesName, string X, double Y)
        {
            if (Xchart.InvokeRequired) 
            {
                Xchart.Invoke(new InvokChartValue(InvokChart),SeriesName,X,Y); 
            } 
            else 
            {
                if (Xchart.Series.FindByName(SeriesName) != null)
                {
                    int r=Xchart.Series[SeriesName].Points.AddXY(X, Y);
                    Color bg = Xchart.Series[SeriesName].Points[r].Color;

                    //Xchart.Series[SeriesName].Points[r].LabelBackColor =
                    //    Color.FromArgb(bg.R, bg.G, bg.B);
                   
                    if (SeriesName == "SNR" || SeriesName == "PSNR" || SeriesName == "CPR")
                        Xchart.Series[SeriesName].Points[r].Label = Y.ToString() + "dB";
                    else
                        Xchart.Series[SeriesName].Points[r].Label = Y.ToString();

                }
            }
        }

        private void InitalChart(string ChartType, string X, double Y)
        {
            Color[] Pal= new Color[] {Color.Red,Color.Blue,Color.Green,Color.Pink,Color.Purple};
            Color[] PalLabel = new Color[] { Color.LightSalmon, Color.LightBlue, 
                Color.LightGreen, Color.LightPink, Color.Purple };

            int i=0;


            if (Xchart.InvokeRequired)
            {
                Xchart.Invoke(new InvokChartValue(InitalChart), ChartType, X, Y);
            }
            else
            {
                btnDraw.Enabled = false;
                btnImages.Enabled = false;
                Xchart.Series.Clear();
                

                if (cnSNR.Checked) Xchart.Series.Add("SNR");
                if (cbPSNR.Checked) Xchart.Series.Add("PSNR");
                if (chColors.Checked) Xchart.Series.Add("Colors");
                if (chOutput.Checked) Xchart.Series.Add(chOutput.Text);


                foreach (var item in Xchart.Series)
                {
                    item.Color=Pal[i];

                    item.MarkerStyle = MarkerStyle.Circle;
                    if (true)
                    {
                        item.IsValueShownAsLabel = true;
                        item.LabelBackColor = PalLabel[i];
                        item.LabelBorderColor = Pal[i];                     
                    }
                    //else
                    //{
                    //    item.IsValueShownAsLabel = false;
                    //}


                    if (ChartType == "Line")
                    {
                        item.ChartType = SeriesChartType.Line;
                        item.BorderWidth = 3;
                    }
                 //   item.Font = new Font("Arial", 10);

                    //if ("PSNR SNR".Contains(item.Name))
                    //    item.LabelFormat = "{#.#}dB";

                    i++;

                }
            }
        }
        private void FinishChart(string SeriesName, string X, double Y)
        {

            if (btnPrint.InvokeRequired)
            {
                btnPrint.Invoke(new InvokChartValue(FinishChart), SeriesName, X, Y);

            }
            else
            {
                btnPrint.Enabled = true;
                btnSaveChart.Enabled = true;

                btnImages.Enabled = true;

                cbPlugin_SelectedIndexChanged(new  object(), new EventArgs());
            }
        }


        /// <summary>
        /// DrawChart Series
        /// </summary>
        private void DrawChart(object obj)
        {
            int W = ((Size)obj).Width, H = ((Size)obj).Height;
           // int W = 512, H = 512;

            Bitmap bmp = new Bitmap(W, H);
            VPCompile.Compiler vc = new VPCompile.Compiler();
            object[] MainArgObj = new object[CountArg];
            int IndexParam=-1,IndexOut=-1;
            int count=0;

            double StartX = (double)numFrom.Value;
            double EndX = (double)numTo.Value;
            double IncX = (double)numInc.Value;

            InitalChart("Line", "0", 0);
            
            MainParameters = new ParameterInfo[CountArg-1];
            MainParameters=GetParamsPlugin(PluginName);

            foreach (ParameterInfo item in MainParameters)
            {
                if (item.Name == argPara)
                    IndexParam = count;

                if (item.IsOut)
                    IndexOut = count;

                MainArgObj[count] = MainParameters[count];
                MainArgObj[count] = item.DefaultValue;
                count++;
            }

            for(double i=StartX;i<=EndX;i+=IncX)
            {
                string ErrorMessage = "";

                if (IndexParam > 0) MainArgObj[IndexParam] = i;
               
                MainArgObj[0] = MainImage;
               // MainArgObj[1] = "";


                // Draw target image
                pbMain.Image= vc.RunCodePlugin(PluginName, MainImage, MainArgObj, out  ErrorMessage);

                if (pbMain.Image == null)
                {
                    MessageBox.Show("An error occurred and Plug-in has stopped!" + 
                        Environment.NewLine + Environment.NewLine +
                        ErrorMessage, "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);

                    FinishChart("", "0", 0);

                    return;
                }

                ii = ImageProperty.CalculateImageInfo(MainImage,
                    pbMain.Image, ImageProperty.RGB.RGB);
                
                InvokChart("SNR", i.ToString(), ii.SNR);
                InvokChart("PSNR", i.ToString(), ii.PSNR);
                InvokChart("Colors", i.ToString(), ii.NumberofColors);

                if(IndexOut>0)
                    try
                    {
                        InvokChart(chOutput.Text, i.ToString(), Convert.ToDouble(MainArgObj[IndexOut]));
                    }
                      catch
                    {
                        InvokChart(chOutput.Text, i.ToString(), 0);
                    }

            }
            FinishChart("", "0", 0);
        }

        /// <summary>
        /// Choose multi files for drawing the chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImages_Click(object sender, EventArgs e)
        {
            PluginName = Application.StartupPath + "\\Plugins\\" + cbPlugin.Text + ".dll";
            argPara = cbParameters.Text;


            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Open Image for analysis";
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP) | *.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp";
            op.Multiselect = true;

            if (op.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(op.FileNames[0]);
                FileNameDir=fi.Directory.ToString();

                ThreadPool.QueueUserWorkItem(DrawChartFiles,(object)op.FileNames);
            }
        }


        // draw with filenames
        private void DrawChartFiles(object p)
        {
            string[] fnames= (string[])p;
            VPCompile.Compiler vc = new VPCompile.Compiler();
            object[] MainArgObj = new object[CountArg];
            int i = 1;
            int IndexOut = 0,count=0;


            InitalChart("Bar", "0", 0);

            MainParameters = new ParameterInfo[CountArg - 1];
            MainParameters = GetParamsPlugin(PluginName);

            foreach (ParameterInfo item in MainParameters)
            {
                if (item.IsOut)
                    IndexOut = count;
                MainArgObj[count] = item.DefaultValue;

                count++;
            }


            foreach (string fn in fnames)
            {
                string ErrorMessage = "";
                FileInfo fi = new FileInfo(fn);

                MainArgObj[0] = MainImage;
                //MainArgObj[1] = "";

                // Draw target image
                pbMain.Image = vc.RunCodePlugin(PluginName,
                        Image.FromFile(fn), MainArgObj, out  ErrorMessage);

                if(pbMain.Image==null)
                {
                    MessageBox.Show("An error occurred and Plug-in has stopped!" + Environment.NewLine + Environment.NewLine+
                        ErrorMessage, "Error"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Error);

                    FinishChart("", "0", 0);

                    return;
                }

                ii = ImageProperty.CalculateImageInfo(MainImage,pbMain.Image, ImageProperty.RGB.RGB);

                InvokChart("SNR", fi.Name, ii.SNR);
                InvokChart("PSNR", fi.Name, ii.PSNR);
                InvokChart("Colors", fi.Name, ii.NumberofColors);

                i++;

                if (IndexOut > 0)
                    try
                    {
                        InvokChart(chOutput.Text, fi.Name, (double)MainArgObj[IndexOut]);
                    }
                    catch
                    {
                        InvokChart(chOutput.Text, fi.Name, 0);
                    }


            }


            FinishChart("", "0", 0);


        }

       

        private void Xchart_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult result = Xchart.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                string LabelName = result.Series.Points[result.PointIndex].AxisLabel;
                if (FileNameDir.Length == 0)
                {
                    double x = result.Series.Points[result.PointIndex].XValue;

                    MessageBox.Show("Value=" +
                        result.Series.Points[result.PointIndex].YValues[0].ToString());
                }
                else
                {
                    string Filname = FileNameDir + "\\" + LabelName;

                    pbMain.Load(Filname);
                }
            }
        }

        private void cbMajorx_CheckedChanged(object sender, EventArgs e)
        {
            Xchart.ChartAreas[0].AxisX.MajorGrid.Enabled = cbMajorx.Checked;
        }

        private void cbMajorY_CheckedChanged(object sender, EventArgs e)
        {
            Xchart.ChartAreas[0].AxisY.MajorGrid.Enabled = cbMajorY.Checked;
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();

            sv.Title = "Save source image";
            sv.DefaultExt = "jpg";
            sv.Filter = "JPG Files(*.jpg)|*.jpg";
            sv.FileName = "Chart"+cbPlugin.Text+"_"+cbParameters.Text;
           
            
            if (sv.ShowDialog() == DialogResult.OK)
            {
                Xchart.SaveImage(sv.FileName, ChartImageFormat.Jpeg);
            }
            sv.Dispose();
        }

        private void chShowLabels_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Xchart.Printing.Print(true);
        }



      
    }
}
