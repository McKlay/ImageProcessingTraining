using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTraining
{
    static class BasicDIP
    {
        public static void Equalisation(ref Bitmap a, ref Bitmap b, int degree)
        {
            int width = a.Width;
            int height = a.Height;
            int[] hist = new int[256];
            int[] Ymap = new int[256];
            int percent = degree;

            // Convert to grayscale and build histogram
            Bitmap grayBitmap = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color original = a.GetPixel(x, y);
                    byte gray = (byte)((original.R + original.G + original.B) / 3);
                    hist[gray]++;
                    grayBitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            // Compute cumulative histogram (mapping)
            int histSum = 0;
            int numSamples = width * height;
            for (int i = 0; i < 256; i++)
            {
                histSum += hist[i];
                Ymap[i] = histSum * 255 / numSamples;
            }

            // Apply percentage (optional)
            if (percent < 100)
            {
                for (int i = 0; i < 256; i++)
                {
                    Ymap[i] = i + (Ymap[i] - i) * percent / 100;
                }
            }

            // Create the equalized image
            b = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color g = grayBitmap.GetPixel(x, y);
                    int eq = Ymap[g.R];
                    eq = Math.Clamp(eq, 0, 255); // Ensure it's within bounds
                    b.SetPixel(x, y, Color.FromArgb(eq, eq, eq));
                }
            }
        }
        public static void Brightness(ref Bitmap a, ref Bitmap b, int value)
        {
            b = new Bitmap(a.Width, a.Height);
            for(int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    Color temp = a.GetPixel(x, y);
                    Color changed;
                    if(value > 0)
                    {
                        changed = Color.FromArgb(Math.Min(temp.R + value, 255), Math.Min(temp.G + value, 255), Math.Min(temp.B + value, 255));
                    } else
                    {
                        changed = Color.FromArgb(Math.Max(temp.R + value, 0), Math.Max(temp.G + value, 0), Math.Max(temp.B + value, 0));
                    }
                    b.SetPixel(x, y, changed);
                }
            }
        }
        public static void Hist(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;
            //Grayscale Conversion
            for(int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (Byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }
            int[] histdata = new int[256];

            for(int x = 0; x < a.Width; x++)
            {
                for(int y = 0; y < a.Height; y++)
                {
                    sample= a.GetPixel(x, y);
                    histdata[sample.R]++; //can be any color property R, G, or B

                }
            }
            b = new Bitmap(256, 800);
            for(int x = 0; x < 256; x++)
            {
                for(int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            // Plotting points based from histdata
            for(int x = 0; x < 256; x++)
            {
                for(int y = 0; y < Math.Min(histdata[x] / 5, b.Height-1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }
        public static bool Conv3x3(ref Bitmap b, ConvMatrix m)
        {
            if (m.Factor == 0) return false;

            Bitmap bSrc = (Bitmap)b.Clone();
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = stride * 2;
            IntPtr Scan0 = bmData.Scan0;
            IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;
                int nPixel;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        // Blue
                        nPixel = (
                            (pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) +
                            (pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) +
                            (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) + (pSrc[6 + stride2] * m.BottomRight)
                            ) / m.Factor + m.Offset;
                        p[3 + stride] = Clamp(nPixel);

                        // Green
                        nPixel = (
                            (pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) +
                            (pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) +
                            (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) + (pSrc[7 + stride2] * m.BottomRight)
                            ) / m.Factor + m.Offset;
                        p[4 + stride] = Clamp(nPixel);

                        // Red
                        nPixel = (
                            (pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) +
                            (pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
                            (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)
                            ) / m.Factor + m.Offset;
                        p[5 + stride] = Clamp(nPixel);

                        p += 3;
                        pSrc += 3;
                    }

                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);
            return true;
        }

        private static byte Clamp(int val)
        {
            if (val < 0) return 0;
            if (val > 255) return 255;
            return (byte)val;
        }


    }
}
