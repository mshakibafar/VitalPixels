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
    public partial class FFind : Form
    {
        FCodeChild CodeParent = new FCodeChild();

        public FFind(FCodeChild fc,string str)
        {
            InitializeComponent();
            CodeParent = fc;
            txFind.Text = str;
        }

        private void Find_Click(object sender, EventArgs e)
        {
             bool Result=CodeParent.txProgram.SelectNext(txFind.Text,false);
             if (Result == false)
                 MessageBox.Show("Cannot find \"" + txFind.Text + "\"", "Not found",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FindPrevious_Click(object sender, EventArgs e)
        {
            bool Result = CodeParent.txProgram.SelectNext(txFind.Text, true);
            if (Result == false)
                MessageBox.Show("Cannot find \"" + txFind.Text + "\"", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            CodeParent.txProgram.SelectedText = txReplace.Text;
        }

        private void BookMark_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            lst = CodeParent.txProgram.FindLines(txFind.Text,
                System.Text.RegularExpressions.RegexOptions.Multiline);
            CodeParent.txProgram.BookmarkColor = Color.Blue;

            foreach (int item in lst)
            {
                CodeParent.txProgram.BookmarkLine(item);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txFind_TextChanged(object sender, EventArgs e)
        {
            if(txFind.Text.Trim().Length>0)
            {
                btnFind.Enabled = true;
                btnPrev.Enabled = true;
                btBookmark.Enabled = true;
            }
            else
            {
                btnFind.Enabled = false;
                btnPrev.Enabled = false;
                btBookmark.Enabled = false;
            }
            txReplace_TextChanged(sender, e);
        }

        private void txReplace_TextChanged(object sender, EventArgs e)
        {
            if(txReplace.Text.Trim().Length>0 && txFind.Text.Trim().Length>0)
                btnReplace.Enabled = true;
            else
                btnReplace.Enabled = false;
        }
    }
}
