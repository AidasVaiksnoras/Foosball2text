using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    class Filter
    {
        private int _hueMin = 0;
        private int _saturationMin = 100;
        private int _brightnessMin = 70;
        private int _hueMax = 35;
        private int _saturationMax = 255;
        private int _brightnessMax = 255;


        public Filter()
        {
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

        public void UpdateValuesHSV(int a, int b, int c)
        {
        _hueMin = a-10;
        _saturationMin = 100;
        _brightnessMin = 70;
        _hueMax = a+10;
        _saturationMax = 255;
        _brightnessMax = 255;
    }
    }
}
