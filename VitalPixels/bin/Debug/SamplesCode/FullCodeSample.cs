using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
   
namespace VPPlugin
{
    public class MyPlugin
   {
       public Image OutPlugin(Image argImage,out string argMessage)
     {
    
          
          Bitmap OutputImage = new Bitmap(argImage.Width, argImage.Height);
         /// TO DO Program
     
        for (int y = 0; y < OutputImage.Height; y++)
        { 
            for (int x = 0; x < OutputImage.Width; x++)
                
            {

                Color c = ((Bitmap) argImage).GetPixel(x, y);
                
                 int luma = ((c.R)+(c.B))/2;
                 if(c.R>100)
                     OutputImage.SetPixel(x, y, Color.FromArgb(c.B,c.R,0));
                 else 
                     if(c.B<100)
                        OutputImage.SetPixel(x, y, Color.FromArgb(c.R, luma,0)); 
                 else
                    OutputImage.SetPixel(x, y, Color.FromArgb(c.G, c.R,c.B)); 
            }  
        }        

        

         argMessage = "Output"; // TO DO External Message
         return (Image)OutputImage;
     }

    }
}