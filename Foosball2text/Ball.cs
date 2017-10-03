using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    

    public class Ball : ICloneable
    {
        public float x { get; set; }
        public float y { get; set; }
        public CircleF _circle { get; set; }
        
        public Ball()
        {
        }

        public Ball(float x, float y, CircleF circle)
        {
            this.x = x;
            this.y = y;
            _circle = circle;
        }

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
                _circle = circleArray[circleArray.Length-1];
                x = _circle.Center.X;
                y = _circle.Center.Y;
            }
            return Circle;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
