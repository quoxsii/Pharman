using System.Data.SqlClient;

namespace Pharman
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-NQ76JFI\SQLEXPRESS";
            string database = "Pharmacy";
            string username = "sa";
            string password = "123456";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
