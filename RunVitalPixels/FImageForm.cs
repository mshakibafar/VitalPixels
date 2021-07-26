using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunVitalPixels
{
    public partial class FImageForm : Form
    {
        private string FileName;
        private double ZoomSet = 1;
        private Image MainImage;


        public FImageForm(string fname)
        {
            InitializeComponent();
            this.FileName = fname;
            MainImage = Image.FromFile(FileName);
            pbImage.Image = (Image)MainImage.Clone(); ;

        }


        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (e.Delta > 0)
                ZoomSet += .1;
            else
                ZoomSet -= .1;
            if (ZoomSet <= .05) ZoomSet = .05;

            ZoomImage(ZoomSet);
            
        }

        public void ResetImage()
        {
            pbImage.Image = MainImage;
            ZoomSet = 1;
            ZoomImage(ZoomSet);
        }

        public void SaveImage()
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter =
                "PNG files (*.png) |*.png" +
                "|All Files (*.*)|*.*";
            savedialog.DefaultExt = "png";
            savedialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if(savedialog.ShowDialog()==DialogResult.OK)
            {
                pbImage.Image.Save(savedialog.FileName, ImageFormat.Png);
            }
        }
        private void ZoomImage(double percent)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            pbImage.Width =  (int)(pbImage.Image.Width* percent);
            pbImage.Height = (int)(pbImage.Image.Height * percent);

            toolStripStatusZoom.Text = 
                "Zoom: "+
                Math.Floor(((double)pbImage.Width / (double)pbImage.Image.Width) * 100).ToString() + "%";

            // Align to Center

            AllignImageToCenter();

        }

        private void AllignImageToCenter()
        {
            if (pbImage.Width < this.Width)
                pbImage.Left = panelMain.Width / 2 - pbImage.Width / 2;
            else
                pbImage.Left = 0;

            if (pbImage.Height < this.Width)
                pbImage.Top = panelMain.Height / 2 - pbImage.Height / 2;
            else
                pbImage.Top = 0;
        }

        private void statusZoom_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClickOnZoomMenu(object sender, EventArgs e)
        {
            ZoomSet=Double.Parse(((ToolStripMenuItem)sender).Text.Replace("%",""))/100;
            ZoomImage(ZoomSet);
        }

        private void FImageForm_ResizeEnd(object sender, EventArgs e)
        {
            AllignImageToCenter();

        }

        private void FImageForm_Load(object sender, EventArgs e)
        {

        }

    }
}
