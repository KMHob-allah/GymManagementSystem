using GymManagementSystem.BLL.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI
{
    public partial class ucDashboard : UserControl
    {
        private enum eExpiringWithin
        {
            TenDays,
            SevenDays,
            FiveDays,
            ThreeDays
        }

        private DataView _dvExpiringMemberships;
        private bool _isUpdatingFilterUI;

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void _InitializeFilter()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "10 Days",
                "7 Days",
                "5 Days",
                "3 Days"
            });

            cbFilterBy.SelectedIndex =
                (int)eExpiringWithin.TenDays;
        }
        private void _SetHeaderText()
        {
            if (dgvMemberships.Columns.Contains("MembershipID"))
                dgvMemberships.Columns["MembershipID"].HeaderText =
                    "Membership ID";

            if (dgvMemberships.Columns.Contains("MemberName"))
                dgvMemberships.Columns["MemberName"].HeaderText =
                    "Member Name";

            if (dgvMemberships.Columns.Contains("PlanName"))
                dgvMemberships.Columns["PlanName"].HeaderText =
                    "Plan";

            if (dgvMemberships.Columns.Contains("EndDate"))
            {
                dgvMemberships.Columns["EndDate"].HeaderText =
                    "End Date";

                dgvMemberships.Columns["EndDate"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvMemberships.Columns.Contains("RemainingDays"))
                dgvMemberships.Columns["RemainingDays"].HeaderText =
                    "Remaining Days";
        }
        private void _UpdateSummaryCards()
        {
            DashboardSummary summary =
                Dashboard.GetSummary();

            if (summary == null)
            {
                ucActiveMembershipsCard.Number = "0";
                ucTodaysAttendance.Number = "0";
                ucCurrentDebtsCard.Number = "0.00 EGP";
                ucTodaysRevenueCard.Number = "0.00 EGP";

                return;
            }

            ucActiveMembershipsCard.Number =
                summary.ActiveMemberships.ToString();

            ucTodaysAttendance.Number =
                summary.TodaysAttendance.ToString();

            ucCurrentDebtsCard.Number =
                $"{summary.CurrentDebt:N2} EGP";

            ucTodaysRevenueCard.Number =
                $"{summary.TodaysRevenue:N2} EGP";
        }
        private void _LoadExpiringMemberships()
        {
            DataTable memberships =
                Dashboard.GetExpiringMemberships();

            _dvExpiringMemberships =
                memberships.DefaultView;

            dgvMemberships.DataSource =
                _dvExpiringMemberships;

            _ApplyExpiringMembershipsFilter();

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void _RefreshRecordsCount()
        {
            int count =
                _dvExpiringMemberships?.Count ?? 0;

            lblRecords.Text =
                $"Records : {count}";
        }

        private void _UpdateEmptyState()
        {
            if (_dvExpiringMemberships?.Table == null)
            {
                lblNoRecords.Text =
                    "No Memberships available at the moment";

                lblNoRecords.Visible = true;

                return;
            }

            bool noData =
                _dvExpiringMemberships.Table.Rows.Count == 0;

            bool noFilterResults =
                _dvExpiringMemberships.Table.Rows.Count > 0 &&
                _dvExpiringMemberships.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No Memberships available at the moment";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No Memberships match the selected period.";

                lblNoRecords.Visible = true;
            }
            else
            {
                lblNoRecords.Visible = false;
            }
        }
        private eExpiringWithin _GetSelectedExpiringWithin()
        {
            if (cbFilterBy.SelectedIndex < 0)
                return eExpiringWithin.TenDays;

            return (eExpiringWithin)cbFilterBy.SelectedIndex;
        }

        private int _GetSelectedDays()
        {
            switch (_GetSelectedExpiringWithin())
            {
                case eExpiringWithin.ThreeDays:
                    return 3;

                case eExpiringWithin.FiveDays:
                    return 5;

                case eExpiringWithin.SevenDays:
                    return 7;

                default:
                    return 10;
            }
        }

        private void _ApplyExpiringMembershipsFilter()
        {
            if (_dvExpiringMemberships == null)
                return;

            int days =
                _GetSelectedDays();

            _dvExpiringMemberships.RowFilter =
                $"RemainingDays <= {days}";

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void _LoadDashboard()
        {
            _UpdateSummaryCards();
            _LoadExpiringMemberships();
        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            _InitializeFilter();
            _LoadDashboard();
            _SetHeaderText();
        }

        private void cbFilterBy_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_isUpdatingFilterUI)
                return;

            _ApplyExpiringMembershipsFilter();
        }
    }
}