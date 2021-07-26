using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VPRun
{
    public partial class FRuntime : Form
    {
        public FRuntime()
        {
            InitializeComponent();
        }

        private void toolBtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Filter = "All supported file:(*.jpg, *.jpeg, *.jpe, *.gif, *.png, *.BMP)|*.jpg; *.jpeg; *.jpe; *.gif; *.png;*.bmp;" +
                "|All Files (*.*)|*.*";
            op.Multiselect = true;
            op.Title = "Open Images";

            if (op.ShowDialog() == DialogResult.OK)
            {
                foreach (string fname in op.FileNames)
                {
                    OpenFile(fname);
                }                                
            }
        }

        private void OpenFile(string fname)
        {
            FChileImage fimg = new FChileImage(fname,this);

            fimg.MdiParent = this;
            fimg.Text = "File: " + fname + "";
            fimg.Show();
        }
    }
}
