using System;
using System.Diagnostics;
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

        public double OmniSpeed => Math.Sqrt(x * x + y * y);
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
        //Fields
        Ball _ball;                                 //Used for coordinates
        Ball _lastFrameBall = new Ball();           //Used for calculating speed and other changes between frames
        BallInformation _ballInformation = new BallInformation(); //X, Y, Speed, BallSide, TeamScored
        Speed _speed;
        double _maxSpeed = 0;
        PlayField _playField;

        //Scoring related
        Stopwatch _positionHasntChangedTime = new Stopwatch();
        bool _scoredOnLostPositionTime;

        //Getters
        public Ball Ball { get => _ball; }
        public BallInformation BallInformation { get => _ballInformation; }

        public BallWatcher(float fieldWidth, float fieldHeight)
        {
            _playField = new PlayField(fieldWidth, fieldHeight);
        }

        public void UpdateBallWatcher(Image<Gray, byte> image)
        {
            if (null != _ball)
                _lastFrameBall = _ball.Clone() as Ball;

            _ball = new Ball(image);

            //TODO try to remove "0 != _ball.X"
            if (null != _ball && (_lastFrameBall.X != _ball.X || _lastFrameBall.Y != _ball.Y))  //If moved
            {
                _scoredOnLostPositionTime = false; //bool reset
                _positionHasntChangedTime.Reset();
                UpdateBallInformation();
            }
            else                                                                                                //If it didn't move
            {
                _positionHasntChangedTime.Start(); //If already started - does nothing

                if (_positionHasntChangedTime.ElapsedMilliseconds > 1500 && !_scoredOnLostPositionTime) //1.5 sec
                {
                    _ballInformation.TeamScored = CheckWhichTeamScored();
                    _scoredOnLostPositionTime = true;
                }
                else _ballInformation.TeamScored = Teams.None;
            }
        }

        private void UpdateBallInformation()
        {
            if (_ball.X < _playField.middleLine)
                _ballInformation.BallSide = FieldSide.Left;
            else
                _ballInformation.BallSide = FieldSide.Right;

            _ballInformation.X = _ball.X.ToString();
            _ballInformation.Y = _ball.Y.ToString();

            UpdateSpeed();
            _ballInformation.Speed = "X: " + _speed.x.ToString() + ";   Y: " + _speed.y.ToString();
            _ballInformation.OmniSpeed = _speed.OmniSpeed.ToString();
        }

        private void UpdateSpeed()
        {
            if (_lastFrameBall.X != 0)
                _speed.x = _ball.X - _lastFrameBall.X;
            if (_lastFrameBall.X != 0)
                _speed.y = _ball.Y - _lastFrameBall.Y;

            UpdateMaxSpeed();
        }

        private void UpdateMaxSpeed()
        {
            if (_speed.OmniSpeed > _maxSpeed)
                _maxSpeed = _speed.OmniSpeed;
        }

        public Teams CheckWhichTeamScored()
        {
            if (_ballInformation.BallSide == FieldSide.Left )
                return Teams.TeamOnLeft;
            else if (_ballInformation.BallSide == FieldSide.Right)
                return Teams.TeamOnRight;

            return Teams.None;
        }
    }
}