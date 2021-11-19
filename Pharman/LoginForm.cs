using System;
using System.Windows.Forms;

namespace Pharman
{
    public partial class LoginForm : Form
    {
        private User user;

        public LoginForm()
        {
            InitializeComponent();
            user = User.getInstance();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (user.LoginAttempt(loginTextBox.Text, passwordTextBox.Text))
            {
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show
                (
                    "Пользователь не найден, проверьте логин и пароль.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
