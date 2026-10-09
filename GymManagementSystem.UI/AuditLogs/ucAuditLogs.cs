using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using GymManagementSystem.BLL.Security;

namespace GymManagementSystem.UI.AuditLogs
{
    public partial class ucAuditLogs : UserControl
    {
        private enum eFilterBy
        {
            None,
            UserName,
            ActionType,
            TableName,
            CreatedDate
        }

        private DataView _dvAuditLogs;
        private bool _isUpdatingFilterUI;

        public ucAuditLogs()
        {
            InitializeComponent();
        }

        private void _SetHeaderText()
        {
            if (dgvAuditLogs.Columns.Contains("AuditLogID"))
                dgvAuditLogs.Columns["AuditLogID"].HeaderText =
                    "Audit Log ID";

            if (dgvAuditLogs.Columns.Contains("UserID"))
                dgvAuditLogs.Columns["UserID"].Visible = false;

            if (dgvAuditLogs.Columns.Contains("UserName"))
                dgvAuditLogs.Columns["UserName"].HeaderText =
                    "User Name";

            if (dgvAuditLogs.Columns.Contains("ActionType"))
                dgvAuditLogs.Columns["ActionType"].HeaderText =
                    "Action Type";

            if (dgvAuditLogs.Columns.Contains("TableName"))
                dgvAuditLogs.Columns["TableName"].HeaderText =
                    "Table Name";

            if (dgvAuditLogs.Columns.Contains("RecordID"))
                dgvAuditLogs.Columns["RecordID"].HeaderText =
                    "Record ID";

            if (dgvAuditLogs.Columns.Contains("CreatedAt"))
            {
                dgvAuditLogs.Columns["CreatedAt"].HeaderText =
                    "Created At";

                dgvAuditLogs.Columns["CreatedAt"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy hh:mm tt";
            }
        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "None",
                "User Name",
                "Action Type",
                "Table Name",
                "Created Date"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
            dtpFilterDate.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count =
               _dvAuditLogs?.Count ?? 0;

            lblRecords.Text =
                $"Records : {count}";
        }
        private void _UpdateCards()
        {
            if (_dvAuditLogs?.Table == null)
                return;

            DataTable table =
                _dvAuditLogs.Table;

            ucAllAuditLogsCard.Number =
                table.Rows.Count.ToString();

            int todayCount = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["CreatedAt"] == DBNull.Value)
                    continue;

                DateTime createdAt =
                    Convert.ToDateTime(
                        row["CreatedAt"]);

                if (createdAt.Date == DateTime.Today)
                    todayCount++;
            }

            ucTodayAuditLogsCard.Number =
                todayCount.ToString();
        }
        private void _UpdateEmptyState()
        {
            if (_dvAuditLogs?.Table == null)
            {
                lblNoRecords.Text =
                    "No Logs found.";

                lblNoRecords.Visible = true;

                return;
            }

            bool noData =
                _dvAuditLogs.Table.Rows.Count == 0;

            bool noFilterResults =
                _dvAuditLogs.Table.Rows.Count > 0 &&
                _dvAuditLogs.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No Logs found.";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No Logs match the selected filters.";

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

                    case eFilterBy.UserName:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.ActionType:

                        _LoadActionTypeValues();

                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;

                    case eFilterBy.TableName:

                        _LoadTableNameValues();

                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;

                    case eFilterBy.CreatedDate:

                        dtpFilterDate.Value =
                            DateTime.Today;

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

        private void _LoadActionTypeValues()
        {
            cbFilterValue.Items.Add("All");

            cbFilterValue.Items.AddRange(new object[]
            {
                "Create",
                "Update",
                "Activate",
                "Deactivate",
                "Login",
                "Logout"
            });

            cbFilterValue.SelectedIndex = 0;
        }
        private void _LoadTableNameValues()
        {
            cbFilterValue.Items.Add("All");

            cbFilterValue.Items.AddRange(new object[]
            {
        "Users",
        "Members",
        "Memberships",
        "Payments",
        "Attendance",
        "Plans"
            });

            cbFilterValue.SelectedIndex = 0;
        }

        private void _LoadAuditLogs()
        {
            DataTable auditLogs =
                AuditLog.GetAll();

            _dvAuditLogs =
                auditLogs.DefaultView;

            dgvAuditLogs.DataSource =
                _dvAuditLogs;

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void ucAuditLogs_Load(object sender, EventArgs e)
        {
            if (!_RequirePermission("AuditLogs.View"))
            {
                Enabled = false;
                return;
            }

            _InitializeFilters();
            _LoadAuditLogs();
            _SetHeaderText();
        }

        private void _ResetFilterControls()
        {
            tbFilterValue.Clear();

            cbFilterValue.Items.Clear();
            cbFilterValue.SelectedIndex = -1;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
            dtpFilterDate.Visible = false;
        }

        private void FilterData(object sender,EventArgs e)
        {
            if (_isUpdatingFilterUI)
                return;

            _ApplyCurrentFilter();
        }
        private void _ApplyCurrentFilter()
        {
            if (_dvAuditLogs == null)
                return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:

                    _ClearFilter();

                    break;

                case eFilterBy.UserName:

                    _FilterByText("UserName");

                    break;

                case eFilterBy.ActionType:

                    _FilterByComboBox("ActionType");

                    break;

                case eFilterBy.TableName:

                    _FilterByComboBox("TableName");

                    break;  

                case eFilterBy.CreatedDate:

                    _FilterByCreatedDate();

                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void _ClearFilter()
        {
            _dvAuditLogs.RowFilter =
                string.Empty;
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

            value =
                _EscapeFilterValue(value);

            _dvAuditLogs.RowFilter =
                $"{columnName} LIKE '{value}%'";
        }
        private void _FilterByCreatedDate()
        {
            DateTime selectedDate =
                dtpFilterDate.Value.Date;

            DateTime nextDate =
                selectedDate.AddDays(1);

            _dvAuditLogs.RowFilter =
                $"CreatedAt >= #{selectedDate:MM/dd/yyyy}# " +
                $"AND CreatedAt < #{nextDate:MM/dd/yyyy}#";
        }
        private string _EscapeFilterValue(string value)
        {
            return value.Replace(
                "'",
                "''");
        }
        private void _FilterByComboBox(string columnName)
        {
            string selectedValue =
                cbFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedValue) ||
                selectedValue == "All")
            {
                _ClearFilter();
                return;
            }

            selectedValue =
                _EscapeFilterValue(selectedValue);

            _dvAuditLogs.RowFilter =
                $"{columnName} = '{selectedValue}'";
        }

        private void cbFilterBy_SelectedIndexChanged(object sender,EventArgs e)
        {
            _ConfigureFilterControls();

            _ApplyCurrentFilter();
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
    }
}