using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace VPPlugin
{

   public class MyPlugin
   {
     public Image OutPlugin(Image argImage,out string argMessage)
     {
    
          Bitmap bm = new Bitmap(argImage.Width, argImage.Height);
         /// TO DO Program
      
            Class1 v          = new Class1();
            MWNumericArray aa = new MWNumericArray(15);
            MWNumericArray ab = new MWNumericArray(6);
            aa                = 12;
            ab                = 1;
            double a          = Convert.ToDouble(v.mohsen(aa, ab).ToString());
            
            argMessage = "Message"; // TO DO External Message
         return (Image)bm;
     }

   }
}