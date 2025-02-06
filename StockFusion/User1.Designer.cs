
namespace StockFusion
{
    partial class User1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User1));
            roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            roundedButton2 = new CustomControls.RoundedButton.RoundedButton();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Transparent;
            roundedButton1.BackgroundColor = Color.Transparent;
            roundedButton1.BackgroundImage = Properties.Resources.Manager;
            roundedButton1.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton1.BorderColor = Color.MediumSlateBlue;
            roundedButton1.BorderFocusColor = Color.Transparent;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonImage = null;
            roundedButton1.ButtonText = " ";
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton1.Location = new Point(48, 120);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(190, 171);
            roundedButton1.TabIndex = 0;
            roundedButton1.TextColor = Color.White;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.Transparent;
            roundedButton2.BackgroundColor = Color.Transparent;
            roundedButton2.BackgroundImage = Properties.Resources.Financial;
            roundedButton2.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton2.BorderColor = Color.MediumSlateBlue;
            roundedButton2.BorderFocusColor = Color.Transparent;
            roundedButton2.BorderRadius = 15;
            roundedButton2.BorderSize = 2;
            roundedButton2.ButtonImage = null;
            roundedButton2.ButtonText = " ";
            roundedButton2.ForeColor = Color.White;
            roundedButton2.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton2.Location = new Point(320, 120);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(190, 171);
            roundedButton2.TabIndex = 1;
            roundedButton2.TextColor = Color.White;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // User1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(602, 471);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RoundedButton.RoundedButton roundedButton1;
        private CustomControls.RoundedButton.RoundedButton roundedButton2;
    }
}
