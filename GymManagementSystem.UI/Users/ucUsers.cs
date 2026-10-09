using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Users
{
    public partial class ucUsers : UserControl
    {
        private enum eFilterBy
        {
            None,
            UserName,
            Role,
            Status
        }

        private DataView _dvUsers;
        private bool _isUpdatingFilterUI;

        public ucUsers()
        {
            InitializeComponent();
        }

        private void _SetHeaderText()
        {
            if (dgvUsers.Columns.Contains("UserID"))
                dgvUsers.Columns["UserID"].HeaderText = "User ID";

            if (dgvUsers.Columns.Contains("UserName"))
                dgvUsers.Columns["UserName"].HeaderText = "Username";

            if (dgvUsers.Columns.Contains("RoleName"))
                dgvUsers.Columns["RoleName"].HeaderText = "Role";

            if (dgvUsers.Columns.Contains("IsActive"))
                dgvUsers.Columns["IsActive"].HeaderText = "Status";

            if (dgvUsers.Columns.Contains("RoleID"))
                dgvUsers.Columns["RoleID"].Visible = false;
        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "None",
                "User name",
                "Role",
                "Status"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count = _dvUsers?.Count ?? 0;

            lblRecords.Text = $"Records : {count}";
        }

        private void _UpdateCards()
        {
            if (_dvUsers?.Table == null)
                return;

            DataTable table = _dvUsers.Table;

            ucAllUsersCard.Number =
                table.Rows.Count.ToString();

            if (!table.Columns.Contains("IsActive"))
            {
                ucActiveUsersCard.Number = "0";
                ucInactiveUsersCard.Number = "0";
                return;
            }

            int activeCount =
                table.Select("IsActive = 'Active'").Length;

            int inactiveCount =
                table.Select("IsActive = 'Inactive'").Length;

            ucActiveUsersCard.Number =
                activeCount.ToString();

            ucInactiveUsersCard.Number =
                inactiveCount.ToString();
        }
        private void _UpdateEmptyState()
        {
            if (_dvUsers?.Table == null)
            {
                lblNoRecords.Text = "No users found.";
                lblNoRecords.Visible = true;
                return;
            }

            bool noData = _dvUsers.Table.Rows.Count == 0;

            bool noFilterResults = _dvUsers.Table.Rows.Count > 0 && _dvUsers.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No users found.";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No users match the selected filters.";

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

                    case eFilterBy.Role:

                        _LoadRoleValues();
                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;

                    case eFilterBy.Status:

                        _LoadStatusValues();
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
            if (cbFilterBy.SelectedIndex < 0)
                return eFilterBy.None;

            return (eFilterBy)cbFilterBy.SelectedIndex;
        }

        private void _LoadUsers()
        {
            DataTable users = User.GetAll();

            _dvUsers = users.DefaultView;

            dgvUsers.DataSource = _dvUsers;

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }
        private void ucUsers_Load(object sender, EventArgs e)
        {
            _InitializeFilters();
            _LoadUsers();
            _SetHeaderText();
        }

        private void _ResetFilterControls()
        {
            tbFilterValue.Clear();

            cbFilterValue.Items.Clear();
            cbFilterValue.SelectedIndex = -1;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }
        
        private void _LoadRoleValues()
        {
            cbFilterValue.Items.Add("All");

            cbFilterValue.Items.AddRange(new object[]
            {
                "Admin",
                "Receptionist"
            }); // issue : Must Downloaded from database, this must apply on the whole program and all sections

            cbFilterValue.SelectedIndex = 0;
        }
        private void _LoadStatusValues()
        {
            cbFilterValue.Items.AddRange(new object[]
            {
                "All",
                "Active",
                "Inactive"
            });

            cbFilterValue.SelectedIndex = 0;
        }

        private void FilterData(object sender, EventArgs e)
        {
            if (_isUpdatingFilterUI)
                return;

            _ApplyCurrentFilter();
        }
        private void _ApplyCurrentFilter()
        {
            if (_dvUsers == null)
                return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:
                    _ClearFilter();
                    break;

                case eFilterBy.UserName:
                    _FilterByText("UserName");
                    break;

                case eFilterBy.Role:
                    _FilterByRole();
                    break;

                case eFilterBy.Status:
                    _FilterByStatus();
                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void _ClearFilter()
        {
            _dvUsers.RowFilter = string.Empty;
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

            _dvUsers.RowFilter =
                $"{columnName} LIKE '{value}%'";
        }
        private void _FilterByRole()
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

            _dvUsers.RowFilter =
                $"RoleName = '{selectedValue}'";
        }
        private void _FilterByStatus()
        {
            string selectedValue =
                cbFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedValue) ||
                selectedValue == "All")
            {
                _ClearFilter();
                return;
            }

            _dvUsers.RowFilter =
                $"IsActive = '{selectedValue}'";
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
        private void cmsUsers_Opening(object sender,CancelEventArgs e)
        {
            int? userID = _GetSelectedUserID();

            if (!userID.HasValue)
            {
                e.Cancel = true;
                return;
            }

            string status =
                dgvUsers.CurrentRow.Cells["IsActive"]
                .Value.ToString();

            activateToolStripMenuItem.Enabled =
                status == "Inactive";

            deactivateToolStripMenuItem.Enabled =
                status == "Active";
        }

        private int? _GetSelectedUserID()
        {
            if (dgvUsers.CurrentRow == null)
                return null;

            DataGridViewCell cell =
                dgvUsers.CurrentRow.Cells["UserID"];

            if (cell?.Value == null ||
                cell.Value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(cell.Value);
        }

        private void activateToolStripMenuItem_Click(object sender,EventArgs e)
        {
            int? userID = _GetSelectedUserID();

            if (!userID.HasValue)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to activate this user?",
                "Confirm Activation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            User user =
                User.GetByID(userID.Value);

            if (user == null)
            {
                MessageBox.Show(
                    "User not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!user.Activate())
            {
                MessageBox.Show(
                    "Failed to activate user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


                return;
            }

            MessageBox.Show(
                "User activated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            AuditLogger.Log("Activate", "Users", GlobalSettings.CurrentUser.UserID);
            _LoadUsers();
        }
        private void deactivateToolStripMenuItem_Click(object sender,EventArgs e)
        {
            int? userID = _GetSelectedUserID();

            if (!userID.HasValue)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this user?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            User user =
                User.GetByID(userID.Value);

            if (user == null)
            {
                MessageBox.Show(
                    "User not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!user.Deactivate())
            {
                MessageBox.Show(
                    "Failed to deactivate user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "User deactivated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            AuditLogger.Log("Deactivate", "Users", GlobalSettings.CurrentUser.UserID);


            _LoadUsers();
        }
        private void showDetailsToolStripMenuItem_Click(object sender,EventArgs e)
        {
            int? userID = _GetSelectedUserID();

            if (!userID.HasValue)
                return;

            User user =
                User.GetByID(userID.Value);

            if (user == null)
            {
                MessageBox.Show(
                    "User not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var frm = new frmUserDetails(user))
            {
                frm.ShowDialog();
            }
        }
        private void editToolStripMenuItem_Click(object sender,EventArgs e)
        {
            int? userID = _GetSelectedUserID();

            if (!userID.HasValue)
                return;

            User user =
                User.GetByID(userID.Value);

            if (user == null)
                return;

            using (var frm = new frmAddEditUser(user))
            {
                frm.UserSaved += Frm_UserSaved;

                frm.ShowDialog();
            }
        }
        private void btnAddUser_Click(object sender,EventArgs e)
        {
            using (var frm = new frmAddEditUser())
            {
                frm.UserSaved += Frm_UserSaved;

                frm.ShowDialog();
            }
        }

        private void Frm_UserSaved(object sender,EventArgs e)
        {
            _LoadUsers();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int? userID = _GetSelectedUserID();

            User user = User.GetByID(userID.Value);

            if (user == null)
                return;

            using (var frm = new frmChangePassword(user))
            {
                frm.ShowDialog();
            }
        }
    }
}