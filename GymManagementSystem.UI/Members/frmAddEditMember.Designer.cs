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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmergencyPhone = new System.Windows.Forms.TextBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.tbThridName = new System.Windows.Forms.TextBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblEmergencyPhone = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblMemberIDValue = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.errpAddEditMember = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditMember)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1116, 527);
            this.pnlContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 60);
            this.panel2.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(872, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 32);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(991, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbMemberInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel1.Size = new System.Drawing.Size(1116, 467);
            this.panel1.TabIndex = 26;
            // 
            // gbMemberInfo
            // 
            this.gbMemberInfo.Controls.Add(this.lblMemberID);
            this.gbMemberInfo.Controls.Add(this.lblFirst);
            this.gbMemberInfo.Controls.Add(this.tbPhoneNumber);
            this.gbMemberInfo.Controls.Add(this.tbEmergencyPhone);
            this.gbMemberInfo.Controls.Add(this.cbAreas);
            this.gbMemberInfo.Controls.Add(this.lblSecond);
            this.gbMemberInfo.Controls.Add(this.tbThridName);
            this.gbMemberInfo.Controls.Add(this.ckbActive);
            this.gbMemberInfo.Controls.Add(this.lblGender);
            this.gbMemberInfo.Controls.Add(this.lblName);
            this.gbMemberInfo.Controls.Add(this.tbFirstName);
            this.gbMemberInfo.Controls.Add(this.rbMale);
            this.gbMemberInfo.Controls.Add(this.lblEmergencyPhone);
            this.gbMemberInfo.Controls.Add(this.tbLastName);
            this.gbMemberInfo.Controls.Add(this.dtpBirthDate);
            this.gbMemberInfo.Controls.Add(this.lblMemberIDValue);
            this.gbMemberInfo.Controls.Add(this.rbFemale);
            this.gbMemberInfo.Controls.Add(this.lblPhoneNumber);
            this.gbMemberInfo.Controls.Add(this.lblLast);
            this.gbMemberInfo.Controls.Add(this.lblThird);
            this.gbMemberInfo.Controls.Add(this.lblBirthDate);
            this.gbMemberInfo.Controls.Add(this.lblArea);
            this.gbMemberInfo.Controls.Add(this.tbSecondName);
            this.gbMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMemberInfo.ForeColor = System.Drawing.Color.White;
            this.gbMemberInfo.Location = new System.Drawing.Point(20, 20);
            this.gbMemberInfo.Name = "gbMemberInfo";
            this.gbMemberInfo.Size = new System.Drawing.Size(1076, 437);
            this.gbMemberInfo.TabIndex = 26;
            this.gbMemberInfo.TabStop = false;
            this.gbMemberInfo.Text = "Member Info";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(24, 52);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(95, 21);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFirst.ForeColor = System.Drawing.Color.Gray;
            this.lblFirst.Location = new System.Drawing.Point(175, 98);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(35, 19);
            this.lblFirst.TabIndex = 8;
            this.lblFirst.Text = "First";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.tbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhoneNumber.Location = new System.Drawing.Point(179, 203);
            this.tbPhoneNumber.MaxLength = 11;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(202, 29);
            this.tbPhoneNumber.TabIndex = 21;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // tbEmergencyPhone
            // 
            this.tbEmergencyPhone.BackColor = System.Drawing.Color.White;
            this.tbEmergencyPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmergencyPhone.Location = new System.Drawing.Point(179, 258);
            this.tbEmergencyPhone.MaxLength = 11;
            this.tbEmergencyPhone.Name = "tbEmergencyPhone";
            this.tbEmergencyPhone.Size = new System.Drawing.Size(202, 29);
            this.tbEmergencyPhone.TabIndex = 22;
            this.tbEmergencyPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            this.tbEmergencyPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmergencyPhone_Validating);
            // 
            // cbAreas
            // 
            this.cbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(785, 255);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(262, 29);
            this.cbAreas.TabIndex = 24;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecond.ForeColor = System.Drawing.Color.Gray;
            this.lblSecond.Location = new System.Drawing.Point(400, 100);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(53, 19);
            this.lblSecond.TabIndex = 11;
            this.lblSecond.Text = "Second";
            // 
            // tbThridName
            // 
            this.tbThridName.BackColor = System.Drawing.Color.White;
            this.tbThridName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbThridName.Location = new System.Drawing.Point(623, 122);
            this.tbThridName.MaxLength = 50;
            this.tbThridName.Name = "tbThridName";
            this.tbThridName.Size = new System.Drawing.Size(202, 29);
            this.tbThridName.TabIndex = 7;
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.ForeColor = System.Drawing.Color.White;
            this.ckbActive.Location = new System.Drawing.Point(785, 321);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(71, 25);
            this.ckbActive.TabIndex = 25;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(24, 325);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 21);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(24, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Location = new System.Drawing.Point(179, 122);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(202, 29);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(179, 323);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 25);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblEmergencyPhone
            // 
            this.lblEmergencyPhone.AutoSize = true;
            this.lblEmergencyPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyPhone.ForeColor = System.Drawing.Color.White;
            this.lblEmergencyPhone.Location = new System.Drawing.Point(24, 258);
            this.lblEmergencyPhone.Name = "lblEmergencyPhone";
            this.lblEmergencyPhone.Size = new System.Drawing.Size(148, 21);
            this.lblEmergencyPhone.TabIndex = 18;
            this.lblEmergencyPhone.Text = "Emergency Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastName.Location = new System.Drawing.Point(845, 122);
            this.tbLastName.MaxLength = 50;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(202, 29);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(785, 196);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(262, 29);
            this.dtpBirthDate.TabIndex = 12;
            // 
            // lblMemberIDValue
            // 
            this.lblMemberIDValue.AutoSize = true;
            this.lblMemberIDValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemberIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMemberIDValue.Location = new System.Drawing.Point(130, 52);
            this.lblMemberIDValue.Name = "lblMemberIDValue";
            this.lblMemberIDValue.Size = new System.Drawing.Size(48, 21);
            this.lblMemberIDValue.TabIndex = 2;
            this.lblMemberIDValue.Text = "[A/N]";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(303, 321);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 25);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 204);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLast.ForeColor = System.Drawing.Color.Gray;
            this.lblLast.Location = new System.Drawing.Point(843, 100);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(34, 19);
            this.lblLast.TabIndex = 9;
            this.lblLast.Text = "Last";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThird.ForeColor = System.Drawing.Color.Gray;
            this.lblThird.Location = new System.Drawing.Point(624, 100);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(40, 19);
            this.lblThird.TabIndex = 10;
            this.lblThird.Text = "Third";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(694, 203);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(87, 21);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(694, 259);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 21);
            this.lblArea.TabIndex = 23;
            this.lblArea.Text = "Area";
            // 
            // tbSecondName
            // 
            this.tbSecondName.BackColor = System.Drawing.Color.White;
            this.tbSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecondName.Location = new System.Drawing.Point(401, 122);
            this.tbSecondName.MaxLength = 50;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(202, 29);
            this.tbSecondName.TabIndex = 5;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating);
            // 
            // errpAddEditMember
            // 
            this.errpAddEditMember.ContainerControl = this;
            // 
            // frmAddEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1116, 527);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.Load += new System.EventHandler(this.frmAddEditMember_Load);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbMemberInfo.ResumeLayout(false);
            this.gbMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox tbThridName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberIDValue;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbEmergencyPhone;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.ComboBox cbAreas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbMemberInfo;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.ErrorProvider errpAddEditMember;
    }
}