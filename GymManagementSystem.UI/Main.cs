using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Attendance;
using GymManagementSystem.UI.AuditLogs;
using GymManagementSystem.UI.Members;
using GymManagementSystem.UI.Memberships;
using GymManagementSystem.UI.Payments;
using GymManagementSystem.UI.Plans;
using GymManagementSystem.UI.Users;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            lblCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Issue
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _LoadUserControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(userControl);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucMembers());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucMemberships());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucPlans());

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucPayments());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucUsers());

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucAttendance());

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();

            _LoadUserControl(new ucAuditLogs());

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HideSettingsSubMenu();
            _LoadUserControl(new ucDashboard());

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            int userID =
                GlobalSettings.CurrentUser.UserID;

            AuditLog auditLog =
                new AuditLog();

            auditLog.UserID = userID;
            auditLog.ActionType = "Logout";
            auditLog.TableName = "Users";
            auditLog.RecordID = userID;

            
            if (!auditLog.Save())
            {
                MessageBox.Show(
                    "Failed to record logout.",
                    "Logout Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            AuditLogger.Log("Logout", "Users", GlobalSettings.CurrentUser.UserID);

            GlobalSettings.CurrentUser = null;

            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblGymName.Text = "Gym Management System";

            lblCurrentUser.Text =
            $"Logged in as : " +
            $"{GlobalSettings.CurrentUser.UserName}  |  {GlobalSettings.CurrentUser.RoleInfo.RoleName}";
            UpdateCurrentTime();

            _clockTimer = new Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();

            ButtonStyleHelper.Apply(this);

            HideSettingsSubMenu();
            _LoadUserControl(new ucDashboard());
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
        
            btnChangePassword.Visible = !btnChangePassword.Visible;
            btnGymInfo.Visible = !btnGymInfo.Visible;
        
        }

        private void HideSettingsSubMenu()
        {
            btnChangePassword.Visible = false;
            btnGymInfo.Visible = false;
        }

        private void btnAccountSecurity_Click(object sender, EventArgs e)
        {
            using(var frm = new frmChangePassword(GlobalSettings.CurrentUser))
            {
                frm.ShowDialog();
            }
                    

        }
    }

}
