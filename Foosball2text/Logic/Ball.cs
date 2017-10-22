using System;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Logic
{
    public class Ball : TrackedObject, ICloneable, IEquatable<Ball>
    {
        //Inherited
        //public float x;
        //public float y;
        public CircleF Circle;

        public Ball(float x = 0, float y = 0) //Optional parameters don't force to assign new values
        {
            base.x = x;
            base.y = y;
        }

        public Ball(Image<Gray, byte> frame)
        {
            ProcessImage(frame);
        }

        private CircleF[] GetCirclesFromFrame(Image<Gray, byte> frame)           //NOTE: still only gets one circle
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

        private void ProcessImage(Image<Gray, byte> frame)
        {
            CircleF[] circleArray = GetCirclesFromFrame(frame);
            if (circleArray.Length != 0)
            {
                Circle = circleArray[circleArray.Length-1];
                x = Circle.Center.X;
                y = Circle.Center.Y;
            }

        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ForcedMove(float toX, float toY) //For testing and possible movement on frames where ball was undetected
        {
            CircleF newCircle = new CircleF(new PointF(toX, toY), Circle.Radius);
            Circle = newCircle;
            x = toX;
            y = toY;
        }

        public bool Equals(Ball other) //if it's on the same coordinates it's the same ball
        {
            if (other.x == x && other.y == y)
                return true;
            return false;
        }
    }

}
