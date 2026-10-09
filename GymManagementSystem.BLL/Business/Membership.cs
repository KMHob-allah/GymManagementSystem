using GymManagementSystem.DAL;
using GymManagementSystem.BLL.Security;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    // TODO: Authorization
    // TODO: Audit Logging
    // TODO: Exceptions
    public class Membership
    {
        public enum eSaveResult
        {
            Success,
            InactiveMember,
            InactivePlan,
            OverlappingMembership,
            HasOutstandingDebt,
            MembershipExpired,
            HasPayments,
            HasAttendance,
            Unauthorized,
            Failed
        }
        
        private Member _member;
        private Plan _plan;

        private int _memberID;
        private int _planID;


        private enum eMode { Add, Update };
        public int MembershipID { get; set; }
        public int MemberID
        {
            get => _memberID;
            set
            {
                if (_memberID != value)
                {
                    _memberID = value;
                    _member = null;
                }
            }
        }
        public int PlanID
        {
            get => _planID;
            set
            {
                if (_planID != value)
                {
                    _planID = value;
                    _plan = null;
                }
            }
        }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        private eMode _Mode;

        public Member MemberInfo
        {
            get
            {
                if (_member == null) _member = Member.GetMemberByID(MemberID);

                return _member;
            }
        }
        public Plan PlanInfo
        {
            get
            {
                if (_plan == null) _plan = Plan.GetByID(PlanID);

                return _plan;
            }
        }

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
            DateTime endDate, decimal totalAmount)
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
                (decimal)row["TotalAmount"]
            );
        }

        private bool _Add()
        {
            int? MembershipID = MembershipsData.Create(
                this.MemberID, 
                this.PlanID,
                this.StartDate,
                 _CalculateEndDate(),
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
                _CalculateEndDate(),
                this.TotalAmount);
        }

        private eSaveResult _Validate()
        {
            if (!MemberInfo.IsActive) return eSaveResult.InactiveMember;
      
            if (!PlanInfo.IsActive) return eSaveResult.InactivePlan;

            if (_Mode == eMode.Add) return _ValidateAdd();

            return _ValidateUpdate();
        }
        private eSaveResult _ValidateAdd()
        {
            if (HasOutstandingDebt()) return eSaveResult.HasOutstandingDebt;

            if (_IsOverlapping()) return eSaveResult.OverlappingMembership;

            return eSaveResult.Success;
        }
        private eSaveResult _ValidateUpdate()
        {
            if (HasPayments()) return eSaveResult.HasPayments;

            if (HasAttendance()) return eSaveResult.HasAttendance;

            if (IsExpired()) return eSaveResult.MembershipExpired;

            if (_IsOverlapping()) return eSaveResult.OverlappingMembership;

            return eSaveResult.Success;
        }

        public eSaveResult Save()
        {            
            eSaveResult validationResult = _Validate();

            if (validationResult != eSaveResult.Success) return validationResult;

            switch (_Mode)
            {
                case eMode.Add:

                    if (!PermissionManager.HasPermission("Memberships.Create")) return eSaveResult.Unauthorized;

                    if (_Add())
                    {
                        _Mode = eMode.Update;
                        return eSaveResult.Success;
                    }

                    return eSaveResult.Failed;

                case eMode.Update:

                    if (!PermissionManager.HasPermission("Memberships.Update")) return eSaveResult.Unauthorized;

                    return _Update() ? eSaveResult.Success : eSaveResult.Failed;

                default:

                    return eSaveResult.Failed;
            }
        }

        public bool HasOutstandingDebt() => MembershipsData.HasOutstandingDebt(this.MemberID);

        public bool IsExpired() => this.EndDate < DateTime.Today;
        
        private bool _IsOverlapping()
        {
            return MembershipsData.IsMembershipOverlapping(
                MemberID,StartDate,_CalculateEndDate(),
                _Mode == eMode.Update ? MembershipID : 0);
        }

        private DateTime _CalculateEndDate() => StartDate.AddDays(PlanInfo.DurationInDays - 1);        

        public bool HasPayments() => MembershipsData.HasPayments(MembershipID);        

        public bool HasAttendance() => MembershipsData.HasAttendance(MembershipID);

        static public Membership GetActiveByMemberID(int memberID)
        {
            DataRow row = MembershipsData.GetActiveByMemberID(memberID);

            if (row == null)
                return null;

            return new Membership(
                (int)row["MembershipID"],
                (int)row["MemberID"],
                (int)row["PlanID"],
                (DateTime)row["StartDate"],
                (DateTime)row["EndDate"],
                (decimal)row["TotalAmount"]
            );
        }

        public decimal GetPaidAmount()
        {
            return PaymentsData.GetPaidAmountByMembershipID(MembershipID);
        }

        public decimal GetRemainingAmount()
        {
            return TotalAmount - GetPaidAmount();
        }        
    }
}