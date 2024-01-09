using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataDataSet.users);

        }
    }
}
