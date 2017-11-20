using System;

using System.ComponentModel;

using System.Windows.Forms;
using Logic;

using Microsoft.Practices.Unity;


namespace Foosball2text
{
    public partial class NavigationForm : Form
    {
        public String _teamA { get; set; }
        public String _teamB { get; set; }
        public UsersDataProvider DataProvider {get; set;}
        public UnityContainer container = new UnityContainer();

        public NavigationForm()
        {
            InitializeComponent();
            DataProvider = new UsersDataProvider();
            container.RegisterType<UsersDataProvider>(new InjectionConstructor());
        }

        private void ProcessButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var form = container.Resolve<LoginForm>();
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
            container.RegisterInstance(this);
            var leaderboard = container.Resolve<LeaderboardForm>();
            leaderboard.Show();
        }

        private void NavigationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            container.RegisterType<UserInfoForm>(new InjectionConstructor(DataProvider));
            UserInfoForm userInfo = container.Resolve<UserInfoForm>(); ;
            userInfo.Show();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            new SettingsForm(this).Show();
        }
    }
}
