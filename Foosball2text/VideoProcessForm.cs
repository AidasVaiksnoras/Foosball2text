using System;
using System.Windows.Forms;

using Emgu.CV;
using System.ComponentModel;
using System.Linq;
using Logic;

namespace Foosball2text
{
    public partial class VideoProcessForm : Form
    {
        private Timer _timer;
        private const int _fps = 30;
        private VideoCapture _capture;
        private FrameHandler _frameHandler;
        private string _filePath;

        public VideoProcessForm(string filePath, int hue, User leftUser, User rightUser)
        {
            InitializeComponent();
            _frameHandler = new FrameHandler(pictureBox1.Width, pictureBox1.Height, leftUser, rightUser);
            _frameHandler.UpdateHue(hue);
            _filePath = filePath;
            Init();

            logData.Add(messageGetter.gameStart);
            listBox1.DataSource = logData;
            logData.ListChanged += new ListChangedEventHandler(OnListChange);
        }
        private void Init()
        {
            _timer = new Timer();

            //Frame Rate
            _timer.Interval = 1000 / _fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();


            _capture = new VideoCapture(_filePath);
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
            _xlabel.Text = _frameHandler.GetWatcherInformation().X;
            _ylabel.Text = _frameHandler.GetWatcherInformation().Y;

            ballOnSideOfFieldValue.Text = Enum.GetName(typeof(FieldSide), _frameHandler.GetWatcherInformation().BallSide);
            SpeedValue.Text = _frameHandler.GetWatcherInformation().Speed; //XY Speed
            OmniSpeedPerMs_value.Text = _frameHandler.GetWatcherInformation().OmniSpeed; //OmniDirectional speed
            ValueUpdates.Text = _frameHandler.GetWatcherInformation().SecondsBetweenBallCapture;
            label_MaxSpeedValue.Text = _frameHandler.GetWatcherInformation().MaxSpeed;

            if (_frameHandler.GetWatcherInformation().TeamScored == Teams.TeamOnLeft)
                AddGoalA();
            if (_frameHandler.GetWatcherInformation().TeamScored == Teams.TeamOnRight)
                AddGoalB();
        }

        // ************ Logger methods ************
        BindingList<String> logData = new BindingList<string>();
        LoggerMessageDelivery messageGetter = new LoggerMessageDelivery();

        private void OnListChange(object sender, ListChangedEventArgs e)
        {
            LogUpdate();
        }

        private void LogUpdate()
        {
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            _frameHandler.ResetGameWatcher();
            logData.Add(messageGetter.gameEnd);
            ResetScore();
        }

        public void AddGoalA()
        {
            int score = int.Parse(TeamA.Text);
            score++;
            TeamA.Text = score.ToString();
            logData.Add(messageGetter.goalLeft);
        }

        public void AddGoalB()
        {
            int score = int.Parse(TeamB.Text);
            score++;
            TeamB.Text = score.ToString();
            logData.Add(messageGetter.goalRight);
        }

        public void ResetScore()
        {
            TeamA.Text = "0";
            TeamB.Text = "0";
        }

        public void NewGame()
        {
            ResetScore();
            logData.Add(messageGetter.gameStart);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            _timer.Tick -= TimerTick;
            Init();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

