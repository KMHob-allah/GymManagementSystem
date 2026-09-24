using System;

namespace GymManagementSystem.BLL.Entities
{
    public class Membership
    {
        public int MembershipID { get; protected set; }
        public int MemberID { get; protected set; }
        public int PlanID { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public float TotalAmount { get; protected set; }

        public Membership(int membershipID, int memberID, int planID, DateTime startDate,
            DateTime endDate, float totalAmount)
        {
            MembershipID = membershipID;
            MemberID = memberID;
            PlanID = planID;
            StartDate = startDate;
            EndDate = endDate;
            TotalAmount = totalAmount;
        }

        //public Membership(int memberID, int planID, DateTime startDate, float totalAmount)
        //{
        //    MemberID = memberID;
        //    PlanID = planID;
        //    StartDate = startDate;
        //    TotalAmount = totalAmount;
        //    CreatedByUserID = createdByUserID;
        //}
    }
}