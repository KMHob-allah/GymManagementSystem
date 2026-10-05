using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Memberships
{
    public partial class ucMembershipFinder : UserControl
    {
        public event EventHandler MembershipSelected;

        private bool _filteringEnabled = true;

        public Membership SelectedMembership
        {
            get => ucMembershipCard1.Membership;
        }

        public bool HasSelectedMembership
        {
            get => SelectedMembership != null;
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

        public ucMembershipFinder()
        {
            InitializeComponent();
        }

        private void _InitializeFilter()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.AddRange(new object[]
            {
                "Membership ID",
                "Member ID"
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

        private void _ClearMembershipCard()
        {
            ucMembershipCard1.LoadMembership(null);
        }

        private void _SearchMembership()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearMembershipCard();
                return;
            }

            if (!int.TryParse(value, out int ID))
            {
                _ClearMembershipCard();

                MessageBox.Show(
                    "Please enter a valid ID.",
                    "Invalid ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Membership membership = null;

            if (cbFilterBy.SelectedIndex == 0)
            {
                membership = Membership.GetByID(ID);
            }
            else if (cbFilterBy.SelectedIndex == 1)
            {
                membership = Membership.GetActiveByMemberID(ID);
            }

            if (membership == null)
            {
                _ClearMembershipCard();

                MessageBox.Show(
                    "Membership not found.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ucMembershipCard1.LoadMembership(membership);

            MembershipSelected?.Invoke(this, EventArgs.Empty);
        }

        private void ucMembershipFinder_Load(object sender, EventArgs e)
        {
            _InitializeFilter();
            _SetFilteringEnabled();
            _ClearMembershipCard();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchMembership();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ClearMembershipCard();

            tbFilterValue.Clear();
            tbFilterValue.Focus();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
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
       
    }
}