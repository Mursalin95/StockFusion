using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace StockFusion.CustomControl
{
    [DefaultEvent("TextChanged")]
    [ToolboxItem(true)]
    [Designer(typeof(ControlDesigner))]
    public partial class RoundedComboBox : UserControl
    {
        #region Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;
        private ComboBox comboBox1;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = " ";
        private bool isPlaceholder = true;

        public event EventHandler TextChanged;
        #endregion

        #region Constructor
        public RoundedComboBox()
        {
            InitializeComponent();
            InitializeComboBox();
            comboBox1.TextChanged += (s, e) => TextChanged?.Invoke(s, e);
            comboBox1.Enter += (s, e) => RemovePlaceholder();
            comboBox1.Leave += (s, e) => SetPlaceholder();
            comboBox1.SelectedIndexChanged += (s, e) => RemovePlaceholder();
            this.Resize += (s, e) => AdjustComboBoxSize();
        }
        #endregion

        #region Properties
        [Category("RoundedComboBox")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RoundedComboBox")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("RoundedComboBox")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RoundedComboBox")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RoundedComboBox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; comboBox1.BackColor = value; this.Invalidate(); }
        }

        [Category("RoundedComboBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; comboBox1.ForeColor = value; }
        }

        [Category("RoundedComboBox")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; comboBox1.Font = value; AdjustComboBoxSize(); }
        }

        [Category("RoundedComboBox")]
        public string Texts
        {
            get { return isPlaceholder ? string.Empty : comboBox1.Text; }
            set { comboBox1.Text = value; SetPlaceholder(); }
        }

        [Category("RoundedComboBox")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; SetPlaceholder(); }
        }

        [Category("RoundedComboBox")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set { placeholderColor = value; if (isPlaceholder) comboBox1.ForeColor = value; }
        }

        [Category("RoundedComboBox")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public ComboBox.ObjectCollection Items
        {
            get { return comboBox1.Items; }
        }
        #endregion

        #region Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw border
            using (GraphicsPath pathBorder = GetFigurePath(this.ClientRectangle, borderRadius))
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                this.Region = new Region(pathBorder);
                penBorder.Alignment = PenAlignment.Center;
                graph.DrawPath(penBorder, pathBorder);
            }
        }
        #endregion

        #region Private methods
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RoundedComboBox
            // 
            this.Name = "RoundedComboBox";
            this.Size = new System.Drawing.Size(200, 40);
            this.ResumeLayout(false);
        }

        private void InitializeComboBox()
        {
            comboBox1 = new ComboBox
            {
                FlatStyle = FlatStyle.Flat,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Font = this.Font,
                DropDownStyle = ComboBoxStyle.DropDownList // Ensure the ComboBox is not editable
            };
            AdjustComboBoxSize();
            this.Controls.Add(comboBox1);
            SetPlaceholder();
        }

        private void AdjustComboBoxSize()
        {
            comboBox1.Location = new Point(borderSize + 5, borderSize + 5);
            comboBox1.Width = this.Width - 2 * (borderSize + 5);
            comboBox1.Height = this.Height - 2 * (borderSize + 5);
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) && comboBox1.SelectedIndex == -1)
            {
                isPlaceholder = true;
                comboBox1.Text = placeholderText;
                comboBox1.ForeColor = placeholderColor;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                comboBox1.Text = string.Empty;
                comboBox1.ForeColor = this.ForeColor;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        #endregion
    }
}
