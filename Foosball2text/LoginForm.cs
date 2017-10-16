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
            if(name1.Text != name2.Text)
            {
                _login.IsNameFree(name1.Text);
                _login._teamA = name1.Text;
                _login.IsNameFree(name2.Text);
                _login._teamB = name2.Text;
                this.Close();
            }
            else
            {
                label.Text = "Vardai negali buti tokie patys";
            }
        }


    }
}
