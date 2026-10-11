using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GymManagementSystem.UI.UserControls
{
    partial class CustomIconButton : IconButton
    {
        private int _borderRadius = 15;

        public CustomIconButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            ApplyBorderRadius();
        }

        [Category("Appearance")]
        [Description("Sets the radius of the button corners.")]
        [DefaultValue(15)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                ApplyBorderRadius();
                Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ApplyBorderRadius();
        }

        private void ApplyBorderRadius()
        {
            if (Width <= 0 || Height <= 0)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = Math.Min(
                    _borderRadius,
                    Math.Min(Width, Height) / 2);

                if (radius == 0)
                {
                    path.AddRectangle(
                        new Rectangle(0, 0, Width, Height));
                }
                else
                {
                    int diameter = radius * 2;

                    path.AddArc(0, 0, diameter, diameter, 180, 90);
                    path.AddArc(
                        Width - diameter, 0,
                        diameter, diameter, 270, 90);
                    path.AddArc(
                        Width - diameter, Height - diameter,
                        diameter, diameter, 0, 90);
                    path.AddArc(
                        0, Height - diameter,
                        diameter, diameter, 90, 90);

                    path.CloseFigure();
                }

                Region?.Dispose();
                Region = new Region(path);
            }
        }
    }
}