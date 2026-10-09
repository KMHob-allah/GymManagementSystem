using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using GymManagementSystem.BLL.Security;

namespace GymManagementSystem.UI.Payments
{
    public partial class ucPayments : UserControl
    {
        private enum eFilterBy
        {
            None,
            MemberName,
            MembershipID,
            PaymentDate,
            CreatedBy
        }

        private DataView _dvPayments;
        private bool _isUpdatingFilterUI;

        public ucPayments()
        {
            InitializeComponent();
        }

        private void _SetHeaderText()
        {
            if (dgvPayments.Columns.Contains("PaymentID"))
                dgvPayments.Columns["PaymentID"].HeaderText = "Payment ID";

            if (dgvPayments.Columns.Contains("MembershipID"))
                dgvPayments.Columns["MembershipID"].HeaderText = "Membership ID";

            if (dgvPayments.Columns.Contains("MemberName"))
                dgvPayments.Columns["MemberName"].HeaderText = "Member";

            if (dgvPayments.Columns.Contains("Amount"))
                dgvPayments.Columns["Amount"].HeaderText = "Amount";

            if (dgvPayments.Columns.Contains("PaymentDate"))
                dgvPayments.Columns["PaymentDate"].HeaderText = "Payment Date";

            if (dgvPayments.Columns.Contains("CreatedByUserID"))
                dgvPayments.Columns["CreatedByUserID"].HeaderText = "Created By ID";

            if (dgvPayments.Columns.Contains("CreatedByUserName"))
                dgvPayments.Columns["CreatedByUserName"].HeaderText = "Created By";
        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "None",
                "Member Name",
                "Membership ID",
                "Payment Date",
                "Created By"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            dtpFilterDate.Value = DateTime.Today;

            tbFilterValue.Visible = false;
            dtpFilterDate.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count = _dvPayments?.Count ?? 0;

            lblRecords.Text = $"Records : {count}";
        }

        private void _UpdateCards()
        {
            DataRow row = Payment.GetSummary();

            if (row == null)
                return;

            decimal totalPaid =
                Convert.ToDecimal(row["TotalPaid"]);

            decimal outstandingDebt =
                Convert.ToDecimal(row["OutstandingDebt"]);

            decimal todayRevenue =
                Convert.ToDecimal(row["TodayRevenue"]);

            ucTotalRevenueCard.Number =
                totalPaid.ToString("N2");

            ucTotalDebtCard.Number =
                outstandingDebt.ToString("N2");

            ucTodayRevenue.Number =
                todayRevenue.ToString("N2");
        }
        private void _UpdateEmptyState()
        {
            if (_dvPayments?.Table == null)
            {
                lblNoRecords.Text = "No payments found.";
                lblNoRecords.Visible = true;
                return;
            }

            bool noData =
                _dvPayments.Table.Rows.Count == 0;

            bool noFilterResults =
                _dvPayments.Table.Rows.Count > 0 &&
                _dvPayments.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No payments found.";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No payments match the selected filter.";

                lblNoRecords.Visible = true;
            }
            else
            {
                lblNoRecords.Visible = false;
            }
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

                    case eFilterBy.MemberName:
                    case eFilterBy.MembershipID:
                    case eFilterBy.CreatedBy:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.PaymentDate:

                        dtpFilterDate.Value = DateTime.Today;
                        dtpFilterDate.Visible = true;
                        dtpFilterDate.Focus();

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
            if (cbFilterBy.SelectedIndex < 0)
                return eFilterBy.None;

            return (eFilterBy)cbFilterBy.SelectedIndex;
        }

        private void _LoadPayments()
        {
            DataTable payments =
                Payment.GetAll();

            _dvPayments =
                payments.DefaultView;

            dgvPayments.DataSource =
                _dvPayments;

            if (dgvPayments.Columns.Contains("CreatedByUserID"))
                dgvPayments.Columns["CreatedByUserID"].Visible = false;

            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"]
                    .DefaultCellStyle.Format =
                    "yyyy/MM/dd HH:mm";
            }

            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"]
                    .DefaultCellStyle.Format =
                    "N2";
            }

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void ucPayments_Load(object sender, EventArgs e)
        {
            if (!_RequirePermission("Payments.View"))
            {
                Enabled = false;
                return;
            }

            _InitializeFilters();
            _ApplyPermissions();
            _LoadPayments();
            _SetHeaderText();
        }

        private void _ResetFilterControls()
        {
            tbFilterValue.Clear();

            tbFilterValue.Visible = false;
            dtpFilterDate.Visible = false;

        }
        private void FilterData(object sender, EventArgs e)
        {
            if (_isUpdatingFilterUI)
                return;

            _ApplyCurrentFilter();
        }

        private void _ApplyCurrentFilter()
        {
            if (_dvPayments == null)
                return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:
                    _ClearFilter();
                    break;

                case eFilterBy.MemberName:
                    _FilterByText("MemberName");
                    break;

                case eFilterBy.MembershipID:
                    _FilterByMembershipID();
                    break;

                case eFilterBy.PaymentDate:
                    _FilterByPaymentDate();
                    break;

                case eFilterBy.CreatedBy:
                    _FilterByText("CreatedByUserName");
                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void _ClearFilter()
        {
            _dvPayments.RowFilter = string.Empty;
        }
        private void _FilterByMembershipID()
        {
            string value =
                tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            if (!int.TryParse(value, out int membershipID))
            {
                _ClearFilter();
                return;
            }

            _dvPayments.RowFilter =
                $"MembershipID = {membershipID}";
        }
        private void _FilterByText(string columnName)
        {
            string value =
                tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            value = _EscapeFilterValue(value);

            _dvPayments.RowFilter =
                $"{columnName} LIKE '{value}%'";
        }
        private void _FilterByPaymentDate()
        {
            DateTime date = dtpFilterDate.Value.Date;

            DateTime nextDay = date.AddDays(1);

            string start =
                date.ToString("MM/dd/yyyy HH:mm:ss");

            string end =
                nextDay.ToString("MM/dd/yyyy HH:mm:ss");

            _dvPayments.RowFilter =
                $"PaymentDate >= #{start}# AND " +
                $"PaymentDate < #{end}#";
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
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_GetSelectedFilter() !=
                eFilterBy.MembershipID)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cmsPayments_Opening(object sender, CancelEventArgs e)
        {
            int? paymentID = _GetSelectedPaymentID();

            if (!paymentID.HasValue)
            {
                e.Cancel = true;
                return;
            }

            bool canView =
                _HasPermission("Payments.View");

            bool canUpdate =
                _HasPermission("Payments.Update");

            showDetailsToolStripMenuItem.Available = canView;
            updateAmountToolStripMenuItem.Available = canUpdate;

            if (!canView && !canUpdate)
            {
                e.Cancel = true;
            }
        }
        private int? _GetSelectedPaymentID()
        {
            if (dgvPayments.CurrentRow == null)
                return null;

            DataGridViewCell cell =
                dgvPayments.CurrentRow.Cells[0];

            if (cell?.Value == null ||
                cell.Value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(cell.Value);
        }

        private void btnAddPayment_Click(object sender,EventArgs e)
        {
            if (!_RequirePermission("Payments.Create")) return;

            using (frmAddEditPayment frm = new frmAddEditPayment())
            {
                frm.PaymentSaved += Frm_PaymentSaved;

                frm.ShowDialog();
            }
        }
        private void showDetailsToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if (!_RequirePermission("Payments.View")) return;

            int? paymentID =
                _GetSelectedPaymentID();

            if (!paymentID.HasValue)
                return;

            Payment payment =
                Payment.GetByID(paymentID.Value);

            if (payment == null)
            {
                MessageBox.Show(
                    "Payment not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (frmPaymentDetails frm = new frmPaymentDetails(payment))
            {
                frm.ShowDialog();
            }
        }
        private void editToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if (!_RequirePermission("Payments.Update")) return;

            int? paymentID =
                _GetSelectedPaymentID();

            if (!paymentID.HasValue)
                return;

            Payment payment =
                Payment.GetByID(paymentID.Value);

            if (payment == null)
                return;

            using (frmAddEditPayment frm = new frmAddEditPayment(payment))
            {
                frm.PaymentSaved += Frm_PaymentSaved;

                frm.ShowDialog();
            }
        }

        private void Frm_PaymentSaved(object sender,EventArgs e)
        {
            _LoadPayments();
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
            btnAddPayment.Visible =
                _HasPermission("Payments.Create");
        }
    }
}