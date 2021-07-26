using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows;
using System.Drawing.Drawing2D;
using System.IO.Compression;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace VPFilter
{
    public class FilterImage
    {
        public enum RGB
        {
            RGB,
            Red,
            Green,
            Blue,
            Grey
        }

        public enum MixType
        {
            Add,
            Sub,
            Average,
            OR,
            XOR,
            AND,
            Min,
            Max
        }

        #region FilterColor
        /// <summary>
        /// Invert Colors of an Image
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        static public Image InvertColor(Image img)
        {


            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j,
                     Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            img = (Bitmap)bmap.Clone();

            return img;

        }
        /// <summary>
        /// Change Color to Red,Blue or Green
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        static public Image ColorRGBImage(Image img, RGB colorFilterType)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    if (colorFilterType == RGB.Red)
                    {
                        nPixelR = c.R;
                        nPixelG = c.G - 255;
                        nPixelB = c.B - 255;
                    }
                    else if (colorFilterType == RGB.Green)
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G;
                        nPixelB = c.B - 255;
                    }
                    else if (colorFilterType == RGB.Blue)
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G - 255;
                        nPixelB = c.B;
                    }
                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
            img = (Bitmap)bmap.Clone();
            return img;

        }
        /// <summary>
        /// Set Brightness for an image
        /// </summary>
        /// <param name="img"></param>
        /// <param name="brightness"></param>
        /// <returns></returns>
        static public Image SetBrightness(Image img, int brightness)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    bmap.SetPixel(i, j,
                      Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
            img = (Bitmap)bmap.Clone();

            return img;
        }
        /// <summary>
        /// Set Contrast of an Image
        /// </summary>
        /// <param name="img"></param>
        /// <param name="brightness"></param>
        /// <returns></returns>
        static public Image SetContrast(Image img, double contrast)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j,
                      Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            img = (Bitmap)bmap.Clone();

            return img;
        }

        /// <summary>
        /// Change Gamma of the Image
        /// </summary>
        /// <param name="img">Input Image</param>
        /// <param name="R">Red</param>
        /// <param name="G">Green</param>
        /// <param name="B">Blue</param>
        /// <returns>Image</returns>
        static public Image SetGamma(Image img, double R, double G, double B)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            byte[] redGamma = CreateGammaArray(R);
            byte[] greenGamma = CreateGammaArray(G);
            byte[] blueGamma = CreateGammaArray(B);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(redGamma[c.R],
                       greenGamma[c.G], blueGamma[c.B]));
                }
            }
            img = (Bitmap)bmap.Clone();

            return img;
        }

        static private byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255,
        (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }
        /// <summary>
        /// Crop Image
        /// </summary>
        /// <param name="Source">Image of Source </param>
        /// <param name="x">Right Position</param>
        /// <param name="y">Top Position</param>
        /// <param name="width">Size of Width</param>
        /// <param name="height">Size of Height</param>
        /// <returns></returns>
        static public Image CropImage(Image Source, int x, int y, int width, int height)
        {
            Rectangle crop = new Rectangle(x, y, width, height);
            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(Source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }

            // ACT ON FIRST IMAGE
          //  FirstImage = (Image)bmp;
            // Width =(uint) width;
            //Height = (uint)height;

            return (Image)bmp;

        }

        /// <summary>
        /// Find Edges of an Image
        /// </summary>
        /// <param name="img"></param>
        /// <returns>Edge pictures</returns>
        public static Image FindEdges(Image img)
        {
            Bitmap b = (Bitmap)img;
            Bitmap bb = (Bitmap)img;
            int width = b.Width;
            int height = b.Height;
            int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            int[,] allPixR = new int[width, height];
            int[,] allPixG = new int[width, height];
            int[,] allPixB = new int[width, height];

            int limit = 128 * 128;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    allPixR[i, j] = b.GetPixel(i, j).R;
                    allPixG[i, j] = b.GetPixel(i, j).G;
                    allPixB[i, j] = b.GetPixel(i, j).B;
                }
            }

            int new_rx = 0, new_ry = 0;
            int new_gx = 0, new_gy = 0;
            int new_bx = 0, new_by = 0;
            int rc, gc, bc;
            for (int i = 1; i < b.Width - 1; i++)
            {
                for (int j = 1; j < b.Height - 1; j++)
                {

                    new_rx = 0;
                    new_ry = 0;
                    new_gx = 0;
                    new_gy = 0;
                    new_bx = 0;
                    new_by = 0;
                    rc = 0;
                    gc = 0;
                    bc = 0;

                    for (int wi = -1; wi < 2; wi++)
                    {
                        for (int hw = -1; hw < 2; hw++)
                        {
                            rc = allPixR[i + hw, j + wi];
                            new_rx += gx[wi + 1, hw + 1] * rc;
                            new_ry += gy[wi + 1, hw + 1] * rc;

                            gc = allPixG[i + hw, j + wi];
                            new_gx += gx[wi + 1, hw + 1] * gc;
                            new_gy += gy[wi + 1, hw + 1] * gc;

                            bc = allPixB[i + hw, j + wi];
                            new_bx += gx[wi + 1, hw + 1] * bc;
                            new_by += gy[wi + 1, hw + 1] * bc;
                        }
                    }
                    try
                    {
                        if (new_rx * new_rx + new_ry * new_ry > limit || new_gx * new_gx + new_gy * new_gy > limit || new_bx * new_bx + new_by * new_by > limit)
                            bb.SetPixel(i, j, Color.Black);

                        else
                            bb.SetPixel(i, j, Color.Transparent);
                    }
                    catch
                    {
                       // global::System.Windows.Forms.MessageBox.Show("This image doesn't support Find Edge filter");
                        return null;
                    }
                }
            }

            return (Image)bb;
        }
        /// <summary>
        /// Add Noise to an image
        /// </summary>
        /// <param name="img">the source image</param>
        /// <param name="Den">Density of Noise</param>
        /// <returns>Noised Image</returns>
        public static Image AddNoise(Image img, int Den)
        {
            int W = img.Width, H = img.Height;
            Bitmap bmp=(Bitmap)img.Clone();
            int RndCore = 10;

            if(Den!=0)
            for (int x = 0; x < W; x++)
            {
                for (int y = 0; y < H; y++)
                {
                    Random rnd = new Random(RndCore*x*y);
                    RndCore = rnd.Next(0, 100 - Den);
                    if (RndCore== 1)
                        bmp.SetPixel(x, y, Color.FromArgb(170, rnd.Next(0,255),
                            rnd.Next(0, 255), rnd.Next(0, 255)));
                }
            }

            img = (Bitmap)bmp.Clone();

            return (Image)img;
        }
        /// <summary>
        /// Flip  Image
        /// </summary>
        /// <param name="rotateFlipType"></param>

        public static Image RotateFlip(Image img, RotateFlipType rotateFlipType)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            bmap.RotateFlip(rotateFlipType);
            img = (Bitmap)bmap.Clone();

            return img;
        }

       /// <summary>
       /// Make Mosaic of an image
       /// </summary>
       /// <param name="img">Input Image</param>
       /// <param name="Den">Size of Mosaic</param>
       /// <returns></returns>

        public static Image Mosaic(Image img, int Den)
        {
            int W = img.Width, H = img.Height;
            Bitmap mainbmp=new Bitmap(img);
            Bitmap bmp = new Bitmap(W, H);
            Graphics gr = Graphics.FromImage(bmp);
            Pen pen= new Pen(Brushes.Black);

            for (int x = 0; x < W; x+=Den)
            {
                for (int y = 0; y < H; y++)
                {
                    Color cl =mainbmp.GetPixel(x,y);
                    cl = Color.FromArgb(255, cl.R , cl.G , cl.B );
                    pen.Color=cl;
                    if(x+Den<W)
                        gr.DrawLine(pen, x, y, x+Den, y+1);
                    else
                        gr.DrawLine(pen, x, y, W, y + 1);


                       
                }
            }

            img = (Bitmap)bmp.Clone();

            return (Image)img;
        }
        #endregion

        /// <summary>
        /// Make soft blue of an image
        /// </summary>
        /// <param name="img">Input Image</param>
        /// <returns>Returned blur image</returns>

        public static Image BlurImage(Image img)
        {
            int W = img.Width, H = img.Height;
            Bitmap mainbmp = new Bitmap(img);
            Bitmap bmp = new Bitmap(W, H);
            Pen pen = new Pen(Brushes.Black);
            Color LastColor = new Color();
            Color CHColor = new Color();

            for (int x = 0; x < W; x ++)
            {
                for (int y = 0; y < H; y++)
                {
                    Color cl = mainbmp.GetPixel(x, y);

                    if (x > 0)
                        CHColor = Color.FromArgb(255, (LastColor.R + cl.R) / 2,
                            (LastColor.G + cl.G) / 2, (LastColor.B + cl.B) / 2);
                    else
                        CHColor = cl;

                    

                    bmp.SetPixel(x,y,CHColor);
                    LastColor = CHColor;

                }
            }

            img = (Bitmap)bmp.Clone();

            return (Image)img;
        }

        // Convert to Grey Style
        public static Image GreyStyle(Image argimage)
        {
            Bitmap c = (Bitmap)argimage;
            Bitmap d = new Bitmap(argimage.Width, argimage.Height);

            for (int i = 0; i < argimage.Width; i++)
            {
                for (int x = 0; x < argimage.Height; x++)
                {
                    Color oc = c.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    d.SetPixel(i, x, nc);
                }
            }
            return (Image)d;

        }

        public static Color MixColor(Color C1, Color C2, MixType mt)
        {
            Color r = new Color();

            switch (mt)
            {
                case MixType.Add:
                    r = Color.FromArgb((C1.R + C2.R) > 255 ? 255 : (C1.R + C2.R),
                        (C1.G + C2.G) > 255 ? 255 : (C1.G + C2.G),
                        (C1.B + C2.B) > 255 ? 255 : (C1.B + C2.B));
                    break;
                case MixType.Sub:
                    r = Color.FromArgb((C1.R - C2.R) <0 ? 0 : (C1.R - C2.R),
                        (C1.G - C2.G) < 0 ? 0 : (C1.G - C2.G),
                        (C1.B - C2.B) < 0 ? 0 : (C1.B - C2.B));
                    break;
                case MixType.Average:
                    r = Color.FromArgb((C1.R + C2.R) / 2,
                        (C1.G + C2.G) / 2,
                        (C1.B + C2.B) / 2);
                    break;
                case MixType.XOR:
                    r = Color.FromArgb((C1.R ^ C2.R) ,
                        (C1.G ^ C2.G),
                        (C1.B ^ C2.B) );
                    break;

                case MixType.AND:
                    r = Color.FromArgb((C1.R & C2.R),
                        (C1.G & C2.G),
                        (C1.B & C2.B));
                    break;

                case MixType.OR:
                    r = Color.FromArgb((C1.R | C2.R),
                        (C1.G | C2.G),
                        (C1.B | C2.B));
                    break;

                case MixType.Min:
                    r = Color.FromArgb(Math.Min(C1.R , C2.R),
                       Math.Min(C1.G, C2.G),
                       Math.Min(C1.B, C2.B));
                    break;

                case MixType.Max:
                    r = Color.FromArgb(Math.Max(C1.R, C2.R),
                       Math.Max(C1.G, C2.G),
                       Math.Max(C1.B, C2.B));
                    break;
                default:
                    break;
            }


            return r;
        }
        /// <summary>
        /// Mix two Image together with different way
        /// </summary>
        /// <param name="source">Main Image</param>
        /// <param name="target">Second Image</param>
        /// <param name="mt">Type of mixing</param>
        /// <returns></returns>
        public static Image MixImage(Image source, Image target, MixType mt)
        {

            Bitmap b1 = new Bitmap(source);
            Bitmap b2 = new Bitmap(target);

            int H = source.Height;
            int W = source.Width;

            Bitmap bmp = new Bitmap(W, H);


            for (int x = 0; x < W; x++)
            {
                for (int y = 0; y < H; y++)
                {
                    Color cpoint = new Color();

                    Color C1 = b1.GetPixel(x, y);

                    if (x < b2.Width && y < b2.Height)
                    {
                        Color C2 = b2.GetPixel(x, y);

                        cpoint = MixColor(C1, C2, mt);
                    }
                    else
                        cpoint = C1;

                    bmp.SetPixel(x, y, cpoint);
                }
            }

            return (Image)bmp;
        }

        public static Image ChangeImageType(Image source,PixelFormat pf)
        {
            Bitmap img = new Bitmap(source);
            Bitmap img8 = new Bitmap(source.Width, source.Height, pf);

            for (int I = 0; I <= img.Width - 1; I++)
            {
                for (int J = 0; J <= img.Height - 1; J++)
                {
                    img8.SetPixel(I, J, img.GetPixel(I, J));
                }
            }

            return (Image)img8;
        }
        /// <summary>
        /// Get Screenshot and return it as an Image
        /// </summary>
        /// <returns></returns>
        public static Image GetScreenCapture()
        {
            Bitmap printscreen = new Bitmap
                        (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
           // printscreen.Save(@"C:\Temp\printscreen.jpg", ImageFormat.Jpeg);

            return (Image)printscreen;

        }
        /// <summary>
        /// Make Image in Threshold 
        /// </summary>
        /// <param name="SourceImage">Source Image</param>
        /// <param name="TR">Threshold of Red</param>
        /// <param name="TG">Threshold Green</param>
        /// <param name="TB">Threshold of Blue</param>
        /// <returns></returns>
        public static Image ThresholdRGB(Image SourceImage, int TR, int TG, int TB)
        {
            Bitmap bmp = new Bitmap(SourceImage.Width, SourceImage.Height);
            Bitmap bmpSource = new Bitmap(SourceImage);


            for (int x = 0; x < SourceImage.Width; x++)
            {
                for (int y = 0; y < SourceImage.Height; y++)
                {
                    Color src = new Color();
                    src = bmpSource.GetPixel(x, y);
                    Color cl = new Color();

                    cl = Color.FromArgb(255,
                        (src.R > TR) ? 255 : 0,
                        (src.G > TG) ? 255 : 0,
                        (src.B > TB) ? 255 : 0
                       );
                    bmp.SetPixel(x, y, cl);
                }
            }


            return (Image)bmp;
        }


        /// <summary>
        /// Change Image to its threshold with RGB
        /// </summary>
        /// <param name="SourceImage"></param>
        /// <param name="TR">Threshold of Red</param>
        /// <param name="TG">Threshold of Green</param>
        /// <param name="TB">Threshold of Blue</param>
        /// <returns></returns>
        public static Image SplittedThresholdRGB(Image SourceImage, int TR, int TG, int TB)
        {
            Bitmap bmp = new Bitmap(SourceImage.Width, SourceImage.Height);
            Bitmap bmpSource = new Bitmap(SourceImage);

            if (TR * TG * TB == 0) return SourceImage;

            for (int x = 0; x < SourceImage.Width; x++)
            {
                for (int y = 0; y < SourceImage.Height; y++)
                {
                    Color src = new Color();
                    src = bmpSource.GetPixel(x, y);
                    Color cl = new Color();

                    cl = Color.FromArgb(255,
                        (src.R / TR) *TR,
                        (src.G / TG) *TG ,
                        (src.B / TB) *TB
                       );
                    bmp.SetPixel(x, y, cl);
                }
            }


            return (Image)bmp;
        }

        ///// <summary>
        ///// Sepia
        ///// </summary>
        ///// <param name="img"></param>
        ///// <returns></returns>
        //public static Image Sepia(Image img)
        //{
        //    Sepia sp = new AForge.Imaging.Filters.Sepia();

        //    return (Image)sp.Apply((Bitmap)img);
        //}


        public static Image VPAForgFilter(Image img,string  Filter)
        {
            switch (Filter.ToUpper().Replace(" ",""))
            {
                case "SEPIA":
                    {
                        Sepia filter = new AForge.Imaging.Filters.Sepia();
                        return (Image)filter.Apply((Bitmap)img);
                    }

                case "SHARPEN":
                    {
                        Sharpen filter = new Sharpen();
                        return (Image)filter.Apply((Bitmap)img);
                    }

                case "GAUSSIANBLUR":
                    {
                        GaussianBlur filter = new GaussianBlur();
                        return (Image)filter.Apply((Bitmap)img);
                    }

                case "JITTER":
                    {
                        Jitter filter = new Jitter();
                        return (Image)filter.Apply((Bitmap)img);
                    }

                case "OILPAINTING":
                    {
                        OilPainting filter = new OilPainting();
                        return (Image)filter.Apply((Bitmap)img);
                    }
                case "BLUR":
                    {
                        Blur filter = new Blur();
                        
                        return (Image)filter.Apply((Bitmap)img);
                    }
                case "GAUSSIANSHARPEN":
                    {
                        GaussianSharpen filter = new GaussianSharpen();

                        return (Image)filter.Apply((Bitmap)img);
                    }
                case "MEDIAN":
                    {
                        Median filter = new Median();

                        return (Image)filter.Apply((Bitmap)img);
                    }
                    
                case "WATERWAVE":
                    {
                        WaterWave filter = new WaterWave();

                        return (Image)filter.Apply((Bitmap)img);
                    }
                case "EDGES":
                    {
                        Edges filter = new Edges();

                        return (Image)filter.Apply((Bitmap)img);
                    }

                default:
                    return null;
            }

                        
        }
    }
}
