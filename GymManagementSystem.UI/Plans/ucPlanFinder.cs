using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class ucPlanFinder : UserControl
    {
        public event EventHandler PlanSelected;

        private bool _filteringEnabled = true;

        public Plan SelectedPlan
        {
            get => ucPlanCard1.Plan;
        }

        public bool HasSelectedPlan
        {
            get => SelectedPlan != null;
        }

        public bool FilteringEnabled
        {
            get => _filteringEnabled;
            set
            {
                _filteringEnabled = value;
                _SetFilteringEnabled();
            }
        }

        public ucPlanFinder()
        {
            InitializeComponent();

            _InitializeFilter();
            _SetFilteringEnabled();
            _ClearPlanCard();
        }

        private void _InitializeFilter()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.AddRange(new object[]
            {
                "Plan ID",
                "Plan Name"
            });

            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Clear();
        }

        private void _SetFilteringEnabled()
        {
            cbFilterBy.Enabled = _filteringEnabled;
            tbFilterValue.Enabled = _filteringEnabled;
            btnSearch.Enabled = _filteringEnabled;
        }

        private void _ClearPlanCard()
        {
            ucPlanCard1.LoadPlan(null);
        }

        private void _SearchPlan()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearPlanCard();
                return;
            }

            Plan plan = null;

            if (cbFilterBy.SelectedIndex == 0)
            {
                if (!int.TryParse(value, out int planID))
                {
                    _ClearPlanCard();

                    MessageBox.Show(
                        "Please enter a valid Plan ID.",
                        "Invalid Plan ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                plan = Plan.GetByID(planID);
            }
            else if (cbFilterBy.SelectedIndex == 1)
            {
                plan = Plan.GetByName(value);
            }

            if (plan == null)
            {
                _ClearPlanCard();

                MessageBox.Show(
                    "Plan not found.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ucPlanCard1.LoadPlan(plan);

            PlanSelected?.Invoke(this, EventArgs.Empty);
        }

        private void ucPlanFinder_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchPlan();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex != 0)
                return;

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFilterValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_ClearPlanCard();

            tbFilterValue.Clear();
            tbFilterValue.Focus();
        }

        public void LoadPlan(Plan plan)
        {
            if (plan == null)
            {
                _ClearPlanCard();
                return;
            }

            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Text = plan.ID.ToString();

            ucPlanCard1.LoadPlan(plan);

            PlanSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}