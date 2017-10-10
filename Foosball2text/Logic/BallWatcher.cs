﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foosball2text
{
    public enum FieldSide { Left, Middle, Right };
    public enum Teams { None, TeamA, TeamB }

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
        public float leftSideLine;
        public float rightSideLine;

        public PlayField(float xSize, float ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;

            float quater = xSize / 4;
            leftSideLine = quater;
            rightSideLine = quater * 3;
        }
    }

    public class BallWatcher
    {
        Ball _ball;                         //Used for coordinates
        Ball _lastFrameBall = new Ball();   //Used for calculating speed and other changes between frames
        Speed _speed;
        PlayField _playField;
        FieldSide ballOnSide = FieldSide.Middle;

        internal Speed Speed { get => _speed; }
        public FieldSide BallOnSide { get => ballOnSide; }
        public int PositionHasntChangedCount { get; private set; }

        public BallWatcher(ref Ball ball, float fieldWidth, float fieldHeight) // <--- Ball is passed by reference
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
                PositionHasntChangedCount = 0;
            }
            else
                PositionHasntChangedCount++;
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

        public string GetXYSpeedString()
        {
            return "X: " + _speed.x.ToString() + ";    Y: " + _speed.y.ToString();
        }

        public Teams checkWhichTeamScored()
        {
            if (PositionHasntChangedCount == 30) //== 1 sec
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