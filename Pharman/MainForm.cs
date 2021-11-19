using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pharman
{
    public partial class MainForm : Form
    {
        private User user;
        private Dictionary<Button, Panel> menuSwitch = new Dictionary<Button, Panel>();

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;

            menuSwitch.Add(accountButton, accountPanel);
            menuSwitch.Add(deliveriesButton, deliveriesPanel);
            menuSwitch.Add(warehouseButton, warehousePanel);
            menuSwitch.Add(managersButton, managersPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            deliveriesDataGridView.DataSource = Deliveries.DeliveriesTable;
            managersDataGridView.DataSource = Managers.ManagersTable;
            warehouseDataGridView.DataSource = Warehouse.WarehouseTable;

            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT [dbo].[Positions].[Name] FROM [dbo].[Positions];";

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                positionComboBox.Items.Add(reader.GetString(0));
                            }
                        }

                        command.CommandText = @"SELECT * FROM [dbo].[fn_GetUSerInfo](@employeeID);";

                        command.Parameters.AddWithValue("@employeeID", user.EmployeeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nameTextBox.Text = reader.GetString(0);
                                surnameTextBox.Text = reader.GetString(1);
                                positionComboBox.SelectedItem = reader.GetString(2);
                                loginTextBox.Text = reader.GetString(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    ex.ToString(),
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Button, Panel> entry in menuSwitch)
            {
                entry.Value.Visible = false;
                entry.Value.Dock = DockStyle.None;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            foreach (KeyValuePair<Button, Panel> entry in menuSwitch)
            {
                entry.Value.Visible = false;
                entry.Value.Dock = DockStyle.None;

                if (entry.Key == clickedButton)
                {
                    entry.Value.Visible = true;
                    entry.Value.Dock = DockStyle.Fill;
                }
            }    
        }

        private void orderDeliveryButton_Click(object sender, EventArgs e)
        {
            DeliveryOrderForm orderSupplyForm = new DeliveryOrderForm();
            orderSupplyForm.ShowDialog();
        }

        private void deleteDeliveryButton_Click(object sender, EventArgs e)
        {
            Deliveries.DeleteDelivery(Convert.ToInt32(deliveriesDataGridView.SelectedRows[0].Cells[0].Value));
        }

        private void loginDataSaveButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != user.Login)
            {
                if (!IsLoginValid()) 
                {
                    loginTextBox.Text = user.Login;

                    MessageBox.Show
                    (
                        "Некорректный логин пользователя.\n" +
                        "Логин должен состоять из 6-20 строчных букв английского алфавита.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                user.ChangeLogin(loginTextBox.Text);

                MessageBox.Show
                (
                    "Логин успешно изменен.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            if (passwordTextBox.Text != string.Empty)
            {
                if (!IsPasswordValid())
                {
                    passwordTextBox.Text = string.Empty;
                    passwordAgainTextBox.Text = string.Empty;

                    MessageBox.Show
                    (
                        "Некорректный пароль пользователя.\n" +
                        "Пароль должен состоять из 6-50 букв английского алфавита и цифр.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (passwordTextBox.Text != passwordAgainTextBox.Text)
                {
                    passwordTextBox.Text = string.Empty;
                    passwordAgainTextBox.Text = string.Empty;

                    MessageBox.Show
                    (
                        "Пароли не совпадают, заполните поля заново.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (passwordTextBox.Text == user.Password)
                {
                    passwordTextBox.Text = string.Empty;
                    passwordAgainTextBox.Text = string.Empty;

                    MessageBox.Show
                    (
                        "Введенный пароль совпадает с нынешним, введите другой.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                user.ChangePassword(passwordTextBox.Text);

                MessageBox.Show
                (
                    "Пароль успешно изменен.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private bool IsLoginValid()
        {
            return Regex.IsMatch(loginTextBox.Text, @"^[a-z]{6,20}$");
        }

        private bool IsPasswordValid()
        {
            return Regex.IsMatch(passwordTextBox.Text, @"^[A-Za-z0-9]{6,50}$");
        }

        private void basicInfoSelectButton_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(dialog.FileName);
                    avatarPictureBox.Image = image;
                    avatarPictureBox.Invalidate();
                }
                catch
                {
                    MessageBox.Show
                    (
                        "Невозможно открыть выбранный файл.",
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void basicInfoSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordAgainTextBox.Enabled = passwordTextBox.Text != string.Empty;
        }

        private void passwordAgainTextBox_EnabledChanged(object sender, EventArgs e)
        {
            if (!passwordAgainTextBox.Enabled)
            {
                passwordAgainTextBox.Text = string.Empty;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 
    }
}
