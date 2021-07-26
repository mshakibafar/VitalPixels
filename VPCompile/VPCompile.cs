using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;


namespace VPCompile
{
    public class Compiler
    {
        private StringBuilder CodeForCompile= new StringBuilder();
        private string DirRefrencesSaveName = Environment.CurrentDirectory;
        private string framworkRegPath = @"Software\Microsoft\.NetFramework";
        private bool ImportMatlab = false;
        private string TempFileName="codes.cs";


        public Compiler(StringBuilder argCode,bool _ImportMatlab)
        {
            CodeForCompile = argCode.Replace("#image", "//#image"); ;
            ImportMatlab = _ImportMatlab;
        }

        public Compiler()
        {
          //  CodeForCompile = argCode;
        }

        /// <summary>
        /// Compile Semi Code
        /// </summary>
        /// <param name="argMessage"></param>
        /// <param name="argTitle"></param>
        /// <param name="argDes"></param>
        /// <param name="argProduct"></param>
        /// <param name="Version"></param>
        /// <param name="argOutput"></param>
        /// <returns></returns>
        public bool CompileSemiCode(out StringBuilder argMessage,
           string argTitle = "CodeLab", string argDes = "Temp", string argProduct = "",
           string Version = "1.0.0.0", string argOutput = "CodeLab")
        {
            StringBuilder argCode=CodeForCompile;
            argCode.Insert(0, "// ##Start Code" + Environment.NewLine);

            bool ResultError = false;

            //*****

            string Code = GetUsingString() +
                                    "[assembly: AssemblyFileVersion(\"" + Version + "\")]" +Environment.NewLine+
                                    "[assembly: AssemblyTitle(\""+argTitle+"\")]" +Environment.NewLine+
                                    "[assembly: AssemblyCompany(\"VitalPixels.com\")]" +Environment.NewLine+
                                    "[assembly: AssemblyCopyright(\"Copyright© Vital Pixels " + DateTime.Now.Year.ToString() + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyDescription(\"" + argDes + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyProduct(\"CodeLab-" + argProduct + "\")]" + Environment.NewLine +

                                    "namespace VPPlugin" + Environment.NewLine +
                                    "{" + Environment.NewLine +
                                    "     public class MyPlugin" + Environment.NewLine +
                                    "    {" + Environment.NewLine +
                                     "       public System.Drawing.Image OutPlugin(System.Drawing.Image InputImage,out string argMessage)" + Environment.NewLine +
                                      "      {" + Environment.NewLine +
                                           "    Bitmap OutputImage = new Bitmap(InputImage.Width, InputImage.Height);" + Environment.NewLine +
                                           "argMessage=\"\";//##Start Code" + Environment.NewLine +
                                                argCode + Environment.NewLine +
                                                "return (System.Drawing.Image)OutputImage;" + Environment.NewLine +
                                    "}}}";

            argMessage = new StringBuilder();
            int StartSemiCode = GetLine("// ##Start Code", Code);

            argMessage.Append("Compile has done successfully");

            // Create the provider and parameters of compiler
            CSharpCodeProvider provider = new CSharpCodeProvider();

            String[] referenceAssemblies = GetRefrences();
                     
            CompilerParameters parameters = new 
                CompilerParameters(referenceAssemblies, argOutput + ".dll", true);
       
            //** Define parameters
            parameters.GenerateExecutable = false;
            parameters.IncludeDebugInformation = false;

            //**Finally Compile Assembly
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, Code);
        //    File.WriteAllText(@"C:\\codes.cs", Code);
            // Now we can check errors 
            int CS0105=0;

            if (results.Errors.HasErrors)
            {
                // Compile has error
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError err in results.Errors)
                {
                    if (err.ErrorNumber != "CS0105")   // filter: The using directive for 'System...' appeared previously in this namespace
                        sb.AppendLine(String.Format("Line {0} -> Error ({1}): {2}", 
                            err.Line - StartSemiCode, err.ErrorNumber, err.ErrorText));
                    else
                        CS0105++;
                }
                int ErrorCount = results.Errors.Count - CS0105;

                ResultError = true;
                argMessage.Clear();
                sb.Append("Compile has " + ErrorCount.ToString() + " errors. ");
                argMessage = sb;
            }
            else // Has no Error
            {
                ////Warning
                //if (results.Errors.HasWarnings)
                //{ // Compile has error
                //    StringBuilder sb = new StringBuilder();
                //    foreach (CompilerError err in results.Errors)
                //    {
                //        if (err.IsWarning)
                //            sb.AppendLine(String.Format("Line {0} -> Warning ({1}): {2}",
                //                err.Line, err.ErrorNumber, err.ErrorText));
                //    }
                //}

                ResultError = false;
            }
            
            return ResultError;
        }

        private string[] GetRefrences()
        {
            CMyDLL myd = new CMyDLL();
            myd = GetMyDLLLastSaved();
            AllRefrences alr = new AllRefrences();
            alr = GetGACLastSaaved();
            int MaxRef=alr.AllRef.Count+myd.AllRef.Count;

            if (ImportMatlab)
                MaxRef += 2;

            string[] referenceAssemblies=new string[MaxRef];

            int i = 0;

            foreach (CGACSettings item in alr.AllRef)
            {
                referenceAssemblies[i] = item.RefrenceName;
                i++;
            }

            foreach (OneDLL item in myd.AllRef)
            {
                if (item.Chosen)
                {
                    referenceAssemblies[i] = item.FileName;
                    //FileInfo fi = new FileInfo(item.FileName);
                    //try
                    //{
                    //    File.Copy(item.FileName, Environment.CurrentDirectory + "\\" +
                    //        fi.Name, true);
                    //}
                    //catch
                    //{

                    //}
                    i++;
                }
            }

            if (ImportMatlab)
            {
                referenceAssemblies[i] = DirRefrencesSaveName + "\\MWArray.dll";
                referenceAssemblies[i+1] = DirRefrencesSaveName + "\\MatLab\\src\\MatLab.dll";
            }

            return referenceAssemblies;
        }
        /// <summary>
        ///  Run file
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public Image  RunCodeLabProgram(string FileName,Image InputImage,out string ErrorMessage,out string OutMessage)
        {
            OutMessage = "";
            ErrorMessage = "Run has started["+FileName+"]";
            Image OutputImage=InputImage;

            if (!File.Exists(FileName))
            {
                ErrorMessage = "No program has been compiled ,yet! ";
                return null;
            }

            string DllName =FileName;
            FileStream fs = File.Open(DllName, FileMode.Open); ;

            try
            {
                AppDomainSetup ads = new AppDomainSetup();
                AppDomain ad = AppDomain.CreateDomain("RunCodeDomain", null, ads);
                AssemblyName assemblyName = new AssemblyName();
                
                AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;

                assemblyName.CodeBase = DllName;

                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                Assembly DLL = Assembly.Load(data);
                
                Type tp = DLL.GetType("VPPlugin.MyPlugin");

                MethodInfo Method = DLL.GetTypes()[0].GetMethod("OutPlugin");
                object[] staticParameters = new object[2];
                staticParameters[0] =InputImage;
                staticParameters[1] = "";
                var o = Activator.CreateInstance(tp, null);
                object Minv = Method.Invoke(o, staticParameters);

                //Show output
                OutputImage = (Image)Minv;
                
                //Method.GetParameters()[0].Name
                
                try
                {
                    OutMessage = Method.GetParameters()[1].Name + "=" + staticParameters[1].ToString();
                }
                catch
                {
                    OutMessage = "-";
                }

                fs.Close();
                // Unload Domain
                AppDomain.Unload(ad);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.ToString();
                return null;
            }
            finally
            {
                fs.Close();
            }

            return OutputImage;
        }

        private Assembly AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName == args.Name);
        }

       
        /// <summary>
        /// Run Plug-in with argument
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="InputImage"></param>
        /// <param name="staticParameters"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        public Image RunCodePlugin(string FileName, Image InputImage, object[] staticParameters,
            out string ErrorMessage)
        {
            ErrorMessage = "";
            Image OutputImage = InputImage;

            if (!File.Exists(FileName))
            {
                ErrorMessage = "No program has been compiled ,yet! ";
                return null;
            }

            string DllName = FileName;
            FileStream fs = File.Open(DllName, FileMode.Open); ;

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
                //object[] staticParameters = new object[2];
                staticParameters[0] = InputImage;

                for (int i = 1; i < staticParameters.Length; i++)
                {
                    staticParameters[i] = null;
                }


                //************ERROR
                var o = Activator.CreateInstance(tp, null);
                var Minv = Method.Invoke(o, staticParameters);
                ErrorMessage = staticParameters[1].ToString();

                //Show output
                OutputImage = (Image)Minv;

                fs.Close();

                // Unload Domain
                AppDomain.Unload(ad);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.ToString();
                return null;
            }
            finally
            {
                fs.Close();
            }

            
            return OutputImage;
        }
        /// <summary>
        /// Compile full code for plug-in
        /// </summary>
        /// <param name="argMessage">Output Message</param>
        /// <param name="fname">Filename</param>
        /// <param name="argTitle"></param>
        /// <param name="argDes"></param>
        /// <param name="argProduct"></param>
        /// <param name="Version"></param>
        /// <returns></returns>
        /// **************
        public bool CompileFullCode(out StringBuilder argMessage, string fname,
            string argTitle = "CodeLab", string argDes = "Temp", string argProduct = "",
            string Version = "1.0.0.0")
        {
            StringBuilder argCode = CodeForCompile;
            bool ResultError = false;
            FileInfo fi = new FileInfo(fname);
            int Startnamespace = 0;
            string argOutput = "";

            if (fi.Extension.Length > 0)
            {
                argOutput = fi.FullName.Replace(fi.Extension, ".dll");
            }
            else
            {
                argOutput = fi.FullName + ".dll";
               // fname += ".cs";
            }
            string sign = "[assembly: AssemblyFileVersion(\"" + Version + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyTitle(\"" + argTitle + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyCompany(\"VitalPixels.com\")]" + Environment.NewLine +
                                    "[assembly: AssemblyCopyright(\"Copyright© VitalPixels.com " + DateTime.Now.Year.ToString() + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyDescription(\"" + argDes + "\")]" + Environment.NewLine +
                                    "[assembly: AssemblyProduct(\"CodeLab-" + argProduct + "\")]" + Environment.NewLine
                                    ;


            Startnamespace = CountLine(argCode.ToString(), "namespace");

            argCode.Replace("namespace",
                sign + Environment.NewLine +
                 "namespace"
                );


            
            string Code =
                argCode.ToString();  //File.ReadAllText(fname);

            argMessage = new StringBuilder();
            argMessage.Append("Compile has done successfully ["+argOutput+"]");
            // Create the provider and parameters of compiler
            CSharpCodeProvider provider = new CSharpCodeProvider();
            String[] referenceAssemblies = GetRefrences();
          

            CompilerParameters parameters = new CompilerParameters(referenceAssemblies, argOutput, true);

            //** Define parameters
            parameters.GenerateExecutable = false;
            parameters.IncludeDebugInformation = false;

            //** Finally Compile Assembly
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, Code);

            // Now we can check errors 

            if (results.Errors.HasErrors)
            {
                // Compile has error
                StringBuilder sb = new StringBuilder();
                foreach (CompilerError err in results.Errors)
                {
                    int LineNumber=err.Line < Startnamespace ? err.Line : err.Line-7;
                        
                    if(ImportMatlab)    LineNumber-=3;


                    sb.AppendLine(String.Format("Line {0} -> Error ({1}): {2}",LineNumber,
                        err.ErrorNumber, err.ErrorText));
                }

                ResultError = true;
                argMessage.Clear();
                sb.Append("Compile has "+results.Errors.Count.ToString()+" errors! ");
                argMessage = sb;
            }
            else // Has no Error
            {
                ////Warning
                //if (results.Errors.HasWarnings)
                //{ // Compile has error
                //    StringBuilder sb = new StringBuilder();
                //    foreach (CompilerError err in results.Errors)
                //    {
                //        if (err.IsWarning)
                //            sb.AppendLine(String.Format("Line {0} -> Warning ({1}): {2}",
                //                err.Line, err.ErrorNumber, err.ErrorText));
                //    }
                //}

                ResultError = false;
            }
           // argMessage = argCode;

            return ResultError;
        }

        private int CountLine(string MainText, string SearchText)
        {
            int Count = 1;

            for (int i = 0; i < MainText.IndexOf(SearchText); i++)
            {
                if (MainText[i] == '\n')
                    Count++;
            }

            return Count;
        }


        public string GetUsingString()
        {
            StringBuilder sb = new StringBuilder();
            AllRefrences alr = new AllRefrences();
            string strGacDir = GetFrameworkDirectory();


            alr = GetGACLastSaaved();
            foreach (CGACSettings item in alr.AllRef)
            {
                List<string> lst= new List<string>();
                lst =GetNameSpaces(strGacDir +  item.RefrenceName);

                if(lst!=null)
                    foreach (var nspaces in lst)
                    {
                        if(nspaces!=null)
                            sb.Append("using " + nspaces +";"+ Environment.NewLine);
                       // sb.Append(+Environment.NewLine);
                    }
            }


            CMyDLL cmy = new CMyDLL();
            cmy=GetMyDLLLastSaved();

            foreach (OneDLL item in cmy.AllRef)
            {
                List<string> lst = new List<string>();
                lst = GetNameSpaces(item.FileName);

                if (item.Chosen)
                {
                    if (lst != null)
                        foreach (var nspaces in lst)
                        {
                            if (nspaces != null)

                                sb.Append("using " + nspaces + ";" + Environment.NewLine);
                            // sb.Append(+Environment.NewLine);
                        }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Get list of name spaces in a DLL or EXE files
        /// </summary>
        /// <param name="argFileName">File Name</param>
        /// <returns> List of namespaces </returns>
        public  List<string> GetNameSpaces(string argFileName)
        {
            if (!File.Exists(argFileName)) return null;
            try
            {
                Assembly asm = Assembly.LoadFile(argFileName);
                List<string> namespaces = new List<string>();

                foreach (var type in asm.GetTypes())
                {
                    string ns = type.Namespace;
                    if (!namespaces.Contains(ns))
                    {
                        namespaces.Add(ns);
                    }
                }

                return namespaces;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Get Selected References
        /// </summary>
        /// <returns></returns>
        public   AllRefrences GetGACLastSaaved()
        {
            AllRefrences cgac = new AllRefrences();

            // If reference files is not been
            if (!File.Exists(DirRefrencesSaveName + "\\Refrences.xml")) return cgac;

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(AllRefrences));
                FileStream fs = new FileStream(DirRefrencesSaveName + "\\Refrences.xml", FileMode.Open);

                cgac = (AllRefrences)xs.Deserialize(fs);

                fs.Close();
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
            }
            return cgac;
        }
        /// <summary>
        /// Get Last List of DLLs
        /// </summary>
        /// <returns></returns>
        public CMyDLL GetMyDLLLastSaved()
        {
            CMyDLL cgac = new CMyDLL();

            // If references files is not been
            if (!File.Exists(DirRefrencesSaveName + "\\ImportedDLL.xml")) return cgac;

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(CMyDLL));
                FileStream fs = new FileStream(DirRefrencesSaveName + "\\ImportedDLL.xml", FileMode.Open);

                cgac = (CMyDLL)xs.Deserialize(fs);

                fs.Close();
            }
            catch 
            {
               // MessageBox.Show(ex.ToString());
            }
            return cgac;
        }
        /// <summary>
        /// Load Assembly list from GAC
        /// </summary>
        /// <returns></returns>
        public List<string> LoadAssemblyRefrences()
        {
            List<string> sb = new List<string>();

            try
            {
                string strGacDir = GetFrameworkDirectory();
                string[] strFiles;

                strFiles = System.IO.Directory.GetFiles(strGacDir, "*.dll");
                foreach (string strFile in strFiles)
                {
                    sb.Add(new FileInfo(strFile).Name);
                }

            }
            catch 
            {
                // MessageBox.Show(ex.Message, "Exception");
            }

            return sb;
        }
        /// <summary>
        /// Get Directory of .NET Framework
        /// </summary>
        /// <returns></returns>
       
        private string GetFrameworkDirectory()
        {
            // This is the location of the .Net Framework Registry Key

            // Get a non-writable key from the registry
            Microsoft.Win32.RegistryKey netFramework = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(framworkRegPath, false);

            // Retrieve the install root path for the framework
            string installRoot = netFramework.GetValue("InstallRoot").ToString();

            // Retrieve the version of the framework executing this program
            string version = string.Format(@"v{0}.{1}.{2}\",
              Environment.Version.Major,
              Environment.Version.Minor,
              Environment.Version.Build);

            // Return the path of the framework
            return System.IO.Path.Combine(installRoot, version);
        }


        private int GetLine(string search, string Strmain)
        {
            //StringBuilder sb = new StringBuilder(Strmain);
            int pos = Strmain.IndexOf(search, 0);
            Strmain = Strmain.Remove(pos);


            string[] spl = Strmain.Split('\n');


            return spl.Length;


        }
       
    }
}
