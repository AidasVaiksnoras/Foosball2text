﻿using System;
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
    public partial class SaveGameResultsForm : Form
    {
        User _userA, _userB;
        //Game's data
        int _goalsA, _goalsB;
        //int _oldRankingA, _oldRankingB;
        //int _rankScorechangeA, _rankScorechangeB;
        //int _newRankA, _newRankB;
        double _maxSpeedA, _maxSpeedB;
        //TimeSpan _gameTime;

        public SaveGameResultsForm(User userA, User userB, int goalsA, int goalsB, double maxSpeedA, double maxSpeedB)
        {
            InitializeComponent();

            _userA = userA;
            _userB = userB;

            label_leftTeamName.Text = _userA.UserName;
            label_rightTeamName.Text = _userB.UserName;

            _goalsA = goalsA;
            _goalsB = goalsB;

            if (_goalsA > _goalsB)
                HeaderLabel.Text = "Game ended. " + _userA.UserName + " team won!";
            else if (_goalsA < _goalsB)
                HeaderLabel.Text = "Game ended. " + _userB.UserName + " team won!";
            else
                HeaderLabel.Text = "Game ended. It's a tie!";

            _maxSpeedA = maxSpeedA;
            _maxSpeedB = maxSpeedB;

            label_goalsA.Text = _goalsA.ToString();
            label_goalsB.Text = _goalsB.ToString();
            label_maxSpeedA.Text = _maxSpeedA.ToString("F5");
            label_maxSpeedB.Text = _maxSpeedB.ToString("F5");
        }

        private void button_saveData_Click(object sender, EventArgs e) //UNDONE button press
        {
            _userA.UpdateData(true, (_goalsA > _goalsB), _maxSpeedA, _goalsA);
            _userB.UpdateData(true, (_goalsB > _goalsA), _maxSpeedB, _goalsB);

            button_saveData.Text = "User datas updated";
            button_saveData.ForeColor = Color.Green;
        }

    }
}
