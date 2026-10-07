using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public static class UsersData
    {
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public static DataRow GetByID(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public static DataRow GetByUsername(string userName)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_GetByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public static bool IsUsernameExists(string userName, int? userID = null)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_IsUsernameExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserName",SqlDbType.NVarChar,50).Value = userName;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = (object)userID ?? DBNull.Value;

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static int? Create(int roleID, string userName, byte[] passwordHash, bool isActive = true)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleID;

                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;

                command.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 256).Value = passwordHash;

                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value) return null;

                return Convert.ToInt32(result);
            }
        }

        public static bool Update(int userID, int roleID, string userName,byte[] passwordHash,bool isActive)
        {
            using (SqlConnection connection =new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                command.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleID;

                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;

                command.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 256).Value =
                    (object)passwordHash ?? DBNull.Value;

                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        
        public static bool Activate(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_Activate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool Deactivate(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_Deactivate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdatePassword(int userID,byte[] passwordHash)   
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Users_UpdatePassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                command.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 256).Value = passwordHash;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
    