using System.Data.SqlClient;

namespace Pharman
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DATASOURCE";
            string database = "Pharmacy";
            string username = "USERNAME";
            string password = "PASSWORD";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
