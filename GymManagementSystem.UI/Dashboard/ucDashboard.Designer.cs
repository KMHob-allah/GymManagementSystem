namespace GymManagementSystem.UI
{
    partial class ucDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvMemberships = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblExpiringWithin = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.ucTodaysRevenueCard = new GymManagementSystem.UI.ucCard();
            this.ucActiveMembershipsCard = new GymManagementSystem.UI.ucCard();
            this.ucCurrentDebtsCard = new GymManagementSystem.UI.ucCard();
            this.ucTodaysAttendance = new GymManagementSystem.UI.ucCard();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvMemberships);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(15, 276);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1217, 263);
            this.pnlGrid.TabIndex = 46;
            // 
            // dgvMemberships
            // 
            this.dgvMemberships.AllowUserToAddRows = false;
            this.dgvMemberships.AllowUserToDeleteRows = false;
            this.dgvMemberships.AllowUserToResizeColumns = false;
            this.dgvMemberships.AllowUserToResizeRows = false;
            this.dgvMemberships.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberships.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvMemberships.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMemberships.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMemberships.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberships.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberships.ColumnHeadersHeight = 45;
            this.dgvMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberships.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMemberships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberships.EnableHeadersVisualStyles = false;
            this.dgvMemberships.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dgvMemberships.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberships.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemberships.MultiSelect = false;
            this.dgvMemberships.Name = "dgvMemberships";
            this.dgvMemberships.ReadOnly = true;
            this.dgvMemberships.RowHeadersVisible = false;
            this.dgvMemberships.RowTemplate.Height = 40;
            this.dgvMemberships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberships.Size = new System.Drawing.Size(1217, 263);
            this.dgvMemberships.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.lblExpiringWithin);
            this.pnlFilters.Controls.Add(this.cbFilterBy);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(15, 215);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1217, 61);
            this.pnlFilters.TabIndex = 45;
            // 
            // lblExpiringWithin
            // 
            this.lblExpiringWithin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpiringWithin.AutoSize = true;
            this.lblExpiringWithin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblExpiringWithin.ForeColor = System.Drawing.Color.White;
            this.lblExpiringWithin.Location = new System.Drawing.Point(3, 17);
            this.lblExpiringWithin.Name = "lblExpiringWithin";
            this.lblExpiringWithin.Size = new System.Drawing.Size(123, 21);
            this.lblExpiringWithin.TabIndex = 30;
            this.lblExpiringWithin.Text = "Expiring Within :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(130, 14);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(241, 29);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // tlpCards
            // 
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.ucTodaysRevenueCard, 3, 0);
            this.tlpCards.Controls.Add(this.ucActiveMembershipsCard, 0, 0);
            this.tlpCards.Controls.Add(this.ucCurrentDebtsCard, 2, 0);
            this.tlpCards.Controls.Add(this.ucTodaysAttendance, 1, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(15, 87);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1217, 128);
            this.tlpCards.TabIndex = 44;
            // 
            // ucTodaysRevenueCard
            // 
            this.ucTodaysRevenueCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTodaysRevenueCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTodaysRevenueCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucTodaysRevenueCard.Icon = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.ucTodaysRevenueCard.Location = new System.Drawing.Point(918, 9);
            this.ucTodaysRevenueCard.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ucTodaysRevenueCard.Name = "ucTodaysRevenueCard";
            this.ucTodaysRevenueCard.Number = "0";
            this.ucTodaysRevenueCard.Size = new System.Drawing.Size(293, 110);
            this.ucTodaysRevenueCard.TabIndex = 4;
            this.ucTodaysRevenueCard.Title = "Today\'s Revenue";
            // 
            // ucActiveMembershipsCard
            // 
            this.ucActiveMembershipsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucActiveMembershipsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucActiveMembershipsCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucActiveMembershipsCard.Icon = FontAwesome.Sharp.IconChar.IdCard;
            this.ucActiveMembershipsCard.Location = new System.Drawing.Point(6, 7);
            this.ucActiveMembershipsCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucActiveMembershipsCard.Name = "ucActiveMembershipsCard";
            this.ucActiveMembershipsCard.Number = "0";
            this.ucActiveMembershipsCard.Size = new System.Drawing.Size(292, 114);
            this.ucActiveMembershipsCard.TabIndex = 3;
            this.ucActiveMembershipsCard.Title = "Active Memberships";
            // 
            // ucCurrentDebtsCard
            // 
            this.ucCurrentDebtsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucCurrentDebtsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCurrentDebtsCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucCurrentDebtsCard.Icon = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ucCurrentDebtsCard.Location = new System.Drawing.Point(614, 7);
            this.ucCurrentDebtsCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucCurrentDebtsCard.Name = "ucCurrentDebtsCard";
            this.ucCurrentDebtsCard.Number = "0";
            this.ucCurrentDebtsCard.Size = new System.Drawing.Size(292, 114);
            this.ucCurrentDebtsCard.TabIndex = 0;
            this.ucCurrentDebtsCard.Title = "Current Debts";
            // 
            // ucTodaysAttendance
            // 
            this.ucTodaysAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTodaysAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTodaysAttendance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucTodaysAttendance.Icon = FontAwesome.Sharp.IconChar.UserCheck;
            this.ucTodaysAttendance.Location = new System.Drawing.Point(310, 7);
            this.ucTodaysAttendance.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucTodaysAttendance.Name = "ucTodaysAttendance";
            this.ucTodaysAttendance.Number = "0";
            this.ucTodaysAttendance.Size = new System.Drawing.Size(292, 114);
            this.ucTodaysAttendance.TabIndex = 2;
            this.ucTodaysAttendance.Title = "Today\'s Attendance";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblNoRecords);
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(15, 539);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1217, 54);
            this.pnlFooter.TabIndex = 43;
            // 
            // lblNoRecords
            // 
            this.lblNoRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoRecords.AutoSize = true;
            this.lblNoRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.lblNoRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblNoRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRecords.Location = new System.Drawing.Point(911, 17);
            this.lblNoRecords.Name = "lblNoRecords";
            this.lblNoRecords.Size = new System.Drawing.Size(302, 21);
            this.lblNoRecords.TabIndex = 29;
            this.lblNoRecords.Text = "No Memberships available at the moment";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRecords.ForeColor = System.Drawing.Color.White;
            this.lblRecords.Location = new System.Drawing.Point(1, 17);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(86, 21);
            this.lblRecords.TabIndex = 29;
            this.lblRecords.Text = "Records : 0";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1217, 72);
            this.pnlHeader.TabIndex = 42;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.lblSubtitle.Location = new System.Drawing.Point(3, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(337, 17);
            this.lblSubtitle.TabIndex = 28;
            this.lblSubtitle.Text = "Overview of the gym\'s current activity and financial status. ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Dashboard";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.Size = new System.Drawing.Size(1247, 608);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvMemberships;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblExpiringWithin;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private ucCard ucTodaysRevenueCard;
        private ucCard ucActiveMembershipsCard;
        private ucCard ucCurrentDebtsCard;
        private ucCard ucTodaysAttendance;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNoRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
