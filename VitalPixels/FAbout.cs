using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FAbout_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace("--VERSION--", Application.ProductVersion);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
