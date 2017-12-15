using System;
using System.Windows.Forms;
using Emgu.CV;
using System.ComponentModel;
using Logic;
using System.Drawing;
using WebApplication.Models;

namespace Foosball2text
{
    public partial class VideoProcessForm : Form
    {
        private Timer _timer;
        private const int _fps = 30;
        private VideoCapture _capture;
        private FrameHandler _frameHandler;
        private string _filePath;
        private NavigationForm _navForm;
        private Logic.User _leftUser, _rightUser;
        private Game _game = new Game();

        public event EventHandler<OnScoredEventArgs> OnScored;
        public event Action OnRestart;

        //Logger list asociated
        BindingList<String> logData = new BindingList<string>();
        LoggerMessageDelivery messageGetter = new LoggerMessageDelivery();

        //Expandable data
        bool _showAdditionalData;
        SplitContainer _container;
        int _extraDataPanelHeight;

        public VideoProcessForm(string filePath, int hue, Logic.User leftUser, Logic.User rightUser, NavigationForm navForm)
        {
            InitializeComponent();

            TeamA_label.Text = leftUser.UserName;
            TeamB_label.Text = rightUser.UserName;

            _navForm = navForm;
            _leftUser = leftUser;
            _rightUser = rightUser;
            _game.LeftUserName = leftUser.UserName;
            _game.RightUserName = rightUser.UserName;
            _game.InProgress = true;
            _frameHandler = new FrameHandler(pictureBox1.Width, pictureBox1.Height);
            _frameHandler.UpdateHue(hue);
            _filePath = filePath;
            ///Additional info
            _container = splitContainer1;
            _extraDataPanelHeight = _container.Panel2.Height;
            _container.Panel2Collapsed = true;

            RegisterEventsHandlers();

            ///Start the video
            InitTimer();
            _capture = new VideoCapture(_filePath);
            NewGame();

            listBox1.DataSource = logData;
            logData.ListChanged += new ListChangedEventHandler(OnListChange);
        }

        private void RegisterEventsHandlers()
        {
            OnRestart += InitTimer;
            OnRestart += () => {
                _capture = new VideoCapture(_filePath);
            };
            OnRestart += () => {
                SetGameEnded();
                logData.Add(messageGetter.gameEnd);
                NewGame();
            };

            OnScored += ServiceClient.OnScoreChanged;
            OnScored += (o, e) => {
                TeamA_score.Text = e.Game.LeftScore.ToString();
                TeamB_score.Text = e.Game.RightScore.ToString();
            };
        }

        private void InitTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000 / _fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;
            
            pictureBox1.Image = _frameHandler.GetResizedImage(frame, pictureBox1.Width, pictureBox1.Height);
            UpdateInformation();
        }

        private void UpdateInformation()
        {
            WatcherInformation newInformation = _frameHandler.GetWatcherInformation();

            if (_showAdditionalData)
            {
                _xlabel.Text = newInformation.X.ToString("F3");
                _ylabel.Text = newInformation.Y.ToString("F3");
                ballOnSideOfFieldValue.Text = Enum.GetName(typeof(FieldSide), newInformation.BallSide);
                SpeedValue.Text = string.Format("X: {0}; Y: {1}", newInformation.XSpeed.ToString("F5"), newInformation.YSpeed.ToString("F5"));
                OmniSpeedPerMs_value.Text = newInformation.OmniSpeed.ToString("F5");
                ValueUpdates.Text = newInformation.SecondsBetweenBallCapture.ToString("F5");
                label_TeamOnLeftMaxValue.Text = newInformation.MaxSpeedTeamOnLeft.ToString("F5");
                label_TeamOnRightMaxValue.Text = newInformation.MaxSpeedTeamOnRight.ToString("F5");
            }
            if (TeamA_score.Text != newInformation.TeamOnLeftGoals.ToString() || TeamB_score.Text != newInformation.TeamOnRightGoals.ToString())
            {
                _game.LeftScore = newInformation.TeamOnLeftGoals;
                _game.RightScore = newInformation.TeamOnRightGoals;
                OnScored(this, new OnScoredEventArgs(_game));
            }

            if (newInformation.NewLogs != null)
            {
                foreach (string log in newInformation.NewLogs)
                    logData.Add(log);
            }
        }

        private void OnScoreChanged(object sender, OnScoredEventArgs e)
        {
            TeamA_score.Text = e.Game.LeftScore.ToString();
            TeamB_score.Text = e.Game.RightScore.ToString();
        }

        private void OnListChange(object sender, ListChangedEventArgs e)
        {
            //Auto-scrolling
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            SetGameEnded();
            logData.Add(messageGetter.gameEnd);

            WatcherInformation newInformation = _frameHandler.GetWatcherInformation();
            SaveGameResultsForm gameEndForm = new SaveGameResultsForm(
                _leftUser,
                _rightUser,
                newInformation.TeamOnLeftGoals,
                newInformation.TeamOnRightGoals,
                newInformation.MaxSpeedTeamOnLeft,
                newInformation.MaxSpeedTeamOnRight);
            gameEndForm.Show();

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            _timer.Tick -= TimerTick;
            OnRestart();
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            _navForm.Show();
            this.Close();
        }

        private void Expand_button_Click(object sender, EventArgs e)
        {
            if (_container.Panel2Collapsed)
            { ///Show additional data
                _showAdditionalData = true;
                _container.Panel2Collapsed = false;
                this.Height = this.Height + _extraDataPanelHeight;
                this.MinimumSize = new Size(this.Width, this.Height);
                Expand_button.Text = "Hide additional data";
            }
            else
            { ///Hide additional data
                _showAdditionalData = false;
                _container.Panel2Collapsed = true;
                this.MinimumSize = new Size(this.Width, this.Height - _extraDataPanelHeight);
                this.Height = this.Height - _extraDataPanelHeight;
                Expand_button.Text = "Show additional data";
            }
        }

        private void VideoProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _navForm.Show();
            SetGameEnded();
        }

        private void SetGameEnded()
        {
            _game.InProgress = false; 
            ServiceClient.PutToDb<Game>(_game, Method.Update);
        }

        private void NewGame()
        {
            _frameHandler.ResetGameWatcher();
            TeamA_score.Text = "0";
            TeamB_score.Text = "0";
            logData.Add(messageGetter.gameStart);

            //DB related
            _game = new Game();
            _game.LeftScore = 0;
            _game.RightScore = 0;
            _game.LeftUserName = _leftUser.UserName;
            _game.RightUserName = _rightUser.UserName;
            _game.InProgress = true; 
            ServiceClient.PutToDb<Game>(_game, Method.Insert);
            /// Following code is required to get such information (like Id) that the local machine can't generate
            _game = ServiceClient.GetCurrentGameFromDbAsync(_game.LeftUserName, _game.RightUserName);
        }
    }
}

