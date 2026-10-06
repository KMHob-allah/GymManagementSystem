using GymManagementSystem.BLL.Entities;
using GymManagementSystem.UI.Memberships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Payments
{
    public partial class frmPaymentDetails : Form
    {
        private readonly Payment _Payment;

        public frmPaymentDetails(Payment Payment)
        {
            InitializeComponent();

            _Payment = Payment;
        }

        private void frmMembershipDetails_Load(object sender, EventArgs e)
        {
            ucPaymentCard1.LoadPayment(_Payment);
        }
    }
}
