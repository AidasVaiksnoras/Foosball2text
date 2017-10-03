using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.IO;

namespace Foosball2text
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private const int _fps = 30;
        private VideoCapture _capture;
        private FrameHandler _frameHandler;
        private VideoLoggerForm _logger;
        string _filePath;    

        public Form1()
        {
            InitializeComponent();
            _logger = new VideoLoggerForm();
            _logger.Show();
            _frameHandler = new FrameHandler(pictureBox1.Width, pictureBox1.Height);
            _timer = new Timer();
            //Frame Rate
            _timer.Interval = 1000 / _fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _filePath = "../../sample.avi"; //<---- On launch video file path
            _capture = new VideoCapture(_filePath);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;

            pictureBox1.Image = _frameHandler.GetResizedImage(frame, pictureBox1.Width, pictureBox1.Height);
            imageBox1.Image = _frameHandler.GetFilteredImage(frame, pictureBox1.Width, pictureBox1.Height);
            UpdateCordinates();

            //BallWatcher Update
            _frameHandler.ballWatcher.UpdateBallWatcher();
            Teams teamScored = _frameHandler.ballWatcher.checkWhichTeamScored();
            _logger.UpdateBallWatcherData(_frameHandler.ballWatcher.GetBallOnSideString(),
                                          _frameHandler.ballWatcher.GetSpeedString(),
                                          teamScored);
        }

        private void UpdateCordinates()
        {
            _xlabel.Text = _frameHandler.X;
            _ylabel.Text = _frameHandler.Y;
            _logger.UpdateBallCoordinates(_frameHandler._ball.X, _frameHandler._ball.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
         {
             Point pt = pictureBox1.PointToClient(MousePosition);
             int x = pt.X;
             int y = pt.Y;
 
             Bitmap bm = new Bitmap(pictureBox1.Image);
             Color colorAtPoint = bm.GetPixel(x, y);

             int hue = Convert.ToInt32(colorAtPoint.GetHue());
 
             _frameHandler.UpdateHue(hue);
 
             _timer.Stop();
             _capture = new VideoCapture(_filePath);
             _timer.Start();
         }
 
         private void button1_Click(object sender, EventArgs e)
         {
             _timer.Stop();
         }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the browse window
            if (result == DialogResult.OK) //If opened a file
            {
                _filePath = openFileDialog1.FileName;
                try //to assign new _capture
                {
                    _capture = new VideoCapture(_filePath);
                    _logger.newGame();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
         }
    }
}

