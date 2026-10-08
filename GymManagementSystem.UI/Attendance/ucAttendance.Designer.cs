namespace GymManagementSystem.UI.Attendance
{
    partial class ucAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.ucAllCheckinsCard = new GymManagementSystem.UI.ucCard();
            this.ucTodayCheckinsCard = new GymManagementSystem.UI.ucCard();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNoRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCheckIn = new FontAwesome.Sharp.IconButton();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvAttendance);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(15, 276);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(934, 128);
            this.pnlGrid.TabIndex = 20;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeColumns = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeight = 45;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dgvAttendance.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 40;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(934, 128);
            this.dgvAttendance.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.dtpFilterDate);
            this.pnlFilters.Controls.Add(this.lblFilter);
            this.pnlFilters.Controls.Add(this.cbFilterBy);
            this.pnlFilters.Controls.Add(this.tbFilterValue);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(15, 215);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(934, 61);
            this.pnlFilters.TabIndex = 19;
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Location = new System.Drawing.Point(307, 17);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(241, 25);
            this.dtpFilterDate.TabIndex = 1;
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
            this.tlpCards.ColumnCount = 2;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCards.Controls.Add(this.ucAllCheckinsCard, 0, 0);
            this.tlpCards.Controls.Add(this.ucTodayCheckinsCard, 1, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(15, 87);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(934, 128);
            this.tlpCards.TabIndex = 18;
            // 
            // ucAllCheckinsCard
            // 
            this.ucAllCheckinsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucAllCheckinsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAllCheckinsCard.Icon = FontAwesome.Sharp.IconChar.Users;
            this.ucAllCheckinsCard.Location = new System.Drawing.Point(5, 5);
            this.ucAllCheckinsCard.Margin = new System.Windows.Forms.Padding(5);
            this.ucAllCheckinsCard.Name = "ucAllCheckinsCard";
            this.ucAllCheckinsCard.Number = "0";
            this.ucAllCheckinsCard.Size = new System.Drawing.Size(457, 118);
            this.ucAllCheckinsCard.TabIndex = 3;
            this.ucAllCheckinsCard.Title = "All Check-ins";
            // 
            // ucTodayCheckinsCard
            // 
            this.ucTodayCheckinsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ucTodayCheckinsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTodayCheckinsCard.Icon = FontAwesome.Sharp.IconChar.UserCheck;
            this.ucTodayCheckinsCard.Location = new System.Drawing.Point(472, 5);
            this.ucTodayCheckinsCard.Margin = new System.Windows.Forms.Padding(5);
            this.ucTodayCheckinsCard.Name = "ucTodayCheckinsCard";
            this.ucTodayCheckinsCard.Number = "0";
            this.ucTodayCheckinsCard.Size = new System.Drawing.Size(457, 118);
            this.ucTodayCheckinsCard.TabIndex = 2;
            this.ucTodayCheckinsCard.Title = "Today\'s  Check-ins";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblNoRecords);
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(15, 404);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(934, 54);
            this.pnlFooter.TabIndex = 17;
            // 
            // lblNoRecords
            // 
            this.lblNoRecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoRecords.AutoSize = true;
            this.lblNoRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.lblNoRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblNoRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoRecords.Location = new System.Drawing.Point(655, 17);
            this.lblNoRecords.Name = "lblNoRecords";
            this.lblNoRecords.Size = new System.Drawing.Size(277, 21);
            this.lblNoRecords.TabIndex = 29;
            this.lblNoRecords.Text = "No Check-ins available at the moment";
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
            this.pnlHeader.Controls.Add(this.btnCheckIn);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(934, 72);
            this.pnlHeader.TabIndex = 16;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCheckIn.IconColor = System.Drawing.Color.Black;
            this.btnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckIn.IconSize = 20;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.Location = new System.Drawing.Point(816, 20);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(117, 32);
            this.btnCheckIn.TabIndex = 26;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(253, 17);
            this.lblSubtitle.TabIndex = 28;
            this.lblSubtitle.Text = "View and manage gym attendance records. ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 32);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Attendance";
            // 
            // ucAttendance
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
            this.Name = "ucAttendance";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(964, 473);
            this.Load += new System.EventHandler(this.ucAttendance_Load);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private ucCard ucAllCheckinsCard;
        private ucCard ucTodayCheckinsCard;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNoRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnCheckIn;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
    }
}
