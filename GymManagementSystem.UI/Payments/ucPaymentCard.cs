using GymManagementSystem.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Payments
{
    public partial class ucPaymentCard : UserControl
    {
        private Payment _payment;
       
        public Payment Payment
        {
            get => _payment;
        }

        public ucPaymentCard()
        {
            InitializeComponent();
        }

        public void LoadPayment(Payment payment)
        {
            if (payment == null)
            {
                _SetDefaultValues();
                payment = null;
                return;
            }

            _payment = payment;

            lblPaymentIDValue.Text = payment.PaymentID.ToString();

            lblMembershipIDValue.Text = payment.MembershipID.ToString();

            lblMemberNameValue.Text = payment.MembershipInfo.MemberInfo.FullName;

            lblPaymentDateValue.Text = payment.PaymentDate.ToString("yyyy/MM/dd ");

            lblAmountValue.Text = payment.Amount.ToString();

            lblCreatedByValue.Text = payment.CreatedByUserInfo.UserName;
        }

        private void _SetDefaultValues()
        {
            lblPaymentIDValue.Text = "???";

            lblMembershipIDValue.Text = "???";

            lblMemberNameValue.Text = "???";

            lblPaymentDateValue.Text = "???";

            lblAmountValue.Text = "???";

            lblCreatedByValue.Text = "???";
        }
    }
}
