namespace ImageProcessingTraining
{
    partial class Form2
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
            pictureBoxCamera = new PictureBox();
            pictureBoxOutput = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            btnLoadBg = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Location = new Point(12, 116);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(314, 226);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            pictureBoxOutput.Location = new Point(442, 116);
            pictureBoxOutput.Name = "pictureBoxOutput";
            pictureBoxOutput.Size = new Size(346, 226);
            pictureBoxOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOutput.TabIndex = 1;
            pictureBoxOutput.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(96, 370);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(558, 370);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnLoadBg
            // 
            btnLoadBg.Location = new Point(308, 373);
            btnLoadBg.Name = "btnLoadBg";
            btnLoadBg.Size = new Size(135, 29);
            btnLoadBg.TabIndex = 4;
            btnLoadBg.Text = "Load Background";
            btnLoadBg.UseVisualStyleBackColor = true;
            btnLoadBg.Click += btnLoadBg_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(318, 405);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "status";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnLoadBg);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pictureBoxOutput);
            Controls.Add(pictureBoxCamera);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCamera;
        private PictureBox pictureBoxOutput;
        private Button btnStart;
        private Button btnStop;
        private Button btnLoadBg;
        private Label lblStatus;
    }
}