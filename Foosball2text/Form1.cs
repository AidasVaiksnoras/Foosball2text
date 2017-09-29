using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace Foosball2text
{
    public partial class Form1 : Form
    {
        Timer _timer;
        private const int Fps = 30;
        VideoCapture _capture;
        private Ball _ball;
        private Filter _filter;

        public Form1()
        {
            InitializeComponent();
            _ball = new Ball();
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

            //draw and display the circle
            circleImage.Draw(_ball.Circle, new Bgr(Color.Green), 7);
            imageBox1.Image = circleImage;
        }

        private void UpdateCordinates()
        {
            _xlabel.Text = _ball.X.ToString();
            _ylabel.Text = _ball.Y.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

