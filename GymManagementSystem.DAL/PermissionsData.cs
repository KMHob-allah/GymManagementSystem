using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class PermissionsData
    {
        public static DataTable GetByRoleID(int roleID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command =
                new SqlCommand("sp_Permissions_GetByRoleID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@RoleID", SqlDbType.Int).Value =
                    roleID;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }
    }
}