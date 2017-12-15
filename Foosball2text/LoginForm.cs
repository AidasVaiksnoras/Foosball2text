using System;
using System.Windows.Forms;
using Logic;
using WebApplication.Helpers;

namespace Foosball2text
{
    public partial class LoginForm : Form
    {
        private UsersDataProvider _dataProvider;
        private DataProviderEF _databaseDataProvider = new DataProviderEF();

        public LoginForm(UsersDataProvider dataProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            _dataProvider.LoadData();

            if (Properties.Settings.Default.DefaultTeamName != "")
                name1.Text = Properties.Settings.Default.DefaultTeamName;
        }

        private void Login1_Click(object sender, EventArgs e)
        {
            String username1 = name1.Text;
            String username2 = name2.Text;
            if (name1.Text == "" || name2.Text == "")
            {
                label.Text = "Komandos pavadinimas neįvestas";
            }
            else if (name1.Text == name2.Text)
            {
                label.Text = "Vardai negali buti tokie patys";
            }
            else
            {
                //UNDONE untested
                if (_databaseDataProvider.UserExists(username1))
                {
                    WebApplication.Models.User dbUser = _databaseDataProvider.GetUser(username1);
                    _dataProvider.LeftUser = new User(dbUser.Username, dbUser.GamesPlayed, dbUser.GamesWon, dbUser.MaxSpeed, dbUser.TotalGoals, dbUser.TimePlayed, dbUser.RankPoints);
                }
                else
                {
                    _dataProvider.AddUser(username1);
                    _dataProvider.LeftUser = new User(username1);
                }

                if (_databaseDataProvider.UserExists(username2))
                {
                    WebApplication.Models.User dbUser = _databaseDataProvider.GetUser(username2);
                    _dataProvider.RightUser = new User(dbUser.Username, dbUser.GamesPlayed, dbUser.GamesWon, dbUser.MaxSpeed, dbUser.TotalGoals, dbUser.TimePlayed, dbUser.RankPoints);
                }
                else
                {
                    _dataProvider.AddUser(username2);
                    _dataProvider.RightUser = new User(username2);
                }

                this.Close();
            }
        }


    }
}
