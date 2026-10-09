using GymManagementSystem.BLL;
using GymManagementSystem.BLL.Entities;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Payments
{
    public partial class frmAddEditPayment : Form
    {
        public enum eMode { Add,Update }

        private bool _isChangingTab;
        private readonly eMode _mode;

        private readonly Payment _payment;

        public event EventHandler PaymentSaved;

        public frmAddEditPayment()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _payment = new Payment();
        }
        public frmAddEditPayment(Payment payment)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _payment = payment;
        }

        private void frmAddEditPayment_Load(object sender, EventArgs e)
        {
            ucMembershipFinder1.MembershipSelected +=
                UcMembershipFinder1_MembershipSelected;

            _InitializeForm();
        }

        private void _InitializeForm()
        {
            if (_mode == eMode.Add)
                _InitializeAddMode();

            else
                _InitializeUpdateMode();

            _ChangeTab(0);

            _UpdateNavigationButtons();
        }
        private void _InitializeAddMode()
        {
            Text = "Add New Payment";
            lblTitle.Text = "Add New Payment";

            lblPaymentIDValue.Text = "[A/N]";

            ucMembershipFinder1.FilteringEnabled = true;

            _SetPaymentInformationDefaultValues();
        }
        private void _InitializeUpdateMode()
        {
            Text = "Edit Payment";
            lblTitle.Text = "Edit Payment";

            lblPaymentIDValue.Text =
                _payment.PaymentID.ToString();

            ucMembershipFinder1.LoadMembership(
                _payment.MembershipInfo);

            ucMembershipFinder1.FilteringEnabled = false;

            _UpdatePaymentInformation();
        }

        private void _SetPaymentInformationDefaultValues()
        {
            lblMembershipIDValue.Text = "???";
            lblPaidAmountValue.Text = "???";
            lblRemainingAmountValue.Text = "???";
            lblPaymentDateValue.Text = DateTime.Today.Date.ToString();

            lblCreatedByValue.Text = "???"; // Issue
                //GlobalSettings.CurrentUser.UserName;

            textBox1.Clear();
        }
        private void _UpdatePaymentInformation()
        {
            if (!ucMembershipFinder1.HasSelectedMembership)
                return;

            Membership membership =
                ucMembershipFinder1.SelectedMembership;

            lblMembershipIDValue.Text =
                membership.MembershipID.ToString();          

            lblPaidAmountValue.Text =
                membership.GetPaidAmount().ToString("0.00");

            lblRemainingAmountValue.Text =
                membership.GetRemainingAmount().ToString("0.00");


            if (_mode == eMode.Update)
            {
                textBox1.Text =
                    _payment.Amount.ToString("0.00");

                lblPaymentDateValue.Text =
                    _payment.PaymentDate.ToString("yyyy/MM/dd HH:mm");

                lblCreatedByValue.Text = _payment.CreatedByUserInfo.UserName.ToString();
            }
        }       
        private void UcMembershipFinder1_MembershipSelected(object sender,EventArgs e)
        {
            if (!ucMembershipFinder1.HasSelectedMembership)
                return;

            lblMembershipIDValue.Text =
                ucMembershipFinder1.SelectedMembership.MembershipID.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tcInfo.SelectedIndex <= 0)
                return;

            _ChangeTab(tcInfo.SelectedIndex - 1);

            _UpdateNavigationButtons();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (tcInfo.SelectedIndex)
            {
                case 0:

                    if (!ucMembershipFinder1.HasSelectedMembership)
                    {
                        MessageBox.Show(
                            "Please select a membership first.",
                            "Membership Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    _UpdatePaymentInformation();

                    _ChangeTab(1);

                    break;
            }

            _UpdateNavigationButtons();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ucMembershipFinder1.HasSelectedMembership)
                return;

            if (!decimal.TryParse(textBox1.Text.Trim(),out decimal amount))
            {
                MessageBox.Show(
                    "Please enter a valid payment amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox1.Focus();
                return;
            }

            try
            {
                if (_mode == eMode.Add)
                {
                    _payment.MembershipID = ucMembershipFinder1.SelectedMembership.MembershipID;

                    _payment.Amount = amount;

                    _payment.CreatedByUserID = 4; // Issue
                        //GlobalSettings.CurrentUser.UserID;

                    Payment.eSaveResult result = _payment.Save();

                    if (result == Payment.eSaveResult.Success)
                    {
                        MessageBox.Show(
                            "Payment saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        PaymentSaved?.Invoke(
                            this,
                            EventArgs.Empty);

                        if(_mode == eMode.Add)
                            AuditLogger.Log("Create", "Payments", _payment.PaymentID);
                        else
                            AuditLogger.Log("Update", "Payments", _payment.PaymentID);


                        Close();
                    }

                    else
                    {
                        _ShowSaveResult(result);
                    }
                }
                else
                {
                    Payment.eSaveResult success = _payment.UpdateAmount(amount);

                    if (success == Payment.eSaveResult.Failed)
                    {
                        MessageBox.Show(
                            "Failed to update payment.",
                            "Update Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    else if (success == Payment.eSaveResult.AmountExceedsRemaining)
                    {
                        MessageBox.Show(
                            "The payment amount exceeds the remaining amount.",
                            "Update Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Payment updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    PaymentSaved?.Invoke(
                        this,
                        EventArgs.Empty);

                    Close();
                }
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


        private void _ChangeTab(int index)
        {
            _isChangingTab = true;

            try
            {
                tcInfo.SelectedIndex = index;
            }
            finally
            {
                _isChangingTab = false;
            }
        }
        private void _UpdateNavigationButtons()
        {
            btnBack.Enabled =
                tcInfo.SelectedIndex > 0;

            btnNext.Visible =
                tcInfo.SelectedIndex < 1;

            btnSave.Visible =
                tcInfo.SelectedIndex == 1;
        }
        private void _ShowSaveResult(Payment.eSaveResult result)
        {
            string message =
                "Failed to save payment.";

            switch (result)
            {
                case Payment.eSaveResult.AmountExceedsRemaining:

                    message =
                        "The payment amount exceeds the remaining amount.";

                    break;


            }

            MessageBox.Show(
                message,
                "Save Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        private void tcInfo_Selecting(object sender,TabControlCancelEventArgs e)
        {
            if (_isChangingTab)
                return;

            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.' &&
                !textBox1.Text.Contains("."))
                return;

            e.Handled = true;
        }

        private void ucMembershipFinder1_MembershipSelected_1(object sender, EventArgs e)
        {
            if (!ucMembershipFinder1.HasSelectedMembership)
                return;

            _UpdatePaymentInformation();
        }
    }
}