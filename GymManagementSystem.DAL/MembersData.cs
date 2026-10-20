using System;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class MembersData
    {
        public static DataRow GetByID(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MemberID", memberID);

                DataTable table = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public static DataTable GetAll()
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_GetAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                DataTable table = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }

                return table;
            }
        }

        public static (int PersonID, int MemberID)? Create(
            string firstName,
            string middleName,
            string lastName,
            string phoneNumber,
            DateTime birthDate,
            bool gender,
            int areaID,
            string emergencyPhone,
            bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName;
                command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(middleName) ? (object)DBNull.Value : middleName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName;
                command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;
                command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = birthDate;
                command.Parameters.Add("@Gender", SqlDbType.Bit).Value = gender;
                command.Parameters.Add("@AreaID", SqlDbType.Int).Value = areaID;
                command.Parameters.Add("@EmergencyPhone", SqlDbType.VarChar, 11).Value = emergencyPhone;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return (
                        Convert.ToInt32(reader["PersonID"]),
                        Convert.ToInt32(reader["MemberID"])
                    );
                }
            }
        }

        public static bool Update(
            int memberID,
            string firstName,
            string middleName,
            string lastName,
            string phoneNumber,
            DateTime birthDate,
            bool gender,
            int areaID,
            string emergencyPhone,
            bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName;
                command.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrWhiteSpace(middleName) ? (object)DBNull.Value : middleName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName;
                command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;
                command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = birthDate;
                command.Parameters.Add("@Gender", SqlDbType.Bit).Value = gender;
                command.Parameters.Add("@AreaID", SqlDbType.Int).Value = areaID;
                command.Parameters.Add("@EmergencyPhone", SqlDbType.VarChar, 11).Value = emergencyPhone;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool Activate(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_Activate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool Deactivate(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_Deactivate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }       

        public static bool DoesMemberExist(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_Exists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MemberID", memberID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool HasOutstandingDebt(int membersID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Members_HasOutstandingDebt", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MemberID", membersID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}