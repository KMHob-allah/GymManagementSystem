using GymManagementSystem.BLL.Common;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.DAL;
using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace GymManagementSystem.BLL.Services
{
    public enum MembershipOperationResultCode
    {
        Success,
        InvalidData,
        NotExistPlan,
        NotExistMember,
        NotActiveMember,        
        NotActivePlan,
        ActiveMembershipAlreadyExists,
        OverlappedMembership,
        OutstandingDebt,
        Failed

    }

    public static class MembershipService
    {
        public static DataTable GetAll()
        {
            return MembershipsData.GetAll();
        }

        public static Membership GetByID(int membershipID)
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

        public static Membership GetActiveMembershipByMemberID(int memberID)
        {
            DataRow row = MembershipsData.GetActiveMembershipByMemberID(memberID);

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

        public static OperationResult<MembershipOperationResultCode,int> CreateMembership(
            int memberID, int planID, DateTime startDate)
        {
            DataRow drMember = MembersData.GetByID(memberID);

            if(drMember == null) return new OperationResult<MembershipOperationResultCode,int>(
                MembershipOperationResultCode.NotExistMember);

            if (!(bool)drMember["IsActive"])
                return new OperationResult<MembershipOperationResultCode, int>(
                MembershipOperationResultCode.NotActiveMember);


            DataRow drPlan = PlansData.GetByID(planID);

            if (drPlan == null) return new OperationResult<MembershipOperationResultCode, int>(
                MembershipOperationResultCode.NotExistPlan);

            if (!(bool)drPlan["IsActive"])
                return new OperationResult<MembershipOperationResultCode, int>(
               MembershipOperationResultCode.NotActivePlan);

            if(startDate < DateTime.Today) return new OperationResult<MembershipOperationResultCode, int>(
               MembershipOperationResultCode.InvalidData);

            DataRow drActiveMembership = MembershipsData.GetActiveMembershipByMemberID(memberID);

            if (drActiveMembership != null && IsDateBetweenTwoDates((DateTime)drActiveMembership["StartDate"]), (DateTime))
            
                return new OperationResult<MembershipOperationResultCode, int>(
                    MembershipOperationResultCode.ActiveMembershipAlreadyExists);                           

            if()

                return new OperationResult<MembershipOperationResultCode, int>(
                    MembershipOperationResultCode.OutstandingDebt);


            int? membershipID = MembershipsData.Create(memberID, planID, startDate, PlansData.GetPlanPrice(planID));

            if (!membershipID.HasValue)
            {
                return new OperationResult<MembershipOperationResultCode, int>(
                    MembershipOperationResultCode.Failed);
            }

            return new OperationResult<MembershipOperationResultCode, int>(
                MembershipOperationResultCode.Success,
                membershipID.Value);
        }

        public static OperationResult<MembershipOperationResultCode, bool> UpdateMembership(
            int membershipID, int memberID, int planID, DateTime startDate)
        {          
            bool updated = MembershipsData.Update(membershipID, memberID, planID, startDate, PlansData.GetPlanPrice(planID));

            if (!updated)
            {
                return new OperationResult<MembershipOperationResultCode, bool>(
                    MembershipOperationResultCode.Failed, false);
            }

            return new OperationResult<MembershipOperationResultCode, bool>(
                MembershipOperationResultCode.Success, true);
        }
    }
}