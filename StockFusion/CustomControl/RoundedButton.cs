using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.RoundedButton
{
    [DefaultEvent("Click")]
    public partial class RoundedButton : UserControl
    {
        #region Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;
        private string buttonText = " ";
        private Color backgroundColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Image buttonImage = null;
        private ContentAlignment imageAlign = ContentAlignment.MiddleCenter;

        public event EventHandler Click;
        #endregion

        #region Constructor
        public RoundedButton()
        {
            InitializeComponent();
            this.BackColor = backgroundColor; // Default background
            this.ForeColor = textColor;
            this.Resize += (s, e) => this.Invalidate();
            this.MouseEnter += (s, e) => { isFocused = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { isFocused = false; this.Invalidate(); };
            this.Click += (s, e) => { }; // Ensure Click event propagates
        }
        #endregion

        #region Properties
        [Category("RoundedButton")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; this.BackColor = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; this.ForeColor = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public string ButtonText
        {
            get { return buttonText; }
            set { buttonText = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public Image ButtonImage
        {
            get { return buttonImage; }
            set { buttonImage = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public ContentAlignment ImageAlign
        {
            get { return imageAlign; }
            set { imageAlign = value; this.Invalidate(); }
        }

        [Category("RoundedButton")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; this.Invalidate(); }
        }
        #endregion

        #region Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw background
            using (GraphicsPath pathSurface = GetFigurePath(this.ClientRectangle, borderRadius))
            using (Brush brushSurface = new SolidBrush(backgroundColor))
            {
                this.Region = new Region(pathSurface);
                graph.FillPath(brushSurface, pathSurface);
            }

            // Draw border
            using (GraphicsPath pathBorder = GetFigurePath(this.ClientRectangle, borderRadius))
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                graph.DrawPath(penBorder, pathBorder);
            }

            // Draw image (if available)
            if (buttonImage != null)
            {
                Rectangle imageRect = GetImageRectangle();
                graph.DrawImage(buttonImage, imageRect);
            }

            // Draw text
            TextRenderer.DrawText(graph, buttonText, this.Font, this.ClientRectangle, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Click?.Invoke(this, e);
        }
        #endregion

        #region Private methods
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "RoundedButton";
            this.Size = new System.Drawing.Size(120, 40);
            this.ResumeLayout(false);
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

        private Rectangle GetImageRectangle()
        {
            int buttonWidth = this.Width;
            int buttonHeight = this.Height;
            int imageWidth = buttonImage.Width;
            int imageHeight = buttonImage.Height;

            // Scale the image to fit within the button while maintaining aspect ratio
            float aspectRatio = (float)imageWidth / imageHeight;
            if (imageWidth > buttonWidth || imageHeight > buttonHeight)
            {
                if (imageWidth > imageHeight)
                {
                    imageWidth = buttonWidth;
                    imageHeight = (int)(buttonWidth / aspectRatio);
                }
                else
                {
                    imageHeight = buttonHeight;
                    imageWidth = (int)(buttonHeight * aspectRatio);
                }
            }

            int imageX = 0;
            int imageY = 0;

            switch (imageAlign)
            {
                case ContentAlignment.TopLeft:
                    imageX = 5;
                    imageY = 5;
                    break;
                case ContentAlignment.TopCenter:
                    imageX = (buttonWidth - imageWidth) / 2;
                    imageY = 5;
                    break;
                case ContentAlignment.TopRight:
                    imageX = buttonWidth - imageWidth - 5;
                    imageY = 5;
                    break;
                case ContentAlignment.MiddleLeft:
                    imageX = 5;
                    imageY = (buttonHeight - imageHeight) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    imageX = (buttonWidth - imageWidth) / 2;
                    imageY = (buttonHeight - imageHeight) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    imageX = buttonWidth - imageWidth - 5;
                    imageY = (buttonHeight - imageHeight) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    imageX = 5;
                    imageY = buttonHeight - imageHeight - 5;
                    break;
                case ContentAlignment.BottomCenter:
                    imageX = (buttonWidth - imageWidth) / 2;
                    imageY = buttonHeight - imageHeight - 5;
                    break;
                case ContentAlignment.BottomRight:
                    imageX = buttonWidth - imageWidth - 5;
                    imageY = buttonHeight - imageHeight - 5;
                    break;
            }

            return new Rectangle(imageX, imageY, imageWidth, imageHeight);
        }
        #endregion
    }
}



