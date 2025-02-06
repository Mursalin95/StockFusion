namespace StockFusion
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            roundedTextBox1 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox2 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            roundedButton2 = new CustomControls.RoundedButton.RoundedButton();
            roundedButton3 = new CustomControls.RoundedButton.RoundedButton();
            Show = new CheckBox();
            labelInvalidInputPrompt = new Label();
            labelInvalidUserNamePrompt = new Label();
            labelInvalidPasswordPrompt = new Label();
            SuspendLayout();
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = SystemColors.Window;
            roundedTextBox1.BorderColor = Color.MediumSlateBlue;
            roundedTextBox1.BorderFocusColor = Color.Transparent;
            roundedTextBox1.BorderRadius = 9;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Location = new Point(249, 109);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.Gray;
            roundedTextBox1.PlaceholderImage = null;
            roundedTextBox1.PlaceholderText = "Username";
            roundedTextBox1.Size = new Size(232, 33);
            roundedTextBox1.TabIndex = 0;
            roundedTextBox1.TabStop = false;
            roundedTextBox1.Texts = "";
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.BorderColor = Color.MediumSlateBlue;
            roundedTextBox2.BorderFocusColor = Color.Transparent;
            roundedTextBox2.BorderRadius = 9;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.Location = new Point(249, 166);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PasswordChar = true;
            roundedTextBox2.PlaceholderColor = Color.Gray;
            roundedTextBox2.PlaceholderImage = null;
            roundedTextBox2.PlaceholderText = "Password";
            roundedTextBox2.Size = new Size(232, 33);
            roundedTextBox2.TabIndex = 1;
            roundedTextBox2.TabStop = false;
            roundedTextBox2.Texts = "";
            roundedTextBox2.TextChanged += roundedTextBox2_TextChanged;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.CornflowerBlue;
            roundedButton1.BackgroundColor = Color.CornflowerBlue;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderFocusColor = Color.SteelBlue;
            roundedButton1.BorderRadius = 8;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonImage = null;
            roundedButton1.ButtonText = " LOG IN";
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton1.Location = new Point(249, 255);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(232, 33);
            roundedButton1.TabIndex = 2;
            roundedButton1.TabStop = false;
            roundedButton1.TextColor = Color.White;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.Transparent;
            roundedButton2.BackgroundColor = Color.Transparent;
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderFocusColor = Color.Transparent;
            roundedButton2.BorderRadius = 15;
            roundedButton2.BorderSize = 2;
            roundedButton2.ButtonImage = null;
            roundedButton2.ButtonText = " NEW USER? REGISTER";
            roundedButton2.Cursor = Cursors.Hand;
            roundedButton2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.Snow;
            roundedButton2.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton2.Location = new Point(379, 311);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(102, 28);
            roundedButton2.TabIndex = 3;
            roundedButton2.TabStop = false;
            roundedButton2.TextColor = Color.Snow;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.Transparent;
            roundedButton3.BackgroundColor = Color.Transparent;
            roundedButton3.BorderColor = Color.Transparent;
            roundedButton3.BorderFocusColor = Color.Transparent;
            roundedButton3.BorderRadius = 9;
            roundedButton3.BorderSize = 2;
            roundedButton3.ButtonImage = null;
            roundedButton3.ButtonText = " FORGOT PASSWORD";
            roundedButton3.Cursor = Cursors.Hand;
            roundedButton3.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton3.ForeColor = Color.Snow;
            roundedButton3.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton3.Location = new Point(239, 311);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(107, 28);
            roundedButton3.TabIndex = 4;
            roundedButton3.TabStop = false;
            roundedButton3.TextColor = Color.Snow;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.BackColor = Color.Transparent;
            Show.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Show.ForeColor = SystemColors.ControlLight;
            Show.Location = new Point(259, 215);
            Show.Name = "Show";
            Show.Size = new Size(112, 19);
            Show.TabIndex = 5;
            Show.Text = "Show Password";
            Show.UseVisualStyleBackColor = false;
            Show.CheckedChanged += Show_CheckedChanged;
            // 
            // labelInvalidInputPrompt
            // 
            labelInvalidInputPrompt.AutoSize = true;
            labelInvalidInputPrompt.BackColor = Color.Transparent;
            labelInvalidInputPrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelInvalidInputPrompt.Location = new Point(249, 240);
            labelInvalidInputPrompt.Name = "labelInvalidInputPrompt";
            labelInvalidInputPrompt.Size = new Size(0, 15);
            labelInvalidInputPrompt.TabIndex = 6;
            // 
            // labelInvalidUserNamePrompt
            // 
            labelInvalidUserNamePrompt.AutoSize = true;
            labelInvalidUserNamePrompt.BackColor = Color.Transparent;
            labelInvalidUserNamePrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelInvalidUserNamePrompt.Location = new Point(249, 120);
            labelInvalidUserNamePrompt.Name = "labelInvalidUserNamePrompt";
            labelInvalidUserNamePrompt.Size = new Size(0, 15);
            labelInvalidUserNamePrompt.TabIndex = 7;
            // 
            // labelInvalidPasswordPrompt
            // 
            labelInvalidPasswordPrompt.AutoSize = true;
            labelInvalidPasswordPrompt.BackColor = Color.Transparent;
            labelInvalidPasswordPrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelInvalidPasswordPrompt.Location = new Point(249, 200);
            labelInvalidPasswordPrompt.Name = "labelInvalidPasswordPrompt";
            labelInvalidPasswordPrompt.Size = new Size(0, 15);
            labelInvalidPasswordPrompt.TabIndex = 8;
            // 
            // SignIn
            // 
            AccessibleRole = AccessibleRole.Cursor;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 512);
            Controls.Add(Show);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedTextBox1);
            Controls.Add(labelInvalidInputPrompt);
            Controls.Add(labelInvalidUserNamePrompt);
            Controls.Add(labelInvalidPasswordPrompt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Sign in";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox1;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox2;
        private CustomControls.RoundedButton.RoundedButton roundedButton1;
        private CustomControls.RoundedButton.RoundedButton roundedButton2;
        private CustomControls.RoundedButton.RoundedButton roundedButton3;
        private new CheckBox Show;
        private Label labelInvalidInputPrompt;
        private Label labelInvalidUserNamePrompt;
        private Label labelInvalidPasswordPrompt;
    }
}
