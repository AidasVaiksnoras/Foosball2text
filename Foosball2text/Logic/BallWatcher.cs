using System;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Logic
{
    public enum FieldSide { Left, Middle, Right };
    public enum Teams { None, TeamOnLeft, TeamOnRight }

    public class Speed
    {
        public float xMoved;
        public float yMoved;
        public Stopwatch timeBetweenCalculations;

        public double SecondsBetweenCalculations => ((double)timeBetweenCalculations.ElapsedMilliseconds) / 1000;

        public Speed()
        {
            xMoved = 0;
            yMoved = 0;
            timeBetweenCalculations = new Stopwatch();
            timeBetweenCalculations.Start();
        }

        public float XPerMs => xMoved / timeBetweenCalculations.ElapsedMilliseconds;
        public float YPerMs => yMoved / timeBetweenCalculations.ElapsedMilliseconds;
        public double OmniSpeedPerSec => Math.Sqrt(xMoved * xMoved + yMoved * yMoved) / SecondsBetweenCalculations; //UNDONE //byTimePassed
    }

    struct PlayField
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

    public class BallWatcher : IBallWatcher
    {
        //Fields
        Ball _ball;                                 //Used for coordinates
        Ball _lastFrameBall = new Ball();           //Used for calculating speed and other changes between frames
        BallInformation _ballInformation = new BallInformation(); //X, Y, Speed, BallSide, TeamScored
        protected Speed _speed = new Speed();
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

            if (null != _ball && 0 != _ball.X && (_lastFrameBall.X != _ball.X || _lastFrameBall.Y != _ball.Y))  //If moved
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

        protected void UpdateBallInformation()
        {
            if (_ball.X < _playField.middleLine)
                _ballInformation.BallSide = FieldSide.Left;
            else
                _ballInformation.BallSide = FieldSide.Right;

            _ballInformation.X = _ball.X.ToString();
            _ballInformation.Y = _ball.Y.ToString();

            CalculateSpeed();
            _ballInformation.Speed = "X: " + _speed.xMoved.ToString() + ";   Y: " + _speed.yMoved.ToString();
            _ballInformation.OmniSpeed = _speed.OmniSpeedPerSec.ToString();
        }

        protected virtual void CalculateSpeed() //TODO test if it gets a speed that's too high on first frames
        {
            if (_lastFrameBall.X != 0)
                _speed.xMoved = _ball.X - _lastFrameBall.X;
            if (_lastFrameBall.Y != 0)
                _speed.yMoved = _ball.Y - _lastFrameBall.Y;

            _ballInformation.TimeBetweenBallCapture = _speed.SecondsBetweenCalculations.ToString();
            _speed.timeBetweenCalculations.Reset();
            _speed.timeBetweenCalculations.Start();
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