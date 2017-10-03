using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball2text
{
    public partial class VideoLoggerForm : Form
    {
        BindingList<String> logData = new BindingList<string>();
        VideoLoggerMessageDelivery messageGetter = new VideoLoggerMessageDelivery();

        public VideoLoggerForm()
        {
            InitializeComponent();
            logData.Add(messageGetter.gameStart);
            listBox1.DataSource = logData;
            logData.ListChanged += new ListChangedEventHandler(list_ListChanged);
        }

        private void list_ListChanged(object sender, ListChangedEventArgs e)
        {
            LatestLogUpdate();
        }

        private void LatestLogUpdate()
        {
            LatestLog.Text = logData.Last();

            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGoalA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGoalB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logData.Add(messageGetter.dissapearedBall);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logData.Add(messageGetter.getPassMessage(PassedToText.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            logData.Add(messageGetter.getDisappearMessage(DisappearedText.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            logData.Add(messageGetter.gameEnd);
            ResetScore();
        }

        public void UpdateBallWatcherData(string ballOnSideText, string speedText, Teams teamScored)
        {
            ballOnSideOfFieldValue.Text = ballOnSideText;
            SpeedValue.Text = speedText;

            if (teamScored == Teams.TeamA)
                AddGoalA();
            if (teamScored == Teams.TeamB)
                AddGoalB();
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

        public void UpdateBallCoordinates(string newCoordinates)
        {
            Coordinates.Text = newCoordinates;
        }

        public void UpdateBallCoordinates(float xCoord, float yCoord)
        {
            string newCoordinates = "X: " + xCoord.ToString() + "; ";
            newCoordinates += "   Y: " + yCoord.ToString();
            Coordinates.Text = newCoordinates;
        }

        public void newGame()
        {
            ResetScore();
            logData.Add(messageGetter.gameStart);
        }
    }
}
