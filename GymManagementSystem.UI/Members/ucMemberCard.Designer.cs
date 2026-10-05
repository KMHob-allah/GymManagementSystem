namespace GymManagementSystem.UI.Members
{
    partial class ucMemberCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblEmergencyPhoneValue = new System.Windows.Forms.Label();
            this.pbMemberPicture = new System.Windows.Forms.PictureBox();
            this.lblEmergencyPhone = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblPhoneNumberValue = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthDateValue = new System.Windows.Forms.Label();
            this.lblAreaValue = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMemberIDValue = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblJoinDateValue = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel3);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1209, 458);
            this.pnlContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPersonalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 386);
            this.panel1.TabIndex = 28;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gbPersonalInfo.Controls.Add(this.lblEmergencyPhoneValue);
            this.gbPersonalInfo.Controls.Add(this.pbMemberPicture);
            this.gbPersonalInfo.Controls.Add(this.lblEmergencyPhone);
            this.gbPersonalInfo.Controls.Add(this.lblPhoneNumber);
            this.gbPersonalInfo.Controls.Add(this.lblFullNameValue);
            this.gbPersonalInfo.Controls.Add(this.lblPhoneNumberValue);
            this.gbPersonalInfo.Controls.Add(this.lblFullName);
            this.gbPersonalInfo.Controls.Add(this.lblBirthDateValue);
            this.gbPersonalInfo.Controls.Add(this.lblAreaValue);
            this.gbPersonalInfo.Controls.Add(this.lblBirthDate);
            this.gbPersonalInfo.Controls.Add(this.lblGenderValue);
            this.gbPersonalInfo.Controls.Add(this.lblArea);
            this.gbPersonalInfo.Controls.Add(this.lblGender);
            this.gbPersonalInfo.Controls.Add(this.lblMemberIDValue);
            this.gbPersonalInfo.Controls.Add(this.lblMemberID);
            this.gbPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.gbPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbPersonalInfo.Size = new System.Drawing.Size(1209, 386);
            this.gbPersonalInfo.TabIndex = 0;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Info";
            // 
            // lblEmergencyPhoneValue
            // 
            this.lblEmergencyPhoneValue.AutoSize = true;
            this.lblEmergencyPhoneValue.Location = new System.Drawing.Point(192, 336);
            this.lblEmergencyPhoneValue.Name = "lblEmergencyPhoneValue";
            this.lblEmergencyPhoneValue.Size = new System.Drawing.Size(31, 21);
            this.lblEmergencyPhoneValue.TabIndex = 25;
            this.lblEmergencyPhoneValue.Text = "???";
            // 
            // pbMemberPicture
            // 
            this.pbMemberPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMemberPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMemberPicture.Image = global::GymManagementSystem.UI.Properties.Resources.MaleAvatar;
            this.pbMemberPicture.Location = new System.Drawing.Point(927, 82);
            this.pbMemberPicture.Name = "pbMemberPicture";
            this.pbMemberPicture.Size = new System.Drawing.Size(228, 257);
            this.pbMemberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMemberPicture.TabIndex = 17;
            this.pbMemberPicture.TabStop = false;
            // 
            // lblEmergencyPhone
            // 
            this.lblEmergencyPhone.AutoSize = true;
            this.lblEmergencyPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyPhone.Location = new System.Drawing.Point(27, 336);
            this.lblEmergencyPhone.Name = "lblEmergencyPhone";
            this.lblEmergencyPhone.Size = new System.Drawing.Size(148, 21);
            this.lblEmergencyPhone.TabIndex = 24;
            this.lblEmergencyPhone.Text = "Emergency Phone";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.Location = new System.Drawing.Point(27, 289);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(192, 101);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblFullNameValue.TabIndex = 16;
            this.lblFullNameValue.Text = "???";
            // 
            // lblPhoneNumberValue
            // 
            this.lblPhoneNumberValue.AutoSize = true;
            this.lblPhoneNumberValue.Location = new System.Drawing.Point(192, 289);
            this.lblPhoneNumberValue.Name = "lblPhoneNumberValue";
            this.lblPhoneNumberValue.Size = new System.Drawing.Size(31, 21);
            this.lblPhoneNumberValue.TabIndex = 19;
            this.lblPhoneNumberValue.Text = "???";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(27, 101);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 21);
            this.lblFullName.TabIndex = 15;
            this.lblFullName.Text = "Full Name";
            // 
            // lblBirthDateValue
            // 
            this.lblBirthDateValue.AutoSize = true;
            this.lblBirthDateValue.Location = new System.Drawing.Point(192, 148);
            this.lblBirthDateValue.Name = "lblBirthDateValue";
            this.lblBirthDateValue.Size = new System.Drawing.Size(31, 21);
            this.lblBirthDateValue.TabIndex = 14;
            this.lblBirthDateValue.Text = "???";
            // 
            // lblAreaValue
            // 
            this.lblAreaValue.AutoSize = true;
            this.lblAreaValue.Location = new System.Drawing.Point(192, 242);
            this.lblAreaValue.Name = "lblAreaValue";
            this.lblAreaValue.Size = new System.Drawing.Size(31, 21);
            this.lblAreaValue.TabIndex = 23;
            this.lblAreaValue.Text = "???";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.Location = new System.Drawing.Point(27, 148);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(87, 21);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Location = new System.Drawing.Point(192, 195);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(31, 21);
            this.lblGenderValue.TabIndex = 12;
            this.lblGenderValue.Text = "???";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(27, 242);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 21);
            this.lblArea.TabIndex = 22;
            this.lblArea.Text = "Area";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(27, 195);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 21);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // lblMemberIDValue
            // 
            this.lblMemberIDValue.AutoSize = true;
            this.lblMemberIDValue.Location = new System.Drawing.Point(192, 54);
            this.lblMemberIDValue.Name = "lblMemberIDValue";
            this.lblMemberIDValue.Size = new System.Drawing.Size(31, 21);
            this.lblMemberIDValue.TabIndex = 2;
            this.lblMemberIDValue.Text = "???";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberID.Location = new System.Drawing.Point(27, 54);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(95, 21);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 14);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.lblStatusValue);
            this.panel3.Controls.Add(this.lblJoinDate);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblJoinDateValue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 58);
            this.panel3.TabIndex = 1;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.ForeColor = System.Drawing.Color.White;
            this.lblStatusValue.Location = new System.Drawing.Point(1027, 17);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(31, 21);
            this.lblStatusValue.TabIndex = 29;
            this.lblStatusValue.Text = "???";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Location = new System.Drawing.Point(27, 23);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(82, 21);
            this.lblJoinDate.TabIndex = 26;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(936, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 21);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // lblJoinDateValue
            // 
            this.lblJoinDateValue.AutoSize = true;
            this.lblJoinDateValue.ForeColor = System.Drawing.Color.White;
            this.lblJoinDateValue.Location = new System.Drawing.Point(192, 23);
            this.lblJoinDateValue.Name = "lblJoinDateValue";
            this.lblJoinDateValue.Size = new System.Drawing.Size(31, 21);
            this.lblJoinDateValue.TabIndex = 27;
            this.lblJoinDateValue.Text = "???";
            // 
            // ucMemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMemberCard";
            this.Size = new System.Drawing.Size(1209, 458);
            this.pnlContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblJoinDateValue;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Label lblEmergencyPhoneValue;
        private System.Windows.Forms.PictureBox pbMemberPicture;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblPhoneNumberValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthDateValue;
        private System.Windows.Forms.Label lblAreaValue;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMemberIDValue;
        private System.Windows.Forms.Label lblMemberID;
    }
}
