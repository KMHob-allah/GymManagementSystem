namespace GymManagementSystem.UI.Plans
{
    partial class frmPlanDetails
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
            this.ucPlanCard1 = new GymManagementSystem.UI.Plans.ucPlanCard();
            this.SuspendLayout();
            // 
            // ucPlanCard1
            // 
            this.ucPlanCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucPlanCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanCard1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucPlanCard1.Location = new System.Drawing.Point(30, 30);
            this.ucPlanCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanCard1.Name = "ucPlanCard1";
            this.ucPlanCard1.Size = new System.Drawing.Size(973, 285);
            this.ucPlanCard1.TabIndex = 0;
            // 
            // frmPlanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1033, 345);
            this.Controls.Add(this.ucPlanCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanDetails";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan Details";
            this.Load += new System.EventHandler(this.frmPlanDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPlanCard ucPlanCard1;
    }
}