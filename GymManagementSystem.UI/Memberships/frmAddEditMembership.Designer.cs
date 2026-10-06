namespace GymManagementSystem.UI.Memberships
{
    partial class frmAddEditMembership
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.ucMemberFinder1 = new GymManagementSystem.UI.Members.ucMemberFinder();
            this.tpPlanInfo = new System.Windows.Forms.TabPage();
            this.ucPlanFinder1 = new GymManagementSystem.UI.Plans.ucPlanFinder();
            this.tpMembershipInfo = new System.Windows.Forms.TabPage();
            this.gbMembershipDetails = new System.Windows.Forms.GroupBox();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblMembershipIDValue = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPlanNameValue = new System.Windows.Forms.Label();
            this.lblMemberNameValue = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcInfo.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpPlanInfo.SuspendLayout();
            this.tpMembershipInfo.SuspendLayout();
            this.gbMembershipDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1266, 71);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Add New Membership";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 71);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcInfo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.panel1.Size = new System.Drawing.Size(1266, 751);
            this.panel1.TabIndex = 43;
            // 
            // tcInfo
            // 
            this.tcInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcInfo.Controls.Add(this.tpMemberInfo);
            this.tcInfo.Controls.Add(this.tpPlanInfo);
            this.tcInfo.Controls.Add(this.tpMembershipInfo);
            this.tcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tcInfo.Location = new System.Drawing.Point(50, 25);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(1166, 629);
            this.tcInfo.TabIndex = 47;
            this.tcInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcInfo_Selecting);
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tpMemberInfo.Controls.Add(this.ucMemberFinder1);
            this.tpMemberInfo.ForeColor = System.Drawing.Color.Black;
            this.tpMemberInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 33);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(25);
            this.tpMemberInfo.Size = new System.Drawing.Size(1158, 592);
            this.tpMemberInfo.TabIndex = 0;
            this.tpMemberInfo.Text = "Member Information";
            // 
            // ucMemberFinder1
            // 
            this.ucMemberFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMemberFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMemberFinder1.FilteringEnabled = true;
            this.ucMemberFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMemberFinder1.Location = new System.Drawing.Point(25, 25);
            this.ucMemberFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMemberFinder1.Name = "ucMemberFinder1";
            this.ucMemberFinder1.Size = new System.Drawing.Size(1108, 542);
            this.ucMemberFinder1.TabIndex = 0;
            // 
            // tpPlanInfo
            // 
            this.tpPlanInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tpPlanInfo.Controls.Add(this.ucPlanFinder1);
            this.tpPlanInfo.Location = new System.Drawing.Point(4, 33);
            this.tpPlanInfo.Name = "tpPlanInfo";
            this.tpPlanInfo.Padding = new System.Windows.Forms.Padding(25);
            this.tpPlanInfo.Size = new System.Drawing.Size(1247, 623);
            this.tpPlanInfo.TabIndex = 1;
            this.tpPlanInfo.Text = "Plan Information";
            // 
            // ucPlanFinder1
            // 
            this.ucPlanFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucPlanFinder1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucPlanFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanFinder1.FilteringEnabled = true;
            this.ucPlanFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucPlanFinder1.Location = new System.Drawing.Point(25, 25);
            this.ucPlanFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanFinder1.Name = "ucPlanFinder1";
            this.ucPlanFinder1.Size = new System.Drawing.Size(1197, 573);
            this.ucPlanFinder1.TabIndex = 3;
            // 
            // tpMembershipInfo
            // 
            this.tpMembershipInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tpMembershipInfo.Controls.Add(this.gbMembershipDetails);
            this.tpMembershipInfo.Location = new System.Drawing.Point(4, 33);
            this.tpMembershipInfo.Name = "tpMembershipInfo";
            this.tpMembershipInfo.Padding = new System.Windows.Forms.Padding(25);
            this.tpMembershipInfo.Size = new System.Drawing.Size(1247, 623);
            this.tpMembershipInfo.TabIndex = 2;
            this.tpMembershipInfo.Text = "Membership information";
            // 
            // gbMembershipDetails
            // 
            this.gbMembershipDetails.Controls.Add(this.lblMembershipID);
            this.gbMembershipDetails.Controls.Add(this.lblMembershipIDValue);
            this.gbMembershipDetails.Controls.Add(this.dtpEndDate);
            this.gbMembershipDetails.Controls.Add(this.lblStartDate);
            this.gbMembershipDetails.Controls.Add(this.dtpStartDate);
            this.gbMembershipDetails.Controls.Add(this.lblEndDate);
            this.gbMembershipDetails.Controls.Add(this.lblTotalAmountValue);
            this.gbMembershipDetails.Controls.Add(this.lblPlanName);
            this.gbMembershipDetails.Controls.Add(this.lblTotalAmount);
            this.gbMembershipDetails.Controls.Add(this.lblPlanNameValue);
            this.gbMembershipDetails.Controls.Add(this.lblMemberNameValue);
            this.gbMembershipDetails.Controls.Add(this.lblMemberName);
            this.gbMembershipDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembershipDetails.ForeColor = System.Drawing.Color.White;
            this.gbMembershipDetails.Location = new System.Drawing.Point(25, 25);
            this.gbMembershipDetails.Name = "gbMembershipDetails";
            this.gbMembershipDetails.Size = new System.Drawing.Size(1197, 573);
            this.gbMembershipDetails.TabIndex = 41;
            this.gbMembershipDetails.TabStop = false;
            this.gbMembershipDetails.Text = "Membership Details";
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembershipID.ForeColor = System.Drawing.Color.White;
            this.lblMembershipID.Location = new System.Drawing.Point(47, 63);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(127, 21);
            this.lblMembershipID.TabIndex = 26;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // lblMembershipIDValue
            // 
            this.lblMembershipIDValue.AutoSize = true;
            this.lblMembershipIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMembershipIDValue.Location = new System.Drawing.Point(190, 63);
            this.lblMembershipIDValue.Name = "lblMembershipIDValue";
            this.lblMembershipIDValue.Size = new System.Drawing.Size(53, 21);
            this.lblMembershipIDValue.TabIndex = 27;
            this.lblMembershipIDValue.Text = "[A/N]";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(194, 277);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(277, 29);
            this.dtpEndDate.TabIndex = 39;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(47, 228);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(86, 21);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(194, 222);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(277, 29);
            this.dtpStartDate.TabIndex = 38;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(47, 283);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 21);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "End Date";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(190, 338);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(31, 21);
            this.lblTotalAmountValue.TabIndex = 37;
            this.lblTotalAmountValue.Text = "???";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanName.ForeColor = System.Drawing.Color.White;
            this.lblPlanName.Location = new System.Drawing.Point(47, 173);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(94, 21);
            this.lblPlanName.TabIndex = 30;
            this.lblPlanName.Text = "Plan Name";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(47, 338);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 21);
            this.lblTotalAmount.TabIndex = 36;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblPlanNameValue
            // 
            this.lblPlanNameValue.AutoSize = true;
            this.lblPlanNameValue.ForeColor = System.Drawing.Color.White;
            this.lblPlanNameValue.Location = new System.Drawing.Point(190, 173);
            this.lblPlanNameValue.Name = "lblPlanNameValue";
            this.lblPlanNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblPlanNameValue.TabIndex = 31;
            this.lblPlanNameValue.Text = "???";
            // 
            // lblMemberNameValue
            // 
            this.lblMemberNameValue.AutoSize = true;
            this.lblMemberNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMemberNameValue.Location = new System.Drawing.Point(190, 118);
            this.lblMemberNameValue.Name = "lblMemberNameValue";
            this.lblMemberNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblMemberNameValue.TabIndex = 33;
            this.lblMemberNameValue.Text = "???";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(47, 118);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(124, 21);
            this.lblMemberName.TabIndex = 32;
            this.lblMemberName.Text = "Member Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 654);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 72);
            this.panel4.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1039, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 35);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Red;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 35;
            this.btnBack.Location = new System.Drawing.Point(0, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 35);
            this.btnBack.TabIndex = 52;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnNext.IconColor = System.Drawing.Color.Yellow;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 35;
            this.btnNext.Location = new System.Drawing.Point(76, 23);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 35);
            this.btnNext.TabIndex = 51;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAddEditMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1266, 822);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Membership";
            this.Load += new System.EventHandler(this.frmAddEditMembership_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tcInfo.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpPlanInfo.ResumeLayout(false);
            this.tpMembershipInfo.ResumeLayout(false);
            this.gbMembershipDetails.ResumeLayout(false);
            this.gbMembershipDetails.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private Members.ucMemberFinder ucMemberFinder1;
        private System.Windows.Forms.TabPage tpPlanInfo;
        private Plans.ucPlanFinder ucPlanFinder1;
        private System.Windows.Forms.TabPage tpMembershipInfo;
        private System.Windows.Forms.GroupBox gbMembershipDetails;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblMembershipIDValue;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPlanNameValue;
        private System.Windows.Forms.Label lblMemberNameValue;
        private System.Windows.Forms.Label lblMemberName;
        private FontAwesome.Sharp.IconButton btnNext;
    }
}