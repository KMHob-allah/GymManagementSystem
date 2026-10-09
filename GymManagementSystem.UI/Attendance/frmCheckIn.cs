using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Attendance
{
    public partial class frmCheckIn : Form
    {
        public event EventHandler CheckInSaved;

        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            ucMembershipFinder1.FilteringEnabled = true;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!ucMembershipFinder1.HasSelectedMembership)
            {
                MessageBox.Show(
                    "Please select a membership.",
                    "Membership Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Membership membership =
                ucMembershipFinder1.SelectedMembership;

            BLL.Entities.Attendance attendance =
                new BLL.Entities.Attendance();

            attendance.MembershipID =
                membership.MembershipID;

            BLL.Entities.Attendance.eSaveResult result =
                attendance.Save();

            switch (result)
            {
                case BLL.Entities.Attendance.eSaveResult.Success:

                    MessageBox.Show(
                        "Member checked in successfully.",
                        "Check-in Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CheckInSaved?.Invoke(this, EventArgs.Empty);

                    AuditLogger.Log("Create", "Attendance", attendance.AttendanceID);
                    Close();

                    break;

                case BLL.Entities.Attendance.eSaveResult.MemberNotActive:

                    MessageBox.Show(
                        "The member is not active.",
                        "Check-in Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    break;

                case BLL.Entities.Attendance.eSaveResult.MembershipNotValid:

                    MessageBox.Show(
                        "The membership is not valid for check-in.",
                        "Check-in Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    break;

                case BLL.Entities.Attendance.eSaveResult.Unauthorized:

                    MessageBox.Show(
                        "You do not have permission to perform this action.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    break;

                case BLL.Entities.Attendance.eSaveResult.Failed:

                    MessageBox.Show(
                        "Failed to check in member.",
                        "Check-in Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    break;
            }
        }
    }


}
