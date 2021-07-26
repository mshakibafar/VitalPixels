using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    public partial class FConvertText : Form
    {
        private Font font = new Font("Times New Roman", 12);
        private int MainWidth=512;
        private int MainHeight = 512;
        private int MarginTop = 5;
        private int MarginLeft = 5;
        private string MainString="";
        public Color FontColor = new Color();
        private Color BackColor = new Color();

        public string filename = "";

        private System.Windows.Forms.TextBox textBox1;

        public FConvertText()
        {
            InitializeComponent();
            FontColor = Color.Black;
            BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text File (*.txt) |*.txt";


            op.Title = "Open Text File";

            if (op.ShowDialog() == DialogResult.OK)
            {
                MainString = File.ReadAllText(op.FileName);

                FitSizes();
                filename = op.FileName;

                pbImageText.Image = ConvertStringToImage(MainString, FontColor);
                btnOK.Enabled = true;
            }
        }

        private void FitSizes()
        {
            if (chAutoSize.Checked == false) return;

            Graphics gr = pbImageText.CreateGraphics();
            int w=MarginLeft*2 + (int)gr.MeasureString(MainString, font).Width;
            int h=MarginTop*2 + (int)gr.MeasureString(MainString, font).Height;
            //if (MarginLeft + gr.MeasureString(MainString, font).Width > MainWidth)

            if(w<numWidth.Maximum)
                numWidth.Value = w;
            else
                numHeight.Value = numWidth.Maximum;

            //if (MarginTop + gr.MeasureString(MainString, font).Height > MainHeight)

            if (h < numHeight.Maximum)
                numHeight.Value = h;
            else
                numHeight.Value = numHeight.Maximum;

        }

        private Image ConvertStringToImage(string str,Color cl)
        {
            Bitmap bmp = new Bitmap(MainWidth, MainHeight);
            Graphics gr = Graphics.FromImage((Image)bmp);


            gr.FillRectangle(new SolidBrush(BackColor), 0, 0, MainWidth, MainHeight);
            gr.DrawString(str, font, new SolidBrush(cl), MarginLeft , MarginTop );
            
            return (Image)bmp;
        }

        private void FontClick(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Font = font;
            fd.Color = FontColor;

            if(fd.ShowDialog()==DialogResult.OK)
            {
                font = fd.Font;
                FontColor =fd.Color;
                FitSizes();

                pbImageText.Image = ConvertStringToImage(MainString,FontColor);
            }
        }



        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            MainWidth = (int)numWidth.Value;
            MainHeight = (int)numHeight.Value;

            pbImageText.Width = MainWidth;
            pbImageText.Height = MainHeight;
            pbImageText.Image = ConvertStringToImage(MainString, FontColor);

        }

        private void numTop_ValueChanged(object sender, EventArgs e)
        {
            MarginLeft= (int)numLeft.Value;
            MarginTop = (int)numTop.Value;


            FitSizes();

            pbImageText.Image = ConvertStringToImage(MainString, FontColor);

        }


        private void pbImageText_MouseDown(object sender, MouseEventArgs e)
        {
            numLeft.Value= e.X;
            numTop.Value = e.Y;
          
        }


        private void pbImageText_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbImageText.Image == null) return;

            pbImageText.Refresh();
            Color cl = new Color();
            cl = Color.FromArgb(180, 0, 0, 250);
            
            Graphics gr = pbImageText.CreateGraphics();
            gr.DrawLine(new Pen(cl), 0, e.Y, pbImageText.Width, e.Y);
            gr.DrawLine(new Pen(cl), e.X, 0, e.X, pbImageText.Height);


            //gr.FillRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 0)),
            //    0, 0, (int)numLeft.Value, pbImageText.Height);

            label6.Text = "X=" + e.X.ToString() + ",Y=" + e.Y.ToString();
            
        }

        private void FConvertText_Load(object sender, EventArgs e)
        {
            

            this.textBox1 = new System.Windows.Forms.TextBox();

            this.textBox1.Location = new System.Drawing.Point(191, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 233);
            this.textBox1.TabIndex = 2;
        }

        private void chAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            FitSizes();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = BackColor;

            if(cd.ShowDialog()==DialogResult.OK)
            {
                BackColor = cd.Color;
                pbImageText.Image = ConvertStringToImage(MainString, FontColor);
            }
        }

    }
}
