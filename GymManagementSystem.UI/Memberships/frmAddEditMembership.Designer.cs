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
            GymManagementSystem.UI.Controls.SegmentedItem segmentedItem1 = new GymManagementSystem.UI.Controls.SegmentedItem();
            GymManagementSystem.UI.Controls.SegmentedItem segmentedItem2 = new GymManagementSystem.UI.Controls.SegmentedItem();
            GymManagementSystem.UI.Controls.SegmentedItem segmentedItem3 = new GymManagementSystem.UI.Controls.SegmentedItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblMembershipIDValue = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblPlanNameValue = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberNameValue = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.customSegmentedControl1 = new GymManagementSystem.UI.Controls.CustomSegmentedControl();
            this.ucMemberFinder1 = new GymManagementSystem.UI.Members.ucMemberFinder();
            this.ucPlanFinder1 = new GymManagementSystem.UI.Plans.ucPlanFinder();
            this.customIconButton2 = new GymManagementSystem.UI.UserControls.CustomIconButton();
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.ucMemberFinder1);
            this.pnlContainer.Controls.Add(this.ucPlanFinder1);
            this.pnlContainer.Location = new System.Drawing.Point(47, 109);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1245, 536);
            this.pnlContainer.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.lblMembershipID);
            this.panel2.Controls.Add(this.lblMembershipIDValue);
            this.panel2.Controls.Add(this.lblPlanName);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.lblTotalAmountValue);
            this.panel2.Controls.Add(this.lblPlanNameValue);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.lblMemberName);
            this.panel2.Controls.Add(this.lblMemberNameValue);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 536);
            this.panel2.TabIndex = 47;
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembershipID.ForeColor = System.Drawing.Color.White;
            this.lblMembershipID.Location = new System.Drawing.Point(31, 38);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(127, 21);
            this.lblMembershipID.TabIndex = 26;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // lblMembershipIDValue
            // 
            this.lblMembershipIDValue.AutoSize = true;
            this.lblMembershipIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMembershipIDValue.Location = new System.Drawing.Point(174, 38);
            this.lblMembershipIDValue.Name = "lblMembershipIDValue";
            this.lblMembershipIDValue.Size = new System.Drawing.Size(48, 21);
            this.lblMembershipIDValue.TabIndex = 27;
            this.lblMembershipIDValue.Text = "[A/N]";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanName.ForeColor = System.Drawing.Color.White;
            this.lblPlanName.Location = new System.Drawing.Point(31, 168);
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
            this.lblTotalAmount.Location = new System.Drawing.Point(31, 363);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 21);
            this.lblTotalAmount.TabIndex = 36;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(178, 295);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(288, 29);
            this.dtpEndDate.TabIndex = 39;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(174, 359);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(31, 21);
            this.lblTotalAmountValue.TabIndex = 37;
            this.lblTotalAmountValue.Text = "???";
            // 
            // lblPlanNameValue
            // 
            this.lblPlanNameValue.AutoSize = true;
            this.lblPlanNameValue.ForeColor = System.Drawing.Color.White;
            this.lblPlanNameValue.Location = new System.Drawing.Point(174, 168);
            this.lblPlanNameValue.Name = "lblPlanNameValue";
            this.lblPlanNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblPlanNameValue.TabIndex = 31;
            this.lblPlanNameValue.Text = "???";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(31, 233);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(86, 21);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(31, 298);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 21);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "End Date";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(31, 103);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(124, 21);
            this.lblMemberName.TabIndex = 32;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblMemberNameValue
            // 
            this.lblMemberNameValue.AutoSize = true;
            this.lblMemberNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMemberNameValue.Location = new System.Drawing.Point(174, 103);
            this.lblMemberNameValue.Name = "lblMemberNameValue";
            this.lblMemberNameValue.Size = new System.Drawing.Size(31, 21);
            this.lblMemberNameValue.TabIndex = 33;
            this.lblMemberNameValue.Text = "???";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(178, 228);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(288, 29);
            this.dtpStartDate.TabIndex = 38;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // customSegmentedControl1
            // 
            this.customSegmentedControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.customSegmentedControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.customSegmentedControl1.BorderRadius = 5;
            this.customSegmentedControl1.BorderSize = 0;
            this.customSegmentedControl1.ButtonSpacing = 10;
            this.customSegmentedControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.customSegmentedControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customSegmentedControl1.IconSize = 1;
            segmentedItem1.Icon = FontAwesome.Sharp.IconChar.None;
            segmentedItem1.Text = "Member Information";
            segmentedItem2.Icon = FontAwesome.Sharp.IconChar.None;
            segmentedItem2.Text = "Plan Information";
            segmentedItem3.Icon = FontAwesome.Sharp.IconChar.None;
            segmentedItem3.Text = "Membership Information";
            this.customSegmentedControl1.Items.Add(segmentedItem1);
            this.customSegmentedControl1.Items.Add(segmentedItem2);
            this.customSegmentedControl1.Items.Add(segmentedItem3);
            this.customSegmentedControl1.Location = new System.Drawing.Point(47, 32);
            this.customSegmentedControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customSegmentedControl1.Name = "customSegmentedControl1";
            this.customSegmentedControl1.SelectedColor = System.Drawing.Color.Gray;
            this.customSegmentedControl1.SelectedIndex = 0;
            this.customSegmentedControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.customSegmentedControl1.Size = new System.Drawing.Size(724, 52);
            this.customSegmentedControl1.TabIndex = 48;
            this.customSegmentedControl1.UnselectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.customSegmentedControl1.UnselectedTextColor = System.Drawing.Color.White;
            this.customSegmentedControl1.SelectedItemChanged += new System.EventHandler(this.customSegmentedControl1_SelectedItemChanged);
            // 
            // ucMemberFinder1
            // 
            this.ucMemberFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMemberFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMemberFinder1.FilteringEnabled = true;
            this.ucMemberFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMemberFinder1.Location = new System.Drawing.Point(0, 0);
            this.ucMemberFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMemberFinder1.Name = "ucMemberFinder1";
            this.ucMemberFinder1.Size = new System.Drawing.Size(1245, 536);
            this.ucMemberFinder1.TabIndex = 41;
            // 
            // ucPlanFinder1
            // 
            this.ucPlanFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucPlanFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanFinder1.FilteringEnabled = true;
            this.ucPlanFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucPlanFinder1.Location = new System.Drawing.Point(0, 0);
            this.ucPlanFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanFinder1.Name = "ucPlanFinder1";
            this.ucPlanFinder1.Size = new System.Drawing.Size(1245, 536);
            this.ucPlanFinder1.TabIndex = 40;
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
            this.customIconButton2.Location = new System.Drawing.Point(1171, 672);
            this.customIconButton2.Name = "customIconButton2";
            this.customIconButton2.Size = new System.Drawing.Size(114, 41);
            this.customIconButton2.TabIndex = 50;
            this.customIconButton2.Text = "Save";
            this.customIconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIconButton2.UseVisualStyleBackColor = false;
            this.customIconButton2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1345, 736);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.customIconButton2);
            this.Controls.Add(this.customSegmentedControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditMembership";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Membership";
            this.Load += new System.EventHandler(this.frmAddEditMembership_Load);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.CustomSegmentedControl customSegmentedControl1;
        private UserControls.CustomIconButton customIconButton2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel2;
        private Members.ucMemberFinder ucMemberFinder1;
        private Plans.ucPlanFinder ucPlanFinder1;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblMembershipIDValue;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblPlanNameValue;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberNameValue;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}