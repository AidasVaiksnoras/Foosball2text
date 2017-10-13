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
    public partial class LoginForm : Form
    {
        private Login _login;

        public LoginForm()
        {
            InitializeComponent();
            _login = new Login(database1DataSet1, userTableAdapter1);
        }

        private void login1_Click(object sender, EventArgs e)
        {
            if (_login.Loginas(name1.Text) == 1) label1.Text = "Sukurtas naujas vartotojas " + name1.Text;
            else label1.Text = "Prisijungta vardu " + name1.Text;
            _login._teamA = name1.Text;
            checkIfDoneNaming();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            if (_login.Loginas(name2.Text) == 1) label2.Text = "Sukurtas naujas vartotojas " + name2.Text;
            else label2.Text = "Prisijungta vardu " + name2.Text;
            _login._teamB = name2.Text;
            checkIfDoneNaming();
        }

        private void checkIfDoneNaming()
        {
            if((label1.Text != "")&&(label2.Text != ""))
            {
                
            }
        }
    }
}
