namespace StockFusion
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                    components = null;
                }
            }
            try
            {
                base.Dispose(disposing);
            }
            catch (Exception)
            {
                // Handle or log the exception as needed
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            roundedTextBox1 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox2 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox3 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox4 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox5 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox6 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox7 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            checkBox1 = new CheckBox();
            labelFirstNamePrompt = new Label();
            labelLastNamePrompt = new Label();
            labelInvalidInputPrompt = new Label();
            labelEmptyFieldPrompt = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Anchor = AnchorStyles.Top;
            roundedTextBox1.BackColor = Color.WhiteSmoke;
            roundedTextBox1.BorderColor = Color.SteelBlue;
            roundedTextBox1.BorderFocusColor = Color.Orange;
            roundedTextBox1.BorderRadius = 15;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Cursor = Cursors.IBeam;
            roundedTextBox1.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox1.Location = new Point(286, 75);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.Gray;
            roundedTextBox1.PlaceholderImage = null;
            roundedTextBox1.PlaceholderText = " First Name";
            roundedTextBox1.Size = new Size(227, 31);
            roundedTextBox1.TabIndex = 0;
            roundedTextBox1.TabStop = false;
            roundedTextBox1.Texts = "";
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Anchor = AnchorStyles.Top;
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.BorderColor = Color.SteelBlue;
            roundedTextBox2.BorderFocusColor = Color.Orange;
            roundedTextBox2.BorderRadius = 15;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.Cursor = Cursors.IBeam;
            roundedTextBox2.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox2.Location = new Point(286, 125);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PasswordChar = false;
            roundedTextBox2.PlaceholderColor = Color.Gray;
            roundedTextBox2.PlaceholderImage = null;
            roundedTextBox2.PlaceholderText = " Last Name";
            roundedTextBox2.Size = new Size(227, 31);
            roundedTextBox2.TabIndex = 1;
            roundedTextBox2.TabStop = false;
            roundedTextBox2.Texts = "";
            roundedTextBox2.TextChanged += roundedTextBox2_TextChanged;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Anchor = AnchorStyles.Top;
            roundedTextBox3.BackColor = Color.White;
            roundedTextBox3.BorderColor = Color.SteelBlue;
            roundedTextBox3.BorderFocusColor = Color.Orange;
            roundedTextBox3.BorderRadius = 15;
            roundedTextBox3.BorderSize = 2;
            roundedTextBox3.Cursor = Cursors.IBeam;
            roundedTextBox3.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox3.Location = new Point(286, 180);
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PasswordChar = false;
            roundedTextBox3.PlaceholderColor = Color.Gray;
            roundedTextBox3.PlaceholderImage = null;
            roundedTextBox3.PlaceholderText = " Email";
            roundedTextBox3.Size = new Size(227, 30);
            roundedTextBox3.TabIndex = 2;
            roundedTextBox3.TabStop = false;
            roundedTextBox3.Texts = "";
            roundedTextBox3.TextChanged += roundedTextBox3_TextChanged;
            // 
            // roundedTextBox4
            // 
            roundedTextBox4.Anchor = AnchorStyles.Top;
            roundedTextBox4.BackColor = Color.White;
            roundedTextBox4.BorderColor = Color.SteelBlue;
            roundedTextBox4.BorderFocusColor = Color.Orange;
            roundedTextBox4.BorderRadius = 15;
            roundedTextBox4.BorderSize = 2;
            roundedTextBox4.Cursor = Cursors.IBeam;
            roundedTextBox4.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox4.Location = new Point(286, 233);
            roundedTextBox4.Name = "roundedTextBox4";
            roundedTextBox4.PasswordChar = false;
            roundedTextBox4.PlaceholderColor = Color.Gray;
            roundedTextBox4.PlaceholderImage = null;
            roundedTextBox4.PlaceholderText = "Phone Number";
            roundedTextBox4.Size = new Size(227, 30);
            roundedTextBox4.TabIndex = 3;
            roundedTextBox4.TabStop = false;
            roundedTextBox4.Texts = "";
            roundedTextBox4.TextChanged += roundedTextBox4_TextChanged;
            // 
            // roundedTextBox5
            // 
            roundedTextBox5.Anchor = AnchorStyles.Top;
            roundedTextBox5.BackColor = Color.White;
            roundedTextBox5.BorderColor = Color.SteelBlue;
            roundedTextBox5.BorderFocusColor = Color.Orange;
            roundedTextBox5.BorderRadius = 15;
            roundedTextBox5.BorderSize = 2;
            roundedTextBox5.Cursor = Cursors.IBeam;
            roundedTextBox5.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox5.Location = new Point(286, 292);
            roundedTextBox5.Name = "roundedTextBox5";
            roundedTextBox5.PasswordChar = false;
            roundedTextBox5.PlaceholderColor = Color.Gray;
            roundedTextBox5.PlaceholderImage = null;
            roundedTextBox5.PlaceholderText = "User Name";
            roundedTextBox5.Size = new Size(227, 30);
            roundedTextBox5.TabIndex = 4;
            roundedTextBox5.TabStop = false;
            roundedTextBox5.Texts = "";
            roundedTextBox5.TextChanged += roundedTextBox5_TextChanged;
            // 
            // roundedTextBox6
            // 
            roundedTextBox6.Anchor = AnchorStyles.Top;
            roundedTextBox6.BackColor = Color.White;
            roundedTextBox6.BorderColor = Color.SteelBlue;
            roundedTextBox6.BorderFocusColor = Color.Orange;
            roundedTextBox6.BorderRadius = 15;
            roundedTextBox6.BorderSize = 2;
            roundedTextBox6.Cursor = Cursors.IBeam;
            roundedTextBox6.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox6.Location = new Point(286, 349);
            roundedTextBox6.Name = "roundedTextBox6";
            roundedTextBox6.PasswordChar = true;
            roundedTextBox6.PlaceholderColor = Color.Gray;
            roundedTextBox6.PlaceholderImage = null;
            roundedTextBox6.PlaceholderText = "Password";
            roundedTextBox6.Size = new Size(227, 29);
            roundedTextBox6.TabIndex = 5;
            roundedTextBox6.TabStop = false;
            roundedTextBox6.Texts = "";
            roundedTextBox6.TextChanged += roundedTextBox6_TextChanged;
            roundedTextBox6.CursorChanged += Form_Click;
            // 
            // roundedTextBox7
            // 
            roundedTextBox7.Anchor = AnchorStyles.Top;
            roundedTextBox7.BackColor = Color.White;
            roundedTextBox7.BorderColor = Color.SteelBlue;
            roundedTextBox7.BorderFocusColor = Color.Orange;
            roundedTextBox7.BorderRadius = 15;
            roundedTextBox7.BorderSize = 2;
            roundedTextBox7.Cursor = Cursors.IBeam;
            roundedTextBox7.ForeColor = SystemColors.ActiveCaptionText;
            roundedTextBox7.Location = new Point(286, 399);
            roundedTextBox7.Name = "roundedTextBox7";
            roundedTextBox7.PasswordChar = true;
            roundedTextBox7.PlaceholderColor = Color.Gray;
            roundedTextBox7.PlaceholderImage = null;
            roundedTextBox7.PlaceholderText = "Confirm Password";
            roundedTextBox7.Size = new Size(227, 29);
            roundedTextBox7.TabIndex = 6;
            roundedTextBox7.TabStop = false;
            roundedTextBox7.Texts = "";
            roundedTextBox7.TextChanged += roundedTextBox7_TextChanged;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Top;
            roundedButton1.BackColor = Color.LightSteelBlue;
            roundedButton1.BackgroundColor = Color.LightSteelBlue;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderFocusColor = Color.SteelBlue;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonImage = null;
            roundedButton1.ButtonText = "Create account";
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton1.Location = new Point(286, 498);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(227, 40);
            roundedButton1.TabIndex = 8;
            roundedButton1.TextColor = Color.Black;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.Desktop;
            checkBox1.Location = new Point(295, 448);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelFirstNamePrompt
            // 
            labelFirstNamePrompt.AutoSize = true;
            labelFirstNamePrompt.BackColor = Color.Transparent;
            labelFirstNamePrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelFirstNamePrompt.Location = new Point(286, 107);
            labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            labelFirstNamePrompt.Size = new Size(0, 15);
            labelFirstNamePrompt.TabIndex = 11;
            // 
            // labelLastNamePrompt
            // 
            labelLastNamePrompt.AutoSize = true;
            labelLastNamePrompt.BackColor = Color.Transparent;
            labelLastNamePrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelLastNamePrompt.Location = new Point(286, 157);
            labelLastNamePrompt.Name = "labelLastNamePrompt";
            labelLastNamePrompt.Size = new Size(0, 15);
            labelLastNamePrompt.TabIndex = 12;
            // 
            // labelInvalidInputPrompt
            // 
            labelInvalidInputPrompt.AutoSize = true;
            labelInvalidInputPrompt.BackColor = Color.Transparent;
            labelInvalidInputPrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelInvalidInputPrompt.Location = new Point(0, 0);
            labelInvalidInputPrompt.Name = "labelInvalidInputPrompt";
            labelInvalidInputPrompt.Size = new Size(0, 15);
            labelInvalidInputPrompt.TabIndex = 13;
            // 
            // labelEmptyFieldPrompt
            // 
            labelEmptyFieldPrompt.AutoSize = true;
            labelEmptyFieldPrompt.BackColor = Color.Transparent;
            labelEmptyFieldPrompt.ForeColor = Color.FromArgb(179, 27, 27);
            labelEmptyFieldPrompt.Location = new Point(0, 0);
            labelEmptyFieldPrompt.Name = "labelEmptyFieldPrompt";
            labelEmptyFieldPrompt.Size = new Size(0, 15);
            labelEmptyFieldPrompt.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Location = new Point(544, 349);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(224, 68);
            textBox1.TabIndex = 14;
            textBox1.Text = "6 to 20 characters\r\nCan contain only letters, numbers and punctuation marks (except spaces)\r\nContains at least two of the following: letters, numbers and symbols ";
            textBox1.Visible = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources.Signup;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(textBox1);
            Controls.Add(labelEmptyFieldPrompt);
            Controls.Add(labelInvalidInputPrompt);
            Controls.Add(labelLastNamePrompt);
            Controls.Add(labelFirstNamePrompt);
            Controls.Add(checkBox1);
            Controls.Add(roundedButton1);
            Controls.Add(roundedTextBox7);
            Controls.Add(roundedTextBox6);
            Controls.Add(roundedTextBox5);
            Controls.Add(roundedTextBox4);
            Controls.Add(roundedTextBox3);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedTextBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            Opacity = 0.95D;
            Padding = new Padding(10, 7, 10, 7);
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox1;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox2;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox3;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox4;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox5;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox6;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox7;
        private CustomControls.RoundedButton.RoundedButton roundedButton1;
        private CheckBox checkBox1;
        private Label labelFirstNamePrompt;
        private Label labelLastNamePrompt;
        private Label labelInvalidInputPrompt;
        private TextBox textBox1;
        private Label labelEmptyFieldPrompt;
    }
}
