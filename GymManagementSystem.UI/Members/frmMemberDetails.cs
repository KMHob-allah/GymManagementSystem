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
    public partial class frmMemberDetails : Form
    {
        private readonly Member _Member;

        public frmMemberDetails(Member Member)
        {
            InitializeComponent();

            _Member = Member;
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            ucMemberCard1.LoadMember(_Member);
        }
    }
}
