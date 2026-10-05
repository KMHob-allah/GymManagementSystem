using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class frmMembershipDetails : Form
    {
        private readonly Membership _Membership;

        public frmMembershipDetails(Membership Membership)
        {
            InitializeComponent();

            _Membership = Membership;
        }

        private void frmMembershipDetails_Load(object sender, EventArgs e)
        {
            ucMembershipCard1.LoadMembership(_Membership);
        }
    }
}
