namespace GymManagementSystem.UI
{
    partial class ucCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.IcnbtnIcon = new FontAwesome.Sharp.IconButton();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.IcnbtnIcon);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 117);
            this.panel1.TabIndex = 8;
            // 
            // IcnbtnIcon
            // 
            this.IcnbtnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IcnbtnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.IcnbtnIcon.FlatAppearance.BorderSize = 0;
            this.IcnbtnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcnbtnIcon.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.IcnbtnIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.IcnbtnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnbtnIcon.IconSize = 30;
            this.IcnbtnIcon.Location = new System.Drawing.Point(166, 12);
            this.IcnbtnIcon.Name = "IcnbtnIcon";
            this.IcnbtnIcon.Size = new System.Drawing.Size(49, 36);
            this.IcnbtnIcon.TabIndex = 6;
            this.IcnbtnIcon.UseVisualStyleBackColor = false;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(10, 76);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(28, 32);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(147)))), ((int)(((byte)(157)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 21);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // ucCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucCard";
            this.Size = new System.Drawing.Size(231, 117);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IcnbtnIcon;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTitle;
    }
}
