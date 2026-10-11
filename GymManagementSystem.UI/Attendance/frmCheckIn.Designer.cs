namespace GymManagementSystem.UI.Attendance
{
    partial class frmCheckIn
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
            this.ucMembershipFinder1 = new GymManagementSystem.UI.Memberships.ucMembershipFinder();
            this.btnCheckIn = new GymManagementSystem.UI.UserControls.CustomIconButton();
            this.SuspendLayout();
            // 
            // ucMembershipFinder1
            // 
            this.ucMembershipFinder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMembershipFinder1.FilteringEnabled = true;
            this.ucMembershipFinder1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMembershipFinder1.Location = new System.Drawing.Point(35, 32);
            this.ucMembershipFinder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMembershipFinder1.Name = "ucMembershipFinder1";
            this.ucMembershipFinder1.Size = new System.Drawing.Size(1236, 452);
            this.ucMembershipFinder1.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.White;
            this.btnCheckIn.BorderRadius = 10;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnCheckIn.IconColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckIn.IconSize = 30;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckIn.Location = new System.Drawing.Point(1150, 511);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(121, 33);
            this.btnCheckIn.TabIndex = 47;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click_1);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1308, 572);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.ucMembershipFinder1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Memberships.ucMembershipFinder ucMembershipFinder1;
        private UserControls.CustomIconButton btnCheckIn;
    }
}