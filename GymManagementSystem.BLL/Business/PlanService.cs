using GymManagementSystem.BLL.Common;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Business
{
    public enum PlanOperationResultCode
        {
            Success,
            InvalidData,
            Failed
        }

    public static class PlanService
    {
        // TODO: Authorization
        // TODO: Audit Logging
        // TODO: Exceptions

        // Functions to validate will be here
        
        public static DataTable GetAll()
        {
            return PlansData.GetAll();
        }

        public static Plan GetByID(int planID)
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

        public static OperationResult<PlanOperationResultCode, int> CreatePlan(string planName,
            int durationInDays, float price, bool isActive)
        {
            // Calling functions to validate will be here

            int? planID = PlansData.Create(planName, durationInDays, price, isActive);

            if (!planID.HasValue)
            {
                return new OperationResult<PlanOperationResultCode, int>(
                    PlanOperationResultCode.Failed);
            }

            return new OperationResult<PlanOperationResultCode, int>(
                PlanOperationResultCode.Success,
                planID.Value);
        }

        public static OperationResult<PlanOperationResultCode, bool> UpdatePlan(int planID,string planName,
            int durationInDays, float price)
        {            
            // Validations will be here 

            bool updated = PlansData.Update(planID, planName, durationInDays, price);

            if (!updated)
            {
                return new OperationResult<PlanOperationResultCode, bool>
                    (PlanOperationResultCode.Failed, false);
            }

            return new OperationResult<PlanOperationResultCode, bool>(
                PlanOperationResultCode.Success, true);
        }

        public static bool ActivatePlan(int planID)
        {
            return PlansData.Activate(planID);
        }

        public static bool DeactivatePlan(int planID)
        {
            return PlansData.Deactivate(planID);
        }

        public static float? GetPlanPrice(int planID)
        {
            return PlansData.GetPlanPrice(planID);
        }
    }
}
