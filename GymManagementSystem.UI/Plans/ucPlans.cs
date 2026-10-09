using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class ucPlans : UserControl
    {
        private enum eFilterBy
        {
            None,
            PlanID,
            PlanName,
            Status
        }

        private DataView _dvPlans;
        private bool _isUpdatingFilterUI;

        public ucPlans()
        {
            InitializeComponent();
        }

        private void _SetHeaderText()
        {
            if (dgvPlans.Columns.Contains("PlanID"))
                dgvPlans.Columns["PlanID"].HeaderText = "Plan ID";

            if (dgvPlans.Columns.Contains("PlanName"))
                dgvPlans.Columns["PlanName"].HeaderText = "Plan Name";

            if (dgvPlans.Columns.Contains("DurationInDays"))
                dgvPlans.Columns["DurationInDays"].HeaderText = "Duration (Days)";

            if (dgvPlans.Columns.Contains("Price"))
                dgvPlans.Columns["Price"].HeaderText = "Price";

            if (dgvPlans.Columns.Contains("IsActive"))
                dgvPlans.Columns["IsActive"].HeaderText = "Status";
        }

        private void _InitializeFilters()
        {
            cbFilterBy.Items.AddRange(new object[]
            {
                "None",
                "Plan ID",
                "Plan Name",
                "Status"
            });

            cbFilterBy.SelectedIndex = (int)eFilterBy.None;

            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }

        private void _RefreshRecordsCount()
        {
            int count = _dvPlans?.Count ?? 0;

            lblRecords.Text = $"Records : {count}";
        }

        private void _UpdateCards()
        {
            if (_dvPlans?.Table == null)
                return;

            DataTable table = _dvPlans.Table;

            ucAllPlansCard.Number =
                table.Rows.Count.ToString();

            if (!table.Columns.Contains("Status"))
            {
                ucActivePlansCard.Number = "0";
                ucInactivePlansCard.Number = "0";
                return;
            }

            int activeCount =
                table.Select("Status = 'Active'").Length;

            int inactiveCount =
                table.Select("Status = 'Inactive'").Length;

            ucActivePlansCard.Number =
                activeCount.ToString();

            ucInactivePlansCard.Number =
                inactiveCount.ToString();
        }

        private void _UpdateEmptyState()
        {
            if (_dvPlans?.Table == null)
            {
                lblNoRecords.Text = "No plans found.";
                lblNoRecords.Visible = true;
                return;
            }

            bool noData =
                _dvPlans.Table.Rows.Count == 0;

            bool noFilterResults =
                _dvPlans.Table.Rows.Count > 0 &&
                _dvPlans.Count == 0;

            if (noData)
            {
                lblNoRecords.Text =
                    "No plans found.";

                lblNoRecords.Visible = true;
            }
            else if (noFilterResults)
            {
                lblNoRecords.Text =
                    "No plans match the selected filters.";

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

                    case eFilterBy.PlanID:
                    case eFilterBy.PlanName:

                        tbFilterValue.Visible = true;
                        tbFilterValue.Focus();

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

        private void _LoadPlans()
        {
            DataTable plans = Plan.GetAll();

            _dvPlans = plans.DefaultView;

            dgvPlans.DataSource = _dvPlans;

            _UpdateCards();
            _RefreshRecordsCount();
            _UpdateEmptyState();
        }

        private void ucPlans_Load(object sender, EventArgs e)
        {
            _InitializeFilters();
            _LoadPlans();
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

        private void FilterData(object sender, EventArgs e)
        {
            if (_isUpdatingFilterUI)
                return;

            _ApplyCurrentFilter();
        }

        private void _ApplyCurrentFilter()
        {
            if (_dvPlans == null)
                return;

            switch (_GetSelectedFilter())
            {
                case eFilterBy.None:
                    _ClearFilter();
                    break;

                case eFilterBy.PlanID:
                    _FilterByPlanID();
                    break;

                case eFilterBy.PlanName:
                    _FilterByText("PlanName");
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
            _dvPlans.RowFilter = string.Empty;
        }

        private void _FilterByPlanID()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearFilter();
                return;
            }

            _dvPlans.RowFilter = $"PlanID = {value}";
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

            _dvPlans.RowFilter =
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

            string isActive = selectedValue == "Active" ? "Active":"Inactive";

            _dvPlans.RowFilter =
                $"Status = '{isActive}'";
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
            if (_GetSelectedFilter() != eFilterBy.PlanID)
                return;

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmsPlans_Opening(object sender, CancelEventArgs e)
        {
            int? planID = _GetSelectedPlanID();

            if (!planID.HasValue)
            {
                e.Cancel = true;
                return;
            }

           string isActive = dgvPlans.CurrentRow.Cells["Status"].Value.ToString();

            activateToolStripMenuItem.Enabled = isActive == "Inactive";
            deactivateToolStripMenuItem.Enabled = isActive == "Active";
        }

        private int? _GetSelectedPlanID()
        {
            if (dgvPlans.CurrentRow == null)
                return null;

            DataGridViewCell cell =
                dgvPlans.CurrentRow.Cells["PlanID"];

            if (cell?.Value == null ||
                cell.Value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(cell.Value);
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? planID = _GetSelectedPlanID();

            if (!planID.HasValue)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to activate this plan?",
                "Confirm Activation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            Plan plan = Plan.GetByID(planID.Value);

            if (plan == null)
            {
                MessageBox.Show(
                    "Plan not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!plan.Activate())
            {
                MessageBox.Show(
                    "Failed to activate plan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "Plan activated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            AuditLogger.Log("Activate", "Plans", plan.ID);
            _LoadPlans();
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? planID = _GetSelectedPlanID();

            if (!planID.HasValue)
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this plan?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            Plan plan = Plan.GetByID(planID.Value);

            if (plan == null)
            {
                MessageBox.Show(
                    "Plan not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!plan.Deactivate())
            {
                MessageBox.Show(
                    "Failed to deactivate plan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "Plan deactivated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            AuditLogger.Log("Deactivate", "Plans", plan.ID);

            _LoadPlans();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? planID = _GetSelectedPlanID();

            if (!planID.HasValue)
                return;

            Plan plan = Plan.GetByID(planID.Value);

            if (plan == null)
            {
                MessageBox.Show(
                    "Plan not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var frm = new frmPlanDetails(plan))
            {
                frm.ShowDialog();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? planID = _GetSelectedPlanID();

            if (!planID.HasValue)
                return;

            Plan plan = Plan.GetByID(planID.Value);

            if (plan == null)
                return;

            using (var frm = new frmAddEditPlan(plan))
            {
                frm.PlanSaved += Frm_PlanSaved;

                frm.ShowDialog();
            }
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAddEditPlan())
            {
                frm.PlanSaved += Frm_PlanSaved;

                frm.ShowDialog();
            }
        }

        private void Frm_PlanSaved(object sender, EventArgs e)
        {
            _LoadPlans();
        }
    }
}