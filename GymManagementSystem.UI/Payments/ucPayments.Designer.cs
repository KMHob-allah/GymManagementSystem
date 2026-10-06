namespace GymManagementSystem.UI.Payments
{
    partial class ucPayments
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddPayment = new FontAwesome.Sharp.IconButton();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.updateAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucTotalRevenueCard = new GymManagementSystem.UI.ucCard();
            this.ucTodayRevenue = new GymManagementSystem.UI.ucCard();
            this.ucTotalDebtCard = new GymManagementSystem.UI.ucCard();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cmsPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvPayments);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(10, 271);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1154, 205);
            this.pnlGrid.TabIndex = 46;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.ColumnHeadersHeight = 45;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayments.ContextMenuStrip = this.cmsPayments;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dgvPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowTemplate.Height = 40;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(1154, 205);
            this.dgvPayments.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.dtpFilterDate);
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Controls.Add(this.cbFilterBy);
            this.pnlFilters.Controls.Add(this.tbFilterValue);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(10, 210);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1154, 61);
            this.pnlFilters.TabIndex = 45;
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFilterDate.Location = new System.Drawing.Point(307, 17);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(241, 25);
            this.dtpFilterDate.TabIndex = 32;
            this.dtpFilterDate.Value = new System.DateTime(2026, 10, 6, 19, 51, 0, 0);
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.FilterData);
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
            // tlpCards
            // 
            this.tlpCards.ColumnCount = 3;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.Controls.Add(this.ucTotalRevenueCard, 0, 0);
            this.tlpCards.Controls.Add(this.ucTodayRevenue, 2, 0);
            this.tlpCards.Controls.Add(this.ucTotalDebtCard, 1, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(10, 82);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1154, 128);
            this.tlpCards.TabIndex = 44;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblNoRecords);
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(10, 476);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1154, 54);
            this.pnlFooter.TabIndex = 43;
            // 
            // lblNoRecords
            // 
            this.lblNoRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoRecords.AutoSize = true;
            this.lblNoRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.lblNoRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblNoRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRecords.Location = new System.Drawing.Point(872, 17);
            this.lblNoRecords.Name = "lblNoRecords";
            this.lblNoRecords.Size = new System.Drawing.Size(278, 21);
            this.lblNoRecords.TabIndex = 29;
            this.lblNoRecords.Text = "No payments available at the moment";
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
            this.pnlHeader.Controls.Add(this.btnAddPayment);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1154, 72);
            this.pnlHeader.TabIndex = 42;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.Color.Black;
            this.btnAddPayment.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddPayment.IconColor = System.Drawing.Color.Black;
            this.btnAddPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPayment.IconSize = 20;
            this.btnAddPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPayment.Location = new System.Drawing.Point(1009, 20);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(144, 32);
            this.btnAddPayment.TabIndex = 26;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(246, 17);
            this.lblSubtitle.TabIndex = 28;
            this.lblSubtitle.Text = "Manage membership payment information";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 32);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Payments";
            // 
            // cmsPayments
            // 
            this.cmsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateAmountToolStripMenuItem});
            this.cmsPayments.Name = "cmsMembers";
            this.cmsPayments.Size = new System.Drawing.Size(160, 54);
            this.cmsPayments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPayments_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // updateAmountToolStripMenuItem
            // 
            this.updateAmountToolStripMenuItem.Name = "updateAmountToolStripMenuItem";
            this.updateAmountToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.updateAmountToolStripMenuItem.Text = "Update Amount";
            this.updateAmountToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ucTotalRevenueCard
            // 
            this.ucTotalRevenueCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTotalRevenueCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTotalRevenueCard.Icon = FontAwesome.Sharp.IconChar.SackDollar;
            this.ucTotalRevenueCard.Location = new System.Drawing.Point(6, 7);
            this.ucTotalRevenueCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucTotalRevenueCard.Name = "ucTotalRevenueCard";
            this.ucTotalRevenueCard.Number = "0";
            this.ucTotalRevenueCard.Size = new System.Drawing.Size(372, 114);
            this.ucTotalRevenueCard.TabIndex = 3;
            this.ucTotalRevenueCard.Title = "Total Revenue";
            // 
            // ucTodayRevenue
            // 
            this.ucTodayRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTodayRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTodayRevenue.Icon = FontAwesome.Sharp.IconChar.CashRegister;
            this.ucTodayRevenue.Location = new System.Drawing.Point(774, 7);
            this.ucTodayRevenue.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucTodayRevenue.Name = "ucTodayRevenue";
            this.ucTodayRevenue.Number = "0";
            this.ucTodayRevenue.Size = new System.Drawing.Size(374, 114);
            this.ucTodayRevenue.TabIndex = 0;
            this.ucTodayRevenue.Title = "Today Revenue";
            // 
            // ucTotalDebtCard
            // 
            this.ucTotalDebtCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTotalDebtCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTotalDebtCard.Icon = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ucTotalDebtCard.Location = new System.Drawing.Point(390, 7);
            this.ucTotalDebtCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucTotalDebtCard.Name = "ucTotalDebtCard";
            this.ucTotalDebtCard.Number = "0";
            this.ucTotalDebtCard.Size = new System.Drawing.Size(372, 114);
            this.ucTotalDebtCard.TabIndex = 2;
            this.ucTotalDebtCard.Title = "Total Debt";
            // 
            // ucPayments
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
            this.Name = "ucPayments";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1174, 540);
            this.Load += new System.EventHandler(this.ucPayments_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cmsPayments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private ucCard ucTotalRevenueCard;
        private ucCard ucTodayRevenue;
        private ucCard ucTotalDebtCard;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNoRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnAddPayment;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cmsPayments;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateAmountToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
    }
}
