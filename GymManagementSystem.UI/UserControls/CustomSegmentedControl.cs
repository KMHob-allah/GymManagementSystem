
using FontAwesome.Sharp;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Windows.Forms;

namespace GymManagementSystem.UI.Controls
{
    [DefaultEvent(nameof(SelectedItemChanged))]
    [DefaultProperty(nameof(Items))]
    public partial class CustomSegmentedControl : UserControl
    {
        private readonly SegmentedItemCollection _items;

        private int _selectedIndex = -1;

        private Color _selectedColor = Color.FromArgb(37, 99, 235);
        private Color _unselectedColor = Color.FromArgb(241, 245, 249);
        private Color _selectedTextColor = Color.White;
        private Color _unselectedTextColor = Color.FromArgb(71, 85, 105);
        private Color _borderColor = Color.FromArgb(226, 232, 240);

        private int _borderRadius = 8;
        private int _borderSize = 1;
        private int _buttonHeight = 40;
        private int _buttonSpacing = 2;
        private int _iconSize = 18;

        public CustomSegmentedControl()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.AllPaintingInWmPaint,
                true);

            _items = new SegmentedItemCollection(this);

            BackColor = Color.White;
            Size = new Size(400, 46);
        }

        [Category("Segmented Control")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(CollectionEditor), typeof(UITypeEditor))]
        public SegmentedItemCollection Items => _items;

        [Category("Segmented Control")]
        [DefaultValue(-1)]
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (value < -1 || value >= _items.Count)
                    throw new ArgumentOutOfRangeException(nameof(value));

                if (_selectedIndex == value)
                    return;

                _selectedIndex = value;

                UpdateButtons();

                OnSelectedItemChanged(EventArgs.Empty);
            }
        }

        [Browsable(false)]
        public SegmentedItem SelectedItem =>
            _selectedIndex >= 0 && _selectedIndex < _items.Count
                ? _items[_selectedIndex]
                : null;

        [Category("Segmented Control")]
        public event EventHandler SelectedItemChanged;

        protected virtual void OnSelectedItemChanged(EventArgs e)
        {
            SelectedItemChanged?.Invoke(this, e);
        }

        [Category("Appearance")]
        public Color SelectedColor
        {
            get => _selectedColor;
            set
            {
                _selectedColor = value;
                UpdateButtons();
            }
        }

        [Category("Appearance")]
        public Color UnselectedColor
        {
            get => _unselectedColor;
            set
            {
                _unselectedColor = value;
                UpdateButtons();
            }
        }

        [Category("Appearance")]
        public Color SelectedTextColor
        {
            get => _selectedTextColor;
            set
            {
                _selectedTextColor = value;
                UpdateButtons();
            }
        }

        [Category("Appearance")]
        public Color UnselectedTextColor
        {
            get => _unselectedTextColor;
            set
            {
                _unselectedTextColor = value;
                UpdateButtons();
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                UpdateButtons();
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(8)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                UpdateButtons();
            }
        }

        [Category("Appearance")]
        [DefaultValue(1)]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = Math.Max(0, value);
                UpdateButtons();
                Invalidate();
            }
        }

        [Category("Layout")]
        [DefaultValue(40)]
        public int ButtonHeight
        {
            get => _buttonHeight;
            set
            {
                _buttonHeight = Math.Max(1, value);
                UpdateLayoutOfButtons();
            }
        }

        [Category("Layout")]
        [DefaultValue(2)]
        public int ButtonSpacing
        {
            get => _buttonSpacing;
            set
            {
                _buttonSpacing = Math.Max(0, value);
                UpdateLayoutOfButtons();
            }
        }

        [Category("Appearance")]
        [DefaultValue(18)]
        public int IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = Math.Max(1, value);
                UpdateButtons();
            }
        }

        public void SelectItem(string name)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (string.Equals(
                    _items[i].Name,
                    name,
                    StringComparison.OrdinalIgnoreCase))
                {
                    SelectedIndex = i;
                    return;
                }
            }
        }

        internal void ItemsChanged()
        {
            if (_items.Count == 0)
            {
                _selectedIndex = -1;
            }
            else if (_selectedIndex >= _items.Count)
            {
                _selectedIndex = _items.Count - 1;
            }
            else if (_selectedIndex < 0)
            {
                _selectedIndex = 0;
            }

            RebuildButtons();
        }

        private void RebuildButtons()
        {
            segmentsPanel.SuspendLayout();

            try
            {
                foreach (Control control in segmentsPanel.Controls)
                    control.Dispose();

                segmentsPanel.Controls.Clear();

                for (int i = 0; i < _items.Count; i++)
                {
                    int index = i;

                    IconButton button = new IconButton
                    {
                        Tag = index,
                        Text = _items[i].Text,
                        IconChar = _items[i].Icon,
                        IconFont = _items[i].IconFont,
                        IconSize = _iconSize,
                        TextImageRelation = TextImageRelation.ImageBeforeText,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ImageAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat,
                        UseVisualStyleBackColor = false,
                        Cursor = Cursors.Hand,
                        Margin = Padding.Empty,
                        Padding = new Padding(6, 0, 6, 0),
                        MinimumSize = Size.Empty,
                        TabStop = true
                    };

                    button.FlatAppearance.BorderSize = 0;
                    button.Click += SegmentButton_Click;

                    segmentsPanel.Controls.Add(button);
                }
            }
            finally
            {
                segmentsPanel.ResumeLayout(true);
            }

            UpdateLayoutOfButtons();
            UpdateButtons();
        }

        private void SegmentButton_Click(object sender, EventArgs e)
        {
            if (sender is IconButton button && button.Tag is int index)
                SelectedIndex = index;
        }

        private void UpdateLayoutOfButtons()
        {


            if (segmentsPanel == null)
                return;

            int count = segmentsPanel.Controls.Count;

            if (count == 0)
                return;

            segmentsPanel.SuspendLayout();


            int spacing = _buttonSpacing;

            int availableWidth =
                segmentsPanel.ClientSize.Width
                - segmentsPanel.Padding.Horizontal
                - spacing * (count - 1);

            int availableHeight =
                segmentsPanel.ClientSize.Height
                - segmentsPanel.Padding.Vertical;

            int buttonWidth = Math.Max(1, availableWidth / count);
            int remainder = Math.Max(0, availableWidth % count);


            for (int i = 0; i < count; i++)
            {
                Control button = segmentsPanel.Controls[i];

                button.Margin = new Padding(
                    0,
                    0,
                    i == count - 1 ? 0 : spacing,
                    0);


                button.Size = new Size(
                    buttonWidth + (i < remainder ? 1 : 0),
                    Math.Max(1, Math.Min(_buttonHeight, availableHeight)));

            }

            segmentsPanel.ResumeLayout(true);
        }

        private void UpdateButtons()
        {
            if (segmentsPanel == null)
                return;

            for (int i = 0; i < segmentsPanel.Controls.Count; i++)
            {
                if (!(segmentsPanel.Controls[i] is IconButton button))
                    continue;

                bool selected = i == _selectedIndex;

                button.BackColor = selected
                    ? _selectedColor
                    : _unselectedColor;

                button.ForeColor = selected
                    ? _selectedTextColor
                    : _unselectedTextColor;

                button.IconColor = button.ForeColor;
                button.IconSize = _iconSize;

                button.FlatAppearance.MouseOverBackColor = selected
                    ? _selectedColor
                    : ControlPaint.Light(_unselectedColor, 0.05f);

                button.FlatAppearance.MouseDownBackColor = selected
                    ? ControlPaint.Dark(_selectedColor, 0.05f)
                    : _unselectedColor;

                ApplyButtonRegion(button);
            }

            Invalidate();
        }

        private void ApplyButtonRegion(Control control)
        {
            if (control.Width <= 0 || control.Height <= 0)
                return;

            int radius = Math.Min(
                _borderRadius,
                Math.Min(control.Width, control.Height) / 2);

            using (GraphicsPath path = CreateRoundedPath(
                new Rectangle(0, 0, control.Width, control.Height),
                radius))
            {
                Region oldRegion = control.Region;
                control.Region = new Region(path);
                oldRegion?.Dispose();
            }
        }

        private GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diameter = radius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(
                bounds.Right - diameter,
                bounds.Y,
                diameter,
                diameter,
                270,
                90);
            path.AddArc(
                bounds.Right - diameter,
                bounds.Bottom - diameter,
                diameter,
                diameter,
                0,
                90);
            path.AddArc(
                bounds.X,
                bounds.Bottom - diameter,
                diameter,
                diameter,
                90,
                90);

            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateLayoutOfButtons();
            UpdateButtons();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_borderSize <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int inset = _borderSize / 2;
            Rectangle bounds = new Rectangle(
                inset,
                inset,
                Math.Max(0, Width - _borderSize),
                Math.Max(0, Height - _borderSize));

            using (GraphicsPath path = CreateRoundedPath(
                bounds,
                Math.Min(_borderRadius, Math.Min(Width, Height) / 2)))
            using (Pen pen = new Pen(_borderColor, _borderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SegmentedItem
    {
        private string _name = "Item";
        private string _text = "Button";
        private IconChar _icon = IconChar.Circle;
        private IconFont _iconFont = IconFont.Auto;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal CustomSegmentedControl Owner { get; set; }

        [Category("Data")]
        [DefaultValue("Item")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value ?? string.Empty;
                NotifyOwner();
            }
        }

        [Category("Appearance")]
        [DefaultValue("Button")]
        public string Text
        {
            get => _text;
            set
            {
                _text = value ?? string.Empty;
                NotifyOwner();
            }
        }

        [Category("Appearance")]
        [DefaultValue(IconChar.Circle)]
        public IconChar Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                NotifyOwner();
            }
        }

        [Category("Appearance")]
        [DefaultValue(IconFont.Auto)]
        public IconFont IconFont
        {
            get => _iconFont;
            set
            {
                _iconFont = value;
                NotifyOwner();
            }
        }

        private void NotifyOwner()
        {
            Owner?.ItemsChanged();
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public class SegmentedItemCollection : Collection<SegmentedItem>
    {
        private readonly CustomSegmentedControl _owner;

        internal SegmentedItemCollection(CustomSegmentedControl owner)
        {
            _owner = owner;
        }

        protected override void InsertItem(int index, SegmentedItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (item.Owner != null && item.Owner != _owner)
                throw new InvalidOperationException(
                    "This item already belongs to another control.");

            item.Owner = _owner;
            base.InsertItem(index, item);
            _owner.ItemsChanged();
        }

        protected override void SetItem(int index, SegmentedItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (item.Owner != null && item.Owner != _owner)
                throw new InvalidOperationException(
                    "This item already belongs to another control.");

            this[index].Owner = null;
            item.Owner = _owner;

            base.SetItem(index, item);
            _owner.ItemsChanged();
        }

        protected override void RemoveItem(int index)
        {
            this[index].Owner = null;
            base.RemoveItem(index);
            _owner.ItemsChanged();
        }

        protected override void ClearItems()
        {
            foreach (SegmentedItem item in this)
                item.Owner = null;

            base.ClearItems();
            _owner.ItemsChanged();
        }
    }
}

