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
        double _maxSpeedPerSec = 0;
        public double MaxSpeedPerMs { get; }

        public GameWatcher(float fieldWidth, float fieldHeight) : base(fieldWidth, fieldHeight)
        {
        }

        protected override void CalculateSpeed()
        {
            base.CalculateSpeed();
            UpdateMaxSpeed();
        }

        private void UpdateMaxSpeed()
        {
            if (_speed.OmniSpeedPerSec > _maxSpeedPerSec)
                _maxSpeedPerSec = _speed.OmniSpeedPerSec;
        }
    }
}
