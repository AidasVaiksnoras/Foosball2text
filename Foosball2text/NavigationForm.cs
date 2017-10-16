﻿using System;
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
    public partial class NavigationForm : Form
    {
        public String _teamA { get; set; }
        public String _teamB { get; set; }

        public NavigationForm()
        {
            InitializeComponent();
        }

        private void ProcessButtonClick(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.ShowDialog();

            DialogResult result = openFileDialog1.ShowDialog();
        }

        private void OnOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Hide();
            new BallColorDetectionForm(openFileDialog1.FileName).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var seconadary = new LeaderboardForm();
            seconadary.Show();
        }
    }
}
