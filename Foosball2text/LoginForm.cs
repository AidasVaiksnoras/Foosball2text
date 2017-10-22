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
        private NavigationForm _navForm;

        public LoginForm(NavigationForm navForm)
        {
            InitializeComponent();
            _login = new Login(database1DataSet1, userTableAdapter1);
            _navForm = navForm;
        }

        private void login1_Click(object sender, EventArgs e)
        {
            if(name1.Text != name2.Text)
            {
                _login.IsNameFree(name1.Text);
                _navForm._teamA = name1.Text;
                _login.IsNameFree(name2.Text);
                _navForm._teamB = name2.Text;
                this.Close();
            }
            else
            {
                label.Text = "Vardai negali buti tokie patys";
            }
        }


    }
}
