namespace StockFusion
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            roundedButton2 = new CustomControls.RoundedButton.RoundedButton();
            roundedButton3 = new CustomControls.RoundedButton.RoundedButton();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Transparent;
            roundedButton1.BackgroundColor = Color.Transparent;
            roundedButton1.BackgroundImage = Properties.Resources.admin;
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
            roundedButton1.Location = new Point(38, 34);
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
            roundedButton2.BackgroundImage = (Image)resources.GetObject("roundedButton2.BackgroundImage");
            roundedButton2.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton2.BorderColor = Color.MediumSlateBlue;
            roundedButton2.BorderFocusColor = Color.Transparent;
            roundedButton2.BorderRadius = 15;
            roundedButton2.BorderSize = 2;
            roundedButton2.ButtonImage = null;
            roundedButton2.ButtonText = " ";
            roundedButton2.Cursor = Cursors.Hand;
            roundedButton2.ForeColor = Color.White;
            roundedButton2.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton2.Location = new Point(307, 34);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(190, 171);
            roundedButton2.TabIndex = 1;
            roundedButton2.TextColor = Color.White;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.Transparent;
            roundedButton3.BackgroundColor = Color.Transparent;
            roundedButton3.BackgroundImage = (Image)resources.GetObject("roundedButton3.BackgroundImage");
            roundedButton3.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton3.BorderColor = Color.MediumSlateBlue;
            roundedButton3.BorderFocusColor = Color.Transparent;
            roundedButton3.BorderRadius = 15;
            roundedButton3.BorderSize = 2;
            roundedButton3.ButtonImage = null;
            roundedButton3.ButtonText = " ";
            roundedButton3.Cursor = Cursors.Hand;
            roundedButton3.ForeColor = Color.White;
            roundedButton3.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton3.Location = new Point(198, 245);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(190, 171);
            roundedButton3.TabIndex = 2;
            roundedButton3.TextColor = Color.White;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(591, 460);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RoundedButton.RoundedButton roundedButton1;
        private CustomControls.RoundedButton.RoundedButton roundedButton2;
        private CustomControls.RoundedButton.RoundedButton roundedButton3;
    }
}
