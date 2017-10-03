using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foosball2text
{
    enum FieldSide { Left, Middle, Right };
    public enum Teams { None, TeamA, TeamB }

    class Speed
    {
        public float x;
        public float y;

        public Speed()
        {
            x = 0;
            y = 0;
        }
    }

    class PlayField
    {
        public float xSize;
        public float ySize;
        public float leftSideLine;
        public float rightSideLine;

        public PlayField(float xSize, float ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            float oneThird = xSize / 3;
            leftSideLine = oneThird;
            rightSideLine = oneThird * 2;
        }
    }

    class BallWatcher
    {
        Ball _ball;                         //Used for coordinates
        Ball _lastFrameBall = new Ball();   //Used for calculating speed and other changes between frames
        Speed _speed = new Speed();
        public FieldSide ballOnSide = FieldSide.Middle;
        int positionHasntChangedFrameCount;
        PlayField _playField;

        public BallWatcher(ref Ball ball, float fieldHeight, float fieldWidth) // <--- Ball is passed by reference
        {
            _ball = ball;
            _lastFrameBall = _ball.Clone() as Ball;
            _playField = new PlayField(fieldWidth, fieldHeight);
        }

        public void UpdateBallWatcher()
        {
            if (_lastFrameBall.X != _ball.X || _lastFrameBall.Y != _ball.Y)
            {
                UpdateballOnSide();
                UpdateSpeed();
                _lastFrameBall = _ball.Clone() as Ball;
                positionHasntChangedFrameCount = 0;
            }
            else
                positionHasntChangedFrameCount++;
        }

        private void UpdateballOnSide()
        {
            if (_ball.X < _playField.leftSideLine)
                ballOnSide = FieldSide.Left;
            else if (_ball.X < _playField.rightSideLine)
                ballOnSide = FieldSide.Middle;
            else ballOnSide = FieldSide.Right;
        }

        public string GetBallOnSideString()
        {
            return Enum.GetName(typeof(FieldSide), ballOnSide);
        }

        private void UpdateSpeed()
        {
            _speed.x = _ball.X - _lastFrameBall.X;
            _speed.y = _ball.Y - _lastFrameBall.Y;
        }

        public string GetSpeedString()
        {
            return "X: " + _speed.x.ToString() + ";    Y: " + _speed.y.ToString();
        }

        public Teams checkWhichTeamScored()
        {
            if (positionHasntChangedFrameCount == 30) //== 1 sec
            {
                if (ballOnSide == FieldSide.Left && _speed.x < 0)
                    return Teams.TeamA;
                else if (ballOnSide == FieldSide.Right && _speed.x > 0)
                    return Teams.TeamB;
            }

            return Teams.None;
        }
    }
}