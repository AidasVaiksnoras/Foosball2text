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
        public float x { get; set; }    //public read-only
        public float y { get; set; }    //public read-only

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
        Speed speed = new Speed();
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
            if (_lastFrameBall.x != _ball.x || _lastFrameBall.y != _ball.y)
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
            if (_ball.x < _playField.leftSideLine)
                ballOnSide = FieldSide.Left;
            else if (_ball.x < _playField.rightSideLine)
                ballOnSide = FieldSide.Middle;
            else ballOnSide = FieldSide.Right;
        }

        public string GetBallOnSideString()
        {
            return Enum.GetName(typeof(FieldSide), ballOnSide);
        }

        private void UpdateSpeed()
        {
            speed.x = _ball.x - _lastFrameBall.x;
            speed.y = _ball.y - _lastFrameBall.y;
        }

        public string GetSpeedString()
        {
            return "X: " + speed.x.ToString() + ";    Y: " + speed.y.ToString();
        }

        public Teams checkWhichTeamScored()
        {
            if (positionHasntChangedFrameCount == 30) //== 1 sec
            {
                if (ballOnSide == FieldSide.Left && speed.x < 0)
                    return Teams.TeamA;
                else if (ballOnSide == FieldSide.Right && speed.x > 0)
                    return Teams.TeamB;
            }

            return Teams.None;
        }
    }
}