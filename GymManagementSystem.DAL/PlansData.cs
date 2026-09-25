using System;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class PlansData
    {
        public static DataRow GetByID(int planID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_GetByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;

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
                using (SqlCommand command = new SqlCommand("sp_Plans_GetAll", connection))
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

        public static int? Create(string planName, int durationInDays, float price, bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_Create", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlanName", SqlDbType.NVarChar, 100).Value = planName;
                    command.Parameters.Add("@DurationInDays", SqlDbType.Int).Value = durationInDays;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = (decimal)price;
                    command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value) return null;

                    return Convert.ToInt32(result);
                }
            }
        }

        public static bool Update(int planID, string planName, int durationInDays, float price)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;

                    command.Parameters.Add("@PlanName", SqlDbType.NVarChar, 100).Value = planName;

                    command.Parameters.Add("@DurationInDays", SqlDbType.Int).Value = durationInDays;

                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool Activate(int planID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_Activate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Deactivate(int planID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_Deactivate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static float GetPlanPrice(int planID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_Plans_GetPriceByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@PlanID", SqlDbType.Int).Value = planID;

                    connection.Open();

                    object result = command.ExecuteScalar();

                    //if (result == null || result == DBNull.Value)
                    //    return null;

                    return Convert.ToSingle(result);
                }
            }
        }

        public static bool IsPlanNameExists(string planName)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))

            using (SqlCommand command = new SqlCommand("sp_Plans_IsNameExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PlanName", planName);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

        public static bool IsPlanNameExistsForOtherPlan(string planName, int planID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Plans_IsNameExistsForOtherPlan", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PlanName", planName);
                command.Parameters.AddWithValue("@PlanID", planID);

                connection.Open();

                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }

    }
}
