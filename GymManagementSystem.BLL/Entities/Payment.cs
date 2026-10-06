using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class Payment
    {
        public enum eSaveResult
        {
            Success,
            AmountExceedsRemaining,
            Failed
        }

        private Membership _membership;
        //private User _createdByUser;

        public int PaymentID { get; set; }
        public int MembershipID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CreatedByUserID { get; set; }

        public Membership MembershipInfo
        {
            get
            {
                if (_membership == null)
                {
                    _membership = Membership.GetByID(MembershipID);
                }

                return _membership;
            }
        }

        //public User CreatedByUserInfo
        //{
        //    get
        //    {
        //        if (_createdByUser == null)
        //            _createdByUser = User.GetByID(CreatedByUserID);

        //        return _createdByUser;
        //    }
        //}
            
        public Payment(
            int paymentID,
            int membershipID,
            decimal amount,
            DateTime paymentDate,
            int createdByUserID)
        {
            PaymentID = paymentID;
            MembershipID = membershipID;
            Amount = amount;
            PaymentDate = paymentDate;
            CreatedByUserID = createdByUserID;
        }

        public Payment()
        {
            PaymentID = 0;
            MembershipID = 0;
            Amount = 0;
            PaymentDate = DateTime.MinValue;
            CreatedByUserID = 0;
        }

        public static DataTable GetAll() => PaymentsData.GetAll();        

        public static Payment GetByID(int paymentID)
        {
            DataRow row = PaymentsData.GetByID(paymentID);

            if (row == null)
                return null;

            return new Payment(
                (int)row["PaymentID"],
                (int)row["MembershipID"],
                (decimal)row["Amount"],
                (DateTime)row["PaymentDate"],
                (int)row["CreatedByUserID"]
            );
        }

        public static DataTable GetByMembershipID(int membershipID)
        {
            return PaymentsData.GetByMembershipID(membershipID);    
        }

        public eSaveResult Save()
        {             
            if (Amount > MembershipInfo.GetRemainingAmount()) return eSaveResult.AmountExceedsRemaining;

            int? paymentID = PaymentsData.Create(MembershipID,Amount,CreatedByUserID);

            if (paymentID.HasValue)
            {
                PaymentID = paymentID.Value;
                return eSaveResult.Success;
            }

            return eSaveResult.Failed;
        }

        public eSaveResult UpdateAmount(decimal newAmount)
        {                       
            decimal remainingAmountForUpdate = MembershipInfo.GetRemainingAmount() + Amount;

            if (newAmount > remainingAmountForUpdate) return eSaveResult.AmountExceedsRemaining;

            if (!PaymentsData.UpdateAmount(PaymentID, newAmount)) return eSaveResult.Failed;

            Amount = newAmount;

            return eSaveResult.Success;
        }

        public static DataRow GetSummary()
        {
            return PaymentsData.GetSummary();
        }

    }
}