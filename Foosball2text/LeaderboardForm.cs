using System;
using System.Windows.Forms;
using Logic;
using SQL_operations;

namespace Foosball2text
{
    public partial class LeaderboardForm : Form
    {
        private UsersDataProvider _dataProvider;
        private NavigationForm _navForm;
        public LeaderboardForm(UsersDataProvider dataProvider, NavigationForm navForm)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            _dataProvider.LoadData();
            gamesWonList.DataSource = _dataProvider.Data.OrderByGamesWon();
            totalScoreList.DataSource = _dataProvider.Data.OrderByTotalScore();
            maxSpeedList.DataSource = _dataProvider.Data.OrderByMaxSpeed();
            gamesPlayedList.DataSource = _dataProvider.Data.OrderByGamesPlayed();
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
            string totalScore = ((User)e.ListItem).TotalScore.ToString();
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
    }
}
