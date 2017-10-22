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
    public partial class LeaderboardForm : Form
    {
        private NavigationForm _navForm;

        public LeaderboardForm(NavigationForm navForm)
        {
            InitializeComponent();
            _navForm = navForm;
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userDataGridView.Sort(this.userDataGridView.Columns[1], ListSortDirection.Descending);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.userDataGridView.Sort(this.userDataGridView.Columns[2], ListSortDirection.Descending);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _navForm.Show();
            this.Close();
        }
    }
}
