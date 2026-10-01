namespace GymManagementSystem.UI.Members
{
    partial class frmMemberDetails
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
            this.ucMemberDetails1 = new GymManagementSystem.UI.Members.ucMemberDetails();
            this.SuspendLayout();
            // 
            // ucMemberDetails1
            // 
            this.ucMemberDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucMemberDetails1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMemberDetails1.Location = new System.Drawing.Point(32, 33);
            this.ucMemberDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMemberDetails1.Name = "ucMemberDetails1";
            this.ucMemberDetails1.Size = new System.Drawing.Size(885, 510);
            this.ucMemberDetails1.TabIndex = 0;
            // 
            // frmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(952, 572);
            this.Controls.Add(this.ucMemberDetails1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.frmMemberDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucMemberDetails ucMemberDetails1;
    }
}