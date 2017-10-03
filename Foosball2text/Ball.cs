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
        private float x;
        private float y;
        private CircleF _circle;
        public Ball()
        {
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public CircleF Circle { get => _circle; set => _circle = value; }

        private CircleF[] GetCirclesFromFrame(Image<Gray, byte> frame)
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

        public void FindCordinates(Image<Gray, byte> frame)
        {
            CircleF[] circleArray = GetCirclesFromFrame(frame);
            if (circleArray.Length != 0)
            {
                Circle = circleArray[circleArray.Length-1];
                X = _circle.Center.X;
                Y = _circle.Center.Y;
            }
        }
    }

}
