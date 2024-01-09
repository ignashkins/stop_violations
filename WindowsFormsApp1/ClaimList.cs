using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ClaimList : Form
    {
        DataBase db = new DataBase();

        int selectedId;
        public ClaimList()
        {
            InitializeComponent();
            cancelEditClaim.Visible = false;
            saveClaimItem.Visible = false;
        }

        private void ClaimList_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            string select = "select claims.id, claims.number, users.name, claims.[desc], states.title from claims join users on claims.user_id = users.id join states on claims.state_id = states.id";
            if (!User.isAdmin)
            {
                select += " where user_id='" + User.sessionId + "'";
            }


            SqlConnection c = db.get();
            DataTable dt = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, c);
            dataAdapter.Fill(dt);
            claimListView.DataSource = dt;
            claimListView.Columns[0].HeaderText = "#";
            claimListView.Columns[1].HeaderText = "Номер авто";
            claimListView.Columns[2].HeaderText = "Заявитель";
            claimListView.Columns[3].HeaderText = "Описание";
            claimListView.Columns[4].HeaderText = "Статус";

            db.close();

            if (stateListSelector.Items.Count == 0)
            {
                stateListSelector.Items.Add("Новое");
                stateListSelector.Items.Add("Подтверждено");
                stateListSelector.Items.Add("Отклонено");
            }

            stateListSelector.SelectedItem = "Новое";

            if (!User.isAdmin)
            {
                stateListSelector.Enabled = false;
            }

        }

        private void putNewClaim_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim();
            claim.Fill(autoNumber.Text, claimText.Text, 1);
            claim.Save();

            autoNumber.Text = "";
            claimText.Text = "";

            Reload();
        }

        private void claimListView_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && User.isAdmin) // Если клик произошел по записи (а не по заголовкам столбцов)
            {
                DataGridViewRow row = claimListView.Rows[e.RowIndex];

                // Здесь вы можете использовать данные строки row
                // например, чтобы получить значение первой ячейки столбца с индексом 0:
                selectedId = Int32.Parse(row.Cells[0].Value.ToString());
                string number = row.Cells[1].Value.ToString();
                string user = row.Cells[2].Value.ToString();
                string desc = row.Cells[3].Value.ToString();
                string state = row.Cells[4].Value.ToString();

                autoNumber.Text = number;
                claimText.Text = desc;
                stateListSelector.SelectedItem = state;

                saveClaimItem.Visible = true;
                cancelEditClaim.Visible = true;
                putNewClaim.Visible = false;

                claimListView.Refresh();
            }
        }

        private void cancelEditClaim_Click(object sender, EventArgs e)
        {
            autoNumber.Text = "";
            claimText.Text = "";
            stateListSelector.SelectedItem = "Новое";
            cancelEditClaim.Visible = false;
            saveClaimItem.Visible = false;
            putNewClaim.Visible = true;
        }

        private void saveClaimItem_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim();
            claim.Fill(autoNumber.Text, claimText.Text, stateListSelector.SelectedIndex + 1);
            claim.Update(selectedId);

            Reload();

            autoNumber.Text = "";
            claimText.Text = "";
            stateListSelector.SelectedItem = "Новое";
            cancelEditClaim.Visible = false;
            saveClaimItem.Visible = false;
            putNewClaim.Visible = true;

            MessageBox.Show("Данные успешно обновлены", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClaimList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
