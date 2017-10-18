using System;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Logic
{
    public class Ball : ICloneable, IEquatable<Ball>
    {
        private float _x;
        private float _y;
        public CircleF Circle { get; set; }
        public float X { get => _x ; set => _x = value; }
        public float Y { get => _y; set => _y = value; }

        public Ball(float x = 0, float y = 0) //Optional parameters don't force to assign new values
        {
            _x = x;
            _y = y;
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
                X = Circle.Center.X;
                Y = Circle.Center.Y;
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
            X = toX;
            Y = toY;
        }

        public bool Equals(Ball other) //if it's on the same coordinates it's the same ball
        {
            if (other.X == _x && other.Y == _y)
                return true;
            return false;
        }
    }

}
