using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Foosball2text
{
    public partial class Form1 : Form
    {
        Timer _timer;
        private const int Fps = 30;
        VideoCapture _capture;

        public Form1()
        {
            InitializeComponent();

            _timer = new Timer();
            //Frame Rate
            _timer.Interval = 1000 / Fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _capture = new VideoCapture("../../sample.avi");
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Mat m = _capture.QueryFrame();
            if (m == null) return;
            Image<Bgr, byte> resizedImage = m.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear);
            pictureBox1.Image = resizedImage.Bitmap;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
