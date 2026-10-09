using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.BLL.Security;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Users
{
    public partial class frmChangePassword : Form
    {
        private User _user;

        public frmChangePassword(User user)
        {
            InitializeComponent();

            _user = user;
        }
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ucUserFinder1.LoadUser(_user);

            ucUserFinder1.FilteringEnabled = false;

            tbOldPassword.Clear();
            tbNewPassword.Clear();
            tbConfirmPassword.Clear();

            errpPassword.Clear();

            tbOldPassword.Focus();
        }

        private bool _ValidateUser()
        {
            if (!ucUserFinder1.HasSelectedUser)
            {
                errpPassword.SetError(
                    ucUserFinder1,
                    "Please select a user.");

                return false;
            }

            errpPassword.SetError(
                ucUserFinder1,
                string.Empty);

            return true;
        }

        private bool _ValidateOldPassword()
        {
            if (string.IsNullOrEmpty(tbOldPassword.Text))
            {
                errpPassword.SetError(
                    tbOldPassword,
                    "Old password is required.");

                return false;
            }

            if (_user == null ||
                !_user.VerifyPassword(tbOldPassword.Text))
            {
                errpPassword.SetError(
                    tbOldPassword,
                    "Old password is incorrect.");

                return false;
            }

            errpPassword.SetError(
                tbOldPassword,
                string.Empty);

            return true;
        }
        private bool _ValidateNewPassword()
        {
            string password =
                tbNewPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                errpPassword.SetError(
                    tbNewPassword,
                    "New password is required.");

                return false;
            }

            if (password.Length < 10)
            {
                errpPassword.SetError(
                    tbNewPassword,
                    "Password must be at least 10 characters long.");

                return false;
            }

            if (password.Contains(" "))
            {
                errpPassword.SetError(
                    tbNewPassword,
                    "Password must not contain spaces.");

                return false;
            }

            errpPassword.SetError(
                tbNewPassword,
                string.Empty);

            return true;
        }
        private bool _ValidateConfirmPassword()
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                errpPassword.SetError(
                    tbConfirmPassword,
                    "Please confirm the new password.");

                return false;
            }

            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                errpPassword.SetError(
                    tbConfirmPassword,
                    "Passwords do not match.");

                return false;
            }

            errpPassword.SetError(
                tbConfirmPassword,
                string.Empty);

            return true;
        }
        private bool _ValidateForm()
        {
            errpPassword.Clear();

            bool isValid = true;

            if (!_ValidateUser())
                isValid = false;

            if (!_ValidateOldPassword())
                isValid = false;

            if (!_ValidateNewPassword())
                isValid = false;

            if (!_ValidateConfirmPassword())
                isValid = false;

            return isValid;
        }

        private void _LoadSelectedUser()
        {
            if (!ucUserFinder1.HasSelectedUser)
            {
                _user = null;
                return;
            }

            _user =
                User.GetByID(
                    ucUserFinder1.SelectedUser.UserID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _LoadSelectedUser();

            if (!_ValidateForm())
                return;

            try
            {
                byte[] newPasswordHash = PasswordHasher.HashPassword(tbNewPassword.Text);

                _user.PasswordHash = newPasswordHash;

                if (!_user.UpdatePassword(newPasswordHash))
                {
                    MessageBox.Show(
                        "Failed to change password.",
                        "Change Password Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Password changed successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                AuditLogger.Log("Update", "Users", GlobalSettings.CurrentUser.UserID);


                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An error occurred while changing the password. Please try again later.",
                    "Change Password Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }


}
