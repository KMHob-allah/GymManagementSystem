using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public static class AttendanceData
    {
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Attendance_GetAll", connection))
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

        public static DataRow GetByID(int attendanceID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Attendance_GetByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@AttendanceID",SqlDbType.Int).Value = attendanceID;

                DataTable dataTable = new DataTable();

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }

        public static int? Create(int membershipID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_Attendance_Create", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@MembershipID",SqlDbType.Int).Value = membershipID;

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
