using GymManagementSystem.BLL.Common;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.DAL;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GymManagementSystem.BLL.Services
{
    public enum CreateMembershipOperationResult
    {
        Success,
        InvalidData,
        NotExistPlan,
        NotExistMember,
        NotActiveMember,        
        NotActivePlan,       
        OverlappedMembership,
        OutstandingDebt,
        Failed

    }
    public enum UpdateMembershipOperationResult
    {
        Success,
        InvalidData,
        NotExistPlan,
        NotExistMembership,
        ExpiredMembership,
        HasLinkedData,
        NotActiveMember,
        NotActivePlan,
        OverlappedMembership,
        Failed

    }

    public abstract class MembershipService
    {
        private bool IsValidStartDate(DateTime startDate) => startDate.Date >= DateTime.Today;

        private bool IsMembershipOverlapping(int memberID,DateTime startDate,DateTime endDate)
        {
            return MembershipsData.IsMembershipOverlapping(memberID,startDate,endDate);
        }

        private bool HasOutstandingDebt(int memberID) => MembershipsData.HasOutstandingDebt(memberID);        

        private bool IsExpiredMembership(DateTime endDate) => endDate < DateTime.Today;

        private bool IsMembershipOverlappingExcluding(int membershipID, int memberID,  DateTime startDate, DateTime endDate)
        {
            return MembershipsData.IsMembershipOverlappingForUpdate(membershipID, memberID, startDate, endDate);
        }

        private OperationResult<CreateMembershipOperationResult, int> FailerResult(CreateMembershipOperationResult result)
        {
            return new OperationResult<CreateMembershipOperationResult, int>(result);
        }
        private OperationResult<UpdateMembershipOperationResult, bool> FailerResult(UpdateMembershipOperationResult result)
        {
            return new OperationResult<UpdateMembershipOperationResult, bool>(result);
        }
       

        public DataTable GetAll()
        {
            return MembershipsData.GetAll();
        }

        public Membership GetByID(int membershipID)
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

        public OperationResult<CreateMembershipOperationResult,int> CreateMembership(int memberID, int planID, DateTime startDate)
        {
            // Validate Member
            DataRow drMember = MembersData.GetByID(memberID);

            if (drMember == null) FailerResult(CreateMembershipOperationResult.NotExistMember);

            if (!(bool)drMember["IsActive"]) FailerResult(CreateMembershipOperationResult.NotActiveMember);

            // Validate Plan
            DataRow drPlan = PlansData.GetByID(planID);

            if (drPlan == null) FailerResult(CreateMembershipOperationResult.NotExistPlan);

            if (!(bool)drPlan["IsActive"]) FailerResult(CreateMembershipOperationResult.NotActivePlan);

            // Validate StartDate
            if (!IsValidStartDate(startDate)) FailerResult(CreateMembershipOperationResult.InvalidData);

            DateTime endDate = startDate.AddDays((int)drPlan["DurationInDays"]);

            // Validate Overlapping Membership
            if (IsMembershipOverlapping(memberID, startDate, endDate)) FailerResult(CreateMembershipOperationResult.OverlappedMembership);

            // Validate Outstanding Debt
            if (HasOutstandingDebt(memberID)) FailerResult(CreateMembershipOperationResult.OutstandingDebt);                                  


            int? membershipID = MembershipsData.Create(memberID, planID, startDate, endDate, (float)drPlan["Price"]);

            if (!membershipID.HasValue) FailerResult(CreateMembershipOperationResult.Failed);

            return new OperationResult<CreateMembershipOperationResult, int>(CreateMembershipOperationResult.Success,membershipID.Value);
        }

        public OperationResult<UpdateMembershipOperationResult, bool> UpdateMembership(int membershipID, int planID, DateTime startDate)
        {          

            DataRow drMembership = MembershipsData.GetByID(membershipID);

            if (drMembership == null) FailerResult(UpdateMembershipOperationResult.NotExistMembership);

            if (IsExpiredMembership((DateTime)drMembership["EndDate"])) FailerResult(UpdateMembershipOperationResult.ExpiredMembership);

            if (MembershipsData.HasPayments(membershipID)) FailerResult(UpdateMembershipOperationResult.HasLinkedData);

            if (MembershipsData.HasAttendance(membershipID)) FailerResult(UpdateMembershipOperationResult.HasLinkedData);

            // Validate StartDate
            if (!IsValidStartDate(startDate)) FailerResult(UpdateMembershipOperationResult.InvalidData);

            // Validate Member
            int memberID = (int)drMembership["MemberID"];

            DataRow drMember = MembersData.GetByID(memberID);

            if (!(bool)drMember["IsActive"]) FailerResult(UpdateMembershipOperationResult.NotActiveMember);

            // Validate Plan
            DataRow drPlan = PlansData.GetByID(planID);

            if (drPlan == null) FailerResult(UpdateMembershipOperationResult.NotExistPlan);

            if (!(bool)drPlan["IsActive"]) FailerResult(UpdateMembershipOperationResult.NotActivePlan);

            DateTime endDate = startDate.AddDays((int)drPlan["DurationInDays"]);

            if (IsMembershipOverlappingExcluding(membershipID, memberID, startDate, endDate)) FailerResult(UpdateMembershipOperationResult.OverlappedMembership); ;


            bool updated = MembershipsData.Update(membershipID, planID, startDate, PlansData.GetPlanPrice(planID));

            if (!updated) FailerResult(UpdateMembershipOperationResult.Failed);

            return new OperationResult<UpdateMembershipOperationResult, bool>(UpdateMembershipOperationResult.Success, true);
        }
    }
}