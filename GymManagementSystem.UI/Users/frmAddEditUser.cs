using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Users
{
    public partial class frmAddEditUser : Form
    {
        public enum eMode { Add, Update }

        private readonly eMode _mode;
        private readonly User _user;

        public event EventHandler UserSaved;

        public frmAddEditUser()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _user = new User();
        }
        public frmAddEditUser(User user)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _user = user;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadRoles();

            if (_mode == eMode.Add)
                _InitializeAddMode();
            else
                _InitializeUpdateMode();
        }

        private void _LoadRoles()
        {
            DataTable roles = Role.GetAll();

            cbRole.DataSource = roles;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleID";
            cbRole.SelectedIndex = -1;
        }

        private void _InitializeAddMode()
        {
            Text = "Add New User";


            lblUserIDValue.Text = "[A/N]";

            tbUserName.Clear();

            cbRole.SelectedIndex = 0;

            chkStatus.Checked = true;

            tbPassword.Clear();
            tbConfirmPassword.Clear();

            lblPassword.Visible = true;
            tbPassword.Visible = true;

            lblConfirmPassword.Visible = true;
            tbConfirmPassword.Visible = true;
        }
        private void _InitializeUpdateMode()
        {
            Text = "Edit User";

            lblUserIDValue.Text =
                _user.UserID.ToString();

            tbUserName.Text =
                _user.UserName;

            cbRole.SelectedValue =
                _user.RoleID;

            chkStatus.Checked =
                _user.IsActive;

            /*
             * Password must not be shown in Update Mode.
             * The current PasswordHash remains inside _user.
             */
            lblPassword.Visible = false;
            tbPassword.Visible = false;

            lblConfirmPassword.Visible = false;
            tbConfirmPassword.Visible = false;
        }

        private bool _ValidateUserName()
        {
            string userName =
                tbUserName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                errpAddEditUser.SetError(
                    tbUserName,
                    "Username is required.");

                return false;
            }

            return true;
        }
        private bool _ValidateUsernameUniqueness()
        {
            string userName =
                tbUserName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
                return true;

            int? userID =
                _mode == eMode.Update
                    ? _user.UserID
                    : (int?)null;

            if (User.IsUsernameExists(
                userName,
                userID))
            {
                errpAddEditUser.SetError(
                    tbUserName,
                    "This username already exists.");

                return false;
            }

            return true;
        }
        private bool _ValidateRole()
        {
            if (cbRole.SelectedIndex < 0 ||
                cbRole.SelectedValue == null)
            {
                errpAddEditUser.SetError(
                    cbRole,
                    "Please select a role.");

                return false;
            }

            return true;
        }
        private bool _ValidatePassword()
        {
            /*
             * Password fields are hidden in Update Mode,
             * so they are not validated there.
             */
            if (_mode == eMode.Update)
                return true;

            string password =
                tbPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                errpAddEditUser.SetError(
                    tbPassword,
                    "Password is required.");

                return false;
            }

            if (password.Length < 10)
            {
                errpAddEditUser.SetError(
                    tbPassword,
                    "Password must be at least 10 characters long.");

                return false;
            }

            if (password.Contains(" "))
            {
                errpAddEditUser.SetError(
                    tbPassword,
                    "Password must not contain spaces.");

                return false;
            }

            return true;
        }
        private bool _ValidateConfirmPassword()
        {
            /*
             * Password fields are hidden in Update Mode,
             * so they are not validated there.
             */
            if (_mode == eMode.Update)
                return true;

            string password =
                tbPassword.Text;

            string confirmPassword =
                tbConfirmPassword.Text;

            if (string.IsNullOrEmpty(confirmPassword))
            {
                errpAddEditUser.SetError(
                    tbConfirmPassword,
                    "Please confirm the password.");

                return false;
            }

            if (password != confirmPassword)
            {
                errpAddEditUser.SetError(
                    tbConfirmPassword,
                    "Passwords do not match.");

                return false;
            }

            return true;
        }
        private bool _ValidateForm()
        {
            errpAddEditUser.Clear();

            bool isValid = true;

            if (!_ValidateUserName())
                isValid = false;

            if (!_ValidateUsernameUniqueness())
                isValid = false;

            if (!_ValidateRole())
                isValid = false;

            if (!_ValidatePassword())
                isValid = false;

            if (!_ValidateConfirmPassword())
                isValid = false;

            return isValid;
        }

        private void _FillUserInfo()
        {
            _user.UserName =
                tbUserName.Text.Trim();

            _user.RoleID =
                Convert.ToInt32(cbRole.SelectedValue);

            _user.IsActive =
                chkStatus.Checked;

            /*
             * In Add Mode there is no existing password hash,
             * so create a new one.
             *
             * In Update Mode password fields are hidden,
             * therefore the existing PasswordHash is preserved.
             */
            if (_mode == eMode.Add)
            {
                _user.SetPassword(
                    tbPassword.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
                return;

            try
            {
                _FillUserInfo();

                if (!_user.Save())
                {
                    MessageBox.Show(
                        _mode == eMode.Add
                            ? "Failed to add user."
                            : "Failed to update user.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    _mode == eMode.Add
                        ? "User added successfully."
                        : "User updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UserSaved?.Invoke(
                    this,
                    EventArgs.Empty);

                if(_mode == eMode.Add)
                    AuditLogger.Log("Create", "Users", GlobalSettings.CurrentUser.UserID);
                else
                    AuditLogger.Log("Update", "Users", GlobalSettings.CurrentUser.UserID);

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An error occurred while saving. Please try again later.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

}
