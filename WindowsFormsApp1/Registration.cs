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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected void Registration_Load(object sender, EventArgs e)
        {
            login.MaxLength = 255;
            password.MaxLength = 255;
            name.MaxLength = 255;
            phone.MaxLength = 255;
            email.MaxLength = 255;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || name.Text == "" || phone.Text == "" || email.Text == "")
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            User user = new User();
            user.Fill(login.Text, password.Text, name.Text, phone.Text, email.Text);
            user.Save();
            MessageBox.Show("Спасибо, вы успешно зарегистрированы в системе! Теперь вы можете использовать указанный логин и пароль для входа.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
