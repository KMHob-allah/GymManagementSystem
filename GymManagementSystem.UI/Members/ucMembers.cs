using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.BLL.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Members
{
    public partial class ucMembers : UserControl
    {
        private enum eFilterBy
        {
            None,
            MemberID,
            Name,
            Status,
            Gender,
            Area
        }

        private DataView _dvMembers;
        private bool _isUpdatingFilterUI;

        public ucMembers()
        {
            InitializeComponent();
        }


        private void _SetHeaderText()
        {
            if (dgvMembers.Columns.Contains("MemberID"))
                dgvMembers.Columns["MemberID"].HeaderText = "Member ID";

            if (dgvMembers.Columns.Contains("FullName"))
                dgvMembers.Columns["FullName"].HeaderText = "Name";

            if (dgvMembers.Columns.Contains("PhoneNumber"))
                dgvMembers.Columns["PhoneNumber"].HeaderText = "Phone Number";

            if (dgvMembers.Columns.Contains("Gender"))
                dgvMembers.Columns["Gender"].HeaderText = "Gender";

            if (dgvMembers.Columns.Contains("Area"))
                dgvMembers.Columns["Area"].HeaderText = "Area";

            if (dgvMembers.Columns.Contains("Status"))
                dgvMembers.Columns["Status"].HeaderText = "Status";
        }
        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "None",
                "Member ID",
                "Name",
                "Status",
                "Gender",
                "Area"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }
        private void _RefreshRecordsCount()
        {
            int count = _dvMembers?.Count ?? 0;

            lblRecords.Text = $"Records : {count}";
        }
        private void _UpdateCards()
        {
            if (_dvMembers?.Table == null)
                return;

            DataTable table = _dvMembers.Table;

            ucAllMembersCard.Number =
                table.Rows.Count.ToString();

            if (!table.Columns.Contains("Status"))
            {
                ucActiveMembersCard.Number = "0";
                ucInactiveMembersCard.Number = "0";
                return;
            }

            int activeCount =
                table.Select("Status = 'Active'").Length;

            int inactiveCount =
                table.Select("Status = 'Inactive'").Length;

            ucActiveMembersCard.Number =
                activeCount.ToString();

            ucInactiveMembersCard.Number =
                inactiveCount.ToString();
        }
        private void _UpdateEmptyState()
        {
            if (_dvMembers?.Table == null)
            {
                lblNoRecords.Text = "No members found.";
                lblNoRecords.Visible = true;
                return;
            }

            bool noData = _dvMembers.Table.Rows.Count == 0;

            bool noFilterResults = _dvMembers.Table.Rows.Count > 0 && _dvMembers.Count == 0;

            if (noData)
            {
                lblNoRecords.Text = "No members found.";
                lblNoRecords.Visible = true;
            }

            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No members match the selected filters.";

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

                    case eFilterBy.MemberID:
                    case eFilterBy.Name:
                    case eFilterBy.Area:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

                        break;

                    case eFilterBy.Status:

                        _LoadStatusValues();
                        cbFilterValue.Visible = true;
                        cbFilterValue.Focus();

                        break;

                    case eFilterBy.Gender:

                        _LoadGenderValues();
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

        private void _LoadMembers()
        {
            DataTable members = Member.GetAll();           

            _dvMembers = members.DefaultView;

            dgvMembers.DataSource = _dvMembers;
            
            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();

        }

        private void ucMembers_Load(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.View"))
            {
                Enabled = false;
                return;
            }

            _InitializeFilters();
            _ApplyPermissions();
            _LoadMembers();
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
        private void _LoadGenderValues()
        {
            cbFilterValue.Items.AddRange(new object[]
            {
                "All",
                "Male",
                "Female"
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
            if (_dvMembers == null) return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:
                    _ClearFilter();
                    break;

                case eFilterBy.MemberID:
                    _FilterByMemberID();
                    break;

                case eFilterBy.Name:
                    _FilterByText("FullName");
                    break;

                case eFilterBy.Area:
                    _FilterByText("Area");
                    break;

                case eFilterBy.Status:
                    _FilterByStatus();
                    break;

                case eFilterBy.Gender:
                    _FilterByGender();
                    break;
            }

            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void _ClearFilter()
        {
            _dvMembers.RowFilter = string.Empty;
        }
        private void _FilterByMemberID()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            _dvMembers.RowFilter = $"MemberID = {value}";
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

            _dvMembers.RowFilter =
                $"{columnName} LIKE '{value}%'";
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

            string isActive = (selectedValue == "Active" ? "Active" : "Inactive");

            _dvMembers.RowFilter = $"Status = '{isActive}'";
        }
        private void _FilterByGender()
        {
            string selectedValue =
                cbFilterValue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedValue) ||
                selectedValue == "All")
            {
                _ClearFilter();
                return;
            }            

            _dvMembers.RowFilter = $"Gender = '{selectedValue}'";
        }

        private string _EscapeFilterValue(string value)
        {
            return value.Replace("'", "''");
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ConfigureFilterControls();
            _ApplyCurrentFilter();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_GetSelectedFilter() != eFilterBy.MemberID) return;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cmsMembers_Opening(object sender, CancelEventArgs e)
        {
            int? memberID = _GetSelectedMemberID();

            if (!memberID.HasValue)
            {
                e.Cancel = true;
                return;
            }

            bool isActive = dgvMembers.CurrentRow.Cells["Status"].Value?.ToString() == "Active";

            bool canView = _HasPermission("Members.View");

            bool canUpdate = _HasPermission("Members.Update");

            bool canActivate = _HasPermission("Members.Activate") && !isActive;

            bool canDeactivate = _HasPermission("Members.Deactivate") && isActive;

            showDetailsToolStripMenuItem.Available = canView;
            editToolStripMenuItem.Available = canUpdate;
            activateToolStripMenuItem.Available = canActivate;
            deactivateToolStripMenuItem.Available = canDeactivate;

            if (!canView && !canUpdate && !canActivate && !canDeactivate)
            {
                e.Cancel = true;
            }
        }

        private int? _GetSelectedMemberID()
        {
            if (dgvMembers.CurrentRow == null) return null;

            DataGridViewCell cell = dgvMembers.CurrentRow.Cells[0];

            if (cell?.Value == null || cell.Value == DBNull.Value) return null;            

            return Convert.ToInt32(cell.Value);
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.Activate")) return;

            int? memberID = _GetSelectedMemberID();

            if (!memberID.HasValue) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to activate this member?",
                "Confirm Activation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Member member = Member.GetMemberByID(memberID.Value);

            if (member == null)
            {
                MessageBox.Show("Member not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!member.Activate())
            {
                MessageBox.Show("Failed to activate member.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Member activated successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            AuditLogger.Log("Activate", "Members", member.MemberID);

            _LoadMembers();
        }
        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.Deactivate"))  return;

            int? memberID = _GetSelectedMemberID();

            if (!memberID.HasValue) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this member?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            Member member = Member.GetMemberByID(memberID.Value);

            if (member == null)
            {
                MessageBox.Show("Member not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!member.Deactivate())
            {
                MessageBox.Show("Failed to deactivate member.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Member deactivated successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            AuditLogger.Log("Dectivate", "Members", member.MemberID);

            _LoadMembers();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.View")) return;

            int? memberID = _GetSelectedMemberID();

            if (!memberID.HasValue)
                return;

            Member member = Member.GetMemberByID(memberID.Value);

            if (member == null)
            {
                MessageBox.Show("Member not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            using (var frm = new frmMemberDetails(member))
            {
                frm.ShowDialog();
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.Update")) return;

            int? memberID = _GetSelectedMemberID();

            if (!memberID.HasValue) return;

            Member member = Member.GetMemberByID(memberID.Value);

            if (member == null) return;

            using (frmAddEditMember frm = new frmAddEditMember(member))
            {
                frm.MemberSaved += Frm_MemberSaved;

                frm.ShowDialog();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (!_RequirePermission("Members.Create")) return;

            using (frmAddEditMember frm = new frmAddEditMember())
            {
                frm.MemberSaved += Frm_MemberSaved;

                frm.ShowDialog();
            }
        }
        private void Frm_MemberSaved(object sender, EventArgs e)
        {
            _LoadMembers();
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
            btnAddMember.Visible =
                _HasPermission("Members.Create");
        }
    }
}