#image <coins.jpg>
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;


using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
   
namespace VPPlugin
{
    public class MyPlugin
   {
       public System.Drawing.Image OutPlugin(System.Drawing.Image InputImage,
       out string NumberofCirles)
     {
    
          Bitmap  bitmap = new Bitmap(InputImage);
         /// TO DO Program
     
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle( 0, 0, bitmap.Width, bitmap.Height ),
                ImageLockMode.ReadWrite, bitmap.PixelFormat );

            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering( );

            colorFilter.Red   = new IntRange( 0, 64 );
            colorFilter.Green = new IntRange( 0, 64 );
            colorFilter.Blue  = new IntRange( 0, 64 );
            colorFilter.FillOutsideRange = false;

            colorFilter.ApplyInPlace( bitmapData );

            // step 2 - locating objects
            BlobCounter blobCounter = new BlobCounter( );

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage( bitmapData );
            Blob[] blobs = blobCounter.GetObjectsInformation( );
            bitmap.UnlockBits( bitmapData );

            // step 3 - check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker( );

            Graphics g      = Graphics.FromImage( bitmap );
            Pen yellowPen   = new Pen( Color.Yellow, 2 ); // circles
            Pen redPen      = new Pen( Color.Red, 2 );       // quadrilateral
            Pen brownPen    = new Pen( Color.Brown, 2 );   // quadrilateral with known sub-type
            Pen greenPen    = new Pen( Color.Green, 2 );   // known triangle
            Pen bluePen     = new Pen( Color.Blue, 2 );     // triangle
            int CountCircle = 0;
            
            for ( int i = 0, n = blobs.Length; i < n; i++ )
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints( blobs[i] );

                AForge.Point center;
                float radius;

                // is circle ?
                if ( shapeChecker.IsCircle( edgePoints, out center, out radius ) )
                {
                    g.DrawEllipse( yellowPen,
                        (float) ( center.X - radius ), (float) ( center.Y - radius ),
                        (float) ( radius * 2 ), (float) ( radius * 2 ) );
                    CountCircle++;
                }
                else
                {
                    List<IntPoint> corners;

                    // is triangle or quadrilateral
                    if ( shapeChecker.IsConvexPolygon( edgePoints, out corners ) )
                    {
                        // get sub-type
                        PolygonSubType subType = shapeChecker.CheckPolygonSubType( corners );

                        Pen pen;

                        if ( subType == PolygonSubType.Unknown )
                        {
                            pen = ( corners.Count == 4 ) ? redPen : bluePen;
                        }
                        else
                        {
                            pen = ( corners.Count == 4 ) ? brownPen : greenPen;
                        }

                        g.DrawPolygon( pen, ToPointsArray( corners ) );
                    }
                }
            }

            yellowPen.Dispose( );
            redPen.Dispose( );
            greenPen.Dispose( );
            bluePen.Dispose( );
            brownPen.Dispose( );
            g.Dispose( );

            NumberofCirles = CountCircle.ToString();
            // and to picture box
            return (System.Drawing.Image) bitmap;

            


            //argMessage ="Message"; // TO DO External Message
            //return (Image)OutputImage;
     }
        private System.Drawing.Point[] ToPointsArray( List<IntPoint> points )
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for ( int i = 0, n = points.Count; i < n; i++ )
            {
                array[i] = new System.Drawing.Point( points[i].X, points[i].Y );
            }

            return array;
        }

    }
}