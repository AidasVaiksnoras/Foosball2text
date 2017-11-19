using System;
using System.Windows.Forms;
using Logic;
using System.Collections.Generic;

namespace Foosball2text
{
    public partial class LeaderboardForm : Form
    {
        private UsersDataProvider _dataProvider;
        private NavigationForm _navForm;

        Lazy<List<User>> gamesWonOrdered;
        Lazy<List<User>> totalScoreOrdered;
        Lazy<List<User>> maxSpeedOrdered;
        Lazy<List<User>> gamesPlayedOrdered;

        public LeaderboardForm(UsersDataProvider dataProvider, NavigationForm navForm)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            _dataProvider.LoadData();

            //Data is loaded when tab is selected
            gamesWonOrdered = new Lazy<List<User>> (() => _dataProvider.UserList.OrderByGamesWon());
            totalScoreOrdered = new Lazy<List<User>>(() => _dataProvider.UserList.OrderByTotalScore());
            maxSpeedOrdered = new Lazy<List<User>>(() => _dataProvider.UserList.OrderByMaxSpeed());
            gamesPlayedOrdered = new Lazy<List<User>>(() => _dataProvider.UserList.OrderByGamesPlayed());
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            //Load the first tab
            gamesWonList.DataSource = gamesWonOrdered.Value;

            _navForm = navForm;
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
            string totalScore = ((User)e.ListItem).TotalGoals.ToString();
            e.Value = String.Format("{0, -5} {1, -30}", totalScore, username);
        }

        private void MaxSpeedList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string maxSpeed = Math.Round(((User)e.ListItem).MaxSpeed, 2).ToString();
            e.Value = String.Format("{0, -10} {1, -30}", maxSpeed, username);
        }

        private void GamesPlayedList_Format(object sender, ListControlConvertEventArgs e)
        {
            string username = ((User)e.ListItem).UserName;
            string gamesPlayed = ((User)e.ListItem).GamesPlayed.ToString();
            e.Value = String.Format("{0, -10} {1, -30}", gamesPlayed, username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new UserInfoForm(_dataProvider, textBox1.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _navForm.Show();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == gamesWonTab)
            {
                gamesWonList.DataSource = gamesWonOrdered.Value;
            }
            if (tabControl1.SelectedTab == totalScoreTab)
            {
                totalScoreList.DataSource = totalScoreOrdered.Value;
            }
            if (tabControl1.SelectedTab == maxSpeedTab)
            {
                maxSpeedList.DataSource = maxSpeedOrdered.Value;
            }
            if (tabControl1.SelectedTab == gamesPlayed)
            {
                gamesPlayedList.DataSource = gamesPlayedOrdered.Value;
            }
        }
    }
}
