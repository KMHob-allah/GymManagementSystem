namespace GymManagementSystem.UI.Authentication
{
    partial class frmLogin
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tbUserName = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.tbPassword = new GymManagementSystem.UI.Controls.CustomTextBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00 = new System.Windows.Forms.Panel();
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLogin = new GymManagementSystem.UI.UserControls.CustomIconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnEye = new FontAwesome.Sharp.IconButton();
            this.pnlLogin.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(79, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gym Management System";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSubtitle.Location = new System.Drawing.Point(250, 130);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(203, 37);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Welcome Back";
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSubtitle2.Location = new System.Drawing.Point(189, 167);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(344, 37);
            this.lblSubtitle2.TabIndex = 2;
            this.lblSubtitle2.Text = "Please sign in to continue";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.White;
            this.chkRememberMe.Location = new System.Drawing.Point(73, 443);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(158, 32);
            this.chkRememberMe.TabIndex = 5;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(176, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "© 2026 Gym Management System";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Black;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.btnEye);
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.lblSubtitle);
            this.pnlLogin.Controls.Add(this.lblSubtitle2);
            this.pnlLogin.Controls.Add(this.chkRememberMe);
            this.pnlLogin.Controls.Add(this.tbUserName);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin.Location = new System.Drawing.Point(687, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLogin.Size = new System.Drawing.Size(659, 705);
            this.pnlLogin.TabIndex = 8;
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbUserName.BorderColor = System.Drawing.Color.LightGray;
            this.tbUserName.BorderRadius = 5;
            this.tbUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUserName.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(73, 287);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Multiline = false;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "user name";
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.Size = new System.Drawing.Size(511, 50);
            this.tbUserName.TabIndex = 13;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserName.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tbPassword.BorderColor = System.Drawing.Color.LightGray;
            this.tbPassword.BorderRadius = 5;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.FocusBorderColor = System.Drawing.SystemColors.GrayText;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(73, 365);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.Size = new System.Drawing.Size(511, 50);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextPadding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(681, 705);
            this.pnlImage.TabIndex = 9;
            // 
            // object_7f7ca507_5440_497c_8c93_5c184a267f00
            // 
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.Dock = System.Windows.Forms.DockStyle.Right;
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.Location = new System.Drawing.Point(658, 15);
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.Name = "object_7f7ca507_5440_497c_8c93_5c184a267f00";
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.Size = new System.Drawing.Size(673, 552);
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.TabIndex = 8;
            this.object_7f7ca507_5440_497c_8c93_5c184a267f00.Visible = false;
            // 
            // object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5
            // 
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.Dock = System.Windows.Forms.DockStyle.Right;
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.Location = new System.Drawing.Point(658, 15);
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.Name = "object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5";
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.Size = new System.Drawing.Size(673, 552);
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.TabIndex = 8;
            this.object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Image = global::GymManagementSystem.UI.Properties.Resources.Logo;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(681, 705);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 40;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(241, 570);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 50);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnExit.IconColor = System.Drawing.Color.DarkRed;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(603, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEye
            // 
            this.btnEye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.ForeColor = System.Drawing.Color.White;
            this.btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnEye.IconColor = System.Drawing.Color.White;
            this.btnEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEye.IconSize = 30;
            this.btnEye.Location = new System.Drawing.Point(533, 372);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(46, 36);
            this.btnEye.TabIndex = 8;
            this.btnEye.UseVisualStyleBackColor = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1346, 705);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbImage;
        private FontAwesome.Sharp.IconButton btnEye;
        private System.Windows.Forms.Panel object_7f7ca507_5440_497c_8c93_5c184a267f00;
        private System.Windows.Forms.Panel object_0f7d0d06_1fc9_4ee2_8be3_cd5e6a9647e5;
        private FontAwesome.Sharp.IconButton btnExit;
        private Controls.CustomTextBox tbUserName;
        private UserControls.CustomIconButton btnLogin;
        private Controls.CustomTextBox tbPassword;
    }
}