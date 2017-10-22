using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Foosball2text
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }
        public UserInfoForm(User user)
        {
            InitializeComponent();
            nameResultLabel.Text = user.UserName;
            gamesPlayedResultLabel.Text = user.GamesPlayed.ToString();
            gamesWonResultLabel.Text = user.GamesWon.ToString();
            totalScoreResultLabel.Text = user.TotalScore.ToString();
            maxSpeedResultLabel.Text = user.MaxSpeed.ToString();
        }

    }
}
