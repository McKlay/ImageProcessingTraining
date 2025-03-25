namespace ImageProcessingTraining
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxA = new PictureBox();
            pictureBoxB = new PictureBox();
            pictureBoxResult = new PictureBox();
            btnLoadImageA = new Button();
            btnLoadImageB = new Button();
            btnSubtract = new Button();
            openFileDialogA = new OpenFileDialog();
            openFileDialogB = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxA
            // 
            pictureBoxA.Location = new Point(114, 58);
            pictureBoxA.Name = "pictureBoxA";
            pictureBoxA.Size = new Size(186, 130);
            pictureBoxA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxA.TabIndex = 0;
            pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            pictureBoxB.Location = new Point(488, 58);
            pictureBoxB.Name = "pictureBoxB";
            pictureBoxB.Size = new Size(194, 130);
            pictureBoxB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxB.TabIndex = 1;
            pictureBoxB.TabStop = false;
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.Location = new Point(258, 262);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(216, 118);
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.TabIndex = 2;
            pictureBoxResult.TabStop = false;
            // 
            // btnLoadImageA
            // 
            btnLoadImageA.Location = new Point(130, 211);
            btnLoadImageA.Name = "btnLoadImageA";
            btnLoadImageA.Size = new Size(148, 29);
            btnLoadImageA.TabIndex = 3;
            btnLoadImageA.Text = "Load Image";
            btnLoadImageA.UseVisualStyleBackColor = true;
            btnLoadImageA.Click += btnLoadImageA_Click;
            // 
            // btnLoadImageB
            // 
            btnLoadImageB.Location = new Point(504, 211);
            btnLoadImageB.Name = "btnLoadImageB";
            btnLoadImageB.Size = new Size(158, 29);
            btnLoadImageB.TabIndex = 4;
            btnLoadImageB.Text = "Load Background";
            btnLoadImageB.UseVisualStyleBackColor = true;
            btnLoadImageB.Click += btnLoadImageB_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(323, 386);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(94, 29);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // openFileDialogA
            // 
            openFileDialogA.FileName = "openFileDialog1";
            // 
            // openFileDialogB
            // 
            openFileDialogB.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubtract);
            Controls.Add(btnLoadImageB);
            Controls.Add(btnLoadImageA);
            Controls.Add(pictureBoxResult);
            Controls.Add(pictureBoxB);
            Controls.Add(pictureBoxA);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxA;
        private PictureBox pictureBoxB;
        private PictureBox pictureBoxResult;
        private Button btnLoadImageA;
        private Button btnLoadImageB;
        private Button btnSubtract;
        private OpenFileDialog openFileDialogA;
        private OpenFileDialog openFileDialogB;
    }
}