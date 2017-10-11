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
    public partial class NavigationForm : Form
    {

        public NavigationForm()
        {
            InitializeComponent();
        }

        private void ProcessButtonClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
        }

        private void OnOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.Hide();
            new BallColorDetectionForm(openFileDialog1.FileName).Show();
        }
    }
}
