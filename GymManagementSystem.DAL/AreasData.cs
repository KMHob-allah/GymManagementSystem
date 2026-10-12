
using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class AreasData
    {
        public static DataTable GetAll()
        {
            using (SqlConnection connection =
                new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command =
                new SqlCommand("sp_Areas_GetAll", connection))
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

        public static DataRow GetByID(int areaID)
        {
            using (SqlConnection connection =
                new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command =
                new SqlCommand("sp_Areas_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@AreaID", SqlDbType.Int).Value = areaID;

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
}
