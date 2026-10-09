using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using GymManagementSystem.BLL.Security;

namespace GymManagementSystem.UI.Attendance
{
    public partial class ucAttendance : UserControl
    {
        private enum eFilterBy
        {
            None,
            AttendanceID,
            MemberName,
            CheckInDateTime
        }

        private DataView _dvAttendance;
        private bool _isUpdatingFilterUI;

        public ucAttendance()
        {
            InitializeComponent();
        }

        private void _SetHeaderText()
        {
            if (dgvAttendance.Columns.Contains("AttendanceID"))
                dgvAttendance.Columns["AttendanceID"].HeaderText = "Attendance ID";

            if (dgvAttendance.Columns.Contains("MembershipID"))
                dgvAttendance.Columns["MembershipID"].Visible = false;

            if (dgvAttendance.Columns.Contains("MemberName"))
                dgvAttendance.Columns["MemberName"].HeaderText = "Member Name";

            if (dgvAttendance.Columns.Contains("CheckInDateTime"))
            {
                dgvAttendance.Columns["CheckInDateTime"].HeaderText =
                    "Check-in Date & Time";

                dgvAttendance.Columns["CheckInDateTime"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy hh:mm tt";
            }
        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
        "None",
        "Attendance ID",
        "Member Name",
        "Check-in Date & Time"
            });

            cbFilterBy.SelectedIndex =
                (int)eFilterBy.None;

            tbFilterValue.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count = _dvAttendance?.Count ?? 0;

            lblRecords.Text =
                $"Records : {count}";
        }

        private void _UpdateCards()
        {
            if (_dvAttendance?.Table == null)
                return;

            DataTable table =
                _dvAttendance.Table;

            ucAllCheckinsCard.Number =
                table.Rows.Count.ToString();

            int todayCount = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row["CheckInDateTime"] == DBNull.Value)
                    continue;

                DateTime checkInDateTime =
                    Convert.ToDateTime(
                        row["CheckInDateTime"]);

                if (checkInDateTime.Date == DateTime.Today)
                    todayCount++;
            }

            ucTodayCheckinsCard.Number =
                todayCount.ToString();
        }
        private void _UpdateEmptyState()
        {
            if (_dvAttendance?.Table == null)
            {
                lblNoRecords.Text =
                    "No Check-ins found.";

                lblNoRecords.Visible = true;

                return;
            }

            bool noData =
                _dvAttendance.Table.Rows.Count == 0;

            bool noFilterResults =
                _dvAttendance.Table.Rows.Count > 0 &&
                _dvAttendance.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No Check-ins found.";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No Check-ins match the selected filters.";

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

                    case eFilterBy.AttendanceID:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.MemberName:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.CheckInDateTime:

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

        private void _LoadAttendance()
        {
            DataTable attendance = BLL.Entities.Attendance.GetAll();

            _dvAttendance =
                attendance.DefaultView;

            dgvAttendance.DataSource =
                _dvAttendance;

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void ucAttendance_Load(object sender, EventArgs e)
        {
            if (!_RequirePermission("Attendance.View"))
            {
                Enabled = false;
                return;
            }

            _InitializeFilters();
            _ApplyPermissions();
            _LoadAttendance();
            _SetHeaderText();
        }
        private void _ResetFilterControls()
        {
            tbFilterValue.Clear();

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
            if (_dvAttendance == null)
                return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:

                    _ClearFilter();

                    break;

                case eFilterBy.AttendanceID:

                    _FilterByAttendanceID();

                    break;

                case eFilterBy.MemberName:

                    _FilterByText("MemberName");

                    break;

                case eFilterBy.CheckInDateTime:

                    _FilterByCheckInDateTime();

                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void _ClearFilter()
        {
            _dvAttendance.RowFilter =
                string.Empty;
        }
        private void _FilterByAttendanceID()
        {
            string value =
                tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            if (!int.TryParse(value, out int attendanceID))
            {
                _ClearFilter();
                return;
            }

            _dvAttendance.RowFilter =
                $"AttendanceID = {attendanceID}";
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

            _dvAttendance.RowFilter =
                $"{columnName} LIKE '{value}%'";
        }
        private void _FilterByCheckInDateTime()
        {
            DateTime selectedDate =
                dtpFilterDate.Value.Date;

            DateTime nextDate =
                selectedDate.AddDays(1);

            _dvAttendance.RowFilter =
                $"CheckInDateTime >= #{selectedDate:MM/dd/yyyy}# " +
                $"AND CheckInDateTime < #{nextDate:MM/dd/yyyy}#";
        }

        private string _EscapeFilterValue(string value)
        {
            return value.Replace(
                "'",
                "''");
        }

        private void cbFilterBy_SelectedIndexChanged(object sender,EventArgs e)
        {
            _ConfigureFilterControls();
            _ApplyCurrentFilter();
        }
        private void tbFilterValue_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (_GetSelectedFilter() !=
                eFilterBy.AttendanceID)
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Attendance.Create"))
                return;

            using (var frm = new frmCheckIn())
            {
                frm.CheckInSaved += Frm_CheckInSaved;
                frm.ShowDialog();
            }
        }

        private void Frm_CheckInSaved(object sender, EventArgs e)
        {
            _LoadAttendance();
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
            btnCheckIn.Visible =
                _HasPermission("Attendance.Create");
        }

    }
}