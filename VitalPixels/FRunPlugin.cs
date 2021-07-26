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
    public partial class FRunPlugin : Form
    {
        private string PluginName;
        public object[]  MainParameters;
        int CountArg = 0;

        public FRunPlugin(string argPluginName)
        {
            InitializeComponent();

            // TODO: Complete member initialization
            this.PluginName = argPluginName;
            ParameterInfo[] Parametres=GetParams();
            LoadForm(Parametres);
        }


        /// <summary>
        /// Load form and make form for man method in plug-in
        /// </summary>
        /// <param name="Parameters"></param>
        private void LoadForm(ParameterInfo[] Parameters)
        {
            int Row = 1;
            int ParaIndex = 0;


            // Make Textbox for every parameter
            foreach (ParameterInfo item in Parameters)
            {
                if(item.ParameterType!=typeof(Image)&&item.IsOut==false)
                {
                    Label lbl = new Label();
                    lbl.Name = "Label" + Row.ToString();
                    lbl.Text = item.Name;
                    lbl.CreateControl();
                    lbl.Size = new System.Drawing.Size(70, 35);
                    lbl.Location =new System.Drawing.Point(10, 35*Row);

                    TextBox tx = new TextBox();
                    tx.Name = item.Name;
                    tx.Size = new System.Drawing.Size(128, 35);
                    tx.Location = new System.Drawing.Point(100, Row*35);
                    tx.Text = item.DefaultValue.ToString();
                    tx.Tag = ParaIndex;

                    // Manage Value
                    tx.KeyPress+=tx_KeyPress;
                    tx.Text = "0";
                    tx.TextChanged+=tx_TextChanged;

                    Label lbltype = new Label();
                    lbltype.Name = "TYP" + Row.ToString();
                    lbltype.Text = "(" +
                        item.ParameterType.ToString().Replace("System.","") + ")";
                    lbltype.CreateControl();
                    lbltype.Location = new System.Drawing.Point(230, 35 * Row);
                    lbl.AutoSize = true;
                    lbltype.ForeColor = Color.Gray;

                    panelParam.Controls.Add(lbl);
                    panelParam.Controls.Add(lbltype);
                    panelParam.Controls.Add(tx);
                    Row++;
                }
                ParaIndex++;
                CountArg++;
                if(ParaIndex>10)
                {
                    MessageBox.Show("The number of parameters exceed from 10.");
                    return;
                }
            }
        }

        private void tx_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tx_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
                btnOK.Enabled = false;
            else
                btnOK.Enabled = true;
        }


        private  ParameterInfo[] GetParams()
        {
            string DllName = PluginName;
            FileStream fs = File.Open(DllName, FileMode.Open);
            ParameterInfo[] pars=null;

            try
            {
                AppDomainSetup ads = new AppDomainSetup();
                AppDomain ad = AppDomain.CreateDomain("RunCodeDomain", null, ads);
                AssemblyName assemblyName = new AssemblyName();
                assemblyName.CodeBase = DllName;
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                Assembly DLL = Assembly.Load(data);

                Type tp = DLL.GetType("VPPlugin.MyPlugin");

                MethodInfo Method = DLL.GetTypes()[0].GetMethod("OutPlugin");
                pars = Method.GetParameters();
                
                fs.Close();

                // Unload Domain
                AppDomain.Unload(ad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fs.Close();
            }

            return pars;
        }

        private void FRunPlugin_Load(object sender, EventArgs e)
        {
            FileVersionInfo fi = FileVersionInfo.GetVersionInfo(PluginName);
            Info.Text = "Description: " + fi.FileDescription+Environment.NewLine;
            Info.Text += fi.Comments;

            this.Text = "Run [" + fi.FileDescription+"]";
        }
        /// <summary>
        /// Press ok to run and send parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CountArg < 1) return;
            MainParameters = new object[CountArg];
            foreach (Control item in panelParam.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    int inx = Int32.Parse(item.Tag.ToString());
                    
                    MainParameters[inx] = Double.Parse(item.Text);
                }
            }
        }


    }
}
