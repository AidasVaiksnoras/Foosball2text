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
        Timer _timer;
        private const int Fps = 30;
        VideoCapture _capture;
        private Ball _ball;
        private Filter _filter;
        private VideoLoggerForm _logger;
        private BallWatcher ballWatcher;
        string filePath;

        public Form1()
        {
            InitializeComponent();
            _logger = new VideoLoggerForm();
            _logger.Show();
            _ball = new Ball();
            ballWatcher = new BallWatcher(ref _ball, pictureBox1.Height, pictureBox1.Width);
            _filter = new Filter();
            _timer = new Timer();
            //Frame Rate
            _timer.Interval = 1000 / Fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _capture = new VideoCapture("../../sample.avi");
        }

        private void TimerTick(object sender, EventArgs e)
        {

            // Capture frame
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;

            // Resize Image to size of pictureBox
            Image<Bgr, byte> resizedImage =
                frame.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Linear);
            pictureBox1.Image = resizedImage.Bitmap;


            Image<Gray, byte> filteredImage = _filter.FilterImage(resizedImage);


            
            Image<Bgr, Byte> circleImage = resizedImage.CopyBlank();
            //Find the coordinates of the ball in the filtered image
            _ball.FindCordinates(filteredImage);

            //Diplay ball's coordinates
            UpdateCordinates();

            //BallWatcher Update
            ballWatcher.UpdateBallWatcher();
            Teams teamScored = ballWatcher.checkWhichTeamScored();
            _logger.UpdateBallWatcherData(ballWatcher.GetBallOnSideString(), ballWatcher.GetSpeedString(), teamScored);

            //draw and display the circle
            circleImage.Draw(_ball._circle, new Bgr(Color.Green), 7);
            imageBox1.Image = circleImage;
        }

        private void UpdateCordinates()
        {
            _xlabel.Text = _ball.x.ToString();
            _ylabel.Text = _ball.y.ToString();
            _logger.UpdateBallCoordinates(_ball.x, _ball.y);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the browse window
            if (result == DialogResult.OK) //If opened a file
            {
                filePath = openFileDialog1.FileName;
                try //to assign new _capture
                {
                    _capture = new VideoCapture(filePath);
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

