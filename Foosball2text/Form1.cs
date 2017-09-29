using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    public partial class Form1 : Form
    {
        Timer _timer;
        private const int Fps = 30;
        VideoCapture _capture;
        private Ball _ball;

        public Form1()
        {
            InitializeComponent();
            _ball = new Ball();
            _timer = new Timer();
            //Frame Rate
            _timer.Interval = 1000 / Fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _capture = new VideoCapture("../../sample.avi");
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // Capture frame
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;

            // Resize Image to size of pictureBox
            Image<Bgr, byte> resizedImage =
                frame.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear);
            pictureBox1.Image = resizedImage.Bitmap;

            // Filter image by given parameters
            Image<Gray, byte> filteredImage = GetFilteredImage(resizedImage.Convert<Hsv, byte>(),
                                                              0, 100, 70, 35, 255, 255);

            // Erode and Dilate snow from grayscale image
            ErodeFrame(filteredImage, 5);
            DilateFrame(filteredImage, 6);

            
            Image<Bgr, Byte> circleImage = resizedImage.CopyBlank();
            //Find the coordinates of the ball in the filtered image
            _ball.FindCordinates(filteredImage);

            //Diplay ball's coordinates
            UpdateCordinates();

            imageBox1.Image = filteredImage;
        }

        private void UpdateCordinates()
        {
            _xlabel.Text = _ball.X.ToString();
            _ylabel.Text = _ball.Y.ToString();
        }

        private void ErodeFrame(Image<Gray, byte> frame, int pointSize)
        {
            var erodeElement = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(pointSize, pointSize), new Point(-1, -1));
            CvInvoke.Erode(frame, frame, erodeElement, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
        }

        private void DilateFrame(Image<Gray, byte> frame, int pointSize)
        {
            var dilateElement = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(pointSize, pointSize), new Point(-1, -1));
            CvInvoke.Dilate(frame, frame, dilateElement, new Point(-1, -1), 1, BorderType.Reflect, default(MCvScalar));
        }

        private Image<Gray, byte> GetFilteredImage(Image<Hsv, byte> image, int lowerHue, int lowerSaturation, 
                                        int lowerValue, int higherHue, int higherSaturation, int higherValue)
        {

            return image.InRange(new Hsv(lowerHue, lowerSaturation, lowerValue), 
                                 new Hsv(higherHue, higherSaturation, higherValue));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

