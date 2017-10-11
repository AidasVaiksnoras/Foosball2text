using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Logic
{
    public class FrameHandler
    {
        private int _hueMin = 0;
        private int _saturationMin = 100;
        private int _brightnessMin = 70;
        private int _hueMax = 0;
        private int _saturationMax = 255;
        private int _brightnessMax = 255;
        private BallWatcher _ballWatcher;

        public FrameHandler()
        {
        }

        public FrameHandler(int pictureBoxWidth, int pictureBoxHeight)
        {
            _ballWatcher = new BallWatcher(pictureBoxWidth, pictureBoxHeight);
        }
        
        public Image GetResizedImage(Mat frame, int width, int height)
        {
            Image<Bgr, byte> resizedImage = frame.ToImage<Bgr, byte>().Resize(width, height, Inter.Linear);
            Image<Gray, byte> filteredImage = FilterImage(resizedImage);
            _ballWatcher.UpdateBallWatcher(filteredImage);
            if (null != _ballWatcher.Ball)
                resizedImage.Draw(_ballWatcher.Ball.Circle, new Bgr(Color.Red), 2);
            return resizedImage.ToBitmap();
        }

        public BallInformation GetBallInformation()
        {
            return _ballWatcher.BallInformation;
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
