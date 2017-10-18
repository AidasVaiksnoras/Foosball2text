using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball2text
{
    public partial class SaveGameResultsForm : Form
    {
        string _teamNameA, _teamNameB;
        int _goalsA, _goalsB;
        //int _oldRankingA, _oldRankingB;
        //int _rankScorechangeA, _rankScorechangeB;
        //int _newRankA, _newRankB;
        double _maxSpeedA, _maxSpeedB;
        //TimeSpan _gameTime;

        public SaveGameResultsForm(string leftTeamName, string rightTeamName)
        {
            InitializeComponent();

            _teamNameA = leftTeamName;
            _teamNameB = rightTeamName;

            label_leftTeamName.Text = _teamNameA;
            label_rightTeamName.Text = _teamNameB;
        }

        public SaveGameResultsForm(int goalsA, int goalsB, double maxSpeedA, double maxSpeedB) : this("Team A", "TeamB")
        {
            _goalsA = goalsA;
            _goalsB = goalsB;

            if (_goalsA > _goalsB)
                HeaderLabel.Text = "Game ended. " + _teamNameA + " team won!";
            else if (_goalsA < _goalsB)
                HeaderLabel.Text = "Game ended. " + _teamNameA + " team won!";
            else
                HeaderLabel.Text = "Game ended. It's a tie!";

            _maxSpeedA = maxSpeedA;
            _maxSpeedB = maxSpeedB;

            label_goalsA.Text = _goalsA.ToString();
            label_goalsB.Text = _goalsB.ToString();
            label_maxSpeedA.Text = _maxSpeedA.ToString("F5");
            label_maxSpeedB.Text = _maxSpeedB.ToString("F5");
        }

        private void button_saveData_Click(object sender, EventArgs e)
        {
            button_saveData.Text = "Functionality not yet implemented";
            button_saveData.ForeColor = Color.Tan;
        }

    }
}
