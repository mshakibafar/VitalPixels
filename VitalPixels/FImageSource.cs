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
using VitalPixels;
using VPFilter;

namespace VitalPixels
{
    public partial class FImageSource : Form
    {
        public string SourceFileName;
        private MDIMainForm ParentForm;
        internal Image InputImage,OutputImage;
        private int DragX, DragY;
        internal ImageProperty imgPro;
        private Image TempDrag;
        private bool MouseOverOutput = false;



        // Open Child with paretForm
        public FImageSource(string fname, MDIMainForm mDIMainForm)
        {
            InitializeComponent();

            SourceFileName = fname;
            ParentForm = mDIMainForm;

            pbInput.Image = Image.FromFile(fname);
            pbOutput.Image = null;
            pbOutput.Size = pbInput.Size;
            InputImage = pbInput.Image;
            imgPro = new ImageProperty(fname);


            AllAlignCenter();
        }

        //public FImageSource(Image img, MDIMainForm mDIMainForm)
        //{
        //    InitializeComponent();

        //    SourceFileName = "";
        //    ParentForm = mDIMainForm;

        //    pbInput.Image = img;
        //    pbOutput.Image = null;
        //    pbOutput.Size = pbInput.Size;
        //    InputImage = pbInput.Image;
        //    imgPro = new ImageProperty(img);


        //    AllAlignCenter();
        //}


        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            pbInput.Top = panelInput.Height / 2 - pbInput.Height / 2;
            pbInput.Left = panelInput.Width / 2 - pbInput.Width / 2;
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            pbOutput.Top = panelOutput.Height / 2 - pbOutput.Height / 2;
            pbOutput.Left = panelOutput.Width / 2 - pbOutput.Width / 2;
        }

        private void splitContainerImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AllAlignCenter();

        }

        /// <summary>
        /// Align Input and output image to center
        /// </summary>
        internal void AllAlignCenter()
        {
            splitContainerImages.SplitterDistance = (splitContainerImages.Width - splitContainerImages.SplitterWidth) / 2;

            pbInput.Top = panelInput.Height / 2 - pbInput.Height / 2;
            pbInput.Left = panelInput.Width / 2 - pbInput.Width / 2;

            pbOutput.Top = panelOutput.Height / 2 - pbOutput.Height / 2;
            pbOutput.Left = panelOutput.Width / 2 - pbOutput.Width / 2;
        }

        private void FImageSource_Activated(object sender, EventArgs e)
        {
            splitContainerImages.Panel1Collapsed = !Properties.Settings.Default.WindowSource;
            splitContainerImages.Panel2Collapsed = !Properties.Settings.Default.WindowOuput;

            if (Properties.Settings.Default.ImageSplitVertical)
                splitContainerImages.Orientation = Orientation.Vertical;
            else
                splitContainerImages.Orientation = Orientation.Horizontal;
            
            ParentForm.pbTinySource.Image = pbInput.Image;
            ParentForm.propertyGridMain.SelectedObject = imgPro;
        }

        private void FImageSource_Paint(object sender, PaintEventArgs e)
        {
            AllAlignCenter();
        }

        private void FImageSource_Load(object sender, EventArgs e)
        {
            User_Controls.UCZoomControl UCZ = new User_Controls.UCZoomControl("Input",this,
                panelInput.Size,InputImage.Size);

            panelSettingInput.Controls.Clear();
            panelSettingInput.Controls.Add(UCZ);

            User_Controls.UCZoomControl UCZO = new User_Controls.UCZoomControl("Output",this,
                panelOutput.Size, InputImage.Size);

            panelSettingOutput.Controls.Clear();
            panelSettingOutput.Controls.Add(UCZO);


            if(Properties.Settings.Default.ShowInfoPanel==false)
            {
                Collapse_Click(sender,e);
                CollapseOutput_Click(sender, e);
            }

        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            double CurrentZoom;
            double NewZoom;
            string TagT;

            if (MouseOverOutput)
            {
                TagT = "Output";
                if (pbOutput.Image == null) return;
                CurrentZoom = ((double)pbOutput.Width) / ((double)pbOutput.Image.Width);

            }
            else
            {
                TagT = "Input";
                CurrentZoom = ((double)pbInput.Width) / ((double)pbInput.Image.Width);
            }

            if(e.Delta>0)
                NewZoom= CurrentZoom * 100 + 10;
            else
                NewZoom= CurrentZoom * 100 - 10;




            if (400>NewZoom&&NewZoom>0)
            {

                ZoomPictureBox(TagT, NewZoom);
                Control[] cl;

                if (!MouseOverOutput)
                     cl= panelSettingInput.Controls.Find("trackBarZoom", true);
                else
                     cl = panelOutput.Controls.Find("trackBarZoom", true);

                try
                {
                    ((TrackBar)cl[0]).Value = (int)(NewZoom);
                }
                catch
                {
                    ParentForm.toolStripStatusLabel.Text = "Zoom:"+ ((int)NewZoom).ToString()+"%";
                }
            }
        }

      

        /// <summary>
        /// Zoom picture Box
        /// </summary>
        /// <param name="UCTag"></param>
        /// <param name="p"></param>
        internal void ZoomPictureBox(string UCTag, double Percent)
        {
            int MW=InputImage.Width, MH=InputImage.Height;

            //if(pbInput.Image!=InputImage)
            //{
            //    MW = TempDrag.Width;
            //    MH = TempDrag.Height;
            //}

            if (UCTag == "Input")
            {
               // btnZoomInput.Text = "Zoom:" + trackBarInputZoom.Value.ToString() + "%";
                pbInput.SizeMode = PictureBoxSizeMode.StretchImage;

                pbInput.Width = (int)(MW * (Percent / 100f));
                pbInput.Height = (int)(MH * (Percent / 100f));


                if(panelInput.Width>pbInput.Width)
                     pbInput.Left = panelInput.Width / 2 - pbInput.Width / 2;
                else
                    pbInput.Left = 5;

                if (panelInput.Height > pbInput.Height)
                    pbInput.Top = panelInput.Height / 2 - pbInput.Height / 2;
                else                
                    pbInput.Top = 5;

                panelInput.Refresh();
            }

            if (UCTag == "Output")
            {
                if (pbOutput.Image == null)
                {
                    Percent = 100;
                    return;
                }
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;

                pbOutput.Width = (int)(OutputImage.Width * ((double)Percent / 100.0));
                pbOutput.Height = (int)(OutputImage.Height * ((double)Percent / 100.0));

                if (panelOutput.Width > pbOutput.Width)
                    pbOutput.Left = panelOutput.Width / 2 - pbOutput.Width / 2;
                else
                    pbOutput.Left = 5;

                if (panelOutput.Height > pbOutput.Height)
                    pbOutput.Top = panelOutput.Height / 2 - pbOutput.Height / 2;
                else
                    pbOutput.Top = 5;

                panelOutput.Refresh();
            }
        }

        internal double FitToScreen(string UCTag)
        {
            double Scale;

            if (UCTag == "Input")
            {
                if (InputImage.Width > InputImage.Height)
                    Scale = ((double)panelInput.Width) / ((double)InputImage.Width);
                else
                    Scale = ((double)panelInput.Height) / ((double)InputImage.Height);
            }
            else
            {
                if (InputImage.Width > InputImage.Height)
                    Scale = ((double)panelOutput.Width) / ((double)InputImage.Width);
                else
                    Scale = ((double)panelOutput.Height) / ((double)InputImage.Height);
            }
           

            ZoomPictureBox(UCTag, Scale * 100);

            return Scale;

        }

        private void splitterInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            splitterInput.SplitPosition = splitterOutput.SplitPosition;
        }

        private void splitterOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            splitterOutput.SplitPosition = splitterInput.SplitPosition;
        }

        private void Collapse_Click(object sender, EventArgs e)
        {
           // panelSettingInput.Visible = false;
            if (btnCollapseInput.ImageIndex == 0)
            {
                panelMainSettingInut.Height = panelTopInput.Height;
                btnCollapseInput.ImageIndex = 1;
                btnRefresh.Visible = false;
                btnInputTypeSetting.Visible = false;
                AllAlignCenter();
                splitterInput.Enabled = false;
            }
            else
            {
                panelMainSettingInut.Height = 100;
                btnCollapseInput.ImageIndex = 0;
                splitterInput.Enabled = true;
                btnRefresh.Visible = true;
                btnInputTypeSetting.Visible = true;
                AllAlignCenter();
            }

        }

        private void ChooseTypeInput_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in MenuSettingType.Items)
            {
                item.Tag = "Input";   
            }

            MenuSettingType.Tag = (Object)"Input";
            MenuSettingType.Show(btnInputTypeSetting, new Point(btnInputTypeSetting.Width, 0));
        }

        

        private void ChooseTypeOutput_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in MenuSettingType.Items)
            {
                item.Tag = "Output";
            }

            MenuSettingType.Tag = (Object)"Output";
            MenuSettingType.Show(btnOutputTypeSetting, new Point(btnOutputTypeSetting.Width, 0));
        }
        /// <summary>
        /// Show Histogram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistogramSettingsShow(object sender, EventArgs e)
        {
            string typeTag = ((ToolStripItem)sender).Tag.ToString();
            

            if (typeTag == "Input")
            {
                UCHistogram UCZ = new UCHistogram(InputImage);
                panelMainSettingInut.Height = 200;
                UCZ.Width = panelSettingInput.Width;
                UCZ.Height = panelSettingInput.Height;

                panelSettingInput.Controls.Clear();
                panelSettingInput.Controls.Add(UCZ);
            }
            else
            {
               // if (pbOutput.Image == null) return;
                UCHistogram UCZ = new UCHistogram(pbOutput.Image);
                panelSettingOutput.Height = 200;
                UCZ.Width = panelSettingOutput.Width;
                UCZ.Height = panelSettingOutput.Height;

                panelSettingOutput.Controls.Clear();
                panelSettingOutput.Controls.Add(UCZ);
            }


        }
        /// <summary>
        /// Show Zoom Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomSettingShow(object sender, EventArgs e)
        {
            string typeTag = ((ToolStripItem)sender).Tag.ToString();

            if (typeTag == "Input")
            {
                User_Controls.UCZoomControl UCZ = new User_Controls.UCZoomControl(typeTag, this,
                 panelInput.Size, InputImage.Size);

                panelMainSettingInut.Height = 75;

                panelSettingInput.Controls.Clear();
                panelSettingInput.Controls.Add(UCZ);
            }
            else
            {
                User_Controls.UCZoomControl UCZ = new User_Controls.UCZoomControl(typeTag, this,
                    panelOutput.Size, InputImage.Size);

                panelSettingOutput.Height = 75;

                panelSettingOutput.Controls.Clear();
                panelSettingOutput.Controls.Add(UCZ);
            }
        }

        private void panelSettingInput_Resize(object sender, EventArgs e)
        {
            foreach (Control item in ((Panel)sender).Controls)
            {
                item.Width = ((Panel)sender).Width;
                item.Height = ((Panel)sender).Height;
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string typeTag = ((ToolStripItem)sender).Tag.ToString();
            VPUserControls.UCColors UCZ;


            if (typeTag == "Input")
            {
                panelMainSettingInut.Height = 150;
                UCZ = new VPUserControls.UCColors(pbInput.Image);
                panelSettingInput.Controls.Clear();
                panelSettingInput.Controls.Add(UCZ);
            }
            else
            {
                if (pbOutput.Image == null) return;
                panelSettingOutput.Height = 150;
                UCZ = new VPUserControls.UCColors(pbOutput.Image);
                panelSettingOutput.Controls.Clear();
                panelSettingOutput.Controls.Add(UCZ);
            }
        }


        private void CollapseOutput_Click(object sender, EventArgs e)
        {
          //  panelMainSettingOutput.Visible = false;
            if (btnCollapseOutput.ImageIndex == 0)
            {
                panelMainSettingOutput.Height = panelTopOutput.Height;
                btnCollapseOutput.ImageIndex = 1;
                btnOutputTypeSetting.Visible = false;
                splitterOutput.Enabled = false;
            }
            else
            {
                panelMainSettingOutput.Height = 100;
                btnCollapseOutput.ImageIndex = 0;
                btnOutputTypeSetting.Visible = true;
                splitterOutput.Enabled = true;
            }
            AllAlignCenter();
        }

        private void pbInput_MouseDown(object sender, MouseEventArgs e)
        {
            DragX = e.X;
            DragY = e.Y;
           // MessageBox.Show(e.X.ToString()+":"+e.Y.ToString());
            if (e.Button != MouseButtons.Right)
            {
                if (ParentForm.CurrentMode != MDIMainForm.ModeEdit.None)
                    ParentForm.CurrentMode = MDIMainForm.ModeEdit.StartDrag;
            }
            else
            {
                if (ParentForm.CurrentMode != MDIMainForm.ModeEdit.None)
                {
                    ParentForm.CurrentMode = MDIMainForm.ModeEdit.None;
                    //toolStripCrop.Checked = false;

                    ((PictureBox)sender).Cursor = Cursors.Arrow;
                    ((PictureBox)sender).Refresh();
                   // toolStripMessage.Text = "Crop Canceled!";
                }
            }
        }

        private void pbInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (ParentForm.CurrentMode == MDIMainForm.ModeEdit.StartDrag)
            {
                Pen pn = new Pen(Brushes.Red);
                int w, h;

                pn.Width = 2;
                pn.DashStyle = DashStyle.Dot;
                pn.Color = Color.Red;

                w = Math.Abs(e.X - DragX);
                h = Math.Abs(e.Y - DragY);

                int X1 = (e.X < DragX) ? e.X : DragX;
                int Y1 = (e.Y < DragY) ? e.Y : DragY;

                // DRAW SHADOW
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 200));
                Region r = new Region(new Rectangle(0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height));
                r.Exclude(new Rectangle(X1, Y1, w, h));
                ((PictureBox)sender).Refresh();
                Bitmap b = new Bitmap(((PictureBox)sender).Width, ((PictureBox)sender).Height);
                Graphics gr = Graphics.FromImage(b);
                Graphics gr2 = ((PictureBox)sender).CreateGraphics();
                gr.FillRegion(semiTransBrush, r);
                gr.DrawRectangle(pn, X1, Y1, w, h);

                gr2.DrawImage(b, 0, 0);
                gr2.Dispose();
                gr.Dispose();

                // Write on Status bar 
                ParentForm.toolStripStatusLabel.Text = "Crop Size: " + w.ToString() + "X" + h.ToString();
            }
            else
            {
                try
                {
                    double Scale = ((double)pbInput.Width) / ((double)pbInput.Image.Width);

                    if (Properties.Settings.Default.ShowColorInput)
                    {
                        Color cl = ((Bitmap)((PictureBox)sender).Image).GetPixel((int)((double)e.X / Scale), 
                            (int)((double)e.Y / Scale));
                        ParentForm.toolStripStatusLabel.Text = cl.ToString().Replace("A=255,", "");
                        ParentForm.StatusColor.BackColor = cl;

                        double RBr = 0.2126, GBr = 0.7152, BBR = 0.0722;
                        double Brightness = (RBr * cl.R + GBr * cl.G + BBR * cl.B);
                        double MaxBr = 255 * RBr + 255 * GBr + 255 * BBR;
                        ParentForm.toolStripBrightness.Text = " Brightness: " + 
                            Math.Floor((Brightness*100)/MaxBr).ToString()+"%";
                    }
                }
                catch
                {
                    ParentForm.toolStripStatusLabel.Text = "";
                }

            }
        }

        private void pbInput_MouseUp(object sender, MouseEventArgs e)
        {
            if (ParentForm.CurrentMode == MDIMainForm.ModeEdit.StartDrag)
            {
                int X1 = (e.X < DragX) ? e.X : DragX;
                int Y1 = (e.Y < DragY) ? e.Y : DragY;
                int w = Math.Abs(e.X - DragX);
                int h = Math.Abs(e.Y - DragY);
                double Scale = (double)InputImage.Width / (double)pbInput.Image.Width;

                pbInput.Image = VPFilter.FilterImage.CropImage(pbInput.Image,
                    (int)(X1 * Scale), (int)(Y1 * Scale),
                    (int)(w * Scale), (int)(h * Scale));
                TempDrag = pbInput.Image;

                //  CurrentSourceImage.MainImage = pbMain.Image;

                ParentForm.CurrentMode = MDIMainForm.ModeEdit.None;
                ParentForm.toolStripCrop.Checked = false;
                ParentForm.SourceChanged();
                pbInput.Cursor = Cursors.Arrow;

                
                //pbInput.BorderStyle = Border3DStyle.Etched;
            }
            AllAlignCenter();
            panelInput.Refresh();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// Refresh Data for chart and colors
        /// </summary>
        internal void RefreshData()
        {
            Control ch = panelSettingInput.Controls[0];

            if (ch.Name == "UCHistogram")
            {
                UCHistogram UCZ = new UCHistogram(InputImage);
                panelMainSettingInut.Height = 200;
                UCZ.Width = panelSettingInput.Width;
                UCZ.Height = panelSettingInput.Height;

                panelSettingInput.Controls.Clear();
                panelSettingInput.Controls.Add(UCZ);
            }

            if (ch.Name == "UCColors")
            {
                VPUserControls.UCColors UCZ = new VPUserControls.UCColors(InputImage);
                panelMainSettingInut.Height = 200;
                UCZ.Width = panelSettingInput.Width;
                UCZ.Height = panelSettingInput.Height;

                panelSettingInput.Controls.Clear();
                panelSettingInput.Controls.Add(UCZ);
            }
            imgPro = new ImageProperty(pbInput.Image, SourceFileName);
            ParentForm.propertyGridMain.SelectedObject = imgPro;
            ParentForm.propertyGridMain.Refresh();
           // pbInput.Refresh();
            panelInput.Refresh();

        }
        /// <summary>
        /// Refresh Histogram and All colors of Output
        /// </summary>
        internal void RefreshOutput()
        {
            Control ch = panelSettingOutput.Controls[0];

            if (ch.Name == "UCHistogram")
            {
                UCHistogram UCZ = new UCHistogram(pbOutput.Image);
                panelSettingOutput.Height = 200;
                UCZ.Width = panelSettingOutput.Width;
                UCZ.Height = panelSettingOutput.Height;

                panelSettingOutput.Controls.Clear();
                panelSettingOutput.Controls.Add(UCZ);
            }

            if (ch.Name == "UCColors")
            {
                VPUserControls.UCColors UCZ = new VPUserControls.UCColors(pbOutput.Image);
                panelSettingOutput.Height = 200;
                UCZ.Width = panelSettingOutput.Width;
                UCZ.Height = panelSettingOutput.Height;

                panelSettingOutput.Controls.Clear();
                panelSettingOutput.Controls.Add(UCZ);
            }


            panelOutput.Refresh();
        }

        private void pbOutput_Paint(object sender, PaintEventArgs e)
        {
            OutputImage = pbOutput.Image;
            if (pbOutput.Image != null) pbOutput.BackgroundImage = null;
            pbInput_Paint(sender, e);
        }


        private void FImageSource_MdiChildActivate(object sender, EventArgs e)
        {
           // MessageBox.Show("Test");

        }

        private void pbOutput_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                double Scale = ((double)pbOutput.Width) / ((double)pbOutput.Image.Width);
                if (Properties.Settings.Default.ShowColorOutput)
                {
                    Color cl = ((Bitmap)pbOutput.Image).GetPixel((int)((double)e.X / Scale) ,(int) ((double)e.Y /Scale));
                    ParentForm.toolStripStatusLabel.Text = cl.ToString().Replace("A=255,", "");
                   // ParentForm.toolStripStatusLabel.Text =Scale.ToString()+":"+((double)e.X / Scale).ToString();
                    ParentForm.StatusColor.BackColor = cl;
                }
            }
            catch
            {
                ParentForm.toolStripStatusLabel.Text = "";
                ParentForm.StatusColor.BackColor = Color.Transparent;
                ParentForm.toolStripStatusLabel.Text = e.X.ToString() + ":" + e.Y.ToString();
              //  MessageBox.Show(pbOutput.Top.ToString());
            }
        }

        private void pbOutput_Move(object sender, EventArgs e)
        {

        }

        private void pbInput_MouseLeave(object sender, EventArgs e)
        {
            ParentForm.toolStripStatusLabel.Text= "";
            ParentForm.StatusColor.BackColor = Color.Transparent;
        }

        private void SaveImageAs(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "PNG File (*.png)|*.png;";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                pbOutput.Image.Save(sv.FileName);
            }
        }

        private void MenuOutputImage_Opening(object sender, CancelEventArgs e)
        {
            if (pbOutput.Image == null)
                e.Cancel = true;
        }

        private void swapWithSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbInput.Image = pbOutput.Image;
            ParentForm.pbTinySource.Image = pbOutput.Image;
            ParentForm.CommitChange(sender,e);
        }

        private void pbInput_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb = (PictureBox)sender;

            if (pb.Image == null) return;
            if (Properties.Settings.Default.ShowGrid)
            {
                Graphics g = e.Graphics;
                e.Graphics.PageUnit = GraphicsUnit.Pixel;
                Color cl = new Color();
                int Step = CentimeterToPixel(1) * (pb.Width / pb.Image.Width);

                if (Step <= 1) return;

                cl = Color.FromArgb(50, Color.White);


                for (int x = 0; x < pb.Width; x += Step)
                {
                    g.DrawLine(new Pen(cl), x, 0, x, pb.Height);
                }
                for (int x = 0; x < pb.Height; x += Step)
                {
                    g.DrawLine(new Pen(cl), 0, x, pb.Width, x);
                }
            }

            if(pbInput.Image!=InputImage)
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Red, 3,ButtonBorderStyle.Dashed,
                    Color.Red,3,ButtonBorderStyle.Dashed,Color.Red,3,ButtonBorderStyle.Dotted,Color.Red,3,ButtonBorderStyle.Dotted);
                ControlPaint.Dark(Color.Red);

            }
           // g.DrawLine(new Pen(cl), 0, 0, -50, -50);

            //MessageBox.Show("Test");
            //panelInput_Paint(sender, new PaintEventArgs(panelInput.CreateGraphics(),
            //    new Rectangle(0,0,panelInput.Width,panelInput.Height)));
            //panelInput.Refresh();
        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {
            if (Properties.Settings.Default.ShowRulers)
            {
                Graphics gr = e.Graphics;
                e.Graphics.PageUnit = GraphicsUnit.Pixel;
                int Step = CentimeterToPixel(1) * (pbInput.Width / pbInput.Image.Width);
                //if(Step<=1) return;

                int RulerHeight = 15;


                // Horizontal Ruler
                gr.FillRectangle(new SolidBrush(Color.White),
                    pbInput.Left, 0, pbInput.Width, RulerHeight);


                for (double x = 0; x < pbInput.Width; x++)
                {
                    if (x % Step == 0)
                        gr.DrawLine(new Pen(Color.Black), (int)(pbInput.Left + x), 0, (int)(pbInput.Left + x), RulerHeight);
                    else
                        if (x % CentimeterToPixel(.1) == 0)
                            gr.DrawLine(new Pen(Color.Gray), (int)(pbInput.Left + x), 0, (int)(pbInput.Left + x), RulerHeight / 2);
                }


                //Vertical Ruler
                gr.FillRectangle(new SolidBrush(Color.White),
                   0, pbInput.Top, RulerHeight, pbInput.Height);


                for (double x = 0; x < pbInput.Height; x++)
                {
                    if (x % Step == 0)
                        gr.DrawLine(new Pen(Color.Black), 0, (int)(pbInput.Top + x), RulerHeight, (int)(pbInput.Top + x));
                    else
                        if (x % CentimeterToPixel(.1) == 0)
                            gr.DrawLine(new Pen(Color.Gray), 0, (int)(pbInput.Top + x), (int)(RulerHeight / 2),
                                (int)(pbInput.Top + x));
                }
            }
        }

        /// <summary>
        /// Change Centimeters to Pixels
        /// </summary>
        /// <param name="Centimeter">Centimeter</param>
        /// <returns>Pixels</returns>

        int CentimeterToPixel(double Centimeter)
        {
            double pixel = -1;
            using (Graphics g = this.CreateGraphics())
            {
                pixel = Centimeter * g.DpiY / 2.54d;
            }
            return (int)pixel;
        }

        private void panelOutput_Paint(object sender, PaintEventArgs e)
        {
            if (pbOutput.Image == null) return;
            if (Properties.Settings.Default.ShowRulers)
            {
                Graphics gr = e.Graphics;
                e.Graphics.PageUnit = GraphicsUnit.Pixel;
                int Step = CentimeterToPixel(1) * (pbOutput.Width / pbOutput.Image.Width);
                //if(Step<=1) return;

                int RulerHeight = 15;


                // Horizontal Ruler
                gr.FillRectangle(new SolidBrush(Color.White),
                    pbOutput.Left, 0, pbOutput.Width, RulerHeight);


                for (double x = 0; x < pbOutput.Width; x++)
                {
                    if (x % Step == 0)
                        gr.DrawLine(new Pen(Color.Black), (int)(pbOutput.Left + x), 0, (int)(pbOutput.Left + x), RulerHeight);
                    else
                        if (x % CentimeterToPixel(.1) == 0)
                            gr.DrawLine(new Pen(Color.Gray), (int)(pbOutput.Left + x), 0, (int)(pbOutput.Left + x), RulerHeight / 2);
                }


                //Vertical Ruler
                gr.FillRectangle(new SolidBrush(Color.White),
                   0, pbOutput.Top, RulerHeight, pbOutput.Height);


                for (double x = 0; x < pbOutput.Height; x++)
                {
                    if (x % Step == 0)
                        gr.DrawLine(new Pen(Color.Black), 0, (int)(pbOutput.Top + x), RulerHeight, (int)(pbOutput.Top + x));
                    else
                        if (x % CentimeterToPixel(.1) == 0)
                            gr.DrawLine(new Pen(Color.Gray), 0, (int)(pbOutput.Top + x), (int)(RulerHeight / 2),
                                (int)(pbOutput.Top + x));
                }
            }

        }

        private void copyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pbOutput.Image);
        }

        private void pbOutput_MouseHover(object sender, EventArgs e)
        {
            MouseOverOutput = true;

        }

        private void panelOutput_MouseLeave(object sender, EventArgs e)
        {
            MouseOverOutput = false;
        }

        private void pbInput_MouseHover(object sender, EventArgs e)
        {
            MouseOverOutput = false;
        }

        private void FImageSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((ParentForm).toolSave.Enabled)
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes ?",
                    "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pbInput.Image.Save(SourceFileName);
                    Close();
                }
                if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

             
    }
}
