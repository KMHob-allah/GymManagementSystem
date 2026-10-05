using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Members
{
    public partial class ucMemberFinder : UserControl
    {
        public event EventHandler MemberSelected;

        private bool _filteringEnabled = true;

        public bool FilteringEnabled
        {
            get => _filteringEnabled;
            set
            {
                _filteringEnabled = value;
                _SetFilteringEnabled();
            }
        }

        private void _SetFilteringEnabled()
        {
            cbFilterBy.Enabled = _filteringEnabled;
            tbFilterValue.Enabled = _filteringEnabled;
            btnSearch.Enabled = _filteringEnabled;
        }

        public Member SelectedMember
        {
            get => ucMemberCard1.Member;
        }
        public bool HasSelectedMember
        {
            get => SelectedMember != null;
        }

        public ucMemberFinder()
        {
            InitializeComponent();
        }

        private void _InitializeFilter()
        {
            cbFilterBy.Items.Add("Member ID");
            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Clear();
        }

        private void _ClearMemberCard()
        {
            ucMemberCard1.LoadMember(null);
            
        }

        private void _SearchMember()
        {
            string value = tbFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                _ClearMemberCard();
                return;
            }

            if (!int.TryParse(value, out int memberID))
            {
                _ClearMemberCard();

                MessageBox.Show(
                    "Please enter a valid Member ID.",
                    "Invalid Member ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Member member = Member.GetMemberByID(memberID);

            if (member == null)
            {
                _ClearMemberCard();

                MessageBox.Show(
                    "Member not found.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ucMemberCard1.LoadMember(member);

            MemberSelected?.Invoke(this, EventArgs.Empty);
        }

        private void ucMemberFinder_Load(object sender, EventArgs e)
        {
            _InitializeFilter();
            _ClearMemberCard();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchMember();
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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ClearMemberCard();

            tbFilterValue.Clear();
            tbFilterValue.Focus();
        }

        public void LoadMember(Member member)
        {
            if (member == null)
            {
                _ClearMemberCard();
                return;
            }

            cbFilterBy.SelectedIndex = 0;

            tbFilterValue.Text = member.MemberID.ToString();

            ucMemberCard1.LoadMember(member);

            MemberSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}