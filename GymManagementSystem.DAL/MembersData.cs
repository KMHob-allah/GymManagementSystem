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
            {
                using (SqlCommand command = new SqlCommand(
                    "sp_Members_GetByID", connection))
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
        }

        public static DataTable GetAll()
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
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
        }

        public static int? Create(string firstName,string secondName,string thirdName,string lastName,
            string phoneNumber,DateTime birthDate,bool gender,string area, string emergencyPhone)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Members_Create", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName;
                    command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Value = secondName;
                    command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Value =
                        string.IsNullOrWhiteSpace(thirdName) ? (object)DBNull.Value : thirdName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;
                    command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = birthDate;
                    command.Parameters.Add("@Gender", SqlDbType.Bit).Value = gender;
                    command.Parameters.Add("@Area", SqlDbType.NVarChar, 100).Value = area;
                    command.Parameters.Add("@EmergencyPhone", SqlDbType.VarChar, 11).Value = emergencyPhone;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return null;

                    return Convert.ToInt32(result);
                }
            }
        }

        public static bool Update(int memberID,string firstName,string secondName,string thirdName,
            string lastName,string phoneNumber,DateTime birthDate,bool gender,
            string area,string emergencyPhone)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Members_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstName;

                    command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50).Value = secondName;

                    command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50).Value =
                        string.IsNullOrWhiteSpace(thirdName) ? (object)DBNull.Value : thirdName;

                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastName;

                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;

                    command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = birthDate;

                    command.Parameters.Add("@Gender", SqlDbType.Bit).Value = gender;

                    command.Parameters.Add("@Area", SqlDbType.NVarChar, 100).Value = area;

                    command.Parameters.Add("@EmergencyPhone", SqlDbType.VarChar, 11).Value = emergencyPhone;

                    connection.Open();

                    return Convert.ToBoolean(command.ExecuteScalar());
                }
            }
        }

        public static bool Activate(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Members_Activate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Deactivate(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Members_Deactivate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static int? GetPersonID(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Members_GetPersonID",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID",SqlDbType.Int).Value = memberID;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value) return null;

                    return Convert.ToInt32(result);
                }
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
    }
}