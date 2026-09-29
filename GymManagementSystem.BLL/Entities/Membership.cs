using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    // TODO: Authorization
    // TODO: Audit Logging
    // TODO: Exceptions
    public class Membership
    {
        private enum eMode { Add, Update };
        public int MembershipID { get; protected set; }
        public int MemberID { get; protected set; }
        public int PlanID { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public float TotalAmount { get; protected set; }
        private eMode _Mode;

        public Membership()
        {
            MembershipID  = 0;
            MemberID = 0;
            PlanID = 0;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            TotalAmount = 0;
            _Mode = eMode.Add;
        }
        protected Membership(int membershipID, int memberID, int planID, DateTime startDate,
            DateTime endDate, float totalAmount)
        {
            MembershipID = membershipID;
            MemberID = memberID;
            PlanID = planID;
            StartDate = startDate;
            EndDate = endDate;
            TotalAmount = totalAmount;

            _Mode = eMode.Update;
        }

        static public DataTable GetAll() => MembershipsData.GetAll();

        static public Membership GetByID(int membershipID)
        {
            DataRow row = MembershipsData.GetByID(membershipID);

            if (row == null) return null;

            return new Membership(
                (int)row["MembershipID"],
                (int)row["MemberID"],
                (int)row["PlanID"],
                (DateTime)row["StartDate"],
                (DateTime)row["EndDate"],
                (float)row["TotalAmount"]
            );
        }

        private bool _Add()
        {
            int? MembershipID = MembershipsData.Create(
                this.MemberID, 
                this.PlanID,
                this.StartDate, 
                this.EndDate,
                this.TotalAmount);

            if (MembershipID.HasValue)
            {
                this.MembershipID = MembershipID.Value;
                return true;
            }

            else return false;
        }
        private bool _Update()
        {
            return MembershipsData.Update(
                this.MembershipID, 
                this.PlanID,
                this.StartDate,
                this.TotalAmount);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:
                {
                    if (_Add())
                    {
                        _Mode = eMode.Update;
                        IsSaved = true;
                    }

                    else IsSaved = false;

                    break;
                }

                case eMode.Update:
                {
                    if (_Update()) IsSaved = true;

                    else IsSaved = false;

                    break;
                }
            }

            return IsSaved;
        }

        public bool HasOutstandingDebt() => MembershipsData.HasOutstandingDebt(this.MemberID);
        public bool IsExpired() => this.EndDate < DateTime.Today;
        public bool IsOverlapping() 
        {               
            return MembershipsData.IsMembershipOverlapping(this.MemberID,this.StartDate,this.EndDate);        
        }


    }
}