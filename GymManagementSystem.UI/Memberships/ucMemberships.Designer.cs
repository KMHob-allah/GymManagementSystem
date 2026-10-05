namespace GymManagementSystem.UI.Memberships
{
    partial class ucMemberships
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMemberships = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvMemberships = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterValue = new System.Windows.Forms.ComboBox();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.ucUpcomingMembershipsCard = new GymManagementSystem.UI.ucCard();
            this.ucAllMembershipsCard = new GymManagementSystem.UI.ucCard();
            this.ucExpiredMembershipsCard = new GymManagementSystem.UI.ucCard();
            this.ucActiveMembershipsCard = new GymManagementSystem.UI.ucCard();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddMembership = new FontAwesome.Sharp.IconButton();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsMemberships.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // cmsMemberships
            // 
            this.cmsMemberships.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.deactivateToolStripMenuItem});
            this.cmsMemberships.Name = "cmsMembers";
            this.cmsMemberships.Size = new System.Drawing.Size(181, 104);
            this.cmsMemberships.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMemberships_Opening);
            // 
            // deactivateToolStripMenuItem
            // 
            this.deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            this.deactivateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deactivateToolStripMenuItem.Text = "Record Payment";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvMemberships);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(15, 276);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1339, 273);
            this.pnlGrid.TabIndex = 41;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberships.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberships.ColumnHeadersHeight = 45;
            this.dgvMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberships.ContextMenuStrip = this.cmsMemberships;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberships.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberships.EnableHeadersVisualStyles = false;
            this.dgvMemberships.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dgvMemberships.Location = new System.Drawing.Point(0, 0);
            this.dgvMemberships.MultiSelect = false;
            this.dgvMemberships.Name = "dgvMemberships";
            this.dgvMemberships.ReadOnly = true;
            this.dgvMemberships.RowHeadersVisible = false;
            this.dgvMemberships.RowTemplate.Height = 40;
            this.dgvMemberships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberships.Size = new System.Drawing.Size(1339, 273);
            this.dgvMemberships.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Controls.Add(this.cbFilterBy);
            this.pnlFilters.Controls.Add(this.tbFilterValue);
            this.pnlFilters.Controls.Add(this.cbFilterValue);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(15, 215);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1339, 61);
            this.pnlFilters.TabIndex = 40;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(1, 17);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 21);
            this.lblFilter.TabIndex = 30;
            this.lblFilter.Text = "Filter";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(52, 17);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(241, 25);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.tbFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterValue.ForeColor = System.Drawing.Color.White;
            this.tbFilterValue.Location = new System.Drawing.Point(307, 17);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(241, 25);
            this.tbFilterValue.TabIndex = 31;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.FilterData);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cbFilterValue
            // 
            this.cbFilterValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterValue.ForeColor = System.Drawing.Color.White;
            this.cbFilterValue.FormattingEnabled = true;
            this.cbFilterValue.Location = new System.Drawing.Point(307, 17);
            this.cbFilterValue.Name = "cbFilterValue";
            this.cbFilterValue.Size = new System.Drawing.Size(241, 25);
            this.cbFilterValue.TabIndex = 32;
            this.cbFilterValue.SelectedIndexChanged += new System.EventHandler(this.FilterData);
            // 
            // tlpCards
            // 
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.ucUpcomingMembershipsCard, 3, 0);
            this.tlpCards.Controls.Add(this.ucAllMembershipsCard, 0, 0);
            this.tlpCards.Controls.Add(this.ucExpiredMembershipsCard, 2, 0);
            this.tlpCards.Controls.Add(this.ucActiveMembershipsCard, 1, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(15, 87);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1339, 128);
            this.tlpCards.TabIndex = 39;
            // 
            // ucUpcomingMembershipsCard
            // 
            this.ucUpcomingMembershipsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucUpcomingMembershipsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUpcomingMembershipsCard.Icon = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.ucUpcomingMembershipsCard.Location = new System.Drawing.Point(1009, 9);
            this.ucUpcomingMembershipsCard.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.ucUpcomingMembershipsCard.Name = "ucUpcomingMembershipsCard";
            this.ucUpcomingMembershipsCard.Number = "0";
            this.ucUpcomingMembershipsCard.Size = new System.Drawing.Size(323, 110);
            this.ucUpcomingMembershipsCard.TabIndex = 4;
            this.ucUpcomingMembershipsCard.Title = "Upcoming Memberships";
            // 
            // ucAllMembershipsCard
            // 
            this.ucAllMembershipsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucAllMembershipsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAllMembershipsCard.Icon = FontAwesome.Sharp.IconChar.LayerGroup;
            this.ucAllMembershipsCard.Location = new System.Drawing.Point(6, 7);
            this.ucAllMembershipsCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucAllMembershipsCard.Name = "ucAllMembershipsCard";
            this.ucAllMembershipsCard.Number = "0";
            this.ucAllMembershipsCard.Size = new System.Drawing.Size(322, 114);
            this.ucAllMembershipsCard.TabIndex = 3;
            this.ucAllMembershipsCard.Title = "All Memberships";
            // 
            // ucExpiredMembershipsCard
            // 
            this.ucExpiredMembershipsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucExpiredMembershipsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucExpiredMembershipsCard.Icon = FontAwesome.Sharp.IconChar.History;
            this.ucExpiredMembershipsCard.Location = new System.Drawing.Point(674, 7);
            this.ucExpiredMembershipsCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucExpiredMembershipsCard.Name = "ucExpiredMembershipsCard";
            this.ucExpiredMembershipsCard.Number = "0";
            this.ucExpiredMembershipsCard.Size = new System.Drawing.Size(322, 114);
            this.ucExpiredMembershipsCard.TabIndex = 0;
            this.ucExpiredMembershipsCard.Title = "Expired Memberships";
            // 
            // ucActiveMembershipsCard
            // 
            this.ucActiveMembershipsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucActiveMembershipsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucActiveMembershipsCard.Icon = FontAwesome.Sharp.IconChar.CircleCheck;
            this.ucActiveMembershipsCard.Location = new System.Drawing.Point(340, 7);
            this.ucActiveMembershipsCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucActiveMembershipsCard.Name = "ucActiveMembershipsCard";
            this.ucActiveMembershipsCard.Number = "0";
            this.ucActiveMembershipsCard.Size = new System.Drawing.Size(322, 114);
            this.ucActiveMembershipsCard.TabIndex = 2;
            this.ucActiveMembershipsCard.Title = "Active Memberships";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblNoRecords);
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(15, 549);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1339, 54);
            this.pnlFooter.TabIndex = 38;
            // 
            // lblNoRecords
            // 
            this.lblNoRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoRecords.AutoSize = true;
            this.lblNoRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.lblNoRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblNoRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRecords.Location = new System.Drawing.Point(1033, 17);
            this.lblNoRecords.Name = "lblNoRecords";
            this.lblNoRecords.Size = new System.Drawing.Size(303, 21);
            this.lblNoRecords.TabIndex = 29;
            this.lblNoRecords.Text = "No memberships available at the moment";
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
            this.pnlHeader.Controls.Add(this.btnAddMembership);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1339, 72);
            this.pnlHeader.TabIndex = 37;
            // 
            // btnAddMembership
            // 
            this.btnAddMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnAddMembership.FlatAppearance.BorderSize = 0;
            this.btnAddMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembership.ForeColor = System.Drawing.Color.Black;
            this.btnAddMembership.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddMembership.IconColor = System.Drawing.Color.Black;
            this.btnAddMembership.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMembership.IconSize = 20;
            this.btnAddMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMembership.Location = new System.Drawing.Point(1177, 20);
            this.btnAddMembership.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMembership.Name = "btnAddMembership";
            this.btnAddMembership.Size = new System.Drawing.Size(161, 32);
            this.btnAddMembership.TabIndex = 26;
            this.btnAddMembership.Text = "Add Membership";
            this.btnAddMembership.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMembership.UseVisualStyleBackColor = false;
            this.btnAddMembership.Click += new System.EventHandler(this.btnAddMembership_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(185, 17);
            this.lblSubtitle.TabIndex = 28;
            this.lblSubtitle.Text = "View and manage memberships";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 32);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Memberships";
            // 
            // ucMemberships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMemberships";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(1369, 618);
            this.Load += new System.EventHandler(this.ucMemberships_Load);
            this.cmsMemberships.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMemberships;
        private System.Windows.Forms.ToolStripMenuItem deactivateToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvMemberships;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterValue;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private ucCard ucAllMembershipsCard;
        private ucCard ucExpiredMembershipsCard;
        private ucCard ucActiveMembershipsCard;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNoRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnAddMembership;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private ucCard ucUpcomingMembershipsCard;
    }
}
