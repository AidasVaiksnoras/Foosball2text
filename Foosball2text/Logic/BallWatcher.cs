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
        protected WatcherInformation watcherInformation = new WatcherInformation(); //X, Y, Speed, BallSide, TeamScored etc.
        protected Speed speed = new Speed();
        protected Teams movingTowardsGoal = Teams.None;
        PlayField _playField;
        //-Scoring related
        protected Teams teamScored = Teams.None;
        Stopwatch _positionHasntChangedTime = new Stopwatch();
        bool _scoredOnLostPositionTime;
        private User _leftUser;
        private User _rightUser;
        //Getters
        public Ball Ball { get => _ball; }
        public WatcherInformation WatcherInformation { get => watcherInformation; }

        public BallWatcher()
        {
            watcherInformation.BallSide = FieldSide.Middle; //Prevents goals until ball is found
        }

        public BallWatcher(float fieldWidth, float fieldHeight, User leftUser, User rightUser) : this()
        {
            _leftUser = leftUser;
            _rightUser = rightUser;
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
                    teamScored = CheckWhichTeamScored();
                    _scoredOnLostPositionTime = true;
                }
                else teamScored = Teams.None;
            }
        }

        protected void UpdateBallInformation()
        {
            if (_ball.X < _playField.middleLine)
                watcherInformation.BallSide = FieldSide.Left;
            else
                watcherInformation.BallSide = FieldSide.Right;

            watcherInformation.X = _ball.X;
            watcherInformation.Y = _ball.Y;

            CalculateSpeed();
            watcherInformation.XSpeed = speed.XPerMs;
            watcherInformation.YSpeed = speed.YPerMs;
            watcherInformation.OmniSpeed = speed.OmniSpeed_ms;

            if (speed.xMoved > 0.0)
                movingTowardsGoal = Teams.TeamOnRight;
            else if (speed.xMoved < 0.0)
                movingTowardsGoal = Teams.TeamOnLeft;
            else
                movingTowardsGoal = Teams.None;
        }

        protected virtual void CalculateSpeed()
        {
            speed.timeBetweenCalculations.Stop();
            speed.msBetweenCalculations = speed.timeBetweenCalculations.ElapsedMilliseconds;

            //ifs removed as I did not find that they do anything
            //if (_lastFrameBall.X != 0)
                speed.xMoved = _ball.X - _lastFrameBall.X;
            //if (_lastFrameBall.Y != 0)
                speed.yMoved = _ball.Y - _lastFrameBall.Y;

            watcherInformation.SecondsBetweenBallCapture = speed.SecondsBetweenCalculations;

            speed.timeBetweenCalculations.Reset();
            speed.timeBetweenCalculations.Start();
        }

        public Teams CheckWhichTeamScored()
        {

            // !!! Following code is a compromise of merge conflicts !!! 
            if (watcherInformation.BallSide == FieldSide.Left)
            {
                _rightUser.TotalScore++;
                return Teams.TeamOnRight;
            }

            else if (watcherInformation.BallSide == FieldSide.Right)
            {
                _leftUser.TotalScore++;
                return Teams.TeamOnLeft;
            }
            return Teams.None;
        }
    }
}