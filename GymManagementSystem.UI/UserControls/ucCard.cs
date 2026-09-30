using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.UI
{
    public partial class ucCard : UserControl
    {
        public ucCard()
        {
            InitializeComponent();
        }

        [Category("Card")]
        [Browsable(true)]
        [Description("The title displayed on the card.")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Card")]
        [Browsable(true)]
        [Description("The number displayed on the card.")]
        public string Number
        {
            get => lblNumber.Text;
            set => lblNumber.Text = value;
        }

        [Category("Card")]
        [Browsable(true)]
        [Description("The icon displayed on the card.")]
        public IconChar Icon
        {
            get => IcnbtnIcon.IconChar;
            set => IcnbtnIcon.IconChar = value;
        }

    }
}
