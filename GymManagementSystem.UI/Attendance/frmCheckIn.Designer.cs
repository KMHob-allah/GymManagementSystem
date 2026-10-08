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
            this.btnCheckIn = new FontAwesome.Sharp.IconButton();
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
            this.ucMembershipFinder1.Size = new System.Drawing.Size(1236, 492);
            this.ucMembershipFinder1.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnCheckIn.IconColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckIn.IconSize = 30;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.Location = new System.Drawing.Point(1144, 547);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(127, 35);
            this.btnCheckIn.TabIndex = 54;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1308, 596);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.ucMembershipFinder1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Memberships.ucMembershipFinder ucMembershipFinder1;
        private FontAwesome.Sharp.IconButton btnCheckIn;
    }
}