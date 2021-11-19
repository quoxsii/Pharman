using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharman
{
    public class Managers
    {
        public static DataTable ManagersTable { get; private set; }

        static Managers()
        {
            ManagersTable = new DataTable();
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
                        command.CommandText = @"SELECT * FROM [dbo].[AppManagers]";

                        ManagersTable.Clear();
                        ManagersTable.Load(command.ExecuteReader()); 
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
