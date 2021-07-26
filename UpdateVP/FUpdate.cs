using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateVP
{
    public partial class FUpdate : Form
    {

        public const string WebSiteAddress = "http://www.vitalpixels.com/update";
        private string OldVersion;

        public FUpdate(string ver)
        {
            InitializeComponent();

            if (ver == "0" || ver == "")
                OldVersion = Application.ProductVersion;
            else
                OldVersion = ver;

           // UpdateGUI(ver);
        }

        private void UpdateGUI(Object sender)
        {

            while(true)
            {
                UpdateStatus("Checking for update....");

                string readVer=CheckUpdate();

                if(readVer=="")
                {
                    UpdateStatus("Connection failed !");
                    UpdateReleaseNote("Checking failed! cannot contact server" + Environment.NewLine
                           + "The remote server could not be resolved !" + Environment.NewLine +
                           "http://www.vitalpixels.com/download");
                    Thread.Sleep(5000);
                    continue;
                }

                // Read and show release note online
                UpdateReleaseNote("Reading release note .....");

                try
                {
                    WebClient client = new WebClient();

                    WebProxy proxy = (WebProxy)WebProxy.GetDefaultProxy();
                    proxy.Credentials = CredentialCache.DefaultCredentials;
                    client.Proxy = proxy;

                    Stream stream = client.OpenRead(WebSiteAddress + "/releasenote.txt");
                    StreamReader reader = new StreamReader(stream);
                    UpdateReleaseNote(reader.ReadToEnd());
                    UpdateVersion("Available Version: " + readVer);

                }
                catch (Exception ex)
                {
                    UpdateReleaseNote("Checking failed! cannot contact server" + Environment.NewLine
                        + "The remote server could not be resolved !" + Environment.NewLine +
                        WebSiteAddress);
                }


                // Check New Version
                if (OldVersion != readVer )
                    UpdateStatus("New version is available.");
                else
                    UpdateStatus("Your software is up to date. New version isn't available.");

                return;
                //Thread.Sleep(5000);
            }
        }
        private delegate void DelReleaseNote(string s);
        private void UpdateReleaseNote(string msg)
        {
            if (txComment.InvokeRequired)
                txComment.Invoke(new DelReleaseNote(UpdateReleaseNote), msg);
            else
                txComment.Text = msg;
        }


        private delegate void delabel(string s);
        private void UpdateStatus(string msg)
        {

            if (lblStatus.InvokeRequired)
                lblStatus.Invoke(new delabel(UpdateStatus), msg);
            else
            {
                if (msg.ToUpper().IndexOf("FAILED")>0)
                    lblStatus.ForeColor = Color.Red;
                else
                    lblStatus.ForeColor = Color.Black; 
                lblStatus.Text = msg;
            }
        }

        private delegate void delVer(string s);
        private void UpdateVersion(string msg)
        {
            

            if (lblNewVer.InvokeRequired)
            {
                lblNewVer.Invoke(new delVer(UpdateVersion),msg);
                lblNewVer.ForeColor = Color.Blue;
            }
            else
            {
                lblNewVer.Text =msg;
                lblNewVer.ForeColor = Color.Blue;
            }
                   
        }
        public string CheckUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                WebProxy proxy = (WebProxy)WebProxy.GetDefaultProxy();
                proxy.Credentials = CredentialCache.DefaultCredentials;
                client.Proxy = proxy;
                String content = client.DownloadString(WebSiteAddress + "/ver.txt");

                return content;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return "";
            }


        }

        private void FUpdate_Load(object sender, EventArgs e)
        {
            lblOldVersion.Text = "Current version: " + OldVersion.ToString();
            ThreadPool.QueueUserWorkItem(UpdateGUI);
        }



        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void DwChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //lblNewVer.Text = e.BytesReceived.ToString();
            progressBar1.Value = e.ProgressPercentage;
            lblPercent.Text = (e.BytesReceived / 1024).ToString() + " KB/" + 
                (e.TotalBytesToReceive / 1024).ToString()+" KB";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string OnlineSetup = WebSiteAddress + "/Setup.exe";
            btnUpdate.Enabled = false;
            lblPercent.Visible = true;
            toolStripRes.Text = "Download has started ... , please wait a few minutes.";
            //bwDownload.RunWorkerAsync();
            //bwDownload.ReportProgress(1);
            using (WebClient DwClient = new WebClient())
            {
                DwClient.DownloadProgressChanged += DwChanged;
                DwClient.DownloadFileCompleted += DwFileCompleted;
                
                progressBar1.Visible = true;
                progressBar1.Style = ProgressBarStyle.Blocks;
                DwClient.DownloadFileAsync(new Uri(OnlineSetup),
                     System.IO.Path.GetTempPath() + "/Setup.exe");
            }
        }

        private void DwFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                toolStripRes.Text = "Download has finished ...";
                System.Diagnostics.Process.Start(System.IO.Path.GetTempPath() + "/Setup.exe");
                toolStripRes.Text = "Running setup";

                Application.Exit();
            }
            else
            {
                MessageBox.Show("Download failed! An error occurred in internet connection",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnUpdate.Enabled = true;
            }
            

        }

        
        private void lblNewVer_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            progressBar1.Visible = false;
        }
        private int GetOnlineFileSize(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "HEAD";
            HttpWebResponse resp = (HttpWebResponse)(req.GetResponse());
            return (int)resp.ContentLength/1024;
        }

        private void progressBar1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void lblNewVer_Click(object sender, EventArgs e)
        {

        }


    }
}
