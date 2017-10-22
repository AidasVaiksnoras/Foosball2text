using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class GameWatcher : BallWatcher, IGameWatcher
    {
        int _teamOnLeftGoals = 0, _teamOnRightGoals = 0;
        double _teamOnLeftMaxSpeed = 0, _teamOnRightMaxSpeed = 0;

        public GameWatcher(float fieldWidth, float fieldHeight, User leftUser, User rightUser) 
            : base(fieldWidth, fieldHeight, leftUser, rightUser)
        {
        }

        public void UpdateGameWatcher(Image <Gray, byte> image)
        {
            base.UpdateBallWatcher(image);
            List<String> newLogs = new List<string>();
            LoggerMessageDelivery messageTemplates = new LoggerMessageDelivery();
            if (teamScored == Teams.TeamOnLeft)
            {
                _teamOnLeftGoals++;
                newLogs.Add(messageTemplates.goalLeft);
            }
            else if (teamScored == Teams.TeamOnRight)
            {
                _teamOnRightGoals++;
                newLogs.Add(messageTemplates.goalRight);
            }

            watcherInformation.TeamOnLeftGoals = _teamOnLeftGoals;
            watcherInformation.TeamOnRightGoals = _teamOnRightGoals;

            watcherInformation.NewLogs = newLogs;
        }

        public void ResetGame()
        {
            _teamOnLeftGoals = 0;
            _teamOnRightGoals = 0;
            _teamOnLeftMaxSpeed = 0;
            _teamOnRightMaxSpeed = 0;
        }

        protected override void CalculateSpeed()
        {
            base.CalculateSpeed();
            UpdateMaxSpeed();
        }

        private void UpdateMaxSpeed()
        {
            if (movingTowardsGoal != Teams.None)
            {
                if (movingTowardsGoal == Teams.TeamOnLeft)
                {
                    if (speed.OmniSpeed_ms > _teamOnRightMaxSpeed)
                    {
                        _teamOnRightMaxSpeed = speed.OmniSpeed_ms;
                        watcherInformation.MaxSpeedTeamOnRight = _teamOnRightMaxSpeed;
                    }
                }
                else //(_movingTowardsGoal == Teams.TeamOnRight)
                {
                    if (speed.OmniSpeed_ms > _teamOnLeftMaxSpeed)
                    {
                        _teamOnLeftMaxSpeed = speed.OmniSpeed_ms;
                        watcherInformation.MaxSpeedTeamOnLeft = _teamOnLeftMaxSpeed;
                    }
                }
            }
        }
    }
}
