using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Authentication
{
    public partial class frmLogin : Form
    {
        public event EventHandler LoginSucceeded;

        private bool _passwordVisible;

        public frmLogin()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _LoadRememberedUserName();
        }
    
        private void _LoadRememberedUserName()
        {
            string rememberedUserName = Properties.Settings.Default.RememberedUserName;

            if (string.IsNullOrWhiteSpace(rememberedUserName)) return;

            tbUserName.Text = rememberedUserName;

            chkRememberMe.Checked = true;

            tbPassword.Focus();
        }
        private void _SaveRememberedUserName()
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.RememberedUserName = tbUserName.Text.Trim();
            }
            else
            {
                Properties.Settings.Default.RememberedUserName = string.Empty;
            }

            Properties.Settings.Default.Save();
        }

        private bool _ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Username Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbUserName.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Password Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbPassword.Focus();

                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput()) return;

            string userName = tbUserName.Text.Trim();

            string password = tbPassword.Text;

            User user;

            BLL.Security.Authentication.eLoginResult result =
                BLL.Security.Authentication.Login(userName,password,out user);

            switch (result)
            {
                case BLL.Security.Authentication.eLoginResult.Success:

                    GlobalSettings.CurrentUser = user;

                    _SaveRememberedUserName();

                    LoginSucceeded?.Invoke(this,EventArgs.Empty);

                    DialogResult = DialogResult.OK;

                    break;

                case BLL.Security.Authentication.eLoginResult.Inactive:

                    MessageBox.Show(
                        "This account is inactive.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbPassword.Clear();
                    tbPassword.Focus();

                    break;

                case BLL.Security.Authentication.eLoginResult.InvalidUsernameOrPassword:

                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    tbPassword.Clear();
                    tbPassword.Focus();

                    break;
            }
        }
        private void btnEye_Click(object sender, EventArgs e)
        {
            _passwordVisible = !_passwordVisible;

            if (_passwordVisible)
            {
                tbPassword.PasswordChar = '\0';

                btnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                tbPassword.PasswordChar = '*';

                btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            Application.Exit();
        }        
    }
}