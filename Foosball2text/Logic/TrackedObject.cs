using System;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Logic
{
    public class TrackedObject : IEquatable<TrackedObject>
    {
        public float x;
        public float y;
        private object _shape;

        public object Shape { get => _shape; set => _shape = value; }

        public bool Equals(TrackedObject other)
        {
            return (other.Shape.Equals(_shape) && other.x == x && other.y == y);
        }
    }
}
