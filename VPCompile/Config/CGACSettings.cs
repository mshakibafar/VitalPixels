using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPCompile
{
    // Main class for sterilization of the all classes 
    public class AllRefrences
    {
        public List<CGACSettings> AllRef = new List<CGACSettings>();
        public AllRefrences()
        {
        }
    }


    // Class for name of Dlls and GAC that has added to the compiler settings 
    public  class CGACSettings
    {
        public string RefrenceName;
        public List<CNameSpaces> NameSP = new List<CNameSpaces>();

        public CGACSettings(string str)
        {
            RefrenceName = str;
        }

        public CGACSettings(string str,CNameSpaces cn)
        {
            RefrenceName = str;
            NameSP.Add(cn);
        }
        public CGACSettings()
        {

        }

    }


    // Class for name spaces
    public class CNameSpaces
    {
        public string NameSpaces;
        public CNameSpaces()
        {
        }
    }

}
