using GymManagementSystem.BLL.Common;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Business
{
    public enum PlanResult
    {
        Success,
        InvalidData,
        DuplicateName,
        Failed
    }

    public abstract class PlanService
    {
        // TODO: Authorization
        // TODO: Audit Logging
        // TODO: Exceptions

        private bool IsValidPlanName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        private bool IsValidPrice(float price)
        {
            return price >= 0;
        }

        private bool IsValidDuration(int duration)
        {
            return duration > 0;
        }

        private bool IsPlanNameExists(string name)
        {
            return PlansData.IsPlanNameExists(name);
        }

        private bool IsPlanNameExistsForOtherPlan(string name, int planID)
        {
            return PlansData.IsPlanNameExistsForOtherPlan(name, planID);
        }
        
        private OperationResult<PlanResult, int> CreateFailerResult(PlanResult Result)
        {
            return new OperationResult<PlanResult, int> (Result);
        }

        private OperationResult<PlanResult, bool> UpdateFailerResult(PlanResult Result)
        {
            return new OperationResult<PlanResult, bool>(Result);
        }


        public DataTable GetAll()
        {
            return PlansData.GetAll();
        }

        public Plan GetByID(int planID)
        {
            DataRow row = PlansData.GetByID(planID);

            if (row == null) return null;

            return new Plan(
                (int)row["PlanID"],
                (string)row["PlanName"],
                (int)row["DurationInDays"],
                (float)row["Price"],
                (bool)row["IsActive"]
            );
        }

        public OperationResult<PlanResult, int> CreatePlan(string planName, int durationInDays, float price, bool isActive)
        {

            if (!IsValidPlanName(planName)) CreateFailerResult(PlanResult.InvalidData);

            if (!IsValidDuration(durationInDays)) CreateFailerResult(PlanResult.InvalidData);

            if (!IsValidPrice(price)) CreateFailerResult(PlanResult.InvalidData);

            if (IsPlanNameExists(planName)) CreateFailerResult(PlanResult.DuplicateName);


            int? planID = PlansData.Create(planName, durationInDays, price, isActive);

            if (!planID.HasValue) CreateFailerResult(PlanResult.Failed);            

            return new OperationResult<PlanResult, int>(PlanResult.Success, planID.Value);
        }

        public  OperationResult<PlanResult, bool> UpdatePlan(int planID,string planName, int durationInDays, float price)
        {

            if (!IsValidPlanName(planName)) UpdateFailerResult(PlanResult.InvalidData);

            if (!IsValidDuration(durationInDays)) UpdateFailerResult(PlanResult.InvalidData);

            if (!IsValidPrice(price)) UpdateFailerResult(PlanResult.InvalidData);

            if (IsPlanNameExistsForOtherPlan(planName, planID)) UpdateFailerResult(PlanResult.DuplicateName);


            bool updated = PlansData.Update(planID, planName, durationInDays, price);

            if (!updated) UpdateFailerResult(PlanResult.Failed);

            return new OperationResult<PlanResult, bool>(PlanResult.Success, true);
        }

        public bool ActivatePlan(int planID)
        {
            return PlansData.Activate(planID);
        }

        public bool DeactivatePlan(int planID)
        {
            return PlansData.Deactivate(planID);
        }


        public float? GetPlanPrice(int planID)
        {
            return PlansData.GetPlanPrice(planID);
        }
    }
}
