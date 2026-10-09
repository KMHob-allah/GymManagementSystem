using System.Drawing;
using System.Windows.Forms;

namespace GymManagementSystem.UI
{
    public static class ButtonStyleHelper
    {
        private static readonly Color HoverColor =
            Color.FromArgb(15, 16, 18);
        
        private static readonly Color PressedColor =
            Color.FromArgb(15, 16, 18);

        public static void Apply(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;

                    button.FlatAppearance.MouseOverBackColor =
                        HoverColor;

                    button.FlatAppearance.MouseDownBackColor =
                        PressedColor;
                }

                if (control.HasChildren)
                {
                    Apply(control);
                }
            }
        }
    }
}