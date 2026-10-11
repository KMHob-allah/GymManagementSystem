namespace GymManagementSystem.UI.Users
{
    partial class frmChangePassword
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
            this.errpPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new GymManagementSystem.UI.UserControls.CustomIconButton();
            this.tbConfirmPassword = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.tbNewPassword = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.tbOldPassword = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.ucUserFinder1 = new GymManagementSystem.UI.Users.ucUserFinder();
            ((System.ComponentModel.ISupportInitialize)(this.errpPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // errpPassword
            // 
            this.errpPassword.ContainerControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(1007, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 43);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.LightGray;
            this.tbConfirmPassword.BorderRadius = 10;
            this.tbConfirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConfirmPassword.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.tbConfirmPassword.Location = new System.Drawing.Point(35, 512);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfirmPassword.Multiline = false;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '\0';
            this.tbConfirmPassword.PlaceholderText = "confirm password";
            this.tbConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConfirmPassword.Size = new System.Drawing.Size(427, 43);
            this.tbConfirmPassword.TabIndex = 43;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfirmPassword.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbNewPassword.BorderColor = System.Drawing.Color.LightGray;
            this.tbNewPassword.BorderRadius = 10;
            this.tbNewPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNewPassword.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbNewPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbNewPassword.ForeColor = System.Drawing.Color.White;
            this.tbNewPassword.Location = new System.Drawing.Point(35, 441);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassword.Multiline = false;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '\0';
            this.tbNewPassword.PlaceholderText = "new password";
            this.tbNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNewPassword.Size = new System.Drawing.Size(427, 43);
            this.tbNewPassword.TabIndex = 42;
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPassword.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbOldPassword.BorderColor = System.Drawing.Color.LightGray;
            this.tbOldPassword.BorderRadius = 10;
            this.tbOldPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbOldPassword.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbOldPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbOldPassword.ForeColor = System.Drawing.Color.White;
            this.tbOldPassword.Location = new System.Drawing.Point(35, 371);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbOldPassword.Multiline = false;
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '\0';
            this.tbOldPassword.PlaceholderText = "old password";
            this.tbOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOldPassword.Size = new System.Drawing.Size(427, 43);
            this.tbOldPassword.TabIndex = 41;
            this.tbOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOldPassword.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // ucUserFinder1
            // 
            this.ucUserFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucUserFinder1.FilteringEnabled = true;
            this.ucUserFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucUserFinder1.Location = new System.Drawing.Point(35, 30);
            this.ucUserFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucUserFinder1.Name = "ucUserFinder1";
            this.ucUserFinder1.Size = new System.Drawing.Size(1083, 297);
            this.ucUserFinder1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1155, 610);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.ucUserFinder1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change User Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUserFinder ucUserFinder1;
        private System.Windows.Forms.ErrorProvider errpPassword;
        private Controls.CustomTextBox tbConfirmPassword;
        private Controls.CustomTextBox tbNewPassword;
        private Controls.CustomTextBox tbOldPassword;
        private UserControls.CustomIconButton btnSave;
    }
}