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

        public VideoLoggerForm()
        {
            InitializeComponent();
            logData.Add(VideoLoggerMessageDelivery.gameStart);
            listBox1.DataSource = logData;
            logData.ListChanged += new ListChangedEventHandler(list_ListChanged);
        }

        void list_ListChanged(object sender, ListChangedEventArgs e)
        {
            LatestLogUpdate();
        }

        private void LatestLogUpdate()
        {
            LatestLog.Text = logData.Last();

            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void LatestLog_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.goalLeft);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.goalRight);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.dissapearedBall);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.getPassMessage(textBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.getDisappearMessage(textBox2.Text));
        }

        private void VideoLoggerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            logData.Add(VideoLoggerMessageDelivery.gameEnd);
        }
    }
}
