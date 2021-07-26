using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalPixels
{
    public partial class FPlugins : Form
    {
        public FPlugins()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Multiselect = false;
            if (File.Exists(txbAddress.Text)) op.FileName = txbAddress.Text;
            op.Filter = "DLL files (*.dll,*.exe) | *.dll;*.exe";
            op.Title = "Choose Plug-in to install";
            if(op.ShowDialog()==DialogResult.OK)
            {
                txbAddress.Text = op.FileName;
                btnInstall.Enabled = true;

                ShowInfo(op.FileName);                
            }
        }
        /// <summary>
        /// Show Information of the Plug-in *(installed and new)
        /// </summary>
        /// <param name="fname">FIlename of the plug-in</param>
        private void ShowInfo(string fname)
        {
            string Pname =  fname;
            FileVersionInfo fDLL = FileVersionInfo.GetVersionInfo(Pname);

            lblDes.Text = "Name: " + fDLL.OriginalFilename;
            lblDes.Text += " ,Version: " + fDLL.FileVersion + Environment.NewLine;
            lblDes.Text += "Company Name: " + fDLL.CompanyName;
            lblDes.Text += " , Description: " + fDLL.FileDescription + Environment.NewLine;
            lblDes.Text += fDLL.LegalCopyright + Environment.NewLine;
            lblDes.Text += "" + fDLL.Language + Environment.NewLine;

            try
            {
                pbIcon.Image = Icon.ExtractAssociatedIcon(fname).ToBitmap();
            }
            catch
            {
                pbIcon.Image = this.Icon.ToBitmap();
            }

            if (Path.GetDirectoryName(Pname) == Application.StartupPath + "\\Plugins")
            {
                lblDes.ForeColor = Color.RoyalBlue;
                btnInstall.Text = "Uninstall";
                txbAddress.Text = "";
            }
            else
            {
                lblDes.ForeColor = Color.Red;
                btnInstall.Text = "Install";
            }

            btnInstall.Enabled = true;
        }
        /// <summary>
        /// Install the plug-in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstallPlugin(object sender, EventArgs e)
        {
            if(((Button)sender).Text.ToUpper()=="UNINSTALL")
            {
                DialogResult dr = MessageBox.Show("Are you sure to remove this plug-in?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                    Uninstall(sender, e);
                return;
            }
            string MainPath = Application.StartupPath;
            FileVersionInfo fDLL = FileVersionInfo.GetVersionInfo(txbAddress.Text);

            Directory.CreateDirectory(MainPath+"\\Plugins");
            if (File.Exists(MainPath + "\\Plugins\\" + fDLL.OriginalFilename))
            {
                MessageBox.Show("Plug-in has install before "
                 , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnInstall.Enabled = false;
            }
            else
            {
                try
                {
                    if (CheckPlugin(txbAddress.Text))
                    {
                        File.Copy(txbAddress.Text, MainPath + "\\Plugins\\" + fDLL.OriginalFilename, true);

                        MessageBox.Show("Plug-in has install successfully"
                        , "Plug-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnInstall.Enabled = false;
                        LoadPlugins();
                        lblDes.ForeColor = Color.RoyalBlue;
                    }
                    else
                    {
                        MessageBox.Show("This file is not suitable for plug-in. "+Environment.NewLine
                            +"Please try another file."
                             , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnInstall.Enabled = false;
                        txbAddress.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plug-in hasn't install successfully" + Environment.NewLine +
                     ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool CheckPlugin(string fname)
        {
            try
            {
                var DLL = Assembly.LoadFile(fname);
                Type tp = DLL.GetType("VPPlugin.MyPlugin");

                MethodInfo Method = DLL.GetTypes()[0].GetMethod("OutPlugin");

                var o = Activator.CreateInstance(tp, null);

                return true;
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
                return false;
            }

        }

        private void FPlugins_Load(object sender, EventArgs e)
        {
            LoadPlugins();

            if (!Directory.Exists(Application.StartupPath + "\\Plugins"))
                Directory.CreateDirectory(Application.StartupPath + "\\Plugins");

            if (dgPlugins.SelectedRows.Count>0)
                ShowInfo(Application.StartupPath + "\\Plugins\\" +
                    dgPlugins.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void LoadPlugins()
        {
            string MainPath = Application.StartupPath;
            dgPlugins.Rows.Clear();

            foreach (string f in Directory.GetFiles(MainPath + "\\Plugins\\", "*.dll"))
            {
                string extension = Path.GetExtension(f);

                int row=dgPlugins.Rows.Add();
                FileVersionInfo   fDLL =FileVersionInfo.GetVersionInfo(f);

                dgPlugins.Rows[row].Cells[0].Value = fDLL.OriginalFilename;
                dgPlugins.Rows[row].Cells[1].Value = fDLL.FileVersion;
                dgPlugins.Rows[row].Cells[2].Value = fDLL.CompanyName;
                dgPlugins.Rows[row].Cells[3].Value = fDLL.Comments;
            }
        }

        private void Uninstall(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("Are you sure to remove this plug-in?", "Warning"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dr != DialogResult.Yes) return;

            string fname = Application.StartupPath + "\\Plugins\\" + dgPlugins.SelectedRows[0].Cells[0].Value;
            if(dgPlugins.SelectedRows.Count>0)
            {
                try
                {
                    File.Delete(fname);
                    MessageBox.Show("This plug-in has successfully uninstalled!","OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnInstall.Enabled = false;
                    lblDes.Text = "";
                    LoadPlugins();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No plug-in selected!");
            }
        }

        private void dgPlugins_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ShowInfo(Application.StartupPath + "\\Plugins\\" + 
                    dgPlugins.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
               // MessageBox.Show(ex.ToString());
            }
        }
    }
}
