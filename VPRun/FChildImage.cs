using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPRun
{
    public partial class FChileImage : Form
    {
        private string FileName;
        private string fname;
        private FRuntime fRuntime;


        public FChileImage(string fname,FRuntime frun)
        {
            this.ParentForm = frun;

            this.FileName = fname;
            InitializeComponent();

            pbImage.Image = Image.FromFile(FileName);
        }



        private void FChileImage_Load(object sender, EventArgs e)
        {

        }
    }
}
