using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharman
{
    public class Warehouse
    {
        public static DataTable WarehouseTable { get; private set; }

        static Warehouse()
        {
            WarehouseTable = new DataTable();
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
                        command.CommandText =
                            @"SELECT * FROM [dbo].[AppWarehouse];";

                        WarehouseTable.Clear();
                        WarehouseTable.Load(command.ExecuteReader());
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
