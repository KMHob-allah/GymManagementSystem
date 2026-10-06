using System;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class PaymentsData
    {
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Payments_GetAll",connection))
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

        public static DataRow GetByID(int paymentID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand(
                "sp_Payments_GetByID",
                connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0
                    ? dataTable.Rows[0]
                    : null;
            }
        }

        public static DataTable GetByMembershipID(int membershipID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand(
                "sp_Payments_GetByMembershipID",
                connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MembershipID", SqlDbType.Int).Value = membershipID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public static int? Create(int membershipID,decimal amount,int createdByUserID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand(
                "sp_Payments_Create",
                connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MembershipID", SqlDbType.Int).Value =
                    membershipID;

                command.Parameters.Add("@Amount", SqlDbType.Decimal).Value =
                    amount;

                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value =
                    createdByUserID;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value) return null;

                return Convert.ToInt32(result);
            }
        }

        public static bool UpdateAmount(int paymentID, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand(
                "sp_Payments_UpdateAmount",
                connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;

                command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;

                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static decimal GetPaidAmountByMembershipID(int membershipID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand(
                "sp_Payments_GetPaidAmountByMembershipID",
                connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MembershipID", SqlDbType.Int).Value =
                    membershipID;

                connection.Open();

                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }

        public static DataRow GetSummary()
        {
            using (SqlConnection connection =
                new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command =
                new SqlCommand(
                    "sp_Payments_GetSummary",
                    connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0
                    ? dataTable.Rows[0]
                    : null;
            }
        }

    }
}
