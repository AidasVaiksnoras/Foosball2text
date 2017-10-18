using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class GameWatcher : BallWatcher
    {
        //TODO add team scores, game time, other game related info
        double _maxSpeedPerMs = 0;
        public double MaxSpeedPerMs { get; }

        public GameWatcher(float fieldWidth, float fieldHeight, User leftUser, User rightUser) 
            : base(fieldWidth, fieldHeight, leftUser, rightUser)
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
            }
        }
    }
}
