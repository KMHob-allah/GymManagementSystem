using FontAwesome.Sharp;
using GymManagementSystem.BLL.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Members
{
    public partial class ucMembers : UserControl
    {
        private DataView _dvMembers;
        public ucMembers()
        {
            InitializeComponent();
        }

        private void _RefreshRecordsCount()
        {
            lblRecords.Text = $"Records : {dgvMembers.Rows.Count}";
        }
        private void _LoadMembers()
        {
            DataTable dtMembers = Member.GetAll();
            _dvMembers = dtMembers.DefaultView;
            dgvMembers.DataSource = _dvMembers;

            _RefreshRecordsCount();

            lblNoRecords.Visible = (dgvMembers.Rows.Count == 0);
        }
        private void ucMembers_Load(object sender, EventArgs e)
        {
            _ConfigureDataGridViewColumns();
            _LoadMembers();

            cbFilterBy.Items.AddRange(new string[] { "None", "Member ID", "Name", "Status", "Gender", "Area" });
            cbFilterBy.SelectedIndex = 0;
            cbFilterValue.Visible = false;
            tbFilterValue.Visible = false;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbFilterBy.SelectedItem?.ToString();

            tbFilterValue.Clear();
            cbFilterValue.Items.Clear();
            _dvMembers.RowFilter = "";

            switch (selectedFilter)
            {
                case "None":
                    cbFilterValue.Visible = false;
                    tbFilterValue.Visible = false;
                    break;

                case "Member ID":
                case "Name":
                case "Area":
                    cbFilterValue.Visible = false;
                    tbFilterValue.Visible = true;
                    break;

                case "Status":
                    cbFilterValue.Items.AddRange(new object[] { "All", "Active", "Inactive" });
                    cbFilterValue.SelectedIndex = 0;
                    cbFilterValue.Visible = true;
                    tbFilterValue.Visible = false;
                    break;

                case "Gender":
                    cbFilterValue.Items.AddRange(new object[] { "All", "Male", "Female" });
                    cbFilterValue.SelectedIndex = 0;
                    cbFilterValue.Visible = true;
                    tbFilterValue.Visible = false;
                    break;
            }
            _RefreshRecordsCount();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem?.ToString() == "Member ID" && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _ConfigureDataGridViewColumns()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberID", HeaderText = "Member ID" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberName", HeaderText = "Full Name" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Phone Number" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Gender" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Area", HeaderText = "Area" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" });
        }

        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembers.Columns[e.ColumnIndex].DataPropertyName == "Gender" && e.Value != null)
            {
                if (bool.TryParse(e.Value.ToString(), out bool isMale))
                {
                    e.Value = isMale ? "Male" : "Female";
                    e.FormattingApplied = true;
                }
            }

            if (dgvMembers.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                if (bool.TryParse(e.Value.ToString(), out bool isActive))
                {
                    e.Value = isActive ? "Active" : "Inactive";
                    e.FormattingApplied = true;
                }
            }
        }

        private void FilterData(object sender, EventArgs e)
        {
            if (_dvMembers == null) return;

            string filterColumn = cbFilterBy.SelectedItem?.ToString();

            if (filterColumn == "None" || string.IsNullOrEmpty(filterColumn))
            {
                _dvMembers.RowFilter = "";
                _RefreshRecordsCount();
                return;
            }

            if (tbFilterValue.Visible)
            {
                string textValue = tbFilterValue.Text.Trim();
                if (string.IsNullOrEmpty(textValue))
                {
                    _dvMembers.RowFilter = "";
                }
                else
                {
                    string dbColumn = "";
                    if (filterColumn == "Member ID") dbColumn = "MemberID";
                    else if (filterColumn == "Name") dbColumn = "MemberName";
                    else if (filterColumn == "Area") dbColumn = "Area";

                    if (filterColumn == "Member ID")
                    {
                        _dvMembers.RowFilter = $"{dbColumn} = {textValue}";
                    }
                    else
                    {
                        _dvMembers.RowFilter = $"{dbColumn} LIKE '{textValue}%'";
                    }
                }
            }
            else if (cbFilterValue.Visible)
            {
                string selectedValue = cbFilterValue.SelectedItem?.ToString();

                if (selectedValue == "All" || string.IsNullOrEmpty(selectedValue))
                {
                    _dvMembers.RowFilter = "";
                }
                else
                {
                    if (filterColumn == "Status")
                    {
                        bool isActive = (selectedValue == "Active");
                        _dvMembers.RowFilter = $"Status = {isActive}";
                    }
                    else if (filterColumn == "Gender")
                    {
                        bool isMale = (selectedValue == "Male");
                        _dvMembers.RowFilter = $"Gender = {isMale}";
                    }
                }
            }

            _RefreshRecordsCount();
        }

    }
}
