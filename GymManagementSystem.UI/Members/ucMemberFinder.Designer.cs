namespace GymManagementSystem.UI.Members
{
    partial class ucMemberFinder
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddMember = new FontAwesome.Sharp.IconButton();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.ucMemberCard1 = new GymManagementSystem.UI.Members.ucMemberCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddMember);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lblFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilter.Size = new System.Drawing.Size(1102, 100);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Search";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnAddMember.IconColor = System.Drawing.Color.White;
            this.btnAddMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMember.IconSize = 30;
            this.btnAddMember.Location = new System.Drawing.Point(633, 43);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(42, 29);
            this.btnAddMember.TabIndex = 35;
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.UseVisualStyleBackColor = false;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tbFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterValue.ForeColor = System.Drawing.Color.White;
            this.tbFilterValue.Location = new System.Drawing.Point(372, 43);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(241, 29);
            this.tbFilterValue.TabIndex = 34;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(111, 43);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(241, 29);
            this.cbFilterBy.TabIndex = 33;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(43, 46);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(61, 21);
            this.lblFilter.TabIndex = 27;
            this.lblFilter.Text = "Search";
            // 
            // ucMemberCard1
            // 
            this.ucMemberCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ucMemberCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMemberCard1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ucMemberCard1.Location = new System.Drawing.Point(0, 100);
            this.ucMemberCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMemberCard1.Name = "ucMemberCard1";
            this.ucMemberCard1.Size = new System.Drawing.Size(1102, 456);
            this.ucMemberCard1.TabIndex = 2;
            // 
            // ucMemberFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.ucMemberCard1);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMemberFinder";
            this.Size = new System.Drawing.Size(1102, 556);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private FontAwesome.Sharp.IconButton btnAddMember;
        private ucMemberCard ucMemberCard1;
    }
}
