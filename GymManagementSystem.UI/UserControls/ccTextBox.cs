
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Controls
{
    public partial class CustomTextBox : UserControl
    {
        private int _borderRadius = 8;
        private int _borderSize = 1;

        private Color _borderColor = Color.LightGray;
        private Color _focusBorderColor = Color.DodgerBlue;

        private string _placeholderText = string.Empty;
        private Padding _textPadding = new Padding(10, 2, 10, 2);

        private bool _isFocused;

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int msg,
            IntPtr wParam,
            string lParam);

        public CustomTextBox()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            BackColor = Color.White;
            ForeColor = Color.FromArgb(45, 45, 45);
            Font = new Font("Segoe UI", 10F);

            txtInner.BackColor = BackColor;
            txtInner.ForeColor = ForeColor;
            txtInner.Font = Font;

            txtInner.TextChanged += (s, e) =>
            {
                OnTextChanged(e);
            };

            txtInner.GotFocus += (s, e) =>
            {
                _isFocused = true;
                Invalidate();
            };

            txtInner.LostFocus += (s, e) =>
            {
                _isFocused = false;
                Invalidate();
            };

            UpdateTextBoxLayout();
            UpdatePlaceholder();
        }

        #region Appearance

        [Category("Appearance")]
        [DefaultValue(8)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                UpdateRoundedRegion();
                UpdateTextBoxLayout();
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color FocusBorderColor
        {
            get => _focusBorderColor;
            set
            {
                _focusBorderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(1)]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = Math.Max(0, Math.Min(value, 10));
                UpdateTextBoxLayout();
                Invalidate();
            }
        }

        [Category("Appearance")]
        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value ?? string.Empty;
                UpdatePlaceholder();
            }
        }

        [Category("Appearance")]
        public Padding TextPadding
        {
            get => _textPadding;
            set
            {
                _textPadding = value;
                UpdateTextBoxLayout();
            }
        }

        [Category("Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;

                if (txtInner != null)
                    txtInner.BackColor = value;

                Invalidate();
            }
        }

        [Category("Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;

                if (txtInner != null)
                    txtInner.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;

                if (txtInner != null)
                {
                    txtInner.Font = value;
                    UpdateTextBoxLayout();
                }
            }
        }

        #endregion

        #region Text Properties

        [Category("Behavior")]
        [Bindable(true)]
        public override string Text
        {
            get => txtInner == null ? base.Text : txtInner.Text;
            set
            {
                if (txtInner != null)
                    txtInner.Text = value ?? string.Empty;
                else
                    base.Text = value;
            }
        }

        [Category("Behavior")]
        [DefaultValue(32767)]
        public int MaxLength
        {
            get => txtInner.MaxLength;
            set => txtInner.MaxLength = Math.Max(0, value);
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => txtInner.ReadOnly;
            set => txtInner.ReadOnly = value;
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get => txtInner.UseSystemPasswordChar;
            set => txtInner.UseSystemPasswordChar = value;
        }

        [Category("Behavior")]
        public char PasswordChar
        {
            get => txtInner.PasswordChar;
            set => txtInner.PasswordChar = value;
        }

        [Category("Behavior")]
        public CharacterCasing CharacterCasing
        {
            get => txtInner.CharacterCasing;
            set => txtInner.CharacterCasing = value;
        }

        [Category("Behavior")]
        public bool Multiline
        {
            get => txtInner.Multiline;
            set
            {
                txtInner.Multiline = value;
                UpdateTextBoxLayout();
            }
        }

        [Category("Behavior")]
        public HorizontalAlignment TextAlign
        {
            get => txtInner.TextAlign;
            set => txtInner.TextAlign = value;
        }

        [Category("Behavior")]
        public ScrollBars ScrollBars
        {
            get => txtInner.ScrollBars;
            set => txtInner.ScrollBars = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public TextBox InnerTextBox => txtInner;

        #endregion

        #region Layout

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            UpdateTextBoxLayout();
            UpdateRoundedRegion();
            Invalidate();
        }

        private void UpdateTextBoxLayout()
        {
            if (txtInner == null)
                return;

            int radiusPadding = Math.Min(
                _borderRadius / 2,
                Math.Max(0, Width / 4));

            int left = _borderSize + _textPadding.Left + radiusPadding;
            int right = _borderSize + _textPadding.Right + radiusPadding;
            int top = _borderSize + _textPadding.Top;
            int bottom = _borderSize + _textPadding.Bottom;

            int availableWidth = Math.Max(
                0, ClientSize.Width - left - right);

            int availableHeight = Math.Max(
                0, ClientSize.Height - top - bottom);

            int textHeight = Math.Min(
                availableHeight, Font.Height + 2);

            int textTop = Multiline
                ? top
                : top + Math.Max(0, (availableHeight - textHeight) / 2);

            txtInner.SetBounds(
                left,
                textTop,
                availableWidth,
                Multiline ? availableHeight : textHeight);
        }

        private GraphicsPath CreateRoundedPath(
            Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (bounds.Width <= 0 || bounds.Height <= 0)
                return path;

            int diameter = Math.Min(
                radius * 2,
                Math.Min(bounds.Width, bounds.Height));

            if (diameter <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            Rectangle arc = new Rectangle(
                bounds.X, bounds.Y, diameter, diameter);

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.X;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void UpdateRoundedRegion()
        {
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            using (GraphicsPath path = CreateRoundedPath(
                new Rectangle(0, 0, ClientSize.Width, ClientSize.Height),
                _borderRadius))
            {
                Region oldRegion = Region;
                Region = new Region(path);

                if (oldRegion != null)
                    oldRegion.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                _borderSize / 2,
                _borderSize / 2,
                Width - _borderSize - 1,
                Height - _borderSize - 1);

            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            Color color = _isFocused
                ? _focusBorderColor
                : _borderColor;

            using (GraphicsPath path =
                CreateRoundedPath(rect, _borderRadius))
            using (Pen pen = new Pen(color, _borderSize))
            {
                e.Graphics.DrawPath(pen, path);

            }
        }

        #endregion

        #region Placeholder

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            UpdatePlaceholder();
            UpdateRoundedRegion();
        }

        private void UpdatePlaceholder()
        {
            if (txtInner == null)
                return;

            if (!txtInner.IsHandleCreated)
                txtInner.CreateControl();

            SendMessage(
                txtInner.Handle,
                EM_SETCUEBANNER,
                (IntPtr)1,
                _placeholderText);
        }

        #endregion

        public void FocusText()
        {
            txtInner.Focus();
        }
    }
}
