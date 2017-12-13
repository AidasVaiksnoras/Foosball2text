using System;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace Foosball2text
{
    public partial class UserInfoForm : Form
    {
        private UsersDataProvider _dataProvider;

        public UserInfoForm(UsersDataProvider dataProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            _dataProvider.LoadData();
            foreach (var lbl in Controls.OfType<Label>())
                lbl.Hide();
        }

        public UserInfoForm(UsersDataProvider dataProvider, string name)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            textBox1.Text = name;
            search(name);
        }

        private void UpdateForm(User user)
        {
            nameResultLabel.Text = user.UserName;
            gamesPlayedResultLabel.Text = user.GamesPlayed.ToString();
            gamesWonResultLabel.Text = user.GamesWon.ToString();
            totalScoreResultLabel.Text = user.TotalGoals.ToString();
            maxSpeedResultLabel.Text = user.MaxSpeed.ToString();
            foreach (var lbl in Controls.OfType<Label>())
                lbl.Show();
        }

        private void search(string name)
        {
            try
            {
                UpdateForm(_dataProvider.GetUserDataFromLocalList(name));
                Show();
            }
            catch (UserNotFoundException ex)
            {
                NotificationForm notificationForm = new NotificationForm("Žaidėjas: " + ex.UserName + " nerastas");
                notificationForm.Show();
            }
        }
        private void Button1_Click(object sender, EventArgs e) => search(textBox1.Text);
    }
}
