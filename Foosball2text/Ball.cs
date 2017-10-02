using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    

    public class Ball
    {
        private float _x;
        private float _y;
        private CircleF _circle;
        public Ball()
        {
        }

        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public CircleF Circle { get => _circle; set => _circle = value; }

        public CircleF[] GetCirclesFromFrame(Image<Gray, byte> frame)
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

        public CircleF GetCircle(Image<Gray, byte> frame)
        {
            CircleF[] circleArray = GetCirclesFromFrame(frame);
            if (circleArray.Length != 0)
            {
                Circle = circleArray[circleArray.Length - 1];
                X = Circle.Center.X;
                Y = Circle.Center.Y;
            }
            return Circle;
        }
    }

}
