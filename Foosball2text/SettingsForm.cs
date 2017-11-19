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
    public partial class SettingsForm : Form
    {
        Form _previousForm;
        public SettingsForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;

            string defaultName = Properties.Settings.Default.DefaultTeamName.ToString();

            textBox1.Text = defaultName;
        }

        private void SaveExit_Click(object sender, EventArgs e)
        {
            Foosball2text.Properties.Settings.Default.DefaultTeamName = textBox1.Text;
            Properties.Settings.Default.Save();

            _previousForm.Show();
            this.Close();
        }
    }
}
