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
    public partial class UserInfoForm : Form
    {
        private UsersDataProvider _dataProvider;

        public UserInfoForm(UsersDataProvider dataProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
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
            totalScoreResultLabel.Text = user.TotalScore.ToString();
            maxSpeedResultLabel.Text = user.MaxSpeed.ToString();
            foreach (var lbl in Controls.OfType<Label>())
                lbl.Show();
        }

        private void search(string name)
        {
            try
            {
                User user = _dataProvider.GetUserData(textBox1.Text);
                UpdateForm(user);
                Show();
            }
            catch (UserNotFoundException ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm("Žaidėjas: " + ex.Message + " nerastas");
                exceptionForm.Show();
            }
        }
        private void Button1_Click(object sender, EventArgs e) => search(textBox1.Text);
    }
}