using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPCompile
{
    public class CMyDLL
    {
        public List<OneDLL> AllRef = new List<OneDLL>();
        public CMyDLL()
        {
        }

        
    }

    public class OneDLL
    {
        public string FileName;
        public bool Chosen;
        public OneDLL(string fname,bool ch)
        {
            FileName = fname;
            Chosen = ch;
        }

        public override string ToString()
        {
            return FileName;
        }
        public OneDLL()
        {

        }
    }
}
