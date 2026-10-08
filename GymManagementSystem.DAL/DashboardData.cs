using System.Data;
using System.Data.SqlClient;

namespace GymManagementSystem.DAL
{
    public static class DashboardData
    {
        public static DataRow GetSummary()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM vw_DashboardSummary",connection))
            {
                command.CommandType = CommandType.Text;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
        }

        public static DataTable GetExpiringMemberships()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM vw_DashboardExpiringMemberships",connection))
            {
                command.CommandType = CommandType.Text;

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