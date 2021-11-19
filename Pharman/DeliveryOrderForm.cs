using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharman
{
    public partial class DeliveryOrderForm : Form
    {
        public DeliveryOrderForm()
        {
            InitializeComponent();
        }

        private void DeliveryOrderForm_Load(object sender, EventArgs e)
        {
            conclusionDateTimePicker.Value = conclusionDateTimePicker.MinDate = DateTime.Today;

            conclusionDateTimePicker.MaxDate = new DateTime
            (
                DateTime.Today.Year + 1,
                DateTime.Today.Month,
                DateTime.Today.Day
            );

            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT [dbo].[Providers].[Name] FROM [dbo].[Providers];";

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                providerComboBox.Items.Add(reader.GetString(0)); 
                            }
                        }

                        command.CommandText = @"SELECT [dbo].[Drugs].[Name] FROM [dbo].[Drugs];";

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                drugComboBox.Items.Add(reader.GetString(0));
                            }
                        }

                        providerComboBox.SelectedIndex = 0;
                        drugComboBox.SelectedIndex = 0;
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

        private void orderButton_Click(object sender, EventArgs e)
        {
            Deliveries.OrderDelivery
            (
                providerComboBox.SelectedItem.ToString(), 
                drugComboBox.SelectedItem.ToString(), 
                (int) amountNumericUpDown.Value,
                priceNumericUpDown.Value, 
                expirationDateTimePicker.Value, 
                conclusionDateTimePicker.Value
            );
        }

        private void conclusionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            expirationDateTimePicker.Value = expirationDateTimePicker.MinDate = new DateTime
            (
                conclusionDateTimePicker.Value.Year,
                conclusionDateTimePicker.Value.Month + 1,
                conclusionDateTimePicker.Value.Day
            );

            expirationDateTimePicker.MaxDate = new DateTime
            (
                expirationDateTimePicker.Value.Year + 1,
                expirationDateTimePicker.Value.Month,
                expirationDateTimePicker.Value.Day
            );
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
