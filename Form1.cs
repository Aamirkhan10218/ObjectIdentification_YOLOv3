using Alturos.Yolo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectIdentification_YOLOv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.Filter = "Image Files|*.jpg;*.png";
                    picSample.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        ConfigurationDetector detector = new ConfigurationDetector();
        MemoryStream stream = new MemoryStream();
        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (picSample.Image!=null)
            {
                var configuration = detector.Detect();
                var yol = new YoloWrapper(configuration);
                picSample.Image.Save(stream, ImageFormat.Jpeg);
                var extractedItems = yol.Detect(stream.ToArray()).ToList(); 
            }
        }
    }
}
