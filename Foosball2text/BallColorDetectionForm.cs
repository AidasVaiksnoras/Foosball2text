using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Logic;

namespace Foosball2text
{
    public partial class BallColorDetectionForm : Form
    {
        private Timer _timer;
        private FrameHandler _frameHandler;
        private string _filePath;
        private VideoCapture _capture;
        private NavigationForm _navForm;

        public BallColorDetectionForm(string filePath, NavigationForm navForm)
        {
            InitializeComponent();
            _filePath = filePath;
            InitTimer();
            _navForm = navForm;
        }

        private void InitTimer()
        {
            _frameHandler = new FrameHandler(_pictureBox.Width, _pictureBox.Height);
            _timer = new Timer();

            //Frame Rate
            _timer.Interval = 1000 / 30;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();
            _capture = new VideoCapture(_filePath);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;

            _pictureBox.Image = _frameHandler.GetResizedImage(frame, _pictureBox.Width, _pictureBox.Height);
        }

        private void OnPauseButtonClick(object sender, EventArgs e)
        {
            _timer.Stop();
        }

        private void OnContinueButtonClick(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void OnRestartButtonClick(object sender, EventArgs e)
        {
            _timer.Tick -= TimerTick;
            InitTimer();
        }

        private void OpenProcessForm(int hue)
        {
            this.Hide();
            new VideoProcessForm(_filePath, hue, _navForm).Show();
        }

        private void OnPictureBoxClick(object sender, EventArgs e)
        {
            Point pt = _pictureBox.PointToClient(MousePosition);
            int x = pt.X;
            int y = pt.Y;

            Bitmap bm = new Bitmap(_pictureBox.Image);
            Color colorAtPoint = bm.GetPixel(x, y);
            OpenProcessForm(Convert.ToInt32(colorAtPoint.GetHue()));
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
