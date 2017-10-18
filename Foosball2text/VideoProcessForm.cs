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
        private const int _fps = 30; //Would this be a problem on a 60fps video?
        private VideoCapture _capture;
        private FrameHandler _frameHandler;
        private string _filePath;

        public VideoProcessForm(string filePath, int hue)
        {
            InitializeComponent();
            _frameHandler = new FrameHandler(pictureBox1.Width, pictureBox1.Height);
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
            WatcherInformation newInformation = _frameHandler.GetWatcherInformation();

            _xlabel.Text = newInformation.X;
            _ylabel.Text = newInformation.Y;

            ballOnSideOfFieldValue.Text = Enum.GetName(typeof(FieldSide), newInformation.BallSide);
            SpeedValue.Text = newInformation.XYSpeed;
            OmniSpeedPerMs_value.Text = newInformation.OmniSpeed;
            ValueUpdates.Text = newInformation.SecondsBetweenBallCapture;
            label_TeamOnLeftMaxValue.Text = newInformation.MaxSpeedTeamOnLeft;
            label_TeamOnRightMaxValue.Text = newInformation.MaxSpeedTeamOnRight;
            TeamA.Text = newInformation.TeamOnLeftGoals;
            TeamB.Text = newInformation.TeamOnRightGoals;

            if (newInformation.NewLogs != null)
            {
                foreach (string log in newInformation.NewLogs)
                    logData.Add(log);
            }
        }

        // ************ Logger methods ************
        BindingList<String> logData = new BindingList<string>();
        LoggerMessageDelivery messageGetter = new LoggerMessageDelivery();

        private void OnListChange(object sender, ListChangedEventArgs e)
        {
            //Auto-scrolling
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            logData.Add(messageGetter.gameEnd);

            WatcherInformation newInformation = _frameHandler.GetWatcherInformation();
            SaveGameResultsForm gameEndForm = new SaveGameResultsForm(
                int.Parse(newInformation.TeamOnLeftGoals),
                int.Parse(newInformation.TeamOnRightGoals),
                double.Parse(newInformation.MaxSpeedTeamOnLeft),
                double.Parse(newInformation.MaxSpeedTeamOnRight));
            gameEndForm.Show();

        }

        public void NewGame()
        {
            _frameHandler.ResetGameWatcher();
            TeamA.Text = "0";
            TeamB.Text = "0";
            logData.Add(messageGetter.gameStart);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            _timer.Tick -= TimerTick;
            Init();
            //NewGame(); Commented out because it doesn't show a goal if video ended too soon
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

