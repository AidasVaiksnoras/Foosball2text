using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.IO;

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

            // Detect and Draw circle
            Image<Bgr, Byte> circleImage = resizedImage.CopyBlank();
            foreach (CircleF circle in GetCirclesFromFrame(filteredImage))
            {
                circleImage.Draw(circle, new Bgr(Color.Green), 7);
                UpdateCordinates(circle);
            }
            imageBox1.Image = circleImage;
        }

        private CircleF[] GetCirclesFromFrame (Image<Gray, byte> frame)
        {
            Gray cannyThreshold = new Gray(12);
            Gray circleAccumulatorThreshold = new Gray(26);
            double resolution = 1.90;
            double minDistance = 1.0;
            int minRadius = 0;
            int maxRadius = 10;

            return frame.HoughCircles(cannyThreshold, circleAccumulatorThreshold, resolution,
                                      minDistance, minRadius, maxRadius)[0];
        }

        private void UpdateCordinates(CircleF circle)
        {
            _xlabel.Text = circle.Center.X.ToString();
            _ylabel.Text = circle.Center.Y.ToString();
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

        private void browseButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the browse window
            if (result == DialogResult.OK) //If opened a file
            {
                string fileName = openFileDialog1.FileName;
                try //to assign new _capture
                {
                    _capture = new VideoCapture(fileName);
                }
                catch (IOException)
                {
                }
            }
        }

    }
}

