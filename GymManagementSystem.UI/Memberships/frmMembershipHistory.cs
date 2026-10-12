
using GymManagementSystem.BLL.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class frmMembershipHistory : Form
    {
        private readonly Membership _membership;

        public frmMembershipHistory(Membership membership)
        {
            if (membership == null)
                throw new ArgumentNullException(nameof(membership));

            InitializeComponent();

            _membership = membership;           
        }

        private void _InitializeDataGrids()
        {
            dgvAttendance.Visible = false;
            dgvPayments.Visible = false;

            dgvAttendance.AutoGenerateColumns = true;
            dgvPayments.AutoGenerateColumns = true;
        }

        private void CustomSegmentedControl1_SelectedItemChanged(
            object sender, EventArgs e)
        {
            _UpdateHistoryView();
        }

        private void _UpdateHistoryView()
        {
            bool showAttendance =
                customSegmentedControl1.SelectedIndex == 0;

            dgvAttendance.Visible = showAttendance;
            dgvPayments.Visible = !showAttendance;

            lblNoAttendance.Visible = false;
            lblNoPayments.Visible = false;

            if (showAttendance)
                _LoadAttendanceHistory(_membership.MembershipID);
            else
                _LoadPaymentHistory(_membership.MembershipID);
        }

        private void _LoadAttendanceHistory(int membershipID)
        {
            DataTable attendance =
                BLL.Entities.Attendance.GetByMembershipID(membershipID);

            dgvAttendance.DataSource = attendance;

            lblNoAttendance.Visible =
                attendance == null || attendance.Rows.Count == 0;

            _ConfigureAttendanceColumns();
        }

        private void _LoadPaymentHistory(int membershipID)
        {
            DataTable payments =
                Payment.GetByMembershipID(membershipID);

            dgvPayments.DataSource = payments;

            lblNoPayments.Visible =
                payments == null || payments.Rows.Count == 0;

            _ConfigurePaymentColumns();
        }

        private void _ConfigureAttendanceColumns()
        {
            if (dgvAttendance.Columns.Contains("AttendanceID"))

            if (dgvAttendance.Columns.Contains("MembershipID"))
                dgvAttendance.Columns["MembershipID"].Visible = false;

            if (dgvAttendance.Columns.Contains("CheckInDateTime"))
            {
                dgvAttendance.Columns["CheckInDateTime"].HeaderText =
                    "Check-In Date & Time";

                dgvAttendance.Columns["CheckInDateTime"]
                    .DefaultCellStyle.Format = "dd MMM yyyy hh:mm tt";
            }
        }

        private void _ConfigurePaymentColumns()
        {
            if (dgvPayments.Columns.Contains("PaymentID"))

            if (dgvPayments.Columns.Contains("MembershipID"))
                dgvPayments.Columns["MembershipID"].Visible = false;

            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"].HeaderText = "Amount";
                dgvPayments.Columns["Amount"]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"].HeaderText =
                    "Payment Date";

                dgvPayments.Columns["PaymentDate"]
                    .DefaultCellStyle.Format = "dd MMM yyyy hh:mm tt";
            }
        }

        private void frmMembershipHistory_Load(object sender, EventArgs e)
        {
            ucMembershipCard1.LoadMembership(_membership);
            ucMembershipCard1.EnableLinks(false, false, false);
            customSegmentedControl1.SelectedItemChanged +=
                CustomSegmentedControl1_SelectedItemChanged;

            _InitializeDataGrids();
            _UpdateHistoryView();
        }
    }
}
