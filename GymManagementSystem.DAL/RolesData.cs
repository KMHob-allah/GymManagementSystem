using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public static class RolesData
    {
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Roles_GetAll", connection))
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
        public static DataRow GetByID(int roleID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Roles_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleID;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }
    }
}
