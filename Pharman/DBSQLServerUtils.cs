using System.Data.SqlClient;

namespace Pharman
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connectionString = 
                $@"Data Source={datasource};
                Initial Catalog={database};
                Persist Security Info=True;
                User ID={username};
                Password={password}";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
