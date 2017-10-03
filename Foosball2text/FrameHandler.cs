using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    class FrameHandler
    {
        private int _hueMin = 0;
        private int _saturationMin = 100;
        private int _brightnessMin = 70;
        private int _hueMax = 0;
        private int _saturationMax = 255;
        private int _brightnessMax = 255;
        private Image<Bgr, byte> _grayscaleImage;
        public Ball _ball;
        //TODO I will make this back to private in the future when I decide where to implement my BallWatcher (goal check) class
        //ATM this is public because I pass a reference, and the Form1 rework deleted the _ball field
        //public Ball Ball {get => _ball;}

        public BallWatcher ballWatcher;

        public FrameHandler()
        {
            _ball = new Ball();
        }

        public FrameHandler(int pictureBoxWidth, int pictureBoxHeight)
        {
            _ball = new Ball();
            ballWatcher = new BallWatcher(ref _ball, pictureBoxWidth, pictureBoxHeight);
        }

        public string X {get => _ball.X.ToString();}
        public string Y {get => _ball.Y.ToString();}
        
        public Image GetResizedImage(Mat frame, int width, int height)
        {
            return frame.ToImage<Bgr, byte>().Resize(width, height, Inter.Linear).ToBitmap();
        }

        public Image<Bgr, byte> GetFilteredImage(Mat frame, int width, int height)
        {
            Image<Bgr, byte> resizedImage = frame.ToImage<Bgr, byte>().Resize(width, height, Inter.Linear);
            Image<Gray, byte> filteredImage = FilterImage(resizedImage);
            _grayscaleImage = resizedImage.CopyBlank();
            if (null != _ball)
                _grayscaleImage.Draw(_ball.GetCircle(filteredImage), new Bgr(Color.Green), 7);
            return _grayscaleImage;
        }


        public Image<Gray, byte> FilterImage(Image<Bgr, byte> frame)
        {
            Image<Gray, byte> filteredImage = GetFilteredImage(frame.Convert<Hsv, byte>(),
                                                             _hueMin, _saturationMin, _brightnessMin, _hueMax, _saturationMax, _brightnessMax);
            for (int i=0; i<5; i++)
            {
                ErodeFrame(filteredImage, 5);
                DilateFrame(filteredImage, 6);
            }
            return filteredImage;
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

        public void UpdateHue(int hue)
        {
            _hueMin = hue-10;
            _hueMax = hue+10;
        }

    }
}
