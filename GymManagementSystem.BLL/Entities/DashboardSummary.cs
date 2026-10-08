using System;

namespace GymManagementSystem.BLL.Entities
{
    public class DashboardSummary
    {
        public int ActiveMemberships { get; set; }
        public int TodaysAttendance { get; set; }
        public decimal CurrentDebt { get; set; }
        public decimal TodaysRevenue { get; set; }
    }
}