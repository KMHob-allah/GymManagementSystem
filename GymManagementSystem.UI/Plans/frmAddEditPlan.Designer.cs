namespace GymManagementSystem.UI.Plans
{
    partial class frmAddEditPlan
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
            this.lblPlanID = new System.Windows.Forms.Label();
            this.tbDurationInDays = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPlanInfo = new System.Windows.Forms.GroupBox();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.tbPlanName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPlanIDValue = new System.Windows.Forms.Label();
            this.lblDurationInDays = new System.Windows.Forms.Label();
            this.errpAddEditPlan = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPlanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanID.ForeColor = System.Drawing.Color.White;
            this.lblPlanID.Location = new System.Drawing.Point(24, 52);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(65, 21);
            this.lblPlanID.TabIndex = 1;
            this.lblPlanID.Text = "Plan ID";
            // 
            // tbDurationInDays
            // 
            this.tbDurationInDays.BackColor = System.Drawing.Color.White;
            this.tbDurationInDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDurationInDays.Location = new System.Drawing.Point(167, 187);
            this.tbDurationInDays.MaxLength = 11;
            this.tbDurationInDays.Name = "tbDurationInDays";
            this.tbDurationInDays.Size = new System.Drawing.Size(202, 29);
            this.tbDurationInDays.TabIndex = 21;
            this.tbDurationInDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDurationInDays_KeyPress);
            this.tbDurationInDays.Validating += new System.ComponentModel.CancelEventHandler(this.tbDurationInDays_Validating);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.White;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Location = new System.Drawing.Point(167, 264);
            this.tbPrice.MaxLength = 11;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(202, 29);
            this.tbPrice.TabIndex = 22;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.ForeColor = System.Drawing.Color.White;
            this.ckbActive.Location = new System.Drawing.Point(167, 331);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(71, 25);
            this.ckbActive.TabIndex = 25;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1106, 493);
            this.pnlContainer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 60);
            this.panel2.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(862, 12);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(981, 12);
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
            this.panel1.Controls.Add(this.gbPlanInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel1.Size = new System.Drawing.Size(1106, 421);
            this.panel1.TabIndex = 26;
            // 
            // gbPlanInfo
            // 
            this.gbPlanInfo.Controls.Add(this.lblPlanID);
            this.gbPlanInfo.Controls.Add(this.tbDurationInDays);
            this.gbPlanInfo.Controls.Add(this.tbPrice);
            this.gbPlanInfo.Controls.Add(this.ckbActive);
            this.gbPlanInfo.Controls.Add(this.lblPlanName);
            this.gbPlanInfo.Controls.Add(this.tbPlanName);
            this.gbPlanInfo.Controls.Add(this.lblPrice);
            this.gbPlanInfo.Controls.Add(this.lblPlanIDValue);
            this.gbPlanInfo.Controls.Add(this.lblDurationInDays);
            this.gbPlanInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlanInfo.ForeColor = System.Drawing.Color.White;
            this.gbPlanInfo.Location = new System.Drawing.Point(20, 20);
            this.gbPlanInfo.Name = "gbPlanInfo";
            this.gbPlanInfo.Size = new System.Drawing.Size(1066, 391);
            this.gbPlanInfo.TabIndex = 26;
            this.gbPlanInfo.TabStop = false;
            this.gbPlanInfo.Text = "Member Info";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanName.ForeColor = System.Drawing.Color.White;
            this.lblPlanName.Location = new System.Drawing.Point(24, 122);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(56, 21);
            this.lblPlanName.TabIndex = 3;
            this.lblPlanName.Text = "Name";
            // 
            // tbPlanName
            // 
            this.tbPlanName.BackColor = System.Drawing.Color.White;
            this.tbPlanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlanName.Location = new System.Drawing.Point(167, 120);
            this.tbPlanName.MaxLength = 50;
            this.tbPlanName.Name = "tbPlanName";
            this.tbPlanName.Size = new System.Drawing.Size(202, 29);
            this.tbPlanName.TabIndex = 4;
            this.tbPlanName.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlanName_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(24, 266);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 21);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price";
            // 
            // lblPlanIDValue
            // 
            this.lblPlanIDValue.AutoSize = true;
            this.lblPlanIDValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPlanIDValue.ForeColor = System.Drawing.Color.White;
            this.lblPlanIDValue.Location = new System.Drawing.Point(163, 52);
            this.lblPlanIDValue.Name = "lblPlanIDValue";
            this.lblPlanIDValue.Size = new System.Drawing.Size(48, 21);
            this.lblPlanIDValue.TabIndex = 2;
            this.lblPlanIDValue.Text = "[A/N]";
            // 
            // lblDurationInDays
            // 
            this.lblDurationInDays.AutoSize = true;
            this.lblDurationInDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurationInDays.ForeColor = System.Drawing.Color.White;
            this.lblDurationInDays.Location = new System.Drawing.Point(20, 189);
            this.lblDurationInDays.Name = "lblDurationInDays";
            this.lblDurationInDays.Size = new System.Drawing.Size(131, 21);
            this.lblDurationInDays.TabIndex = 20;
            this.lblDurationInDays.Text = "Duration (Days)";
            // 
            // errpAddEditPlan
            // 
            this.errpAddEditPlan.ContainerControl = this;
            // 
            // frmAddEditPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1106, 493);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Plan";
            this.Load += new System.EventHandler(this.frmAddEditPlan_Load);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbPlanInfo.ResumeLayout(false);
            this.gbPlanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.TextBox tbDurationInDays;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPlanInfo;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.TextBox tbPlanName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPlanIDValue;
        private System.Windows.Forms.Label lblDurationInDays;
        private System.Windows.Forms.ErrorProvider errpAddEditPlan;
    }
}