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
        private BallWatcher ballWatcher;
        string filePath;

        public Form1()
        {
            InitializeComponent();
            _logger = new VideoLoggerForm();
            _logger.Show();
            _ball = new Ball();
            ballWatcher = new BallWatcher(ref _ball, pictureBox1.Height, pictureBox1.Width);
            _frameHandler = new FrameHandler();
            _timer = new Timer();
            //Frame Rate
            _timer.Interval = 1000 / _fps;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _capture = new VideoCapture("../../sample.avi");
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Mat frame = _capture.QueryFrame();
            if (frame == null)
                return;

            // Resize Image to size of pictureBox
            pictureBox1.Image = _frameHandler.GetResizedImage(frame, pictureBox1.Width, pictureBox1.Height);
            imageBox1.Image = _frameHandler.GetFilteredImage(frame, pictureBox1.Width, pictureBox1.Height);
            
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
            //^^^^^^^^^^^ Removed the call for frame handler on merge conflict. Will fix if needed
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
             _capture = new VideoCapture("../../sample.avi");
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

