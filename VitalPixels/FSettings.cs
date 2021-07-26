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
    public partial class FSettings : Form
    {
        public FSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = btnColor.BackColor;

            if(cd.ShowDialog()==DialogResult.OK)
            {
                btnColor.BackColor=cd.Color;
            }
        }

        private void FSettings_Load(object sender, EventArgs e)
        {
            chkLastOpened.Checked = Properties.Settings.Default.StartupReopen;
            chkUpdate.Checked = Properties.Settings.Default.StartupUpdate;

            chkLineNumber.Checked = Properties.Settings.Default.EditorShowline;
            chkFoldingLine.Checked = Properties.Settings.Default.EditorShowFolding;
            btnColor.BackColor = Properties.Settings.Default.EditorBackColor;

            chkinfoPanel.Checked = Properties.Settings.Default.ShowInfoPanel;
            chkColorInput.Checked = Properties.Settings.Default.ShowColorInput;
            chkColorOutput.Checked = Properties.Settings.Default.ShowColorOutput;

            chOpenSample.Checked = Properties.Settings.Default.OpenSampleImage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartupReopen =chkLastOpened.Checked ;
            Properties.Settings.Default.StartupUpdate =chkUpdate.Checked ;

            Properties.Settings.Default.EditorShowline = chkLineNumber.Checked;
            Properties.Settings.Default.EditorShowFolding= chkFoldingLine.Checked;
            Properties.Settings.Default.EditorBackColor = btnColor.BackColor;

            Properties.Settings.Default.ShowInfoPanel= chkinfoPanel.Checked;
            Properties.Settings.Default.ShowColorInput= chkColorInput.Checked ;
            Properties.Settings.Default.ShowColorOutput= chkColorOutput.Checked ;
            Properties.Settings.Default.OpenSampleImage = chOpenSample.Checked;
            Properties.Settings.Default.Save();
        }

    }
}
