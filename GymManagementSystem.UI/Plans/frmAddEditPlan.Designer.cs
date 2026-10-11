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
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.lblPlanIDValue = new System.Windows.Forms.Label();
            this.errpAddEditPlan = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPrice = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.tbDurationInDays = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.tbPlanName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.btnSave = new GymManagementSystem.UI.UserControls.CustomIconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditPlan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanID.ForeColor = System.Drawing.Color.White;
            this.lblPlanID.Location = new System.Drawing.Point(37, 32);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(65, 21);
            this.lblPlanID.TabIndex = 1;
            this.lblPlanID.Text = "Plan ID";
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.ForeColor = System.Drawing.Color.White;
            this.ckbActive.Location = new System.Drawing.Point(37, 328);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(65, 23);
            this.ckbActive.TabIndex = 25;
            this.ckbActive.Text = "Active";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // lblPlanIDValue
            // 
            this.lblPlanIDValue.AutoSize = true;
            this.lblPlanIDValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPlanIDValue.ForeColor = System.Drawing.Color.White;
            this.lblPlanIDValue.Location = new System.Drawing.Point(136, 32);
            this.lblPlanIDValue.Name = "lblPlanIDValue";
            this.lblPlanIDValue.Size = new System.Drawing.Size(48, 21);
            this.lblPlanIDValue.TabIndex = 2;
            this.lblPlanIDValue.Text = "[A/N]";
            // 
            // errpAddEditPlan
            // 
            this.errpAddEditPlan.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbDurationInDays);
            this.panel1.Controls.Add(this.tbPlanName);
            this.panel1.Controls.Add(this.lblPlanID);
            this.panel1.Controls.Add(this.ckbActive);
            this.panel1.Controls.Add(this.lblPlanIDValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(60, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 382);
            this.panel1.TabIndex = 26;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbPrice.BorderColor = System.Drawing.Color.LightGray;
            this.tbPrice.BorderRadius = 5;
            this.tbPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPrice.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(37, 249);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "price";
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.Size = new System.Drawing.Size(440, 46);
            this.tbPrice.TabIndex = 46;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPrice.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // tbDurationInDays
            // 
            this.tbDurationInDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbDurationInDays.BorderColor = System.Drawing.Color.LightGray;
            this.tbDurationInDays.BorderRadius = 5;
            this.tbDurationInDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDurationInDays.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbDurationInDays.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbDurationInDays.ForeColor = System.Drawing.Color.White;
            this.tbDurationInDays.Location = new System.Drawing.Point(37, 174);
            this.tbDurationInDays.Margin = new System.Windows.Forms.Padding(4);
            this.tbDurationInDays.Multiline = false;
            this.tbDurationInDays.Name = "tbDurationInDays";
            this.tbDurationInDays.PasswordChar = '\0';
            this.tbDurationInDays.PlaceholderText = "duration (days)";
            this.tbDurationInDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDurationInDays.Size = new System.Drawing.Size(440, 46);
            this.tbDurationInDays.TabIndex = 45;
            this.tbDurationInDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDurationInDays.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.tbDurationInDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDurationInDays_KeyPress);
            this.tbDurationInDays.Validating += new System.ComponentModel.CancelEventHandler(this.tbDurationInDays_Validating);
            // 
            // tbPlanName
            // 
            this.tbPlanName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbPlanName.BorderColor = System.Drawing.Color.LightGray;
            this.tbPlanName.BorderRadius = 5;
            this.tbPlanName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPlanName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbPlanName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbPlanName.ForeColor = System.Drawing.Color.White;
            this.tbPlanName.Location = new System.Drawing.Point(37, 99);
            this.tbPlanName.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlanName.Multiline = false;
            this.tbPlanName.Name = "tbPlanName";
            this.tbPlanName.PasswordChar = '\0';
            this.tbPlanName.PlaceholderText = "plan name";
            this.tbPlanName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlanName.Size = new System.Drawing.Size(440, 46);
            this.tbPlanName.TabIndex = 44;
            this.tbPlanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPlanName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.tbPlanName.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlanName_Validating);
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
            this.btnSave.Location = new System.Drawing.Point(818, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 33);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // frmAddEditPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(999, 502);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPlan";
            this.Padding = new System.Windows.Forms.Padding(60, 50, 60, 70);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Plan";
            this.Load += new System.EventHandler(this.frmAddEditPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpAddEditPlan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.Label lblPlanIDValue;
        private System.Windows.Forms.ErrorProvider errpAddEditPlan;
        private System.Windows.Forms.Panel panel1;
        private UserControls.CustomIconButton btnSave;
        private Controls.CustomTextBox tbDurationInDays;
        private Controls.CustomTextBox tbPlanName;
        private Controls.CustomTextBox tbPrice;
    }
}