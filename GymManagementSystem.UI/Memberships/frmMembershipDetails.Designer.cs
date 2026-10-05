namespace GymManagementSystem.UI.Memberships
{
    partial class frmMembershipDetails
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
            this.ucMembershipCard1 = new GymManagementSystem.UI.Memberships.ucMembershipCard();
            this.SuspendLayout();
            // 
            // ucMembershipCard1
            // 
            this.ucMembershipCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucMembershipCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMembershipCard1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMembershipCard1.Location = new System.Drawing.Point(15, 15);
            this.ucMembershipCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMembershipCard1.Name = "ucMembershipCard1";
            this.ucMembershipCard1.Size = new System.Drawing.Size(1002, 391);
            this.ucMembershipCard1.TabIndex = 0;
            // 
            // frmMembershipDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1032, 421);
            this.Controls.Add(this.ucMembershipCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMembershipDetails";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Details";
            this.Load += new System.EventHandler(this.frmMembershipDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucMembershipCard ucMembershipCard1;
    }
}