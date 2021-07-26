using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Threading;



namespace VitalPixels
{
    public partial class FMatlabSettings : Form
    {
        private Process proc = new Process();
        private delegate void DelButDisable(Control ctl,bool ena);
        private delegate void DelAppendText(string text, Color color);
        private int a = 0;

        public FMatlabSettings()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = Environment.SpecialFolder.CommonProgramFiles.ToString();
            fb.ShowNewFolderButton = false;
            
            if (fb.ShowDialog() == DialogResult.OK)
                txMatAddress.Text = fb.SelectedPath;

        }


        /// <summary>
        /// Find Completed Name of Program in Register
        /// </summary>
        /// <param name="ProgramName"></param>
        /// <returns></returns>
        public string GetInstalledApps(string ProgramName)
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                RegistryView.Registry32);
                
            rk = Registry.LocalMachine.OpenSubKey(uninstallKey);
           
            txMatAddress.Text = rk.ToString();
            foreach (string skName in rk.GetSubKeyNames())
            {
                using (RegistryKey sk = rk.OpenSubKey(skName))
                {
                    try
                    {
                        string Fullname = sk.GetValue("DisplayName").ToString().ToUpper();

                        txClassName.Text += Fullname + Environment.NewLine;

                        if (Fullname.Contains(ProgramName.ToUpper()))
                            return Fullname;
                    }
                    catch (Exception ex)
                    {
                    //    MessageBox.Show(skName);
                    }

                }
            }
            rk.Dispose();
            return "Not Found";
        }
        public string GetApplictionInstallPath(string nameOfAppToFind)
        {
            string installedPath;
            string keyName;
            string MainName = GetInstalledApps(nameOfAppToFind);

            // search in: CurrentUser
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            installedPath = ExistsInSubKey(Registry.CurrentUser, keyName, "DisplayName", MainName);
            if (!string.IsNullOrEmpty(installedPath))
            {
                return installedPath;
            }

            // search in: LocalMachine_32
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            installedPath = ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", MainName);
            if (!string.IsNullOrEmpty(installedPath))
            {
                return installedPath;
            }

            // search in: LocalMachine_64
            keyName = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            installedPath = ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", MainName);
            if (!string.IsNullOrEmpty(installedPath))
            {
                return installedPath;
            }

            return string.Empty;
        }

        private  string ExistsInSubKey(RegistryKey root, string subKeyName, string attributeName, string nameOfAppToFind)
        {
            RegistryKey subkey;
            string displayName;
            
            using (RegistryKey key = root.OpenSubKey(subKeyName))
            {
                if (key != null)
                {
                    foreach (string kn in key.GetSubKeyNames())
                    {
                        using (subkey = key.OpenSubKey(kn))
                        {
                            displayName = subkey.GetValue(attributeName) as string;
                            if (nameOfAppToFind.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                            {
                                return subkey.GetValue("InstallLocation") as string;
                            }
                        }
                    }
                }
            }
            return string.Empty;
        }

        private void txMatAddress_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txMatAddress.Text + "\\bin\\mcc.bat"))
            {
                HideError(txMatAddress);
                errorProvider1.Clear();
                btnBuild.Enabled = true;
            }
            else
            {
                ShowError(txMatAddress, "MatLab not found");
            }
        }
        /// <summary>
        /// Hide Error from Control Bo
        /// </summary>
        /// <param name="Ctrl">Control Box Name</param>
        private void HideError(Control Ctrl)
        {
            Ctrl.BackColor = Color.White;
            
            errorProvider1.Clear();

            foreach (Control ct in this.Controls)
            {
                if (errorProvider1.GetError(ct).Length>0)
                    return;
            }
            btnOK.Enabled = true;
        }
        /// <summary>
        /// Show Error in Control Box
        /// </summary>
        /// <param name="Ctrl">Control Name</param>
        /// <param name="strMsg">Error Message</param>
        private void ShowError(Control Ctrl,string strMsg)
        {
            Ctrl.BackColor = Color.Pink;
            btnOK.Enabled = false;
            errorProvider1.SetError(Ctrl, strMsg);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveMatLabSettings();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkUseProgram_CheckedChanged(object sender, EventArgs e)
        {
            //grpProgram.Enabled = chkUseProgram.Checked;
            chkUseProgram.ImageIndex = (chkUseProgram.ImageIndex == 0) ? 1 : 0;

            if (chkUseProgram.Checked)
                chkUseProgram.BackColor = Color.LightGreen;
            else
                chkUseProgram.BackColor = Color.LightPink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "MatLab Script(*.m)|*.m";
            op.Multiselect = false;
            op.Title = "Select MatLab Script File";
            op.InitialDirectory = txMatAddress.Text;

            if(op.ShowDialog()==DialogResult.OK)
            {
                txMFile.Text = op.FileName;
            }
        }

        private void FMatlabSettings_Load(object sender, EventArgs e)
        {
            LoadMatLabSettings();
        }

        private void LoadMatLabSettings()
        {
            txMatAddress.Text = Properties.Settings.Default.MatLabAddress;
            txClassName.Text = Properties.Settings.Default.MatLabClassName;
            chkUseProgram.Checked = Properties.Settings.Default.MatLabImportFile;
            txMFile.Text = Properties.Settings.Default.MatLabMFile;

            if(File.Exists(Properties.Settings.Default.MatLabAddress+"\\bin\\mcc.bat"))
            {
                AppendText("MATLAB was found in \"" + Properties.Settings.Default.MatLabAddress+"\"", Color.Green);

                FileVersionInfo myFileVersionInfo =
                    FileVersionInfo.GetVersionInfo(Properties.Settings.Default.MatLabAddress + "\\bin\\matlab.exe");

                AppendText("MATLAB Version is "+ myFileVersionInfo.FileVersion, Color.Green);
                btnBuild.Enabled = true;
            }
            else
            {
                AppendText("MATLAB was not found in", Color.Red);
                btnBuild.Enabled = false;
            }

            if (File.Exists(Application.StartupPath + "\\MatLab\\src\\MatLab.dll"))
            {
                chkUseProgram.Enabled = true;
            }
            else
            {
                chkUseProgram.Enabled = false;
                chkUseProgram.Checked = false;
            }
        }

        private void SaveMatLabSettings()
        {
            Properties.Settings.Default.MatLabAddress=txMatAddress.Text;
            Properties.Settings.Default.MatLabClassName=txClassName.Text;
            Properties.Settings.Default.MatLabImportFile= chkUseProgram.Checked;
            Properties.Settings.Default.MatLabMFile=txMFile.Text;

            Properties.Settings.Default.Save();
        }

        private void txMFile_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(txMFile.Text))
                ShowError(txMFile, "M-File not found");
            else
                HideError(txMFile);
        }

        private void txClassName_TextChanged(object sender, EventArgs e)
        {
            if (txClassName.Text.Length == 0)
                ShowError(txClassName, "Class Name is necessary");
            else
            {
                if (Regex.IsMatch(txClassName.Text, @"^[a-zA-Z0-9_]+$")&&
                    Char.IsDigit(txClassName.Text[0])==false)
                    HideError(txClassName);
                else
                    ShowError(txClassName, "Class Name is not valid");
            }
        }

        private void Build_Click(object sender, EventArgs e)
        {
           DoBuild(new Object());
        }

        private void DoBuild(object obj)
        {
            AppendText("Compiling " +
                Properties.Settings.Default.MatLabMFile + " has started, please wait...",
                Color.Green);
            timer1.Enabled = true;
            ThreadPool.QueueUserWorkItem(ThreadProc);
            //ThreadProc(new object());
        }

        private void ThreadProc(Object obj)
        {
           BuildDisable(btnBuild,false);
           BuildDisable(groupBox1, false);
           BuildDisable(grpProgram, false);


           CompileMatlab(Properties.Settings.Default.MatLabAddress,
                    Application.StartupPath + "\\MatLab",
                    Properties.Settings.Default.MatLabMFile,
                    Properties.Settings.Default.MatLabClassName);
           BuildDisable(btnBuild,true);

        }


        private void BuildDisable(Control ctrl,bool ena)
        {
            if (ctrl.InvokeRequired == false)
                ctrl.Enabled = ena;
            else
                ctrl.Invoke(new DelButDisable(BuildDisable),ctrl,ena);
        }
        /// <summary>
        /// Compile M-File to .NET DLL file for reference 
        /// </summary>
        /// <param name="adr">Address of Matlab Compiler</param>
        /// <param name="ProjDir">Target Directory</param>
        /// <param name="MFile">M-File</param>
        /// <param name="ClassName">Class Name</param>
        private void CompileMatlab(string adr, string ProjDir, string MFile, string ClassName)
        {
            // Start the child process.
            AppendText("Checked...", Color.Black);

            if (File.Exists(ProjDir + "\\src\\MatLab.dll"))
                File.Delete(ProjDir + "\\src\\MatLab.dll");
            AppendText("Old Files Removed...", Color.Black);

            // Redirect the output stream of the child process.
            proc.StartInfo.WorkingDirectory = adr;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.EnableRaisingEvents = true;
            proc.Exited += ExitBuild;
            //AppendText("GUI Configured...", Color.Black);

            Directory.CreateDirectory(ProjDir + "\\distrib");
            Directory.CreateDirectory(ProjDir + "\\src");
            AppendText("Necessary Directory Created...", Color.Black);

            proc.StartInfo.FileName = adr + "\\bin\\mcc.bat";
            proc.StartInfo.FileName.Replace("\\\\", "\\");

            if(!File.Exists(proc.StartInfo.FileName))
            {
                AppendText(proc.StartInfo.FileName+" has problem", Color.Red);

                return;
            }
            proc.StartInfo.Arguments = " -W \"dotnet:MatLab," + ClassName + ",0.0,private\"" +
                " -T link:lib -d \"" + ProjDir + "\\src\" " +
                " -w enable:specified_file_mismatch -w enable:repeated_file -w enable:switch_ignored " +
                " -w enable:missing_lib_sentinel -w enable:demo_license -v " +
                "\"class{" + ClassName + ":" + MFile + "}\" -a " +
                "\"" + MFile + "\"";

            proc.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            // AppendText(proc.StartInfo.FileName, Color.Black);
            //  AppendText(proc.StartInfo.Arguments, Color.Red);
            proc.WaitForExit();

           // OutMsg = output;
            //return output;
        }


        private void ExitBuild(object sender, EventArgs e)
        {
            BuildDisable(groupBox1, true);
            BuildDisable(grpProgram, true);

            string OutMsg = "";
            timer1.Enabled = false;
            a = 0;
            try
            {
                OutMsg = proc.StandardOutput.ReadToEnd();
                if (OutMsg == "") return;
            }
            catch
            {
                return;
            }
            
            if (!File.Exists(Application.StartupPath + "\\MatLab\\src\\MatLab.dll"))
            {
                AppendText("Compile was not successful !", Color.Red);
                AppendText(OutMsg, Color.Red);

                chkUseProgram.Enabled = false;
                chkUseProgram.Checked = false;
            }
            else
            {
                try
                {
                    OutMsg = OutMsg.Remove(OutMsg.LastIndexOf(Environment.NewLine));
                    OutMsg = OutMsg.Replace("Generating file \"", "Generating file \"file:\\");

                    AppendText("Compile was  successful !", Color.DarkGreen);
                    AppendText(OutMsg, Color.Blue);
                    AppendText("Help: \" file:\\" +
                    Application.StartupPath + "\\MatLab\\src\\MatLab.xml\"", Color.Blue);
                    BuildDisable(chkUseProgram, true);

                    if (File.Exists(Application.StartupPath + "\\MatLab\\src\\MatLab.dll"))
                        File.Copy(Application.StartupPath + "\\MatLab\\src\\MatLab.dll",
                            Application.StartupPath + "\\MatLab.dll",true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Warning",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        internal void AppendText(string text, Color color)
        {
            String msg = text;
            bool TimeTag = false;
            RichTextBox box = richMessage;

            if (richMessage.InvokeRequired==false)
            {
                // Clear richedit if it is full
                if (box.TextLength + text.Length >= box.MaxLength)
                    box.Text = "";

                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;
                box.SelectionColor = color;
                if (TimeTag) msg += "[" + DateTime.Now.ToString() + "]";
                box.AppendText(msg + Environment.NewLine);
                box.SelectionColor = box.ForeColor;
                box.ScrollToCaret();
            }
            else
            {
                richMessage.Invoke(new DelAppendText(AppendText),msg,color);
            }

        }

        private void richMessage_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText); 
        }

        private void saveAsLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text file|*.txt";
            sv.DefaultExt = "txt";
            sv.Title = "Save log";

            if (sv.ShowDialog() == DialogResult.OK)
                richMessage.SaveFile(sv.FileName,RichTextBoxStreamType.PlainText);
        }

        private void printLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richMessage.Text = "";
        }

        private void FMatlabSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            proc.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string str= new string('#',a);
            a++;
            richMessage.Text+="#";  
        }
    }
}
