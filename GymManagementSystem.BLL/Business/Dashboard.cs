using GymManagementSystem.DAL;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public static class Dashboard
    {
        public static DashboardSummary GetSummary()
        {
            DataRow row = DashboardData.GetSummary();

            if (row == null) return null;

            return new DashboardSummary
            {
                ActiveMemberships = System.Convert.ToInt32(row["ActiveMemberships"]),

                TodaysAttendance = System.Convert.ToInt32(row["TodaysAttendance"]),

                CurrentDebt = System.Convert.ToDecimal(row["CurrentDebt"]),

                TodaysRevenue = System.Convert.ToDecimal(row["TodaysRevenue"])
            };
        }

        public static DataTable GetExpiringMemberships() =>  DashboardData.GetExpiringMemberships();        
    }
}