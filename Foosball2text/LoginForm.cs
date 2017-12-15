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
            //_dataProvider.LoadData(); no need to load ALL users

            if (Properties.Settings.Default.DefaultTeamName != "")
                name1.Text = Properties.Settings.Default.DefaultTeamName;
        }

        private void Login1_Click(object sender, EventArgs e)
        {
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
                _dataProvider.LeftUser = _dataProvider.AddUser(name1.Text);
                _dataProvider.RightUser = _dataProvider.AddUser(name2.Text);
                _dataProvider.CommitBothTeamsData(); //Save possible new users
                this.Close();
            }
        }


    }
}
