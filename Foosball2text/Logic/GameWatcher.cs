using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class GameWatcher : BallWatcher
    {
        int _teamOnLeftGoals = 0, _teamOnRightGoals = 0;
        double _teamOnLeftMaxSpeed = 0, _teamOnRightMaxSpeed = 0;
        double _maxSpeedPerMs = 0;

        public double MaxSpeedPerMs { get; }

        public GameWatcher(float fieldWidth, float fieldHeight) : base(fieldWidth, fieldHeight)
        {
        }

        public void UpdateGameWatcher(Image <Gray, byte> image)
        {
            base.UpdateBallWatcher(image);
            List<String> newLogs = new List<string>();
            LoggerMessageDelivery messageTemplates = new LoggerMessageDelivery();
            if (_teamScored == Teams.TeamOnLeft)
            {
                _teamOnLeftGoals++;
                newLogs.Add(messageTemplates.goalLeft);
            }
            else if (_teamScored == Teams.TeamOnRight)
            {
                _teamOnRightGoals++;
                newLogs.Add(messageTemplates.goalRight);
            }

            _watcherInformation.TeamOnLeftGoals = _teamOnLeftGoals.ToString();
            _watcherInformation.TeamOnRightGoals = _teamOnRightGoals.ToString();

            _watcherInformation.NewLogs = newLogs;
        }

        public void ResetGame()
        {
            _teamOnLeftGoals = 0;
            _teamOnRightGoals = 0;
            _teamOnLeftMaxSpeed = 0;
            _teamOnRightMaxSpeed = 0;
            _maxSpeedPerMs = 0;
        }

        protected override void CalculateSpeed()
        {
            base.CalculateSpeed();
            UpdateMaxSpeed();
        }

        private void UpdateMaxSpeed() //FIXME it should check maxSpeed with Teams' maxSpeed
        {
            if (_speed.OmniSpeed_ms > _maxSpeedPerMs)
            {
                _maxSpeedPerMs = _speed.OmniSpeed_ms;
                _watcherInformation.MaxSpeed = _maxSpeedPerMs.ToString("F5");

                //Assign to the correct team
                if (_movingTowardsGoal != Teams.None)
                {
                    if (_movingTowardsGoal == Teams.TeamOnLeft)
                    {
                        _teamOnRightMaxSpeed = _maxSpeedPerMs;
                        _watcherInformation.MaxSpeedTeamOnRight = _teamOnRightMaxSpeed.ToString("F5");
                    }
                    else
                    {
                        _teamOnLeftMaxSpeed = _maxSpeedPerMs;
                        _watcherInformation.MaxSpeedTeamOnLeft = _teamOnLeftMaxSpeed.ToString("F5");
                    }
                }
            }
        }
    }
}
