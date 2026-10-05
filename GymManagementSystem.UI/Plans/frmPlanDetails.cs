using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Memberships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class frmPlanDetails : Form
    {      
        private readonly Plan _Plan;

        public frmPlanDetails(Plan plan)
        {
            InitializeComponent();

            _Plan = plan;
        }

        private void frmPlanDetails_Load(object sender, EventArgs e)
        {
            ucPlanCard1.LoadPlan(_Plan);
        }
    }
}
