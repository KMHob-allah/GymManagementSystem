using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.BLL.Security;
using GymManagementSystem.UI.Attendance;
using GymManagementSystem.UI.AuditLogs;
using GymManagementSystem.UI.Members;
using GymManagementSystem.UI.Memberships;
using GymManagementSystem.UI.Payments;
using GymManagementSystem.UI.Plans;
using GymManagementSystem.UI.Users;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymManagementSystem.UI
{
    public partial class Main : Form
    {
        private Timer _clockTimer;

        public Main()
        {
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }

        private void UpdateCurrentTime()
        {
            lblCurrentTime.Text =
                DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private bool _HasPermission(string permissionName)
        {
            return PermissionManager.HasPermission(permissionName);
        }

        private bool _IsAdmin()
        {
            return string.Equals(
                GlobalSettings.CurrentUser?.RoleInfo?.RoleName,
                "Admin",
                StringComparison.OrdinalIgnoreCase);
        }

        private void _ApplySidebarPermissions()
        {
            // Dashboard has no dedicated permission in the current database.
            // Therefore, it is restricted to Admin.
            btnDashboard.Visible = _IsAdmin();

            iconButton4.Visible = _HasPermission("Members.View");
            iconButton1.Visible = _HasPermission("Memberships.View");
            iconButton3.Visible = _HasPermission("Plans.View");
            iconButton5.Visible = _HasPermission("Payments.View");
            iconButton2.Visible = _HasPermission("Users.View");
            iconButton7.Visible = _HasPermission("Attendance.View");
            iconButton8.Visible = _HasPermission("AuditLogs.View");

            // Settings has no dedicated permission in the current database.
            // Its availability remains unchanged.
            iconButton6.Visible = true;

            HideSettingsSubMenu();
        }

        private void _ShowAccessDenied()
        {
            MessageBox.Show(
                "You do not have permission to access this section.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void _OpenModule(
            string permissionName,
            UserControl userControl)
        {
            if (!_HasPermission(permissionName))
            {
                userControl.Dispose();
                _ShowAccessDenied();
                return;
            }

            HideSettingsSubMenu();
            _LoadUserControl(userControl);
        }

        private void _LoadUserControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(userControl);
        }

        private void _LoadDefaultPage()
        {
            if (_IsAdmin())
            {
                _LoadUserControl(new ucDashboard());
                return;
            }

            if (_HasPermission("Members.View"))
            {
                _LoadUserControl(new ucMembers());
                return;
            }

            if (_HasPermission("Memberships.View"))
            {
                _LoadUserControl(new ucMemberships());
                return;
            }

            if (_HasPermission("Payments.View"))
            {
                _LoadUserControl(new ucPayments());
                return;
            }

            if (_HasPermission("Attendance.View"))
            {
                _LoadUserControl(new ucAttendance());
                return;
            }

            if (_HasPermission("Plans.View"))
            {
                _LoadUserControl(new ucPlans());
                return;
            }

            if (_HasPermission("Users.View"))
            {
                _LoadUserControl(new ucUsers());
                return;
            }

            if (_HasPermission("AuditLogs.View"))
            {
                _LoadUserControl(new ucAuditLogs());
                return;
            }

            MessageBox.Show(
                "Your account does not have permission to access any section.",
                "Access Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            _OpenModule("Members.View", new ucMembers());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _OpenModule("Memberships.View", new ucMemberships());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            _OpenModule("Plans.View", new ucPlans());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            _OpenModule("Payments.View", new ucPayments());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            _OpenModule("Users.View", new ucUsers());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            _OpenModule("Attendance.View", new ucAttendance());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            _OpenModule("AuditLogs.View", new ucAuditLogs());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!_IsAdmin())
            {
                _ShowAccessDenied();
                return;
            }

            HideSettingsSubMenu();
            _LoadUserControl(new ucDashboard());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (GlobalSettings.CurrentUser == null)
            {
                Close();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            int userID = GlobalSettings.CurrentUser.UserID;

            // Record the logout only once.
            bool auditSaved = AuditLogger.Log(
                "Logout",
                "Users",
                userID);

            if (!auditSaved)
            {
                MessageBox.Show(
                    "Logout could not be recorded in the audit logs.",
                    "Audit Log Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            PermissionManager.Clear();

            GlobalSettings.CurrentUser = null;

            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (GlobalSettings.CurrentUser == null)
            {
                Close();
                return;
            }

            lblGymName.Text = "Gym Management System";

            lblCurrentUser.Text =
                $"Logged in as : " +
                $"{GlobalSettings.CurrentUser.UserName}  |  " +
                $"{GlobalSettings.CurrentUser.RoleInfo.RoleName}";

            UpdateCurrentTime();

            _clockTimer = new Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();

            ButtonStyleHelper.Apply(this);

            _ApplySidebarPermissions();

            _LoadDefaultPage();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            bool showSubMenu =
                !btnChangePassword.Visible &&
                !btnGymInfo.Visible;

            btnChangePassword.Visible = showSubMenu;
            btnGymInfo.Visible = showSubMenu;
        }

        private void HideSettingsSubMenu()
        {
            btnChangePassword.Visible = false;
            btnGymInfo.Visible = false;
        }

        private void btnAccountSecurity_Click(object sender, EventArgs e)
        {
            using (var frm =
                new frmChangePassword(GlobalSettings.CurrentUser))
            {
                frm.ShowDialog();
            }
        }
    }
}