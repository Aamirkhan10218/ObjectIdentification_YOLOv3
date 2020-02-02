namespace ObjectIdentification_YOLOv3
{
    partial class Form1
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
            this.picSample = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            this.SuspendLayout();
            // 
            // picSample
            // 
            this.picSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.picSample.Location = new System.Drawing.Point(0, 0);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(538, 357);
            this.picSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSample.TabIndex = 0;
            this.picSample.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(0, 363);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(107, 53);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(144, 363);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(107, 53);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.picSample);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Identification";
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnDetect;
    }
}

