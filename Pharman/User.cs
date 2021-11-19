using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharman
{
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int EmployeeID { get; private set; }
        public int UserTypeID { get; private set; }

        private static User instance;

        public static User getInstance()
        {
            if (instance == null)
                instance = new User();
            return instance;
        }

        private User()
        { }

        private bool Exist()
        {
            return Login != null;
        }

        public bool LoginAttempt(string login, string password)
        {
            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM [dbo].[fn_LoginAttempt](@login, @password);";

                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Login = reader.GetString(0);
                                Password = reader.GetString(1);
                                EmployeeID = reader.GetInt32(2);
                                UserTypeID = reader.GetInt32(3);
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

            return Exist();
        }

        private void Update()
        {
            if (!Exist()) return;

            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT * FROM [dbo].[fn_GetUserData](@employeeID);";

                        command.Parameters.AddWithValue("@employeeID", EmployeeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Login = reader.GetString(0);
                                Password = reader.GetString(1);
                                UserTypeID = reader.GetInt32(3);
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

        public void ChangeLogin(string login)
        {
            if (!Exist()) return;

            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "sp_ChangeLogin";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@employeeID", EmployeeID);
                        command.ExecuteNonQuery();
                    }
                }

                Update();
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

        public void ChangePassword(string password)
        {
            if (!Exist()) return;

            try
            {
                using (SqlConnection connection = DBUtils.GetDBConnection())
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "sp_ChangePassword";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@employeeID", EmployeeID);
                        command.ExecuteNonQuery();
                    }
                }

                Update();
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
