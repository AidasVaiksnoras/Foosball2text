using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class GameWatcher : BallWatcher
    {
        double _teamOnLeftMaxSpeed = 0, _teamOnRightMaxSpeed = 0;
        double _maxSpeedPerMs = 0;

        public double MaxSpeedPerMs { get; }

        public GameWatcher(float fieldWidth, float fieldHeight) : base(fieldWidth, fieldHeight)
        {
        }

        public void ResetMaxSpeed()
        {
            _maxSpeedPerMs = 0;
        }

        protected override void CalculateSpeed()
        {
            base.CalculateSpeed();
            UpdateMaxSpeed();
        }

        private void UpdateMaxSpeed()
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
