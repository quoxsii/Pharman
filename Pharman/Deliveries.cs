using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharman
{
    public static class Deliveries
    {
        public static DataTable DeliveriesTable { get; private set; }

        static Deliveries()
        {
            DeliveriesTable = new DataTable();
            UpdateTable();
        }

        private static void UpdateTable()
        {
            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM [dbo].[AppDeliveries]";

                        DeliveriesTable.Clear();
                        DeliveriesTable.Load(command.ExecuteReader());
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

        public static void OrderDelivery(string provider, string drug, int amount, decimal price, DateTime conclusionDate, DateTime expirationDate)
        {
            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "sp_OrderDelivery";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@provider", provider);
                        command.Parameters.AddWithValue("@drug", drug);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@conclusionDate", conclusionDate);
                        command.Parameters.AddWithValue("@expirationDate", expirationDate);

                        command.ExecuteNonQuery();

                        UpdateTable(); 
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

        public static void DeleteDelivery(int id)
        {
            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"DELETE FROM [dbo].[Deliveries] WHERE [dbo].[Deliveries].[ID] = @id;";

                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();

                        UpdateTable();
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
    }
}
