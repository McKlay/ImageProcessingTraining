using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTraining
{
    static class BasicDIP
    {
        public static void Equalisation(ref Bitmap a, ref Bitmap b, int degree)
        {
            int height = a.Height;
            int width = a.Width;
            int numSamples, histSum;
            int[] Ymap = new int[256];
            int[] hist = new int[256];
            int percent = degree;

            // Compute the histogram for the sub-image
            Color nakuha;
            Color gray;
            Byte graydata;
            //Compute greyscale
            for(int x = 0; x < a.Width; x++)
            {
                for(int y = 0; y < a.Height; y++)
                {
                    nakuha = a.GetPixel(x, y);
                    graydata = (Byte)((nakuha.R + nakuha.G + nakuha.B)/3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
                // Histogram 1D data
                for(int k = 0; k < a.Width; k++)
                {
                    for(int y = 0; y < a.Height; y++)
                    {
                        nakuha = a.GetPixel(k, y);
                        hist[nakuha.B]++;
                    }
                }
                // remap the Ys, use maximum contrast (degree == 100)
                // based on the histogram equalization
                numSamples = (a.Width * a.Height); // number of samples that contributed to the histogram
                histSum = 0;
                for(int h = 0; h < 256; h++)
                {
                    histSum += hist[h];
                    Ymap[h] = histSum * 255 / numSamples;
                }

                // If desired contrast is not maximum (percent < 100), then adjust the mapping
                if(percent < 100)
                {
                    for(int h = 0; h < 256; h++)
                    {
                        Ymap[h] = h + ((int)Ymap[h] - h) * percent / 100;
                    }
                }

                b = new Bitmap(a.Width, a.Height);
                // enhance the region by remapping the intensities
                for(int y = 0; y < a.Height; y++)
                {
                    for(int k = 0; k < a.Width; k++)
                    {
                        // set the new value of the gray value
                        Color temp = Color.FromArgb(Ymap[a.GetPixel(k, y).R], Ymap[a.GetPixel(k, y).G], Ymap[a.GetPixel(k, y).B]);
                        b.SetPixel(k, y, temp);
                    }
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
    }
}
