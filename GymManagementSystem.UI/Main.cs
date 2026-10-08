using GymManagementSystem.UI.Attendance;
using GymManagementSystem.UI.Members;
using GymManagementSystem.UI.Memberships;
using GymManagementSystem.UI.Payments;
using GymManagementSystem.UI.Plans;
using GymManagementSystem.UI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
      
        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            _LoadUserControl(new ucMembers());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ucMemberships());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ucPlans());

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ucPayments());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ucUsers());

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            _LoadUserControl(new ucAttendance());

        }
    }
}
