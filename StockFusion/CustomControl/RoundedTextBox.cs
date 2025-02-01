using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.RoundedTextBox
{
    [DefaultEvent("TextChanged")]
    public partial class RoundedTextBox : UserControl
    {
        #region Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;
        private TextBox textBox1;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "Enter text...";
        private bool isPlaceholder = true;
        private bool isPasswordChar = false;
        private Image placeholderImage = null;

        public event EventHandler TextChanged;
        #endregion

        #region Constructor
        public RoundedTextBox()
        {
            InitializeComponent();
            InitializeTextBox();
            this.BackColor = Color.White; // Default background
            textBox1.TextChanged += (s, e) => TextChanged?.Invoke(s, e);
            textBox1.Enter += (s, e) => { isFocused = true; this.Invalidate(); RemovePlaceholder(); };
            textBox1.Leave += (s, e) => { isFocused = false; this.Invalidate(); SetPlaceholder(); };
            textBox1.Paint += TextBox1_Paint;
            this.Resize += (s, e) => AdjustTextBoxSize();
        }
        #endregion

        #region Properties
        [Category("RoundedTextBox")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }

        [Category("RoundedTextBox")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; textBox1.Font = value; AdjustTextBoxSize(); }
        }

        [Category("RoundedTextBox")]
        public string Texts
        {
            get { return isPlaceholder ? string.Empty : textBox1.Text; }
            set { textBox1.Text = value; SetPlaceholder(); }
        }

        [Category("RoundedTextBox")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; SetPlaceholder(); }
        }

        [Category("RoundedTextBox")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set { placeholderColor = value; if (isPlaceholder) textBox1.ForeColor = value; }
        }

        [Category("RoundedTextBox")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set { isPasswordChar = value; textBox1.UseSystemPasswordChar = value && !isPlaceholder; }
        }

        [Category("RoundedTextBox")]
        public Image PlaceholderImage
        {
            get { return placeholderImage; }
            set { placeholderImage = value; this.Invalidate(); }
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
            this.Name = "RoundedTextBox";
            this.Size = new System.Drawing.Size(200, 40);
            this.ResumeLayout(false);
        }

        private void InitializeTextBox()
        {
            textBox1 = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Font = this.Font
            };
            AdjustTextBoxSize();
            this.Controls.Add(textBox1);
            SetPlaceholder();
        }

        private void AdjustTextBoxSize()
        {
            textBox1.Location = new Point(borderSize + 5, borderSize + 5);
            textBox1.Width = this.Width - 2 * (borderSize + 5);
            textBox1.Height = this.Height - 2 * (borderSize + 5);
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                textBox1.BackColor = this.BackColor; // Ensure proper background
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
                textBox1.Invalidate(); // Trigger Paint event
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                textBox1.Text = string.Empty;
                textBox1.ForeColor = this.ForeColor;
                textBox1.BackColor = this.BackColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
                textBox1.Invalidate(); // Trigger Paint event
            }
        }

        private void TextBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isPlaceholder && placeholderImage != null)
            {
                Graphics g = e.Graphics;
                int imageX = (textBox1.ClientSize.Width - placeholderImage.Width) / 2;
                int imageY = (textBox1.ClientSize.Height - placeholderImage.Height) / 2;
                g.DrawImage(placeholderImage, new Point(imageX, imageY));
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




