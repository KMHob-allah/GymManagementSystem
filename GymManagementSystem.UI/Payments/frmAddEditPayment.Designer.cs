namespace GymManagementSystem.UI.Payments
{
    partial class frmAddEditPayment
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
            GymManagementSystem.UI.Controls.SegmentedItem segmentedItem5 = new GymManagementSystem.UI.Controls.SegmentedItem();
            GymManagementSystem.UI.Controls.SegmentedItem segmentedItem6 = new GymManagementSystem.UI.Controls.SegmentedItem();
            this.lblPaidAmountValue = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblRemainingAmountValue = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblPaymentDateValue = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblPaymentIDValue = new System.Windows.Forms.Label();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblMembershipIDValue = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAmount = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucMembershipFinder1 = new GymManagementSystem.UI.Memberships.ucMembershipFinder();
            this.btnSave = new GymManagementSystem.UI.UserControls.CustomIconButton();
            this.customSegmentedControl1 = new GymManagementSystem.UI.Controls.CustomSegmentedControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPaidAmountValue
            // 
            this.lblPaidAmountValue.AutoSize = true;
            this.lblPaidAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblPaidAmountValue.Location = new System.Drawing.Point(851, 42);
            this.lblPaidAmountValue.Name = "lblPaidAmountValue";
            this.lblPaidAmountValue.Size = new System.Drawing.Size(31, 21);
            this.lblPaidAmountValue.TabIndex = 49;
            this.lblPaidAmountValue.Text = "???";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaidAmount.ForeColor = System.Drawing.Color.White;
            this.lblPaidAmount.Location = new System.Drawing.Point(668, 42);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(110, 21);
            this.lblPaidAmount.TabIndex = 48;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblRemainingAmountValue
            // 
            this.lblRemainingAmountValue.AutoSize = true;
            this.lblRemainingAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblRemainingAmountValue.Location = new System.Drawing.Point(851, 103);
            this.lblRemainingAmountValue.Name = "lblRemainingAmountValue";
            this.lblRemainingAmountValue.Size = new System.Drawing.Size(31, 21);
            this.lblRemainingAmountValue.TabIndex = 47;
            this.lblRemainingAmountValue.Text = "???";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.White;
            this.lblRemainingAmount.Location = new System.Drawing.Point(668, 103);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(159, 21);
            this.lblRemainingAmount.TabIndex = 46;
            this.lblRemainingAmount.Text = "Remaining Amount";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.White;
            this.lblCreatedByValue.Location = new System.Drawing.Point(209, 220);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(31, 21);
            this.lblCreatedByValue.TabIndex = 44;
            this.lblCreatedByValue.Text = "???";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lblCreatedBy.Location = new System.Drawing.Point(44, 220);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(92, 21);
            this.lblCreatedBy.TabIndex = 43;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblPaymentDateValue
            // 
            this.lblPaymentDateValue.AutoSize = true;
            this.lblPaymentDateValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentDateValue.Location = new System.Drawing.Point(209, 164);
            this.lblPaymentDateValue.Name = "lblPaymentDateValue";
            this.lblPaymentDateValue.Size = new System.Drawing.Size(31, 21);
            this.lblPaymentDateValue.TabIndex = 42;
            this.lblPaymentDateValue.Text = "???";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentID.ForeColor = System.Drawing.Color.White;
            this.lblPaymentID.Location = new System.Drawing.Point(44, 42);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(99, 21);
            this.lblPaymentID.TabIndex = 40;
            this.lblPaymentID.Text = "Payment ID";
            // 
            // lblPaymentIDValue
            // 
            this.lblPaymentIDValue.AutoSize = true;
            this.lblPaymentIDValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentIDValue.Location = new System.Drawing.Point(209, 42);
            this.lblPaymentIDValue.Name = "lblPaymentIDValue";
            this.lblPaymentIDValue.Size = new System.Drawing.Size(31, 21);
            this.lblPaymentIDValue.TabIndex = 41;
            this.lblPaymentIDValue.Text = "???";
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembershipID.ForeColor = System.Drawing.Color.White;
            this.lblMembershipID.Location = new System.Drawing.Point(44, 103);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(127, 21);
            this.lblMembershipID.TabIndex = 26;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // lblMembershipIDValue
            // 
            this.lblMembershipIDValue.AutoSize = true;
            this.lblMembershipIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMembershipIDValue.Location = new System.Drawing.Point(209, 103);
            this.lblMembershipIDValue.Name = "lblMembershipIDValue";
            this.lblMembershipIDValue.Size = new System.Drawing.Size(31, 21);
            this.lblMembershipIDValue.TabIndex = 27;
            this.lblMembershipIDValue.Text = "???";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentDate.ForeColor = System.Drawing.Color.White;
            this.lblPaymentDate.Location = new System.Drawing.Point(44, 164);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(118, 21);
            this.lblPaymentDate.TabIndex = 28;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.lblPaidAmountValue);
            this.panel1.Controls.Add(this.lblPaymentID);
            this.panel1.Controls.Add(this.lblPaidAmount);
            this.panel1.Controls.Add(this.lblRemainingAmountValue);
            this.panel1.Controls.Add(this.lblPaymentDate);
            this.panel1.Controls.Add(this.lblRemainingAmount);
            this.panel1.Controls.Add(this.lblMembershipIDValue);
            this.panel1.Controls.Add(this.lblMembershipID);
            this.panel1.Controls.Add(this.lblCreatedByValue);
            this.panel1.Controls.Add(this.lblPaymentIDValue);
            this.panel1.Controls.Add(this.lblCreatedBy);
            this.panel1.Controls.Add(this.lblPaymentDateValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 447);
            this.panel1.TabIndex = 50;
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbAmount.BorderColor = System.Drawing.Color.LightGray;
            this.tbAmount.BorderRadius = 5;
            this.tbAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAmount.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbAmount.ForeColor = System.Drawing.Color.White;
            this.tbAmount.Location = new System.Drawing.Point(672, 164);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAmount.Multiline = false;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PasswordChar = '\0';
            this.tbAmount.PlaceholderText = "Amount";
            this.tbAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAmount.Size = new System.Drawing.Size(292, 45);
            this.tbAmount.TabIndex = 50;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAmount.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucMembershipFinder1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(66, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 447);
            this.panel2.TabIndex = 51;
            // 
            // ucMembershipFinder1
            // 
            this.ucMembershipFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMembershipFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMembershipFinder1.FilteringEnabled = true;
            this.ucMembershipFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMembershipFinder1.Location = new System.Drawing.Point(0, 0);
            this.ucMembershipFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMembershipFinder1.Name = "ucMembershipFinder1";
            this.ucMembershipFinder1.Size = new System.Drawing.Size(1073, 447);
            this.ucMembershipFinder1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1025, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 41);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            segmentedItem5.Icon = FontAwesome.Sharp.IconChar.None;
            segmentedItem5.Text = "Membership Information";
            segmentedItem6.Icon = FontAwesome.Sharp.IconChar.None;
            segmentedItem6.Text = "Payment Information";
            this.customSegmentedControl1.Items.Add(segmentedItem5);
            this.customSegmentedControl1.Items.Add(segmentedItem6);
            this.customSegmentedControl1.Location = new System.Drawing.Point(66, 30);
            this.customSegmentedControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customSegmentedControl1.Name = "customSegmentedControl1";
            this.customSegmentedControl1.SelectedColor = System.Drawing.Color.Gray;
            this.customSegmentedControl1.SelectedIndex = 0;
            this.customSegmentedControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.customSegmentedControl1.Size = new System.Drawing.Size(724, 52);
            this.customSegmentedControl1.TabIndex = 49;
            this.customSegmentedControl1.UnselectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.customSegmentedControl1.UnselectedTextColor = System.Drawing.Color.White;
            this.customSegmentedControl1.SelectedItemChanged += new System.EventHandler(this.customSegmentedControl1_SelectedItemChanged);
            // 
            // frmAddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1206, 663);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customSegmentedControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPayment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPayment";
            this.Load += new System.EventHandler(this.frmAddEditPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblMembershipIDValue;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblPaymentIDValue;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblPaymentDateValue;
        private System.Windows.Forms.Label lblPaidAmountValue;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblRemainingAmountValue;
        private System.Windows.Forms.Label lblRemainingAmount;
        private Controls.CustomSegmentedControl customSegmentedControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Memberships.ucMembershipFinder ucMembershipFinder1;
        private Controls.CustomTextBox tbAmount;
        private UserControls.CustomIconButton btnSave;
    }
}