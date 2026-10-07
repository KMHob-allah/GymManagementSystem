using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Plans
{
    public partial class ucUserCard : UserControl
    {
        private User _user;

        public User User
        {
            get => _user;
        }

        public ucUserCard()
        {
            InitializeComponent();
        }

        public void LoadUser(User user)
        {
            if (user == null)
            {
                _SetDefaultValues();
                _user = null;
                return;
            }

            _user = user;

            lblUserIDValue.Text = user.UserID.ToString();

            lblUserNameValue.Text = user.UserName;

            lblRoleValue.Text = user.RoleInfo.RoleName; 

            lblStatusValue.Text = User.IsActive ? "Active" : "Inactive";
        }

        private void _SetDefaultValues()
        {
            lblUserIDValue.Text = "???";

            lblUserNameValue.Text = "???";

            lblRoleValue.Text = "???";

            lblStatusValue.Text = "???";
        }
    }
}