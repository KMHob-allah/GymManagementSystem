using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class ucPlanCard : UserControl
    {
        private Plan _plan;

        public Plan Plan
        {
            get => _plan;
        }

        public ucPlanCard()
        {
            InitializeComponent();
        }

        public void LoadPlan(Plan plan)
        {
            if (plan == null)
            {
                _SetDefaultValues();
                _plan = null;
                return;
            }

            _plan = plan;

            lblPlanIDValue.Text = plan.ID.ToString();

            lblPlanNameValue.Text = plan.Name;

            lblDurationInDaysValue.Text =
                plan.DurationInDays.ToString();

            lblPriceValue.Text =
                plan.Price.ToString("0.00");

            lblStatusValue.Text =
                plan.IsActive ? "Active" : "Inactive";
        }

        private void _SetDefaultValues()
        {
            lblPlanIDValue.Text = "???";

            lblPlanNameValue.Text = "???";

            lblDurationInDaysValue.Text = "???";

            lblPriceValue.Text = "???";

            lblStatusValue.Text = "???";
        }
    }
}