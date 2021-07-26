using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitalPixels.Config;

namespace VitalPixels
{
    class ImageProperty
    {
        #region Properties
        static public string MyCustomName = "No Arg";


        public struct ImageInfoResult
        {
            public double SNR;
            public double PSNR;
            public int NumberofColors;
        }

        public enum RGB
        {
            RGB,
            Red,
            Green,
            Blue,
            Grey
        }

        [System.ComponentModel.Editor(typeof(System.Windows.Forms.Design.FileNameEditor), 
            typeof(System.Drawing.Design.UITypeEditor)),
        Browsable(true), Category("FileInfo"),
        Description("File name of current image")]

        // Properties
        public string FileName
        {
            get
            {
                return _FileName;
            }

            set
            {
                if (File.Exists(value))
                {
                    try
                    {
                        Image img = Image.FromFile(value);
                        _FileName = value;
                        MainImage = Image.FromFile(value);
                        FirstImage = MainImage;
                    }
                    catch 
                    {
                        System.Windows.Forms.MessageBox.Show("File isn't an image , please choose another file.",
                            "Notice", System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
        }
        [Browsable(true), Category("FileInfo"), Description("Size of current file in Bytes")]

        public long Size
        {
            get
            {
                if (FileName.Length > 0)
                {
                    FileInfo f = new FileInfo(FileName);
                    return f.Length;
                }
                else
                    return 0;
            }
        }
        [Browsable(true), Category("ImageInfo"), Description("Width of current Image in pixels")]
        public uint Width
        {
            get
            {
                return _Width;
            }

            set
            {
                if (value < 10000)
                {
                    _Width = value;
                }
                else
                    _Width = 10000;
                MainImage = ResizeImage(FirstImage, new Size((int)_Width, (int)MainImage.Height));
            }
        }

        [Browsable(true), Category("ImageInfo"), Description("Height of current Image in pixels")]
        public uint Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value < 10000)
                {
                    _Height = value;
                }
                else
                    _Height = 10000;
                MainImage = ResizeImage(FirstImage, new Size((int)MainImage.Width, (int)_Height));
            }
        }
        [Browsable(true), Category("ImageInfo"), Description("Number of pixels in current Image")]
        public int TotalPixels
        {
            get
            {
                return (int)(_Width * _Height);
            }

        }
        [Browsable(true), Category("Resolution"), Description("Horizontal Resolution of current Image")]
        public float HorizontalResolution
        {
            get
            {
                if (FileName.Length > 0)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(FileName);
                    return img.HorizontalResolution;
                }
                else
                    return 0;
            }
        }
        [Browsable(true), Category("Resolution"), Description("Vertical Resolution of current Image")]
        public float VerticalResolution
        {
            get
            {
                if (FileName.Length > 0)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(FileName);
                    return img.VerticalResolution;
                }
                else
                    return 0;
            }

        }
        [Category("ColorsInfo")]
        public uint NumberofColors
        {
            get
            {
                return (uint)GetColorCount();
            }

        }

        private uint CountColorImage()
        {
            throw new NotImplementedException();
        }

        [Browsable(true), Category("Result"), 
        Description("Signal-to-noise ratio (abbreviated SNR) is a measure used in science and engineering that compares the level of a desired signal to the level of background noise. It is defined as the ratio of signal power to the noise power, often expressed in decibels.")]
        public string SNR
        {
            get
            {
                return _SNR.ToString() + " dB";
            }
        }
        [Browsable(true), Category("Result"), Description("The term peak signal-to-noise ratio (PSNR) is an expression for the ratio between the maximum possible value (power) of a signal and the power of distorting noise that affects the quality of its representation.")]
        public string PSNR
        {
            get
            {
                return _PSNR.ToString() + " dB";
            }
        }
        [Category("Result")]

        public string OutputColor
        {
            get
            {
                return _ColorOutput.ToString();
            }
        }

        [Category("Result")]

        public string ElapsedTime
        {
            get
            {
                return _RunTime.ToString()+" ms";
            }
        }

        [DisplayNameCustom(),Category("Output")]
        public string MyProperty 
        { 
            get
            {
                return _MyProperty;
            }
        }
        #endregion
        #region FIELDS

        // Fields
        private string _FileName;
        private uint _Width;
        private uint _Height;
        public Image MainImage;
        protected Image FirstImage;
        public double _SNR;
        public double _PSNR;
        public double _ColorOutput;
        public long _RunTime;

        #endregion

        #region Constructor
        //Constructor
        public ImageProperty(string fname)
        {
            FileName = fname;

            if (File.Exists(fname))
            {
                FileInfo f = new FileInfo(fname);
                // Size = f.Length;
                System.Drawing.Image img = System.Drawing.Image.FromFile(fname);
                MainImage = Image.FromFile(fname);
                FirstImage = Image.FromFile(fname);
                Width = (uint)img.Width;
                Height = (uint)img.Height;
            }
        }
        public ImageProperty(Image img,string fname)
        {
            FileName = fname;

            MainImage = img;
            FirstImage = img;
            Width = (uint)img.Width;
            Height = (uint)img.Height;

        }
        public void Dispose()
        {
            MainImage.Dispose();
            FirstImage.Dispose();
          //  ColorHashSet.Clear();
        }
        #endregion

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            Image Result = new Bitmap(imgToResize, size);
            return Result;
        }

        /// <summary>
        /// Calculate SNR,PSNR,CPR between to Image
        /// </summary>
        /// <param name="Sourceimg">Source Image</param>
        /// <param name="Targetimg">Target Image</param>
        /// <returns>ImageInfoResult</returns>
        static public ImageInfoResult CalculateImageInfo(Image Sourceimg, Image Targetimg,
            RGB ColorMode = RGB.RGB)
        {
            // Check for error
            ImageInfoResult img = new ImageInfoResult();
            if (Targetimg == null) return img;

            HashSet<Color> clhash = new HashSet<Color>();
            HashSet<Color> clVitalhash = new HashSet<Color>();

            double AllUp = 0;

            img.SNR = img.PSNR = 0;
            img.NumberofColors = 0;

            //if (Sourceimg.Size != Targetimg.Size)
            //    return img;

            int W = Sourceimg.Width, H = Sourceimg.Height;

            Bitmap Sbitmap = new Bitmap(Sourceimg, new Size(W, H));
            Bitmap Tbitmap = new Bitmap(Targetimg, new Size(W, H));

            Color SColor = new Color();
            Color TColor = new Color();

            int SCode = 0, TCode = 0;
            ulong down = 0;

            for (int x = 0; x < W; x++)
            {
                for (int y = 0; y < H; y++)
                {
                    SColor = Sbitmap.GetPixel(x, y);
                    clVitalhash.Add(SColor);
                    TColor = Tbitmap.GetPixel(x, y);
                    clhash.Add(TColor);

                    if (ColorMode == RGB.RGB)
                    {
                        SCode = (int)(SColor.R * 0.3 + SColor.G * 0.59 + SColor.B * 0.11);
                        TCode = (int)(TColor.R * 0.3 + TColor.G * 0.59 + TColor.B * 0.11);
                    }
                    if (ColorMode == RGB.Red)
                    {
                        SCode = (SColor.R);
                        TCode = (TColor.R);
                    }
                    if (ColorMode == RGB.Blue)
                    {
                        SCode = (SColor.B);
                        TCode = (TColor.B);
                    }
                    if (ColorMode == RGB.Green)
                    {
                        SCode = (SColor.G);
                        TCode = (TColor.G);
                    }

                    down += (ulong)((SCode - TCode) * (SCode - TCode));
                    AllUp += (ulong)(SCode * SCode);
                }
                // AllUp += (double)up;
                //   up = 0;
            }

            Sbitmap.Dispose();
            Tbitmap.Dispose();

            double CalSNR, CalPSNR;

            if (down == 0) return img;

            CalSNR = (double)(AllUp) / (double)down;
            CalSNR = (10 * Math.Log10(CalSNR));
            CalSNR = Math.Round(CalSNR * 100) / 100;

            double MSE = (double)down / (double)(W * H);
            CalPSNR = 10 * Math.Log10(255 * 255 / MSE);
            CalPSNR = Math.Round(CalPSNR * 100) / 100;

            img.NumberofColors = clVitalhash.Count;
            img.SNR = CalSNR;
            img.PSNR = CalPSNR;

            //  img.CPR = -10 * Math.Log10((double)clhash.Count / ((double)W * H));
            //  img.CPR = Math.Round(img.CPR * 100) / 100;

            img.NumberofColors = clhash.Count;

            return img;
        }

        public int GetColorCount()
        {
            // Check for error
            HashSet<Color> clhash = new HashSet<Color>();
            int W = MainImage.Width, H = MainImage.Height;
            Bitmap Sbitmap = new Bitmap(MainImage, new Size(W, H));


            Color SColor = new Color();

            for (int x = 0; x < W; x++)
            {
                for (int y = 0; y < H; y++)
                {
                    SColor = Sbitmap.GetPixel(x, y);
                    clhash.Add(SColor);
                }
            }


            return clhash.Count;
        }


        internal static string GetCustomName()
        {
            //throw new NotImplementedException();
            return MyCustomName;
        }

        public string _MyProperty;
    }
}
