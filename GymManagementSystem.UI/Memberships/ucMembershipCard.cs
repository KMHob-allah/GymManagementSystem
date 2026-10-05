using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Members;
using GymManagementSystem.UI.Plans;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class ucMembershipCard : UserControl
    {
        private Membership _membership;

        public Membership Membership
        {
            get => _membership;
        }

        public ucMembershipCard()
        {
            InitializeComponent();
        }


        public void LoadMembership(Membership membership)
        {
            if (membership == null)
            {
                _SetDefaultValues();
                _membership = null;
                return;
            }

            _membership = membership;

            lblMembershipIDValue.Text = membership.MembershipID.ToString();

            lblMemberNameValue.Text = membership.MemberInfo.FullName;

            lblPlanNameValue.Text = membership.PlanInfo.Name;

            lblStartDateValue.Text = membership.StartDate.ToString("yyyy/MM/dd");
            
            lblEndDateValue.Text = membership.EndDate.ToString("yyyy/MM/dd");
            
            lblTotalAmountValue.Text = membership.TotalAmount.ToString();

            _EnableLinks(true, true, true, true);
        }

        private void _SetDefaultValues()
        {
            lblMembershipIDValue.Text = "???";

            lblMemberNameValue.Text = "???";

            lblPlanNameValue.Text = "???";

            lblStartDateValue.Text = "???";

            lblEndDateValue.Text = "???";

            lblTotalAmountValue.Text = "???";

            _EnableLinks(false, false, false, false);

        }

        private void _EnableLinks(
            bool EnableAttendanceHistory,
            bool EnablePaymentHistory,
            bool EnableMemberDetails,
            bool EnablePlanDetails)
        {
            lnklblAttendanceHistory.Enabled = EnableAttendanceHistory;
            lnklblPaymentHistory.Enabled = EnablePaymentHistory;
            lnklblMemberDetails.Enabled = EnableMemberDetails;
            lnklblPlanDetails.Enabled = EnablePlanDetails;
        }

        private void lnklblPaymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Show Payment History
        }

        private void lnklblAttendanceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // TODO: Show Attendance History
        }

        private void lnklblMemberDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (var frm = new frmMemberDetails(_membership.MemberInfo))
            {
                frm.ShowDialog();
            }
        }

        private void lnklblPlanDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new frmPlanDetails(_membership.PlanInfo))
            {
                frm.ShowDialog();
            }

        }
    }
}
