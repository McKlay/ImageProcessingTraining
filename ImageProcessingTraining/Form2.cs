using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices; // for Marshal.Copy if needed
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingTraining
{
    public partial class Form2 : Form
    {
        Bitmap imageA; // background
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Bitmap ChromaKey(Bitmap cameraFrame, Bitmap background)
        {
            // 1) Scale background to match cameraFrame size
            //    (this overwrites aspect ratio if they differ)
            Bitmap scaledBackground = new Bitmap(cameraFrame.Width, cameraFrame.Height);

            using (Graphics g = Graphics.FromImage(scaledBackground))
            {
                // Draw the background so it fills the entire area of cameraFrame
                g.DrawImage(background, new Rectangle(0, 0, cameraFrame.Width, cameraFrame.Height));
            }

            // 2) Create result with the same size & pixel format
            Bitmap result = new Bitmap(cameraFrame.Width, cameraFrame.Height, PixelFormat.Format24bppRgb);

            // Lock all three bitmaps
            Rectangle rect = new Rectangle(0, 0, cameraFrame.Width, cameraFrame.Height);

            BitmapData cameraData = cameraFrame.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bgData = scaledBackground.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData resData = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = 3; // for 24bpp
            int width = cameraFrame.Width;
            int height = cameraFrame.Height;

            unsafe
            {
                for (int y = 0; y < height; y++)
                {
                    // Pointers to each row
                    byte* cameraRow = (byte*)cameraData.Scan0 + (y * cameraData.Stride);
                    byte* bgRow = (byte*)bgData.Scan0 + (y * bgData.Stride);
                    byte* resRow = (byte*)resData.Scan0 + (y * resData.Stride);

                    for (int x = 0; x < width; x++)
                    {
                        // Camera pixel (BGR)
                        byte b = cameraRow[x * bytesPerPixel + 0];
                        byte g = cameraRow[x * bytesPerPixel + 1];
                        byte r = cameraRow[x * bytesPerPixel + 2];

                        // Background pixel (BGR)
                        byte bb = bgRow[x * bytesPerPixel + 0];
                        byte bg_ = bgRow[x * bytesPerPixel + 1];
                        byte br = bgRow[x * bytesPerPixel + 2];

                        // Example green-screen logic:
                        // If the camera pixel is "mostly green," we consider it background.
                        // Tweak thresholds for your actual lighting.
                        if (g > 100 && r < 100 && b < 100)
                        {
                            // Use background
                            resRow[x * bytesPerPixel + 0] = bb;
                            resRow[x * bytesPerPixel + 1] = bg_;
                            resRow[x * bytesPerPixel + 2] = br;
                        }
                        else
                        {
                            // Keep camera
                            resRow[x * bytesPerPixel + 0] = b;
                            resRow[x * bytesPerPixel + 1] = g;
                            resRow[x * bytesPerPixel + 2] = r;
                        }
                    }
                }
            }

            // Unlock bits
            cameraFrame.UnlockBits(cameraData);
            scaledBackground.UnlockBits(bgData);
            result.UnlockBits(resData);

            // We don’t need the scaled background anymore
            scaledBackground.Dispose();

            return result;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();
            lblStatus.Text = "Camera Started";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                lblStatus.Text = "Camera Stopped";
            }
        }

        private void btnLoadBg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(ofd.FileName);
                pictureBoxCamera.Image = imageA;
                lblStatus.Text = "Background Loaded";
            }
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // IF USING lockbits
            if (imageA == null) return;

            // Clone the camera frame
            using (Bitmap frame = (Bitmap)eventArgs.Frame.Clone())
            {
                // Perform the LockBits-based chroma key
                Bitmap output = ChromaKey(frame, imageA);

                // Show the result in pictureBoxOutput
                // (Make sure pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom for best scaling)
                pictureBoxOutput.Image = output;
            }

            /*  IF USING Get/Set Pixel
            // Clone the incoming camera frame
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            // Create a result bitmap the same size as the camera frame
            Bitmap result = new Bitmap(frame.Width, frame.Height);
            for (int x = 0; x < frame.Width && x < imageA.Width; x++)
            {
                for (int y = 0; y < frame.Height && y < imageA.Height; y++)
                {
                    Color fgPixel = frame.GetPixel(x, y);    // camera
                    Color bgPixel = imageA.GetPixel(x, y);   // background image

                    // Example: If the pixel is "mostly green," we consider it background
                    // and replace it with the background image pixel
                    if (fgPixel.G > 100 && fgPixel.R < 100 && fgPixel.B < 100)
                    {
                        result.SetPixel(x, y, bgPixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, fgPixel);
                    }
                }
            }
            pictureBoxOutput.Image = result;
             */

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
