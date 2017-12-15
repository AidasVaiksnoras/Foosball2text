using System;
using System.Windows.Forms;
using Logic;

namespace Foosball2text
{
    public partial class LoginForm : Form
    {
        private UsersDataProvider _dataProvider;

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
            string team1 = name1.Text;
            string team2 = name2.Text;
            if (team1 == "" || team2 == "")
            {
                label.Text = "Komandos pavadinimas neįvestas";
            }
            else if (team1 == team2)
            {
                label.Text = "Vardai negali buti tokie patys";
            }
            else
            {
                /*// Karolio kodas
                if (_dataProvider.UserExistsInDb(team1))
                {
                    _dataProvider.LeftUser = _dataProvider.GetUserFromDb(team1);
                }
                else
                    _dataProvider.LeftUser = _dataProvider.AddUser(team1);

                if (_dataProvider.UserExistsInDb(team2))
                {
                    _dataProvider.RightUser = _dataProvider.GetUserFromDb(team2);
                }
                else
                    _dataProvider.RightUser = _dataProvider.AddUser(team2);
                //*/

                ///Weird code (it worked)
                _dataProvider.LeftUser = _dataProvider.AddUser(name1.Text);
                _dataProvider.RightUser = _dataProvider.AddUser(name2.Text);
                _dataProvider.CommitBothTeamsData(); //Save possible new users
                //*/

                label.Text = "Komandos sėkmingai prisijungė";
                this.Close();
            }
        }


    }
}
