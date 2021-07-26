using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels.VPUserControls
{
    public partial class UCColors : UserControl
    {
        private Image MainImage;
        public UCColors(Image arImg)
        {
            InitializeComponent();

            MainImage = arImg;
        }

        private void UCColors_Load(object sender, EventArgs e)
        {
            int cnt = 1; 
            ToolTip tp = new ToolTip();
            HashSet<Color> hs = new HashSet<Color>();
            List<Color> ls = new List<Color>();
            Color TempColor = new Color();
            Bitmap bitmap = (Bitmap)MainImage;


            for (int x = 0; x < MainImage.Width; x++)
                for (int y = 0; y < MainImage.Height; y++)
                {
                    TempColor = bitmap.GetPixel(x, y);

                    //Reds[TempColor.R]++;
                    //Greens[TempColor.G]++;
                    //Blues[TempColor.B]++;
                    if(hs.Contains(TempColor)==false)
                    {
                        int row = dataGridIndex.Rows.Add(TempColor.ToString().Replace("Color [A=255,", "").Replace("]", ""),
                         TempColor.R * 65536 + TempColor.G * 256 + TempColor.B);
                        dataGridIndex.Rows[row].Cells["Color"].Style.BackColor = TempColor;
                        dataGridIndex.Rows[row].Cells["Color"].Style.ForeColor = TempColor;

                        dataGridIndex.Rows[row].Cells["ColorCode"].Value = TempColor.R.ToString("X")
                            + ":" + TempColor.G.ToString("X") + ":" + TempColor.B.ToString("X");

                        dataGridIndex.Rows[row].Cells["no"].Value = cnt;
                        cnt++;
                    }

                    hs.Add(TempColor);
                }
            //var ColorList = hs.OrderBy<Color, int>(x => x.ToArgb()); ;
            //dataGridIndex.Rows.Clear();

            //foreach (var item in hs)
            //{
            //    int row = dataGridIndex.Rows.Add(item.ToString().Replace("Color [A=255,", "").Replace("]", ""),
            //        item.R * 65536 + item.G * 256 + item.B);
            //    dataGridIndex.Rows[row].Cells["Color"].Style.BackColor = item;
            //    dataGridIndex.Rows[row].Cells["Color"].Style.ForeColor = item;

            //    dataGridIndex.Rows[row].Cells["ColorCode"].Value = item.R.ToString("X")
            //        + ":" + item.G.ToString("X") + ":" + item.B.ToString("X") ;
            //}
        }
    }
}
