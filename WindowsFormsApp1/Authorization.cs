using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Authorization : Form
    {
        int sessionId;

        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username.MaxLength = 50;
            password.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Auth(username.Text, password.Text))
            {
                MessageBox.Show("Вы успешно авторизовались!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form claims = new ClaimList();
                claims.Show();
                Visible = false;

            } else
            {
                MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showRegister_Click(object sender, EventArgs e)
        {
            Form registration = new Registration();
            registration.Show();
        }

    }
}
