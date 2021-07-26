using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels.User_Controls
{
    public partial class UCZoomControl : UserControl
    {
        private string UCTag;
        private Object ParentInstance;
        private Size ParentSize;
        private Size ImageSize;


        public UCZoomControl(string argTag,Object Instance,Size argSize,Size argImageSize)
        {
            InitializeComponent();
                        
            trackBarZoom.Tag = (object)argTag;
            UCTag = argTag;
            ParentInstance = Instance;

                       ParentSize = argSize;
            ImageSize = argSize;
        }



        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            if (UCTag == "Output" && ((FImageSource)(ParentInstance)).pbOutput.Image == null) trackBarZoom.Value = 100;

            ((FImageSource)(ParentInstance)).ZoomPictureBox(UCTag, trackBarZoom.Value);
            labelZoomPer.Text = "Zoom: " + trackBarZoom.Value.ToString()+"%";
        }

        private void FitToScreen(object sender, EventArgs e)
        {
            double Scale=((FImageSource)(ParentInstance)).FitToScreen(UCTag);
            if (Scale < .1) Scale = .1;
            if (Scale * 100 <= trackBarZoom.Maximum)
                trackBarZoom.Value = (int)(Scale * 100);
            else
                trackBarZoom.Value = trackBarZoom.Maximum;

        }

        private void OriginalSize_Click(object sender, EventArgs e)
        {
            ((FImageSource)(ParentInstance)).ZoomPictureBox(UCTag, 100);
            trackBarZoom.Value = 100;
        }

    }
}
