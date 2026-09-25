using System;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class MembershipsData
    {
        private static bool DoesMemberExist(int memberID)
        {
            return MembersData.DoesMemberExist(memberID);
        }

        public static DataRow GetByID(int membershipID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Memberships_GetByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MembershipID", SqlDbType.Int).Value = membershipID;

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
                using (SqlCommand command = new SqlCommand("Select * From MembershipOverview", connection))
                {
                    command.CommandType = CommandType.Text;

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

        public static int? Create(int memberID, int planID, DateTime startDate, DateTime endDate, float totalAmount)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Memberships_Create", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberID;
                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;
                    command.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate;
                    command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value) return null;

                    return Convert.ToInt32(result);
                }
            }
        }

        public static bool Update(int membershipID, int planID, DateTime startDate, float totalAmount)
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_Memberships_Update", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@MembershipID", SqlDbType.Int).Value = membershipID;
                        command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;
                        command.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate;
                        command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }

        public static bool IsMembershipOverlapping(int memberID,DateTime startDate,DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Memberships_IsOverlapping", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MemberID", memberID);
                command.Parameters.AddWithValue("@StartDate", startDate.Date);
                command.Parameters.AddWithValue("@EndDate", endDate.Date);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool HasOutstandingDebt(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Memberships_HasOutstandingDebt", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MemberID", memberID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool HasPayments(int membershipID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Memberships_HasPayments", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MembershipID", membershipID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool HasAttendance(int membershipID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Memberships_HasAttendance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MembershipID", membershipID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool IsMembershipOverlappingForUpdate(int membershipID,int memberID,DateTime startDate,DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Memberships_IsOverlappingExcluding", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MembershipID", membershipID);
                command.Parameters.AddWithValue("@MemberID", memberID);
                command.Parameters.AddWithValue("@StartDate", startDate.Date);
                command.Parameters.AddWithValue("@EndDate", endDate.Date);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
    }
}

