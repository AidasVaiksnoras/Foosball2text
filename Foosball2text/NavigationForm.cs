using System;

using System.ComponentModel;

using System.Windows.Forms;
using Logic;
using SQL_operations;

namespace Foosball2text
{
    public partial class NavigationForm : Form
    {
        public String _teamA { get; set; }
        public String _teamB { get; set; }
        public UsersDataProvider DataProvider {get; set;}

        public NavigationForm()
        {
            InitializeComponent();
            DataProvider = new UsersDataProvider();
        }

        private void ProcessButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm(DataProvider);
            form.ShowDialog();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Show();
            }
        }

        private void OnOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Hide();
            new BallColorDetectionForm(openFileDialog1.FileName, 
                DataProvider.LeftUser, DataProvider.RightUser, this).Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //UNDONE testing SQL read
            //System.Collections.Generic.List<User> allUserData = new System.Collections.Generic.List<User>();
            //allUserData = ReadOperations.GetAllUserData();
            //User customUser = ReadOperations.GetUsersData("Pirmasius");
            WriteOperations.UpdateUserPlayData(new User("Editable test", 4, 3, 9.444, 16, "0000-00-06T03:04:05Z", 10));

            var leaderboard = new LeaderboardForm(DataProvider, this);
            leaderboard.Show();
            this.Hide();
        }

        private void NavigationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new UserInfoForm(DataProvider);
            userInfo.Show();
        }
    }
}
