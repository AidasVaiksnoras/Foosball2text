using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Logic
{
    public enum FieldSide { Left, Middle, Right };
    public enum Teams { None, TeamOnLeft, TeamOnRight }

    struct Speed
    {
        public float x;
        public float y;

        public double OneDirectionalSpeed => Math.Sqrt(x * x + y * y);
    }

    class PlayField
    {
        public float xSize;
        public float ySize;
        public float middleLine;

        public PlayField(float xSize, float ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            middleLine = xSize / 2;
        }
    }

    public class BallWatcher
    {
        Ball _ball;                                 //Used for coordinates
        private Ball _lastFrameBall = new Ball();   //Used for calculating speed and other changes between frames
        private BallInformation _ballInformation = new BallInformation();
        public BallInformation BallInformation { get => _ballInformation; set => _ballInformation = value; }
        Speed _speed;
        PlayField _playField;
        FieldSide ballOnSide = FieldSide.Middle;
        public Ball Ball { get =>_ball; }
        internal Speed Speed { get => _speed; }
        public FieldSide BallOnSide { get => ballOnSide; }
        public int PositionHasntChangedCount { get; private set; }

        public BallWatcher(float fieldWidth, float fieldHeight)
        {
            _playField = new PlayField(fieldWidth, fieldHeight);
        }

        public void UpdateBallWatcher(Image<Gray, byte> image)
        {
            if (null != _ball)
                _lastFrameBall = _ball.Clone() as Ball;

            _ball = new Ball(image);

            if (null != _ball && 0 != _ball.X && (_lastFrameBall.X != _ball.X || _lastFrameBall.Y != _ball.Y))
            {
                UpdateBallInformation();
                PositionHasntChangedCount = 0;
            }
            else
            {
                PositionHasntChangedCount++;
                _ballInformation.TeamScored = Teams.None;
            }
        }

        private void UpdateBallInformation()
        {
            if (_ball.X < _playField.middleLine)
                _ballInformation.BallSide =  FieldSide.Left;
            else
                _ballInformation.BallSide = FieldSide.Right;
            _ballInformation.X = _ball.X.ToString();
            _ballInformation.Y = _ball.Y.ToString();
            UpdateSpeed();
            _ballInformation.Speed = "X: " + _speed.x.ToString() + ";    Y: " + _speed.y.ToString();
            _ballInformation.TeamScored = CheckWhichTeamScored();
        }

        private void UpdateSpeed()
        {
            if (_lastFrameBall.X != 0)
                _speed.x = _ball.X - _lastFrameBall.X;
            if (_lastFrameBall.X != 0)
                _speed.y = _ball.Y - _lastFrameBall.Y;
        }

        public Teams CheckWhichTeamScored()
        {
            if (PositionHasntChangedCount > 40) //== 1,5 sec
            {
                PositionHasntChangedCount = 0;
                if (_ballInformation.BallSide == FieldSide.Left )
                    return Teams.TeamOnRight;
                else if (_ballInformation.BallSide == FieldSide.Right)
                    return Teams.TeamOnLeft;
            }

            return Teams.None;
        }
    }
}