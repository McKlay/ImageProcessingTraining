using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTraining
{
    class ConvMatrix
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;
        public int MidLeft = 0, Pixel = 1, MidRight = 0;
        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;

        public int Factor = 1;
        public int Offset = 0;

        // Optional factory methods for common filters
        public static ConvMatrix Sharpen()
        {
            return new ConvMatrix
            {
                TopLeft = 0,
                TopMid = -2,
                TopRight = 0,
                MidLeft = -2,
                Pixel = 11,
                MidRight = -2,
                BottomLeft = 0,
                BottomMid = -2,
                BottomRight = 0,
                Factor = 3
            };
        }

        public static ConvMatrix EdgeDetection()
        {
            return new ConvMatrix
            {
                TopLeft = -1,
                TopMid = -1,
                TopRight = -1,
                MidLeft = -1,
                Pixel = 8,
                MidRight = -1,
                BottomLeft = -1,
                BottomMid = -1,
                BottomRight = -1,
                Factor = 1
            };
        }

        public static ConvMatrix BoxBlur()
        {
            return new ConvMatrix
            {
                TopLeft = 1,
                TopMid = 1,
                TopRight = 1,
                MidLeft = 1,
                Pixel = 1,
                MidRight = 1,
                BottomLeft = 1,
                BottomMid = 1,
                BottomRight = 1,
                Factor = 9
            };
        }

        public static ConvMatrix GaussianBlur()
        {
            return new ConvMatrix
            {
                TopLeft = 1,
                TopMid = 2,
                TopRight = 1,
                MidLeft = 2,
                Pixel = 4,
                MidRight = 2,
                BottomLeft = 1,
                BottomMid = 2,
                BottomRight = 1,
                Factor = 16,
                Offset = 0
            };
        }

        public static ConvMatrix Emboss()
        {
            return new ConvMatrix
            {
                TopLeft = -2,
                TopMid = -1,
                TopRight = 0,
                MidLeft = -1,
                Pixel = 1,
                MidRight = 1,
                BottomLeft = 0,
                BottomMid = 1,
                BottomRight = 2,
                Factor = 1,
                Offset = 128 // Shift to make gray the "neutral" base
            };
        }

        public static ConvMatrix EdgeEnhance()
        {
            return new ConvMatrix
            {
                TopLeft = -1,
                TopMid = -1,
                TopRight = -1,
                MidLeft = -1,
                Pixel = 9,
                MidRight = -1,
                BottomLeft = -1,
                BottomMid = -1,
                BottomRight = -1,
                Factor = 1,
                Offset = 128
            };
        }

        public static ConvMatrix MeanBlur()
        {
            return new ConvMatrix
            {
                TopLeft = 1,
                TopMid = 1,
                TopRight = 1,
                MidLeft = 1,
                Pixel = 1,
                MidRight = 1,
                BottomLeft = 1,
                BottomMid = 1,
                BottomRight = 1,
                Factor = 9,
                Offset = 0
            };
        }

        public static ConvMatrix SobelVertical()
        {
            return new ConvMatrix
            {
                TopLeft = -1,
                TopMid = -2,
                TopRight = -1,
                MidLeft = 0,
                Pixel = 0,
                MidRight = 0,
                BottomLeft = 1,
                BottomMid = 2,
                BottomRight = 1,
                Factor = 1,
                Offset = 0
            };
        }
        public static ConvMatrix Outline()
        {
            return new ConvMatrix
            {
                TopLeft = -1,
                TopMid = 0,
                TopRight = -1,
                MidLeft = 0,
                Pixel = 4,
                MidRight = 0,
                BottomLeft = -1,
                BottomMid = 0,
                BottomRight = -1,
                Factor = 1,
                Offset = 127
            };
        }

    }
}
