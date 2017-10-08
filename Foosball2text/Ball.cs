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
        public float X { get; set; }
        public float Y { get; set; }
        public CircleF Circle { get; set; }
        
        public Ball()
        {
        }

        public Ball(float x, float y, CircleF circle)
        {
            X = x;
            Y = y;
            Circle = circle;
        }

        public CircleF[] GetCirclesFromFrame(Image<Gray, byte> frame)           //NOTE: still only gets one circle (look: line 40)
        {
            Gray cannyThreshold = new Gray(12);
            Gray circleAccumulatorThreshold = new Gray(26);
            double resolution = 1.90;
            double minDistance = 1.0;
            int minRadius = 0;
            int maxRadius = 10;

            return frame.HoughCircles(cannyThreshold, circleAccumulatorThreshold, resolution,
                                      minDistance, minRadius, maxRadius)[0];    //<-------- one circle
        }

        public CircleF GetCircle(Image<Gray, byte> frame)
        {
            CircleF[] circleArray = GetCirclesFromFrame(frame);
            if (circleArray.Length != 0)
            {
                Circle = circleArray[circleArray.Length-1];
                X = Circle.Center.X;
                Y = Circle.Center.Y;
            }
            return Circle;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ForcedMove(float toX, float toY) //For testing and possible movement on frames where ball was undetected
        {
            CircleF newCircle = new CircleF(new PointF(toX, toY), Circle.Radius);
            Circle = newCircle;
            X = toX;
            Y = toY;
        }
    }

}
