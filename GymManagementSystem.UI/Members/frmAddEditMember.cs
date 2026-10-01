using GymManagementSystem.BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Members
{
    public partial class frmAddEditMember : Form
    {
        public enum eMode
        {
            Add,
            Update
        }

        private readonly eMode _mode;
        private readonly Member _member;

        public event EventHandler MemberSaved;

        public frmAddEditMember()
        {
            InitializeComponent();

            _mode = eMode.Add;
            _member = null;
        }
        public frmAddEditMember(Member member)
        {
            InitializeComponent();

            _mode = eMode.Update;
            _member = member;
        }

        private void _InitializeForm()
        {
            if (_mode == eMode.Add) _SetDefaultValues();

            else _LoadMemberData();
        }

        private void _SetDefaultValues()
        {
            // Default values
        }

        private void _LoadMemberData()
        {
            // Load _member values into controls
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSaved = _mode == eMode.Add ? _SaveNewMember() : _UpdateMember();

            if (!isSaved) return;

            MemberSaved?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private bool _SaveNewMember()
        {
            // Add logic
            return true;
        }

        private bool _UpdateMember()
        {
            // Update logic
            return true;
        }

        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            _InitializeForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
