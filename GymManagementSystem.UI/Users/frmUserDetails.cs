using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Plans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Users
{
    public partial class frmUserDetails : Form
    {
        private readonly User _User;

        public frmUserDetails(User user)
        {
            InitializeComponent();

            _User = user;
        }

        private void frmPlanDetails_Load(object sender, EventArgs e)
        {
            ucUserCard1.LoadUser(_User);
        }
    }
}
