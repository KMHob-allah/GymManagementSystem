namespace GymManagementSystem.UI.Memberships
{
    partial class ucMembershipCard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lnklblPlanDetails = new System.Windows.Forms.LinkLabel();
            this.lnklblPaymentHistory = new System.Windows.Forms.LinkLabel();
            this.lnklblMemberDetails = new System.Windows.Forms.LinkLabel();
            this.lnklblAttendanceHistory = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMembershipInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblMemberNameValue = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblPlanNameValue = new System.Windows.Forms.Label();
            this.lblEndDateValue = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblStartDateValue = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblMembershipIDValue = new System.Windows.Forms.Label();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbMembershipInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.gbMembershipInfo);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.tableLayoutPanel1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(984, 398);
            this.pnlContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lnklblPlanDetails, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnklblPaymentHistory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnklblMemberDetails, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lnklblAttendanceHistory, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 341);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lnklblPlanDetails
            // 
            this.lnklblPlanDetails.AutoSize = true;
            this.lnklblPlanDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnklblPlanDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblPlanDetails.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(147)))), ((int)(((byte)(142)))));
            this.lnklblPlanDetails.Location = new System.Drawing.Point(741, 0);
            this.lnklblPlanDetails.Name = "lnklblPlanDetails";
            this.lnklblPlanDetails.Size = new System.Drawing.Size(240, 57);
            this.lnklblPlanDetails.TabIndex = 27;
            this.lnklblPlanDetails.TabStop = true;
            this.lnklblPlanDetails.Text = "Plan Details";
            this.lnklblPlanDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblPlanDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblPlanDetails_LinkClicked);
            // 
            // lnklblPaymentHistory
            // 
            this.lnklblPaymentHistory.AutoSize = true;
            this.lnklblPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnklblPaymentHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblPaymentHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(147)))), ((int)(((byte)(142)))));
            this.lnklblPaymentHistory.Location = new System.Drawing.Point(3, 0);
            this.lnklblPaymentHistory.Name = "lnklblPaymentHistory";
            this.lnklblPaymentHistory.Size = new System.Drawing.Size(240, 57);
            this.lnklblPaymentHistory.TabIndex = 2;
            this.lnklblPaymentHistory.TabStop = true;
            this.lnklblPaymentHistory.Text = "Payment History";
            this.lnklblPaymentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblPaymentHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblPaymentHistory_LinkClicked);
            // 
            // lnklblMemberDetails
            // 
            this.lnklblMemberDetails.AutoSize = true;
            this.lnklblMemberDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnklblMemberDetails.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblMemberDetails.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(147)))), ((int)(((byte)(142)))));
            this.lnklblMemberDetails.Location = new System.Drawing.Point(495, 0);
            this.lnklblMemberDetails.Name = "lnklblMemberDetails";
            this.lnklblMemberDetails.Size = new System.Drawing.Size(240, 57);
            this.lnklblMemberDetails.TabIndex = 26;
            this.lnklblMemberDetails.TabStop = true;
            this.lnklblMemberDetails.Text = "Member Details";
            this.lnklblMemberDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblMemberDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblMemberDetails_LinkClicked);
            // 
            // lnklblAttendanceHistory
            // 
            this.lnklblAttendanceHistory.AutoSize = true;
            this.lnklblAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnklblAttendanceHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnklblAttendanceHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(147)))), ((int)(((byte)(142)))));
            this.lnklblAttendanceHistory.Location = new System.Drawing.Point(249, 0);
            this.lnklblAttendanceHistory.Name = "lnklblAttendanceHistory";
            this.lnklblAttendanceHistory.Size = new System.Drawing.Size(240, 57);
            this.lnklblAttendanceHistory.TabIndex = 3;
            this.lnklblAttendanceHistory.TabStop = true;
            this.lnklblAttendanceHistory.Text = "Attendance History";
            this.lnklblAttendanceHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblAttendanceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAttendanceHistory_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 13);
            this.panel1.TabIndex = 26;
            // 
            // gbMembershipInfo
            // 
            this.gbMembershipInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.gbMembershipInfo.Controls.Add(this.lblTotalAmountValue);
            this.gbMembershipInfo.Controls.Add(this.lblTotalAmount);
            this.gbMembershipInfo.Controls.Add(this.lblMemberNameValue);
            this.gbMembershipInfo.Controls.Add(this.lblMemberName);
            this.gbMembershipInfo.Controls.Add(this.lblPlanNameValue);
            this.gbMembershipInfo.Controls.Add(this.lblEndDateValue);
            this.gbMembershipInfo.Controls.Add(this.lblPlanName);
            this.gbMembershipInfo.Controls.Add(this.lblStartDateValue);
            this.gbMembershipInfo.Controls.Add(this.lblEndDate);
            this.gbMembershipInfo.Controls.Add(this.lblStartDate);
            this.gbMembershipInfo.Controls.Add(this.lblMembershipIDValue);
            this.gbMembershipInfo.Controls.Add(this.lblMembershipID);
            this.gbMembershipInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembershipInfo.ForeColor = System.Drawing.Color.White;
            this.gbMembershipInfo.Location = new System.Drawing.Point(0, 0);
            this.gbMembershipInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMembershipInfo.Name = "gbMembershipInfo";
            this.gbMembershipInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbMembershipInfo.Size = new System.Drawing.Size(984, 328);
            this.gbMembershipInfo.TabIndex = 26;
            this.gbMembershipInfo.TabStop = false;
            this.gbMembershipInfo.Text = "Membership Info";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(170, 276);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(31, 21);
            this.lblTotalAmountValue.TabIndex = 25;
            this.lblTotalAmountValue.Text = "???";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(27, 276);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 21);
            this.lblTotalAmount.TabIndex = 24;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblMemberNameValue
            // 
            this.lblMemberNameValue.AutoSize = true;
            this.lblMemberNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMemberNameValue.Location = new System.Drawing.Point(170, 92);
            this.lblMemberNameValue.Name = "lblMemberNameValue";
            this.lblMemberNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblMemberNameValue.TabIndex = 16;
            this.lblMemberNameValue.Text = "???";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberName.Location = new System.Drawing.Point(27, 92);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(124, 21);
            this.lblMemberName.TabIndex = 15;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblPlanNameValue
            // 
            this.lblPlanNameValue.AutoSize = true;
            this.lblPlanNameValue.Location = new System.Drawing.Point(170, 138);
            this.lblPlanNameValue.Name = "lblPlanNameValue";
            this.lblPlanNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblPlanNameValue.TabIndex = 14;
            this.lblPlanNameValue.Text = "???";
            // 
            // lblEndDateValue
            // 
            this.lblEndDateValue.AutoSize = true;
            this.lblEndDateValue.Location = new System.Drawing.Point(170, 230);
            this.lblEndDateValue.Name = "lblEndDateValue";
            this.lblEndDateValue.Size = new System.Drawing.Size(31, 21);
            this.lblEndDateValue.TabIndex = 23;
            this.lblEndDateValue.Text = "???";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanName.Location = new System.Drawing.Point(27, 138);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(94, 21);
            this.lblPlanName.TabIndex = 13;
            this.lblPlanName.Text = "Plan Name";
            // 
            // lblStartDateValue
            // 
            this.lblStartDateValue.AutoSize = true;
            this.lblStartDateValue.Location = new System.Drawing.Point(170, 184);
            this.lblStartDateValue.Name = "lblStartDateValue";
            this.lblStartDateValue.Size = new System.Drawing.Size(31, 21);
            this.lblStartDateValue.TabIndex = 12;
            this.lblStartDateValue.Text = "???";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(27, 230);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 21);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(27, 184);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(86, 21);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblMembershipIDValue
            // 
            this.lblMembershipIDValue.AutoSize = true;
            this.lblMembershipIDValue.Location = new System.Drawing.Point(170, 46);
            this.lblMembershipIDValue.Name = "lblMembershipIDValue";
            this.lblMembershipIDValue.Size = new System.Drawing.Size(31, 21);
            this.lblMembershipIDValue.TabIndex = 2;
            this.lblMembershipIDValue.Text = "???";
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembershipID.Location = new System.Drawing.Point(27, 46);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(127, 21);
            this.lblMembershipID.TabIndex = 0;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // ucMembershipCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMembershipCard";
            this.Size = new System.Drawing.Size(984, 398);
            this.pnlContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbMembershipInfo.ResumeLayout(false);
            this.gbMembershipInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.LinkLabel lnklblPaymentHistory;
        private System.Windows.Forms.LinkLabel lnklblAttendanceHistory;
        private System.Windows.Forms.LinkLabel lnklblPlanDetails;
        private System.Windows.Forms.LinkLabel lnklblMemberDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMembershipInfo;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblMemberNameValue;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblPlanNameValue;
        private System.Windows.Forms.Label lblEndDateValue;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblStartDateValue;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMembershipIDValue;
        private System.Windows.Forms.Label lblMembershipID;
    }
}
