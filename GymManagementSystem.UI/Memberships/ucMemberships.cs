using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Members;
using GymManagementSystem.BLL.Security;
using System;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class ucMemberships : UserControl
    {
        private enum eFilterBy
        {
            None,
            MembershipID,
            PlanName,
            MembershipStatus,
            PaymentStatus
        }

        private DataView _dvMemberships;
        private bool _isUpdatingFilterUI;

        public ucMemberships()
        {
            InitializeComponent();
        }

        private void _HideInternalColumns()
        {
            if (dgvMemberships.Columns.Contains("MemberID"))
                dgvMemberships.Columns["MemberID"].Visible = false;

            if (dgvMemberships.Columns.Contains("PlanID"))
                dgvMemberships.Columns["PlanID"].Visible = false;

        }

        private void _SetHeaderText()
        {
            if (dgvMemberships.Columns.Contains("MembershipID"))
                dgvMemberships.Columns["MembershipID"].HeaderText = "Membership ID";

            if (dgvMemberships.Columns.Contains("PlanName"))
                dgvMemberships.Columns["PlanName"].HeaderText = "Plan Name";

            if (dgvMemberships.Columns.Contains("StartDate"))
                dgvMemberships.Columns["StartDate"].HeaderText = "Start Date";

            if (dgvMemberships.Columns.Contains("EndDate"))
                dgvMemberships.Columns["EndDate"].HeaderText = "End Date";

            if (dgvMemberships.Columns.Contains("TotalAmount"))
                dgvMemberships.Columns["TotalAmount"].HeaderText = "Total Amount";

            if (dgvMemberships.Columns.Contains("PaidAmount"))
                dgvMemberships.Columns["PaidAmount"].HeaderText = "Paid Amount";

            if (dgvMemberships.Columns.Contains("RemainingAmount"))
                dgvMemberships.Columns["RemainingAmount"].HeaderText = "Remaining Amount";

            if (dgvMemberships.Columns.Contains("MembershipStatus"))
                dgvMemberships.Columns["MembershipStatus"].HeaderText = "Membership Status";

            if (dgvMemberships.Columns.Contains("PaymentStatus"))
                dgvMemberships.Columns["PaymentStatus"].HeaderText = "Payment Status";

        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
            "None",
            "Membership ID",
            "Plan Name",
            "Membership Status",
            "Payment Status"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count = _dvMemberships?.Count ?? 0;

            lblRecords.Text = $"Records : {count}";
        }
        private void _UpdateCards()
        {
            if (_dvMemberships?.Table == null) return;

            DataTable table = _dvMemberships.Table;

            ucAllMembershipsCard.Number = table.Rows.Count.ToString();

            if (!table.Columns.Contains("MembershipStatus"))
            {
                ucActiveMembershipsCard.Number = "0";
                ucExpiredMembershipsCard.Number = "0";
                ucUpcomingMembershipsCard.Number = "0";
                return;
            }

            int activeCount = table.Select("MembershipStatus = 'Active'").Length;

            int expiredCount = table.Select("MembershipStatus = 'Expired'").Length;

            int upcomingCount = table.Select("MembershipStatus = 'Upcoming'").Length;

            ucActiveMembershipsCard.Number = activeCount.ToString();

            ucExpiredMembershipsCard.Number = expiredCount.ToString();

            ucUpcomingMembershipsCard.Number = upcomingCount.ToString();
        }
        private void _UpdateEmptyState()
        {
            if (_dvMemberships?.Table == null)
            {
                lblNoRecords.Text = "No memberships found.";
                lblNoRecords.Visible = true;
                return;
            }

            bool noData = _dvMemberships.Table.Rows.Count == 0;

            bool noFilterResults = _dvMemberships.Table.Rows.Count > 0 && _dvMemberships.Count == 0;

            if (noData)
            {
                lblNoRecords.Text = "No memberships found.";
                lblNoRecords.Visible = true;
            }

            else if (noFilterResults)
            {
                lblNoRecords.Text = "No memberships match the selected filters.";

                lblNoRecords.Visible = true;
            }

            else lblNoRecords.Visible = false;            
        }
        private void _ConfigureFilterControls()
        {
            _isUpdatingFilterUI = true;

            try
            {
                _ResetFilterControls();

                switch (_GetSelectedFilter())
                {
                    case eFilterBy.None:
                        break;

                    case eFilterBy.MembershipID:
                    case eFilterBy.PlanName:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.MembershipStatus:

                        _LoadMembershipStatusValues();
                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;

                    case eFilterBy.PaymentStatus:

                        _LoadPaymentStatusValues();
                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;
                }
            }

            finally
            {
                _isUpdatingFilterUI = false;
            }
        }
        private eFilterBy _GetSelectedFilter()
        {
            if (cbFilterBy.SelectedIndex < 0) return eFilterBy.None;

            return (eFilterBy)cbFilterBy.SelectedIndex;
        }

        private void _LoadMemberships()
        {
            DataTable memberships = Membership.GetAll();

            _dvMemberships = memberships.DefaultView;

            dgvMemberships.DataSource = _dvMemberships;

            dgvMemberships.Columns["StartDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            dgvMemberships.Columns["EndDate"].DefaultCellStyle.Format = "yyyy/MM/dd";

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void ucMemberships_Load(object sender, EventArgs e)
        {
            if (!_RequirePermission("Memberships.View"))
            {
                Enabled = false;
                return;
            }

            _InitializeFilters();
            _ApplyPermissions();
            _LoadMemberships();
            _SetHeaderText();
            _HideInternalColumns();

        }

        private void _ResetFilterControls()
        {
            tbFilterValue.Clear();

            cbFilterValue.Items.Clear();
            cbFilterValue.SelectedIndex = -1;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }
        private void _LoadMembershipStatusValues()
        {
            cbFilterValue.Items.AddRange(new object[]
            {
            "All",
            "Upcoming",
            "Active",
            "Expired"
            });

            cbFilterValue.SelectedIndex = 0;
        }
        private void _LoadPaymentStatusValues()
        {
            cbFilterValue.Items.AddRange(new object[]
            {
            "All",
            "Paid",
            "Partially Paid",
            "Unpaid"
            });

            cbFilterValue.SelectedIndex = 0;
        }
        private void FilterData(object sender, EventArgs e)
        {
            if (_isUpdatingFilterUI) return;

            _ApplyCurrentFilter();
        }

        private void _ApplyCurrentFilter()
        {
            if (_dvMemberships == null) return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:
                    _ClearFilter();
                    break;

                case eFilterBy.MembershipID:
                    _FilterByMembershipID();
                    break;               

                case eFilterBy.PlanName:
                    _FilterByText("PlanName");
                    break;

                case eFilterBy.MembershipStatus:
                    _FilterByMembershipStatus();
                    break;

                case eFilterBy.PaymentStatus:
                    _FilterByPaymentStatus();
                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void _ClearFilter()
        {
            _dvMemberships.RowFilter = string.Empty;
        }
        private void _FilterByMembershipID()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            _dvMemberships.RowFilter =
                $"MembershipID = {value}";
        }
        private void _FilterByText(string columnName)
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            value = _EscapeFilterValue(value);

            _dvMemberships.RowFilter =
                $"{columnName} LIKE '{value}%'";

        }
        private void _FilterByMembershipStatus()
        {
            string selectedValue =
                cbFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedValue) ||
                selectedValue == "All")
            {
                _ClearFilter();
                return;
            }

            _dvMemberships.RowFilter =
                $"MembershipStatus = '{_EscapeFilterValue(selectedValue)}'";
        }
        private void _FilterByPaymentStatus()
        {
            string selectedValue =
                cbFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedValue) ||
                selectedValue == "All")
            {
                _ClearFilter();
                return;
            }

            _dvMemberships.RowFilter =
                $"PaymentStatus = '{_EscapeFilterValue(selectedValue)}'";
        }

        private string _EscapeFilterValue(string value)
        {
            return value.Replace("'", "''");
        }

        private void cbFilterBy_SelectedIndexChanged(object sender,EventArgs e)
        {
            _ConfigureFilterControls();
            _ApplyCurrentFilter();
        }
        private void tbFilterValue_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (_GetSelectedFilter() != eFilterBy.MembershipID)
                return;

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int? _GetSelectedMembershipID()
        {
            if (dgvMemberships.CurrentRow == null) return null;

            DataGridViewCell cell = dgvMemberships.CurrentRow.Cells[0];

            if (cell?.Value == null || cell.Value == DBNull.Value) return null;

            return Convert.ToInt32(cell.Value);
        }

        private void cmsMemberships_Opening(object sender, CancelEventArgs e)
        {
            int? membershipID = _GetSelectedMembershipID();

            if (!membershipID.HasValue)
            {
                e.Cancel = true;
                return;
            }

            bool canView = _HasPermission("Memberships.View");

            bool canUpdate = _HasPermission("Memberships.Update");

            showDetailsToolStripMenuItem.Available = canView;
            editToolStripMenuItem.Available = canUpdate;

            if (!canView && !canUpdate)
            {
                e.Cancel = true;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Memberships.View")) return;

            int? membershipID = _GetSelectedMembershipID();

            if (!membershipID.HasValue)
                return;

            Membership membership = Membership.GetByID(membershipID.Value);

            if (membership == null)
            {
                MessageBox.Show("Membership not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var frm = new frmMembershipDetails(membership))
            {
                frm.ShowDialog();
            }
        }
        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Memberships.Create")) return;

            using (frmAddEditMembership frm = new frmAddEditMembership())
            {
                frm.MembershipSaved += Frm_MembershipSaved;

                frm.ShowDialog();
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Memberships.Update")) return;

            int? membershipID = _GetSelectedMembershipID();

            if (!membershipID.HasValue)
                return;

            Membership membership = Membership.GetByID(membershipID.Value);

            if (membership == null)
            {
                MessageBox.Show(
                    "Membership not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (frmAddEditMembership frm = new frmAddEditMembership(membership))
            {
                frm.MembershipSaved += Frm_MembershipSaved;

                frm.ShowDialog();
            }
        }

        private void Frm_MembershipSaved(object sender, EventArgs e)
        {
            _LoadMemberships();
        }

        private bool _HasPermission(string permissionName)
        {
            return PermissionManager.HasPermission(permissionName);
        }
        private bool _RequirePermission(string permissionName)
        {
            if (_HasPermission(permissionName))
                return true;

            MessageBox.Show(
                "You do not have permission to perform this action.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }
        private void _ApplyPermissions()
        {
            btnAddMembership.Visible =
                _HasPermission("Memberships.Create");
        }
    }
}
