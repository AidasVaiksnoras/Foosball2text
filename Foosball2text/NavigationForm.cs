using System;

using System.ComponentModel;

using System.Windows.Forms;
using Logic;
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
            DataProvider.LoadData();
        }

        private void ProcessButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm(DataProvider);
            form.ShowDialog();

            DialogResult result = openFileDialog1.ShowDialog();
        }

        private void OnOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Hide();
            new BallColorDetectionForm(openFileDialog1.FileName, 
                DataProvider.LeftUser, DataProvider.RightUser, this).Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var leaderboard = new LeaderboardForm(DataProvider, this);
            leaderboard.Show();
            this.Hide();
        }

        private void NavigationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataProvider.SaveData();
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfo = new UserInfoForm(DataProvider);
            userInfo.Show();
        }
    }
}
