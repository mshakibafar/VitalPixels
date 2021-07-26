using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VitalPixels
{
    public partial class FOpenSampleImage : Form
    {
        public string FileName { get; set; }

        public FOpenSampleImage()
        {
            InitializeComponent();
        }

        private void FOpenSampleImage_Load(object sender, EventArgs e)
        {
            FillImageinList();
        }

        private void FillImageinList()
        {
            string[] dirs = Directory.GetFiles(Application.StartupPath+"\\Samples", "*.png");
            string[] Standard=new string[7] {"Barbara.png", "Boat.png", "Cameraman.png","Lenna.png"
                                                ,"Mandril.png","Parrot.png","Peppers.png"};

            foreach (string item in dirs)
	        {
                Image img= Image.FromFile(item);
                int inx = imageList1.Images.Add(img, this.BackColor);

                FileInfo fi = new FileInfo(item);
                ListViewItem lv;
                if(Standard.Contains<string>(fi.Name))
                    lv = new ListViewItem(fi.Name,inx,listViewImages.Groups[0]);
                else
                    lv = new ListViewItem(fi.Name,inx,listViewImages.Groups[1]);

                listViewImages.Items.Add(lv);
	        }

            this.Refresh();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FileName = listViewImages.SelectedItems[0].Text;
            Close();
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fname = Application.StartupPath + "\\Samples\\" + listViewImages.SelectedItems[0].Text;
                FileInfo fi = new FileInfo(fname);
                Size sz = new System.Drawing.Size();
                Image img=Image.FromFile(fname);
                sz = img.Size;

                lblWidth.Text = "Width: " + sz.Width.ToString();
                lblHeight.Text = "Height: " + sz.Height.ToString();
                lblSize.Text = "Size: " + (fi.Length / 1024).ToString() + " KB";
                lblColors.Text = "Resolution: " + img.HorizontalResolution.ToString();
                btnOK.Enabled = true;
            }
            catch
            {
                btnOK.Enabled = false;
            }
        }

        private void listViewImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewImages.SelectedItems.Count > 0)
            {
                DialogResult = DialogResult.OK;
                btnOK_Click(sender, e);
            }
        }

    }
}
