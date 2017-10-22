﻿using System;
using System.Windows.Forms;
using Logic;

namespace Foosball2text
{
    public partial class LeaderboardForm : Form
    {
        private UsersDataProvider _dataProvider;
        public LeaderboardForm(UsersDataProvider dataProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            gamesWonList.DataSource = _dataProvider.Data.OrderByGamesWon();
            totalScoreList.DataSource = _dataProvider.Data.OrderByTotalScore();
            maxSpeedList.DataSource = _dataProvider.Data.OrderByMaxSpeed();
            gamesPlayedList.DataSource = _dataProvider.Data.OrderByGamesPlayed();
        }

        private void GamesWonList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string gamesWon = ((User)e.ListItem).GamesWon.ToString();
            e.Value = String.Format("{0, -5} {1, -30}", gamesWon, username);
        }

        private void TotalScoreList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string totalScore = ((User)e.ListItem).TotalScore.ToString();
            e.Value = String.Format("{0, -5} {1, -30}", totalScore, username);
        }

        private void MaxSpeedList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string maxSpeed = ((User)e.ListItem).MaxSpeed.ToString();
            e.Value = String.Format("{0, -10} {1, -30}", maxSpeed, username);
        }

        private void GamesPlayedList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string gamesPlayed = ((User)e.ListItem).MaxSpeed.ToString();
            e.Value = String.Format("{0, -10} {1, -30}", gamesPlayed, username);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _dataProvider.GetUserData(textBox1.Text);
                UserInfoForm userForm = new UserInfoForm(user);
                userForm.Show();
            }
            catch(UserNotFoundException ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm("Žaidėjas: " + ex.Message + " nerastas");
                exceptionForm.Show();
            }
        }
    }
}
