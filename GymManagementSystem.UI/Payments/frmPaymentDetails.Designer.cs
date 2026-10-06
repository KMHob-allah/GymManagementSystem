namespace GymManagementSystem.UI.Payments
{
    partial class frmPaymentDetails
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
            this.ucPaymentCard1 = new GymManagementSystem.UI.Payments.ucPaymentCard();
            this.SuspendLayout();
            // 
            // ucPaymentCard1
            // 
            this.ucPaymentCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucPaymentCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPaymentCard1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucPaymentCard1.Location = new System.Drawing.Point(30, 30);
            this.ucPaymentCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPaymentCard1.Name = "ucPaymentCard1";
            this.ucPaymentCard1.Size = new System.Drawing.Size(972, 360);
            this.ucPaymentCard1.TabIndex = 0;
            // 
            // frmPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1032, 420);
            this.Controls.Add(this.ucPaymentCard1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentDetails";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.frmMembershipDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPaymentCard ucPaymentCard1;
    }
}