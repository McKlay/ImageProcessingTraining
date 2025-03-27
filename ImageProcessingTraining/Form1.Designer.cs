namespace ImageProcessingTraining
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            mIrrorHoriToolStripMenuItem = new ToolStripMenuItem();
            mirrorVertiToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            webCamSubtractionToolStripMenuItem = new ToolStripMenuItem();
            staticImageSubtractionToolStripMenuItem = new ToolStripMenuItem();
            advancedEnhancementToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem2 = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem1 = new ToolStripMenuItem();
            boxBlurToolStripMenuItem1 = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            edgeEnhancementToolStripMenuItem = new ToolStripMenuItem();
            meanBlurToolStripMenuItem = new ToolStripMenuItem();
            sobelVerticalToolStripMenuItem = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, advancedEnhancementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, greyscalingToolStripMenuItem, inversionToolStripMenuItem, mIrrorHoriToolStripMenuItem, mirrorVertiToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, webCamSubtractionToolStripMenuItem, staticImageSubtractionToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(255, 26);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // greyscalingToolStripMenuItem
            // 
            greyscalingToolStripMenuItem.Name = "greyscalingToolStripMenuItem";
            greyscalingToolStripMenuItem.Size = new Size(255, 26);
            greyscalingToolStripMenuItem.Text = "Greyscaling";
            greyscalingToolStripMenuItem.Click += greyscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(255, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click_1;
            // 
            // mIrrorHoriToolStripMenuItem
            // 
            mIrrorHoriToolStripMenuItem.Name = "mIrrorHoriToolStripMenuItem";
            mIrrorHoriToolStripMenuItem.Size = new Size(255, 26);
            mIrrorHoriToolStripMenuItem.Text = "MIrror Hori";
            mIrrorHoriToolStripMenuItem.Click += mIrrorHoriToolStripMenuItem_Click;
            // 
            // mirrorVertiToolStripMenuItem
            // 
            mirrorVertiToolStripMenuItem.Name = "mirrorVertiToolStripMenuItem";
            mirrorVertiToolStripMenuItem.Size = new Size(255, 26);
            mirrorVertiToolStripMenuItem.Text = "Mirror Verti";
            mirrorVertiToolStripMenuItem.Click += mirrorVertiToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(255, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(255, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // webCamSubtractionToolStripMenuItem
            // 
            webCamSubtractionToolStripMenuItem.Name = "webCamSubtractionToolStripMenuItem";
            webCamSubtractionToolStripMenuItem.Size = new Size(255, 26);
            webCamSubtractionToolStripMenuItem.Text = "Web Cam Subtraction";
            webCamSubtractionToolStripMenuItem.Click += webCamSubtractionToolStripMenuItem_Click;
            // 
            // staticImageSubtractionToolStripMenuItem
            // 
            staticImageSubtractionToolStripMenuItem.Name = "staticImageSubtractionToolStripMenuItem";
            staticImageSubtractionToolStripMenuItem.Size = new Size(255, 26);
            staticImageSubtractionToolStripMenuItem.Text = "Static Image Subtraction";
            staticImageSubtractionToolStripMenuItem.Click += staticImageSubtractionToolStripMenuItem_Click;
            // 
            // advancedEnhancementToolStripMenuItem
            // 
            advancedEnhancementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sharpenToolStripMenuItem2, edgeDetectionToolStripMenuItem1, boxBlurToolStripMenuItem1, gaussianBlurToolStripMenuItem, embossToolStripMenuItem, edgeEnhancementToolStripMenuItem, meanBlurToolStripMenuItem, sobelVerticalToolStripMenuItem, laplacianToolStripMenuItem });
            advancedEnhancementToolStripMenuItem.Name = "advancedEnhancementToolStripMenuItem";
            advancedEnhancementToolStripMenuItem.Size = new Size(182, 24);
            advancedEnhancementToolStripMenuItem.Text = "Advanced Enhancement";
            // 
            // sharpenToolStripMenuItem2
            // 
            sharpenToolStripMenuItem2.Name = "sharpenToolStripMenuItem2";
            sharpenToolStripMenuItem2.Size = new Size(224, 26);
            sharpenToolStripMenuItem2.Text = "Sharpen";
            sharpenToolStripMenuItem2.Click += sharpenToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem1
            // 
            edgeDetectionToolStripMenuItem1.Name = "edgeDetectionToolStripMenuItem1";
            edgeDetectionToolStripMenuItem1.Size = new Size(224, 26);
            edgeDetectionToolStripMenuItem1.Text = "Edge Detection";
            edgeDetectionToolStripMenuItem1.Click += edgeDetectionToolStripMenuItem_Click;
            // 
            // boxBlurToolStripMenuItem1
            // 
            boxBlurToolStripMenuItem1.Name = "boxBlurToolStripMenuItem1";
            boxBlurToolStripMenuItem1.Size = new Size(224, 26);
            boxBlurToolStripMenuItem1.Text = "Box Blur";
            boxBlurToolStripMenuItem1.Click += boxBlurToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(224, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(224, 26);
            embossToolStripMenuItem.Text = "Emboss";
            embossToolStripMenuItem.Click += embossToolStripMenuItem_Click;
            // 
            // edgeEnhancementToolStripMenuItem
            // 
            edgeEnhancementToolStripMenuItem.Name = "edgeEnhancementToolStripMenuItem";
            edgeEnhancementToolStripMenuItem.Size = new Size(224, 26);
            edgeEnhancementToolStripMenuItem.Text = "Edge Enhancement";
            edgeEnhancementToolStripMenuItem.Click += edgeEnhancementToolStripMenuItem_Click;
            // 
            // meanBlurToolStripMenuItem
            // 
            meanBlurToolStripMenuItem.Name = "meanBlurToolStripMenuItem";
            meanBlurToolStripMenuItem.Size = new Size(224, 26);
            meanBlurToolStripMenuItem.Text = "Mean Blur";
            meanBlurToolStripMenuItem.Click += meanBlurToolStripMenuItem_Click;
            // 
            // sobelVerticalToolStripMenuItem
            // 
            sobelVerticalToolStripMenuItem.Name = "sobelVerticalToolStripMenuItem";
            sobelVerticalToolStripMenuItem.Size = new Size(224, 26);
            sobelVerticalToolStripMenuItem.Text = "Sobel Vertical";
            sobelVerticalToolStripMenuItem.Click += sobelVerticalToolStripMenuItem_Click;
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(224, 26);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(432, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(432, 31);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(210, 56);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(110, 31);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(216, 56);
            trackBar2.TabIndex = 4;
            trackBar2.Value = 50;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem mIrrorHoriToolStripMenuItem;
        private ToolStripMenuItem mirrorVertiToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem webCamSubtractionToolStripMenuItem;
        private ToolStripMenuItem staticImageSubtractionToolStripMenuItem;
        private ToolStripMenuItem advancedEnhancementToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem2;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem1;
        private ToolStripMenuItem boxBlurToolStripMenuItem1;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private ToolStripMenuItem edgeEnhancementToolStripMenuItem;
        private ToolStripMenuItem meanBlurToolStripMenuItem;
        private ToolStripMenuItem sobelVerticalToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
    }
}
