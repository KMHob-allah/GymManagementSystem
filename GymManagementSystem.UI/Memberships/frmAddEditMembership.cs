using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class frmAddEditMembership : Form
    {            
        public enum eMode
        {
            Add,
            Update
        }

        private bool _isChangingTab;
        private readonly eMode _mode;
        private readonly Membership _membership;

        public event EventHandler MembershipSaved;


        public frmAddEditMembership()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _membership = new Membership();
        }

        public frmAddEditMembership(Membership membership)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _membership = membership;
        }

        private void frmAddEditMembership_Load(object sender, EventArgs e)
        {
            ucMemberFinder1.MemberSelected += UcMemberFinder1_MemberSelected;
            ucPlanFinder1.PlanSelected += UcPlanFinder1_PlanSelected;

            _InitializeForm();
        }

        private void _InitializeForm()
        {
            if (_mode == eMode.Add)
                _InitializeAddMode();

            else
                _InitializeUpdateMode();

            tcInfo.SelectedIndex = 0;

            dtpStartDate.MinDate = DateTime.Today;

            _UpdateNavigationButtons();
        }

        private void _InitializeAddMode()
        {
            lblMembershipIDValue.Text = "[A/N]";

            ucMemberFinder1.FilteringEnabled = true;
            ucPlanFinder1.FilteringEnabled = true;

            _SetMembershipInformationDefaultValues();
        }

        private void _InitializeUpdateMode()
        {
            Text = "Edit Membership";
            lblTitle.Text = "Edit Membership";

            lblMembershipIDValue.Text =
                _membership.MembershipID.ToString();

            // Member: selected + filter locked
            ucMemberFinder1.LoadMember(_membership.MemberInfo);
            ucMemberFinder1.FilteringEnabled = false;

            // Plan: selected + filter remains enabled
            ucPlanFinder1.LoadPlan(_membership.PlanInfo);
            ucPlanFinder1.FilteringEnabled = true;

            dtpStartDate.Value = _membership.StartDate;

            _UpdateMembershipInformation();
        }

        private void _SetMembershipInformationDefaultValues()
        {
            lblMemberNameValue.Text = "???";
            lblPlanNameValue.Text = "???";
            lblTotalAmountValue.Text = "???";

            dtpEndDate.Value = dtpStartDate.Value;
        }

        private void _UpdateMembershipInformation()
        {
            if (!ucMemberFinder1.HasSelectedMember ||
                !ucPlanFinder1.HasSelectedPlan)
            {
                return;
            }

            Member member = ucMemberFinder1.SelectedMember;
            Plan plan = ucPlanFinder1.SelectedPlan;

            lblMemberNameValue.Text = member.FullName;

            lblPlanNameValue.Text = plan.Name;

            lblTotalAmountValue.Text =
                plan.Price.ToString("0.00");

            _CalculateEndDate();
        }

        private void _CalculateEndDate()
        {
            if (!ucPlanFinder1.HasSelectedPlan) return;

            Plan plan = ucPlanFinder1.SelectedPlan;

            dtpEndDate.Value = dtpStartDate.Value.AddDays(plan.DurationInDays - 1);
        }

        private void UcMemberFinder1_MemberSelected(object sender, EventArgs e)
        {
            if (!ucMemberFinder1.HasSelectedMember) return;

            lblMemberNameValue.Text = ucMemberFinder1.SelectedMember.FullName;
        }

        private void UcPlanFinder1_PlanSelected(object sender, EventArgs e)
        {
            if (!ucPlanFinder1.HasSelectedPlan)
                return;

            Plan plan = ucPlanFinder1.SelectedPlan;

            lblPlanNameValue.Text = plan.Name;

            lblTotalAmountValue.Text =
                plan.Price.ToString("0.00");

            _CalculateEndDate();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateEndDate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcInfo.SelectedIndex <= 0)
                return;

            _ChangeTab(tcInfo.SelectedIndex - 1);

            _UpdateNavigationButtons();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (tcInfo.SelectedIndex)
            {
                case 0:

                    if (!ucMemberFinder1.HasSelectedMember)
                    {
                        MessageBox.Show(
                            "Please select a member first.",
                            "Member Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    _ChangeTab(1);
                    break;

                case 1:

                    if (!ucPlanFinder1.HasSelectedPlan)
                    {
                        MessageBox.Show(
                            "Please select a plan first.",
                            "Plan Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    _UpdateMembershipInformation();

                    _ChangeTab(2);
                    break;
            }

            _UpdateNavigationButtons();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ucMemberFinder1.HasSelectedMember || !ucPlanFinder1.HasSelectedPlan)
            {
                return;
            }

            try
            {
                _FillMembershipInfo();

                Membership.eSaveResult result = _membership.Save();

                if (result == Membership.eSaveResult.Success)
                {
                    MessageBox.Show(
                        "Membership saved successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MembershipSaved?.Invoke(this, EventArgs.Empty);

                    if(_mode == eMode.Add)
                        AuditLogger.Log("Create", "Memberships", _membership.MembershipID);

                    else
                        AuditLogger.Log("Update", "Memberships", _membership.MembershipID);


                    Close();
                }

                else _ShowSaveResult(result);                
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An error occurred while saving. Please try again later.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void _ChangeTab(int index)
        {
            _isChangingTab = true;

            try
            {
                tcInfo.SelectedIndex = index;
            }
            finally
            {
                _isChangingTab = false;
            }
        }

        private void _UpdateNavigationButtons()
        {
            btnBack.Enabled = tcInfo.SelectedIndex > 0;

            btnNext.Visible = tcInfo.SelectedIndex < 2;

            btnSave.Visible = tcInfo.SelectedIndex == 2;
        }

        private void _FillMembershipInfo()
        {
            _membership.MemberID =
                ucMemberFinder1.SelectedMember.MemberID;

            _membership.PlanID =
                ucPlanFinder1.SelectedPlan.ID;

            _membership.StartDate =
                dtpStartDate.Value.Date;

            _membership.EndDate =
                dtpEndDate.Value.Date;

            _membership.TotalAmount =
                ucPlanFinder1.SelectedPlan.Price;
        }


        private void _ShowSaveResult(Membership.eSaveResult result)
        {
            string message = "Failed to save membership.";

            switch (result)
            {
                case Membership.eSaveResult.InactiveMember:
                    message = "The selected member is inactive.";
                    break;

                case Membership.eSaveResult.InactivePlan:
                    message = "The selected plan is inactive.";
                    break;

                case Membership.eSaveResult.OverlappingMembership:
                    message = "The member already has an overlapping membership.";
                    break;

                case Membership.eSaveResult.HasOutstandingDebt:
                    message = "The member has outstanding debt.";
                    break;

                case Membership.eSaveResult.MembershipExpired:
                    message = "The membership has already expired.";
                    break;

                case Membership.eSaveResult.HasPayments:
                    message = "This membership has payments and cannot be updated.";
                    break;

                case Membership.eSaveResult.HasAttendance:
                    message = "This membership has attendance records and cannot be updated.";
                    break;

                case Membership.eSaveResult.Unauthorized:
                    message = "You do not have permission to perform this action.";
                    break;
            }

            MessageBox.Show(
                message,
                result == Membership.eSaveResult.Unauthorized
                    ? "Access Denied"
                    : "Save Failed",
                MessageBoxButtons.OK,
                result == Membership.eSaveResult.Unauthorized
                    ? MessageBoxIcon.Warning
                    : MessageBoxIcon.Warning);
        }

        private void tcInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_isChangingTab)
                return;

            e.Cancel = true;
        }
    }
}