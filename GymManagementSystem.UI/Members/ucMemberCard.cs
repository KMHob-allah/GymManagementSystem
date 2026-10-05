using GymManagementSystem.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Members
{
    public partial class ucMemberCard : UserControl
    {
        private Member _member;

        public Member Member
        {
            get => _member;
        }

        public ucMemberCard()
        {
            InitializeComponent();
        }

        private void _SetDefaultPicture(bool IsMale)
        {
            pbMemberPicture.Image = IsMale ? Properties.Resources.MaleAvatar : Properties.Resources.FemaleAvatar;
        }

        public void LoadMember(Member member)
        {
            if (member == null)
            {
                _SetDefaultValues();
                _member = null;
                return;
            }

            _member = member;

            lblMemberIDValue.Text = member.MemberID.ToString();

            lblFullNameValue.Text = member.FullName;               

            lblBirthDateValue.Text = member.BirthDate.ToString("yyyy/MM/dd");

            lblGenderValue.Text = member.IsMale ? "Male" : "Female";

            lblPhoneNumberValue.Text = member.PhoneNumber;
            lblEmergencyPhoneValue.Text = member.EmergencyPhone;
            lblAreaValue.Text = member.Area;

            lblJoinDateValue.Text = member.JoinDate.ToString("yyyy/MM/dd");

            lblStatusValue.Text = member.IsActive ? "Active" : "Inactive";

            _SetDefaultPicture(member.IsMale);


        }       

        private void _SetDefaultValues()
        {
            lblMemberIDValue.Text = "???";

            lblFullNameValue.Text = "???";

            lblBirthDateValue.Text = "???";
            lblGenderValue.Text = "???";

            lblPhoneNumberValue.Text = "???";
            lblEmergencyPhoneValue.Text = "???";
            lblAreaValue.Text = "???";

            lblJoinDateValue.Text = "???";
            lblStatusValue.Text = "???";

            pbMemberPicture.Image = null;
        }
       
    }
}

