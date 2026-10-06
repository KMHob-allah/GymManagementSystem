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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpMembershipInfo = new System.Windows.Forms.TabPage();
            this.ucMembershipFinder1 = new GymManagementSystem.UI.Memberships.ucMembershipFinder();
            this.tpPaymentInfo = new System.Windows.Forms.TabPage();
            this.gbPaymentDetails = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblPaymentDateValue = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblPaymentIDValue = new System.Windows.Forms.Label();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblMembershipIDValue = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRemainingAmountValue = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblPaidAmountValue = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcInfo.SuspendLayout();
            this.tpMembershipInfo.SuspendLayout();
            this.tpPaymentInfo.SuspendLayout();
            this.gbPaymentDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(1024, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 35);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(50, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1151, 72);
            this.panel4.TabIndex = 46;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tcInfo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.panel1.Size = new System.Drawing.Size(1251, 703);
            this.panel1.TabIndex = 45;
            // 
            // tcInfo
            // 
            this.tcInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcInfo.Controls.Add(this.tpMembershipInfo);
            this.tcInfo.Controls.Add(this.tpPaymentInfo);
            this.tcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tcInfo.Location = new System.Drawing.Point(50, 25);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(1151, 581);
            this.tcInfo.TabIndex = 47;
            this.tcInfo.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcInfo_Selecting);
            // 
            // tpMembershipInfo
            // 
            this.tpMembershipInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tpMembershipInfo.Controls.Add(this.ucMembershipFinder1);
            this.tpMembershipInfo.ForeColor = System.Drawing.Color.Black;
            this.tpMembershipInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tpMembershipInfo.Location = new System.Drawing.Point(4, 33);
            this.tpMembershipInfo.Name = "tpMembershipInfo";
            this.tpMembershipInfo.Padding = new System.Windows.Forms.Padding(25);
            this.tpMembershipInfo.Size = new System.Drawing.Size(1143, 544);
            this.tpMembershipInfo.TabIndex = 0;
            this.tpMembershipInfo.Text = "Membership Information";
            // 
            // ucMembershipFinder1
            // 
            this.ucMembershipFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMembershipFinder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMembershipFinder1.FilteringEnabled = true;
            this.ucMembershipFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMembershipFinder1.Location = new System.Drawing.Point(25, 25);
            this.ucMembershipFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMembershipFinder1.Name = "ucMembershipFinder1";
            this.ucMembershipFinder1.Size = new System.Drawing.Size(1093, 494);
            this.ucMembershipFinder1.TabIndex = 0;
            this.ucMembershipFinder1.MembershipSelected += new System.EventHandler(this.ucMembershipFinder1_MembershipSelected_1);
            // 
            // tpPaymentInfo
            // 
            this.tpPaymentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tpPaymentInfo.Controls.Add(this.gbPaymentDetails);
            this.tpPaymentInfo.Location = new System.Drawing.Point(4, 33);
            this.tpPaymentInfo.Name = "tpPaymentInfo";
            this.tpPaymentInfo.Padding = new System.Windows.Forms.Padding(25);
            this.tpPaymentInfo.Size = new System.Drawing.Size(1143, 544);
            this.tpPaymentInfo.TabIndex = 2;
            this.tpPaymentInfo.Text = "Payment Information";
            // 
            // gbPaymentDetails
            // 
            this.gbPaymentDetails.Controls.Add(this.lblPaidAmountValue);
            this.gbPaymentDetails.Controls.Add(this.lblPaidAmount);
            this.gbPaymentDetails.Controls.Add(this.lblRemainingAmountValue);
            this.gbPaymentDetails.Controls.Add(this.lblRemainingAmount);
            this.gbPaymentDetails.Controls.Add(this.textBox1);
            this.gbPaymentDetails.Controls.Add(this.lblCreatedByValue);
            this.gbPaymentDetails.Controls.Add(this.lblCreatedBy);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentDateValue);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentID);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentIDValue);
            this.gbPaymentDetails.Controls.Add(this.lblMembershipID);
            this.gbPaymentDetails.Controls.Add(this.lblMembershipIDValue);
            this.gbPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.gbPaymentDetails.Controls.Add(this.lblAmount);
            this.gbPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaymentDetails.ForeColor = System.Drawing.Color.White;
            this.gbPaymentDetails.Location = new System.Drawing.Point(25, 25);
            this.gbPaymentDetails.Name = "gbPaymentDetails";
            this.gbPaymentDetails.Size = new System.Drawing.Size(1093, 494);
            this.gbPaymentDetails.TabIndex = 41;
            this.gbPaymentDetails.TabStop = false;
            this.gbPaymentDetails.Text = "Payment Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(891, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 29);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.White;
            this.lblCreatedByValue.Location = new System.Drawing.Point(208, 274);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(43, 274);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(92, 21);
            this.lblCreatedBy.TabIndex = 43;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblPaymentDateValue
            // 
            this.lblPaymentDateValue.AutoSize = true;
            this.lblPaymentDateValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentDateValue.Location = new System.Drawing.Point(208, 218);
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
            this.lblPaymentID.Location = new System.Drawing.Point(43, 96);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(99, 21);
            this.lblPaymentID.TabIndex = 40;
            this.lblPaymentID.Text = "Payment ID";
            // 
            // lblPaymentIDValue
            // 
            this.lblPaymentIDValue.AutoSize = true;
            this.lblPaymentIDValue.ForeColor = System.Drawing.Color.White;
            this.lblPaymentIDValue.Location = new System.Drawing.Point(208, 96);
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
            this.lblMembershipID.Location = new System.Drawing.Point(43, 157);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(127, 21);
            this.lblMembershipID.TabIndex = 26;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // lblMembershipIDValue
            // 
            this.lblMembershipIDValue.AutoSize = true;
            this.lblMembershipIDValue.ForeColor = System.Drawing.Color.White;
            this.lblMembershipIDValue.Location = new System.Drawing.Point(208, 157);
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
            this.lblPaymentDate.Location = new System.Drawing.Point(43, 218);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(118, 21);
            this.lblPaymentDate.TabIndex = 28;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(706, 218);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 21);
            this.lblAmount.TabIndex = 36;
            this.lblAmount.Text = "Amount";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1251, 71);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Add New Payment";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 71);
            this.panel2.TabIndex = 44;
            // 
            // lblRemainingAmountValue
            // 
            this.lblRemainingAmountValue.AutoSize = true;
            this.lblRemainingAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblRemainingAmountValue.Location = new System.Drawing.Point(887, 157);
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
            this.lblRemainingAmount.Location = new System.Drawing.Point(706, 157);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(159, 21);
            this.lblRemainingAmount.TabIndex = 46;
            this.lblRemainingAmount.Text = "Remaining Amount";
            // 
            // lblPaidAmountValue
            // 
            this.lblPaidAmountValue.AutoSize = true;
            this.lblPaidAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblPaidAmountValue.Location = new System.Drawing.Point(887, 96);
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
            this.lblPaidAmount.Location = new System.Drawing.Point(706, 96);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(110, 21);
            this.lblPaidAmount.TabIndex = 48;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // frmAddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1251, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPayment";
            this.Load += new System.EventHandler(this.frmAddEditPayment_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tcInfo.ResumeLayout(false);
            this.tpMembershipInfo.ResumeLayout(false);
            this.tpPaymentInfo.ResumeLayout(false);
            this.gbPaymentDetails.ResumeLayout(false);
            this.gbPaymentDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnNext;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tpMembershipInfo;
        private System.Windows.Forms.TabPage tpPaymentInfo;
        private System.Windows.Forms.GroupBox gbPaymentDetails;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblMembershipIDValue;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblPaymentIDValue;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblPaymentDateValue;
        private System.Windows.Forms.TextBox textBox1;
        private Memberships.ucMembershipFinder ucMembershipFinder1;
        private System.Windows.Forms.Label lblPaidAmountValue;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblRemainingAmountValue;
        private System.Windows.Forms.Label lblRemainingAmount;
    }
}