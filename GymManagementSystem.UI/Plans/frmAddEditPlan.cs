using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class frmAddEditPlan : Form
    {
        public enum eMode { Add, Update }

        private readonly eMode _mode;
        private readonly Plan _plan;

        public event EventHandler PlanSaved;

        public frmAddEditPlan()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _plan = new Plan();
        }

        public frmAddEditPlan(Plan plan)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _plan = plan;
        }

        private void _InitializeForm()
        {
            if (_mode == eMode.Add)
                _SetDefaultValues();

            else
                _LoadPlanData();
        }

        private void _FillPlanInfo()
        {
            _plan.Name = tbPlanName.Text.Trim();
            _plan.DurationInDays = int.Parse(tbDurationInDays.Text.Trim());


            _plan.Price = decimal.Parse(
                tbPrice.Text.Trim().Replace(',', '.'),
                System.Globalization.CultureInfo.InvariantCulture);


            _plan.IsActive = ckbActive.Checked;
        }

        private void _SetDefaultValues()
        {
            lblPlanIDValue.Text = "[A/N]";

            tbPlanName.Text = string.Empty;
            tbDurationInDays.Text = string.Empty;
            tbPrice.Text = string.Empty;

            ckbActive.Checked = true;
        }

        private void _LoadPlanData()
        {
            lblPlanIDValue.Text = _plan.ID.ToString();

            tbPlanName.Text = _plan.Name;
            tbDurationInDays.Text = _plan.DurationInDays.ToString();
            tbPrice.Text = _plan.Price.ToString("0.00");

            ckbActive.Checked = _plan.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateAllInputs())
            {
                MessageBox.Show(
                    "Please fix the errors before saving.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                _FillPlanInfo();

                if (_plan.Save())
                {
                    MessageBox.Show(
                        "Plan saved successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    PlanSaved?.Invoke(this, EventArgs.Empty);

                    if(_mode == eMode.Add)
                        AuditLogger.Log("Create", "Plans", _plan.ID);
                    else
                        AuditLogger.Log("Update", "Plans", _plan.ID);

                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to save plan. Please try again.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An error occurred while saving. Please try again later.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditPlan_Load(object sender, EventArgs e)
        {
            _InitializeForm();
        }

        private void tbPlanName_Validating(object sender, CancelEventArgs e)
        {
            _ValidatePlanName();
        }

        private void tbDurationInDays_Validating(object sender, CancelEventArgs e)
        {
            _ValidateDurationInDays();
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            _ValidatePrice();
        }

        private bool _ValidatePlanName()
        {
            if (string.IsNullOrWhiteSpace(tbPlanName.Text.Trim()))
            {
                errpAddEditPlan.SetError(
                    tbPlanName,
                    "Plan name cannot be blank.");

                return false;
            }

            errpAddEditPlan.SetError(tbPlanName, string.Empty);
            return true;
        }

        private bool _ValidateDurationInDays()
        {
            if (!int.TryParse(tbDurationInDays.Text.Trim(), out int duration) ||
                duration <= 0)
            {
                errpAddEditPlan.SetError(
                    tbDurationInDays,
                    "Duration must be a positive number.");

                return false;
            }

            errpAddEditPlan.SetError(tbDurationInDays, string.Empty);
            return true;
        }

        private bool _ValidatePrice()
        {
            if (!decimal.TryParse(tbPrice.Text.Trim(), out decimal price) ||
                price <= 0)
            {
                errpAddEditPlan.SetError(
                    tbPrice,
                    "Price must be greater than zero.");

                return false;
            }

            errpAddEditPlan.SetError(tbPrice, string.Empty);
            return true;
        }

        private bool _ValidateAllInputs()
        {
            bool isPlanNameValid = _ValidatePlanName();
            bool isDurationValid = _ValidateDurationInDays();
            bool isPriceValid = _ValidatePrice();

            return
                isPlanNameValid &&
                isDurationValid &&
                isPriceValid;
        }

        private void tbDurationInDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (tbPrice.Text.Contains(".") || tbPrice.Text.Contains(","))
                    e.Handled = true;

                return;
            }

            e.Handled = true;
        }
    }
}