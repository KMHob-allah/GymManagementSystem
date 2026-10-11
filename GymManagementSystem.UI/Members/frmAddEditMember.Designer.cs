namespace GymManagementSystem.UI.Members
{
    partial class frmAddEditMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errpAddEditMember = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFirstName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMemberIDValue = new System.Windows.Forms.Label();
            this.tbEmergencyPhone = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tbSecondName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.tbLastName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tbThirdName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.customIconButton2 = new GymManagementSystem.UI.UserControls.CustomIconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errpAddEditMember
            // 
            this.errpAddEditMember.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.dtpBirthDate);
            this.panel1.Controls.Add(this.tbPhoneNumber);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblMemberIDValue);
            this.panel1.Controls.Add(this.tbEmergencyPhone);
            this.panel1.Controls.Add(this.ckbActive);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.tbSecondName);
            this.panel1.Controls.Add(this.cbAreas);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.lblMemberID);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Controls.Add(this.tbThirdName);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel1.Location = new System.Drawing.Point(50, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 609);
            this.panel1.TabIndex = 54;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbFirstName.BorderColor = System.Drawing.Color.LightGray;
            this.tbFirstName.BorderRadius = 5;
            this.tbFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFirstName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(24, 90);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "first name";
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.Size = new System.Drawing.Size(440, 51);
            this.tbFirstName.TabIndex = 43;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFirstName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(594, 332);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 21);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Status";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(703, 245);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 25);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpBirthDate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dtpBirthDate.Location = new System.Drawing.Point(703, 90);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(330, 31);
            this.dtpBirthDate.TabIndex = 12;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.tbPhoneNumber.BorderRadius = 5;
            this.tbPhoneNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPhoneNumber.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.tbPhoneNumber.Location = new System.Drawing.Point(24, 436);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Multiline = false;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.PlaceholderText = "phone number";
            this.tbPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhoneNumber.Size = new System.Drawing.Size(440, 51);
            this.tbPhoneNumber.TabIndex = 48;
            this.tbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhoneNumber.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(594, 245);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 21);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // lblMemberIDValue
            // 
            this.lblMemberIDValue.AutoSize = true;
            this.lblMemberIDValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemberIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMemberIDValue.Location = new System.Drawing.Point(126, 18);
            this.lblMemberIDValue.Name = "lblMemberIDValue";
            this.lblMemberIDValue.Size = new System.Drawing.Size(48, 21);
            this.lblMemberIDValue.TabIndex = 2;
            this.lblMemberIDValue.Text = "[A/N]";
            // 
            // tbEmergencyPhone
            // 
            this.tbEmergencyPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbEmergencyPhone.BorderColor = System.Drawing.Color.LightGray;
            this.tbEmergencyPhone.BorderRadius = 5;
            this.tbEmergencyPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmergencyPhone.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbEmergencyPhone.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbEmergencyPhone.ForeColor = System.Drawing.Color.White;
            this.tbEmergencyPhone.Location = new System.Drawing.Point(24, 522);
            this.tbEmergencyPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmergencyPhone.Multiline = false;
            this.tbEmergencyPhone.Name = "tbEmergencyPhone";
            this.tbEmergencyPhone.PasswordChar = '\0';
            this.tbEmergencyPhone.PlaceholderText = "emergency phone";
            this.tbEmergencyPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmergencyPhone.Size = new System.Drawing.Size(440, 51);
            this.tbEmergencyPhone.TabIndex = 47;
            this.tbEmergencyPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmergencyPhone.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.ForeColor = System.Drawing.Color.White;
            this.ckbActive.Location = new System.Drawing.Point(703, 332);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(71, 25);
            this.ckbActive.TabIndex = 25;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(805, 245);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 25);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // tbSecondName
            // 
            this.tbSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbSecondName.BorderColor = System.Drawing.Color.LightGray;
            this.tbSecondName.BorderRadius = 5;
            this.tbSecondName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSecondName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbSecondName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbSecondName.ForeColor = System.Drawing.Color.White;
            this.tbSecondName.Location = new System.Drawing.Point(24, 176);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecondName.Multiline = false;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PasswordChar = '\0';
            this.tbSecondName.PlaceholderText = "second name";
            this.tbSecondName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSecondName.Size = new System.Drawing.Size(440, 51);
            this.tbSecondName.TabIndex = 46;
            this.tbSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSecondName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // cbAreas
            // 
            this.cbAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAreas.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbAreas.ForeColor = System.Drawing.Color.White;
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(703, 175);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(330, 31);
            this.cbAreas.TabIndex = 24;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbLastName.BorderColor = System.Drawing.Color.LightGray;
            this.tbLastName.BorderRadius = 5;
            this.tbLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLastName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(24, 349);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Multiline = false;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "last name";
            this.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastName.Size = new System.Drawing.Size(440, 51);
            this.tbLastName.TabIndex = 45;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLastName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(20, 18);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(95, 21);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(594, 90);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(87, 21);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // tbThirdName
            // 
            this.tbThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbThirdName.BorderColor = System.Drawing.Color.LightGray;
            this.tbThirdName.BorderRadius = 5;
            this.tbThirdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbThirdName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbThirdName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbThirdName.ForeColor = System.Drawing.Color.White;
            this.tbThirdName.Location = new System.Drawing.Point(24, 263);
            this.tbThirdName.Margin = new System.Windows.Forms.Padding(4);
            this.tbThirdName.Multiline = false;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.PasswordChar = '\0';
            this.tbThirdName.PlaceholderText = "third name";
            this.tbThirdName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbThirdName.Size = new System.Drawing.Size(440, 51);
            this.tbThirdName.TabIndex = 44;
            this.tbThirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbThirdName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(594, 168);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 21);
            this.lblArea.TabIndex = 23;
            this.lblArea.Text = "Area";
            // 
            // customIconButton2
            // 
            this.customIconButton2.BackColor = System.Drawing.Color.White;
            this.customIconButton2.BorderRadius = 10;
            this.customIconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.customIconButton2.ForeColor = System.Drawing.Color.Black;
            this.customIconButton2.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.customIconButton2.IconColor = System.Drawing.Color.Black;
            this.customIconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customIconButton2.IconSize = 30;
            this.customIconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customIconButton2.Location = new System.Drawing.Point(985, 686);
            this.customIconButton2.Name = "customIconButton2";
            this.customIconButton2.Size = new System.Drawing.Size(121, 36);
            this.customIconButton2.TabIndex = 46;
            this.customIconButton2.Text = "Save";
            this.customIconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIconButton2.UseVisualStyleBackColor = false;
            // 
            // frmAddEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1156, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customIconButton2);
            this.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditMember";
            this.Padding = new System.Windows.Forms.Padding(50, 55, 50, 77);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.Load += new System.EventHandler(this.frmAddEditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errpAddEditMember;
        private System.Windows.Forms.Panel panel1;
        private Controls.CustomTextBox tbFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private Controls.CustomTextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblGender;
        private UserControls.CustomIconButton customIconButton2;
        private System.Windows.Forms.Label lblMemberIDValue;
        private Controls.CustomTextBox tbEmergencyPhone;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.RadioButton rbFemale;
        private Controls.CustomTextBox tbSecondName;
        private System.Windows.Forms.ComboBox cbAreas;
        private Controls.CustomTextBox tbLastName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBirthDate;
        private Controls.CustomTextBox tbThirdName;
        private System.Windows.Forms.Label lblArea;
    }
}