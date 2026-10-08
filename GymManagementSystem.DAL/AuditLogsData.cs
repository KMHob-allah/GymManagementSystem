using System;
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class AuditLogsData
    {
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();


            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_AuditLogs_GetAll", connection))
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

        public static DataRow GetByID(int auditLogID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_AuditLogs_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@AuditLogID",SqlDbType.Int).Value = auditLogID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public static int? Create(int userID,string actionType,string tableName,int recordID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_AuditLogs_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@UserID",SqlDbType.Int).Value =userID;

                command.Parameters.Add("@ActionType",SqlDbType.NVarChar, 20).Value =actionType;

                command.Parameters.Add("@TableName",SqlDbType.NVarChar, 100).Value =tableName;

                command.Parameters.Add("@RecordID",SqlDbType.Int).Value =recordID;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToInt32(result);
            }
        }
    }

}
