using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Users
{
    public partial class ucUserFinder : UserControl
    {       
        public event EventHandler UserSelected;

        private bool _filteringEnabled = true;

        public User SelectedUser
        {
            get => ucUserCard1.User;
        }

        public bool HasSelectedUser
        {
            get => SelectedUser != null;
        }

        public bool FilteringEnabled
        {
            get => _filteringEnabled;
            set
            {
                _filteringEnabled = value;
                _SetFilteringEnabled();
            }
        }

        public ucUserFinder()
        {
            InitializeComponent();

            _InitializeFilter();
            _SetFilteringEnabled();
            _ClearUserCard();
        }

        private void _InitializeFilter()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.AddRange(new object[]
            {
                "User ID",
                "User Name"
            });

            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Clear();
        }

        private void _SetFilteringEnabled()
        {
            cbFilterBy.Enabled = _filteringEnabled;
            tbFilterValue.Enabled = _filteringEnabled;
            btnSearch.Enabled = _filteringEnabled;
        }

        private void _ClearUserCard()
        {
            ucUserCard1.LoadUser(null);
        }

        private void _SearchUser()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearUserCard();
                return;
            }

            User user = null;

            if (cbFilterBy.SelectedIndex == 0)
            {
                if (!int.TryParse(value, out int userID))
                {
                    _ClearUserCard();

                    MessageBox.Show(
                        "Please enter a valid User ID.",
                        "Invalid User ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                user = User.GetByID(userID);
            }
            else if (cbFilterBy.SelectedIndex == 1)
            {
                user = User.GetByUsername(value);
            }

            if (user == null)
            {
                _ClearUserCard();

                MessageBox.Show(
                    "User not found.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ucUserCard1.LoadUser(user);

            UserSelected?.Invoke(this, EventArgs.Empty);
        }

        private void ucUserFinder_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchUser();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex != 0)
                return;

            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFilterValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_ClearUserCard();

            tbFilterValue.Clear();
            tbFilterValue.Focus();
        }

        public void LoadUser(User user)
        {
            if (user == null)
            {
                _ClearUserCard();
                return;
            }

            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Text = user.UserID.ToString();

            ucUserCard1.LoadUser(user);

            UserSelected?.Invoke(this, EventArgs.Empty);
        }
    }


}
