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
using System.Xml.Serialization;

namespace VitalPixels
{
    public partial class FCompilerSettings : Form
    {
        private List<string> NecessaryDLL = new List<string>();
        private string DirRefrencesSaveName = Application.StartupPath;
        private bool UserActive = false;


        public FCompilerSettings()
        {
            InitializeComponent();

            NecessaryDLL.Add("system.dll");
            NecessaryDLL.Add("system.drawing.dll");
            NecessaryDLL.Add("mscorlib.dll");
        }

        private void FCompilerSettings_Load(object sender, EventArgs e)
        {
            FillGACTable();
          //  LoadNameSpaces();

        }

        private void FillGACTable()
        {
            List<string> ls = new List<string>();
            VPCompile.Compiler vp = new VPCompile.Compiler();

            ls = vp.LoadAssemblyRefrences();

            VPCompile.AllRefrences alr = new VPCompile.AllRefrences();
            alr = vp.GetGACLastSaaved();

            VPCompile.CMyDLL cmdll = new VPCompile.CMyDLL();


            UserActive = false;

            foreach (string item in ls)
            {
                int inx;
                bool res = alr.AllRef.Exists(element => element.RefrenceName == (item));
                if (res)
                {
                    inx = chGAC.Rows.Add("used");
                    chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                    inx = chGAC.Rows.Add("unused");

                chGAC.Rows[inx].Cells["colGlobalName"].Value = item;
                
                //;chGAC.Rows[inx].Cells[2].Value = fname;
                //if (item.ToLower().Contains("system."))
                //    chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.LightYellow;
                //if (item.ToLower().Contains("microsoft."))
                //    chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.LightCyan;

                if (NecessaryDLL.Contains(item.ToLower()))
                {
                    chGAC.Rows[inx].ReadOnly = true;
                    chGAC.Rows[inx].Cells["colGlobalUse"].Value = "used";
                    chGAC.Rows[inx].Cells["colGlobalComment"].Value = "Necessary";
                    chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            
            cmdll = vp.GetMyDLLLastSaved();

            // File GridMyDLL
            foreach (var item in cmdll.AllRef)
            {
                int inx;
              
                inx = GridDLL.Rows.Add("used");
                if (!File.Exists(item.FileName))
                {
                    GridDLL.Rows[inx].DefaultCellStyle.BackColor = Color.Red;
                    GridDLL.Rows[inx].Cells["colName"].Value = item.FileName;
                    GridDLL.Rows[inx].ReadOnly = true;
                    GridDLL.Rows[inx].Cells["ColCheck"].Value = "unused";
                    GridDLL.Rows[inx].Cells["colVersion"].Value = "File not found";
                }
                else
                {
                    FileVersionInfo fDLL = FileVersionInfo.GetVersionInfo(item.FileName);
                    GridDLL.Rows[inx].Cells["colName"].Value = fDLL.OriginalFilename;
                    GridDLL.Rows[inx].Cells["colVersion"].Value = fDLL.FileVersion;
                    GridDLL.Rows[inx].Cells["colCompany"].Value = fDLL.CompanyName;
                    GridDLL.Rows[inx].Cells["colLocation"].Value = item.FileName;
                    GridDLL.Rows[inx].Cells["colComment"].Value = fDLL.FileDescription;
                    GridDLL.Rows[inx].Cells["ColCheck"].Value = item.Chosen ? "used" : "unused";

                    if (GridDLL.Rows[inx].Cells["ColCheck"].Value.ToString() == "used")
                        GridDLL.Rows[inx].DefaultCellStyle.BackColor = Color.LightGreen;
                    else
                        GridDLL.Rows[inx].DefaultCellStyle.BackColor = Color.White;
                }

                
            }
            UserActive = true;
        }
        /// <summary>
        /// Save settings after clicking the OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save GAC Settings
            VPCompile.Compiler vp = new VPCompile.Compiler();

            VPCompile.AllRefrences cgac = new VPCompile.AllRefrences();
            XmlSerializer xs = new XmlSerializer(typeof(VPCompile.AllRefrences));
            FileStream fs = new FileStream(DirRefrencesSaveName+"\\Refrences.xml", FileMode.Create);

            for (int i = 0; i < chGAC.Rows.Count; i++)
            {
                if (chGAC.Rows[i].Cells["colGlobalUse"].Value.ToString().ToLower() == "used")
                    cgac.AllRef.Add(new VPCompile.CGACSettings(chGAC.Rows[i].Cells["colGlobalName"].Value.ToString()));
            }
            xs.Serialize(fs, cgac);
            fs.Close();

            // Save DLL Settings
            VPCompile.CMyDLL cdll = new  VPCompile.CMyDLL();
            XmlSerializer xsdll = new XmlSerializer(typeof( VPCompile.CMyDLL));
            FileStream fsdll = new FileStream(DirRefrencesSaveName+"\\ImportedDLL.xml", FileMode.Create);

            for (int i = 0; i < GridDLL.Rows.Count; i++)
            {
               // if (GridDLL.Rows[i].Cells["ColCheck"].Value.ToString().ToLower() == "used")
                try
                {
                    cdll.AllRef.Add(new
                        VPCompile.OneDLL(GridDLL.Rows[i].Cells["colLocation"].Value.ToString(),
                        GridDLL.Rows[i].Cells["ColCheck"].Value.ToString() == "used"));
                }
                catch
                {
                    
                }
            }
            xsdll.Serialize(fsdll, cdll);
            fsdll.Close();
        }


        /// <summary>
        /// Load Last Settings
        /// </summary>
        /// <returns></returns>

        private void chGAC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (UserActive == false) return;
            int inx = e.RowIndex;
            
            if(chGAC.Rows[inx].Cells["colGlobalUse"].Value.ToString() == "used")
                chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.LightBlue;
            else
                chGAC.Rows[inx].DefaultCellStyle.BackColor = Color.White; ;
        }

     
        private void AddDLL_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Multiselect = true;
            op.Filter = "DLL files (*.dll,*.exe) | *.dll;*.exe";
            op.Title = "Choose DLL to add";

            if (op.ShowDialog() == DialogResult.OK)
            {
                foreach (var fnames in op.FileNames)
                {
                    bool IsRepeated = false;


                    //for (int i = 0; i < GridDLL.Rows.Count; i++)
                    //{
                    //    try
                    //    {
                    //        if (GridDLL.Rows[i].Cells["colLocation"].Value.ToString() == fnames)
                    //        {
                    //            IsRepeated = true;
                    //            break;
                    //        }
                    //    }
                    //    catch
                    //    { 
                    //    }
                    //}
                    foreach (DataGridViewRow item in GridDLL.Rows)
                    {
                        if (item.Cells["colLocation"].Value!=null)
                        if (item.Cells["colLocation"].Value.ToString() == fnames)
                        {
                            IsRepeated = true;
                            break;
                        }
                    }
                    if (!IsRepeated)
                    {
                        FileVersionInfo fDLL = FileVersionInfo.GetVersionInfo(fnames);
                        string extension = Path.GetExtension(fnames);

                        int row = GridDLL.Rows.Add();

                        GridDLL.Rows[row].Cells["colName"].Value = fDLL.OriginalFilename;
                        GridDLL.Rows[row].Cells["colName"].ToolTipText = fnames;
                        GridDLL.Rows[row].Cells["colVersion"].Value = fDLL.FileVersion;
                        GridDLL.Rows[row].Cells["colCompany"].Value = fDLL.CompanyName;
                        GridDLL.Rows[row].Cells["colLocation"].Value = fnames;
                        GridDLL.Rows[row].Cells["colComment"].Value = fDLL.FileDescription;
                        GridDLL.Rows[row].Cells["ColCheck"].Value = "used";
                    }
                    else
                    {
                        MessageBox.Show(fnames + " has chosen before!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GridDLL_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (UserActive == false) return;
            int inx = e.RowIndex;

            try
            {
                if (GridDLL.Rows[inx].Cells["ColCheck"].Value.ToString() == "used")
                    GridDLL.Rows[inx].DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    GridDLL.Rows[inx].DefaultCellStyle.BackColor = Color.White; ;
            }
            catch
            { 
            }
        }

        private void Default_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to restore to default settings?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            for (int i = 0; i < GridDLL.Rows.Count; i++)
            {
                GridDLL.Rows[i].Cells["ColCheck"].Value = "unused";
                GridDLL.Rows[i].DefaultCellStyle.BackColor = Color.White; ;
            }


            for (int i = 0; i < chGAC.Rows.Count; i++)
            {
                if (NecessaryDLL.Contains(chGAC.Rows[i].Cells["colGlobalName"].Value.ToString().ToLower()))
                {
                    chGAC.Rows[i].ReadOnly = true;
                    chGAC.Rows[i].Cells["colGlobalUse"].Value = "used";
                    chGAC.Rows[i].Cells["colGlobalComment"].Value = "Necessary";
                    chGAC.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    chGAC.Rows[i].Cells["colGlobalUse"].Value = "unused";
                    chGAC.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }
            }
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string DName = GridDLL.SelectedRows[0].Cells["colName"].Value.ToString();

            if (MessageBox.Show(
               "Are you sure to remove \""+DName+"\" from list?",
               "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            // Check if Grid of DLLs is Active delete row
           
            GridDLL.Rows.Remove(GridDLL.SelectedRows[0]);

        }

  
    }
}
