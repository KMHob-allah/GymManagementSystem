using GymManagementSystem.BLL;
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
    public partial class frmAddEditMember : Form
    {
        public enum eMode {Add,Update}

        private readonly eMode _mode;
        private readonly Member _member;

        public event EventHandler MemberSaved;

        public frmAddEditMember()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _member = new Member();
        }
        public frmAddEditMember(Member member)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _member = member;
        }

        private void _InitializeForm()
        {
            if (_mode == eMode.Add) _SetDefaultValues();

            else _LoadMemberData();
        }
        private void _ConfigBirthDateLimits()
        {
            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-10);

            dtpBirthDate.MinDate = DateTime.Today.AddYears(-100);
        }
        private void _FillAreasComboBox()
        {
            cbAreas.Items.Clear(); 

            cbAreas.Items.AddRange(new object[] {"El Burullus","Baltim","El-Koum El-Ahmar"});

            if (cbAreas.Items.Count > 0) cbAreas.SelectedIndex = 0;            
        }
        private void _FillMemberInfo()
        {
            _member.FirstName = tbFirstName.Text.Trim();
            _member.SecondName = tbSecondName.Text.Trim();
            _member.ThirdName = tbThridName.Text.Trim();
            _member.LastName = tbLastName.Text.Trim();
            _member.PhoneNumber = tbPhoneNumber.Text.Trim();
            _member.EmergencyPhone = tbEmergencyPhone.Text.Trim();
            _member.Gender = (rbMale.Checked ? Gender.Male : Gender.Female);
            _member.Area = cbAreas.SelectedItem.ToString();
            _member.BirthDate = dtpBirthDate.Value;
            _member.IsActive = ckbActive.Checked;
        }

        private void _SetDefaultValues()
        {
            lblMemberIDValue.Text = "[A/N]";
            tbFirstName.Text = string.Empty;
            tbSecondName.Text = string.Empty;
            tbThridName .Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbEmergencyPhone.Text = string.Empty;
            rbMale.Checked = true;
            dtpBirthDate.Value = DateTime.Today.AddYears(-20);
            ckbActive.Checked = true;

        }
        private void _LoadMemberData()
        {
            lblMemberIDValue.Text = _member.MemberID.ToString();
            tbFirstName.Text = _member.FirstName;
            tbSecondName.Text = _member.SecondName;
            tbThridName.Text = _member.ThirdName;
            tbLastName.Text = _member.LastName;
            tbPhoneNumber.Text = _member.PhoneNumber;
            tbEmergencyPhone.Text = _member.EmergencyPhone;

            if (_member.IsMale) rbMale.Checked = true;
            else rbFemale.Checked = true;

            ckbActive.Checked = _member.IsActive;
            dtpBirthDate.Value = _member.BirthDate;
            // TODO: Must Fix Area , Should I Change it in the database 
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateAllInputs())
            {
                MessageBox.Show(
                    "Please fix the errors before saving.",
                    "Validation Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                _FillMemberInfo();

                if (_member.Save())
                {
                    MessageBox.Show(
                        "Member saved successfully!", 
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MemberSaved?.Invoke(this, EventArgs.Empty);

                    if(_mode == eMode.Add)
                        AuditLogger.Log("Create", "Members", _member.MemberID);

                    else 
                        AuditLogger.Log("Update", "Members", _member.MemberID);

                    this.Close();
                }

                else
                {
                    MessageBox.Show(
                        "Failed to save member. Please try again.", 
                        "Save Failed",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show(
                    $"An error occurred while saving.Please try again later.",
                    "Save Failed", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
          

        }     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            _FillAreasComboBox();
            _ConfigBirthDateLimits();
            _InitializeForm();
        }



        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            _ValidateTextBox(tbFirstName, "First name cannot be blank.");
        }
        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            _ValidateTextBox(tbSecondName, "Second name cannot be blank.");
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            _ValidateTextBox(tbLastName, "Last name cannot be blank.");
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            _ValidatePhoneTextBox(tbPhoneNumber);
        }
        private void txtEmergencyPhone_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmergencyPhoneTextBox(tbEmergencyPhone);
        }



        private bool _IsValidEgyptianPhone(string phone)
        {
            if (phone.Length != 11)
                return false;

            return phone.StartsWith("010") ||
                   phone.StartsWith("011") ||
                   phone.StartsWith("012") ||
                   phone.StartsWith("015");
        }

        private bool _ValidateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                errpAddEditMember.SetError(textBox, errorMessage);
                return false;
            }
            else
            {
                errpAddEditMember.SetError(textBox, string.Empty);
                return true;
            }
        }
        private bool _ValidatePhoneTextBox(TextBox textBox)
        {
            string phone = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone) || !_IsValidEgyptianPhone(phone))
            {
                errpAddEditMember.SetError(textBox, "Phone must be 11 digits and start with 010, 011, 012, or 015.");
                return false;
            }
            else
            {
                errpAddEditMember.SetError(textBox, string.Empty);
                return true;
            }
        }
        private bool _ValidateEmergencyPhoneTextBox(TextBox textBox)
        {
            string emergencyPhone = textBox.Text.Trim();
            string mainPhone = tbPhoneNumber.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(emergencyPhone) || !_IsValidEgyptianPhone(emergencyPhone))
            {
                errpAddEditMember.SetError(textBox, "Emergency phone must be 11 digits");
                return false;
            }
            else if (emergencyPhone == mainPhone)
            {
                errpAddEditMember.SetError(textBox, "Emergency phone cannot be the same as the main phone.");
                return false;
            }
            else
            {
                errpAddEditMember.SetError(textBox, string.Empty);
                return true;
            }
        }
        private bool _ValidateAllInputs()
        {
            bool isFirstNameValid = _ValidateTextBox(tbFirstName, "First name cannot be blank.");
            bool isSecondNameValid = _ValidateTextBox(tbSecondName, "Second name cannot be blank.");
            bool isLastNameValid = _ValidateTextBox(tbLastName, "Last name cannot be blank.");
            bool isPhoneValid = _ValidatePhoneTextBox(tbPhoneNumber);
            bool isEmergencyPhoneValid = _ValidateEmergencyPhoneTextBox(tbEmergencyPhone);

            return 
                isFirstNameValid && 
                isSecondNameValid && 
                isLastNameValid && 
                isPhoneValid && 
                isEmergencyPhoneValid;        
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

      
    }
}
