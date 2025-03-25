using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessingTraining
{
    public partial class Form3 : Form
    {
        Bitmap imageA, imageB, colorGreen;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLoadImageA_Click(object sender, EventArgs e)
        {
            if (openFileDialogA.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(openFileDialogA.FileName);
                pictureBoxA.Image = imageB;
            }
        }

        private void btnLoadImageB_Click(object sender, EventArgs e)
        {
            if (openFileDialogB.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(openFileDialogB.FileName);
                pictureBoxB.Image = imageA;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // 1) Basic checks
            if (imageA == null || imageB == null)
            {
                MessageBox.Show("Please load both Image A and Image B.");
                return;
            }
            if (imageA.Width != imageB.Width || imageA.Height != imageB.Height)
            {
                MessageBox.Show("Images must be the same size!");
                return;
            }

            // 2) Create a result image
            Bitmap resultImage = new Bitmap(imageB.Width, imageB.Height);

            // 3) Specify the green color in code + threshold
            Color myGreen = Color.FromArgb(0, 255, 0);
            // Convert that green to a grayscale value
            int rmyGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;  // Adjust as needed

            // 4) Loop through all pixels
            for (int y = 0; y < imageB.Height; y++)
            {
                for (int x = 0; x < imageB.Width; x++)
                {
                    // Get the pixel from Image B
                    Color pixelB = imageB.GetPixel(x, y);

                    // Convert to 1‑byte grayscale
                    int grayB = (pixelB.R + pixelB.G + pixelB.B) / 3;

                    // Compare to the grayscale of pure green
                    int subtractValue = Math.Abs(grayB - rmyGreen);

                    // 5) Decide if it’s “close to green”
                    if (subtractValue <= threshold)
                    {
                        // Pixel is green ⇒ Replace with pixel from Image A
                        Color pixelA = imageA.GetPixel(x, y);
                        resultImage.SetPixel(x, y, pixelA);
                    }
                    else
                    {
                        // Pixel is NOT green ⇒ Keep Image B’s pixel
                        resultImage.SetPixel(x, y, pixelB);
                    }
                }
            }

            // 6) Display the result
            pictureBoxResult.Image = resultImage;
        }
    }
}
