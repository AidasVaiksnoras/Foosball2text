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
        public double xMoved;
        public double yMoved;
        public Stopwatch timeBetweenCalculations;
        public double msBetweenCalculations; //Save value on every StopWatch.Stop() to use for speed calculations

        public Speed()
        {
            xMoved = 0;
            yMoved = 0;
            timeBetweenCalculations = new Stopwatch();
            timeBetweenCalculations.Start();
        }

        public double SecondsBetweenCalculations => msBetweenCalculations / 1000.0;
        public double XPerMs => xMoved / msBetweenCalculations;
        public double YPerMs => yMoved / msBetweenCalculations;
        public double OmniSpeed_ms => Math.Sqrt(xMoved * xMoved + yMoved * yMoved) / msBetweenCalculations;
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
        protected WatcherInformation _watcherInformation = new WatcherInformation(); //X, Y, Speed, BallSide, TeamScored etc.
        protected Speed _speed = new Speed();
        protected Teams _movingTowardsGoal = Teams.None;
        PlayField _playField;
        //Scoring related
        Stopwatch _positionHasntChangedTime = new Stopwatch();
        bool _scoredOnLostPositionTime;

        //Getters
        public Ball Ball { get => _ball; }
        public WatcherInformation WatcherInformation { get => _watcherInformation; }

        public BallWatcher()
        {
            _watcherInformation.BallSide = FieldSide.Middle; //Prevents goals until ball is found
        }

        public BallWatcher(float fieldWidth, float fieldHeight) : this()
        {
            _playField = new PlayField(fieldWidth, fieldHeight);
        }

        public void UpdateBallWatcher(Image<Gray, byte> image)
        {
            if (null != _ball)
                _lastFrameBall = _ball.Clone() as Ball;

            _ball = new Ball(image);

            //I removed this and it changed nothing so until further notice it's commented
            if (/*null != _ball &&*/ 0 != _ball.X && (_lastFrameBall.X != _ball.X || _lastFrameBall.Y != _ball.Y))  //If detected moving
            {
                _scoredOnLostPositionTime = false; //bool reset allows to score again
                _positionHasntChangedTime.Reset();
                UpdateBallInformation();
            }
            else                                                                                                    //If it didn't move
            {
                _positionHasntChangedTime.Start(); //If already started - does nothing

                if (_positionHasntChangedTime.ElapsedMilliseconds > 1500 && !_scoredOnLostPositionTime) //1.5 sec
                {
                    _watcherInformation.TeamScored = CheckWhichTeamScored();
                    _scoredOnLostPositionTime = true;
                }
                else _watcherInformation.TeamScored = Teams.None;
            }
        }

        protected void UpdateBallInformation()
        {
            if (_ball.X < _playField.middleLine)
                _watcherInformation.BallSide = FieldSide.Left;
            else
                _watcherInformation.BallSide = FieldSide.Right;

            _watcherInformation.X = _ball.X.ToString();
            _watcherInformation.Y = _ball.Y.ToString();

            CalculateSpeed();
            _watcherInformation.Speed = "per ms: X:" + _speed.XPerMs.ToString("F5") + "   Y:" + _speed.YPerMs.ToString("F5");
            _watcherInformation.OmniSpeed = _speed.OmniSpeed_ms.ToString("F5");

            if (_speed.xMoved > 0.0)
                _movingTowardsGoal = Teams.TeamOnRight;
            else if (_speed.xMoved < 0.0)
                _movingTowardsGoal = Teams.TeamOnLeft;
            else
                _movingTowardsGoal = Teams.None;

        }

        protected virtual void CalculateSpeed()
        {
            _speed.timeBetweenCalculations.Stop();
            _speed.msBetweenCalculations = _speed.timeBetweenCalculations.ElapsedMilliseconds;

            //ifs removed as I did not find that they do anything
            //if (_lastFrameBall.X != 0)
                _speed.xMoved = _ball.X - _lastFrameBall.X;
            //if (_lastFrameBall.Y != 0)
                _speed.yMoved = _ball.Y - _lastFrameBall.Y;

            _watcherInformation.SecondsBetweenBallCapture = _speed.SecondsBetweenCalculations.ToString();

            _speed.timeBetweenCalculations.Reset();
            _speed.timeBetweenCalculations.Start();
        }

        public Teams CheckWhichTeamScored()
        {
            if (_watcherInformation.BallSide == FieldSide.Left )
                return Teams.TeamOnLeft;
            else if (_watcherInformation.BallSide == FieldSide.Right)
                return Teams.TeamOnRight;

            return Teams.None;
        }
    }
}