namespace StockFusion
{
    partial class Forget
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
            roundedTextBox1 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox2 = new CustomControls.RoundedTextBox.RoundedTextBox();
            roundedTextBox3 = new CustomControls.RoundedTextBox.RoundedTextBox();
            Checkbox1 = new CheckBox();
            roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            SuspendLayout();
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.White;
            roundedTextBox1.BorderColor = Color.SkyBlue;
            roundedTextBox1.BorderFocusColor = Color.SkyBlue;
            roundedTextBox1.BorderRadius = 15;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Location = new Point(137, 100);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.Gray;
            roundedTextBox1.PlaceholderImage = null;
            roundedTextBox1.PlaceholderText = "Username";
            roundedTextBox1.Size = new Size(239, 34);
            roundedTextBox1.TabIndex = 0;
            roundedTextBox1.TabStop = false;
            roundedTextBox1.Texts = "";
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.BorderColor = Color.SkyBlue;
            roundedTextBox2.BorderFocusColor = Color.SkyBlue;
            roundedTextBox2.BorderRadius = 15;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.Location = new Point(137, 157);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PasswordChar = false;
            roundedTextBox2.PlaceholderColor = Color.Gray;
            roundedTextBox2.PlaceholderImage = null;
            roundedTextBox2.PlaceholderText = "New password";
            roundedTextBox2.Size = new Size(239, 34);
            roundedTextBox2.TabIndex = 1;
            roundedTextBox2.TabStop = false;
            roundedTextBox2.Texts = "";
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.BackColor = Color.White;
            roundedTextBox3.BorderColor = Color.SkyBlue;
            roundedTextBox3.BorderFocusColor = Color.SkyBlue;
            roundedTextBox3.BorderRadius = 15;
            roundedTextBox3.BorderSize = 2;
            roundedTextBox3.Location = new Point(137, 210);
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PasswordChar = false;
            roundedTextBox3.PlaceholderColor = Color.Gray;
            roundedTextBox3.PlaceholderImage = null;
            roundedTextBox3.PlaceholderText = "Confirm password";
            roundedTextBox3.Size = new Size(239, 34);
            roundedTextBox3.TabIndex = 2;
            roundedTextBox3.TabStop = false;
            roundedTextBox3.Texts = "";
            // 
            // Checkbox1
            // 
            Checkbox1.AutoSize = true;
            Checkbox1.Location = new Point(146, 250);
            Checkbox1.Name = "Checkbox1";
            Checkbox1.Size = new Size(108, 19);
            Checkbox1.TabIndex = 3;
            Checkbox1.TabStop = false;
            Checkbox1.Text = "Show Password";
            Checkbox1.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.CornflowerBlue;
            roundedButton1.BackgroundColor = Color.CornflowerBlue;
            roundedButton1.BorderColor = Color.RoyalBlue;
            roundedButton1.BorderFocusColor = Color.SteelBlue;
            roundedButton1.BorderRadius = 9;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonImage = null;
            roundedButton1.ButtonText = " Retrieve Password";
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.ImageAlign = ContentAlignment.MiddleCenter;
            roundedButton1.Location = new Point(137, 305);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(239, 35);
            roundedButton1.TabIndex = 4;
            roundedButton1.TabStop = false;
            roundedButton1.TextColor = Color.White;
            // 
            // Forget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(547, 493);
            Controls.Add(roundedButton1);
            Controls.Add(Checkbox1);
            Controls.Add(roundedTextBox3);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedTextBox1);
            Name = "Forget";
            Text = "Recovery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox1;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox2;
        private CustomControls.RoundedTextBox.RoundedTextBox roundedTextBox3;
        private CheckBox Checkbox1;
        private CustomControls.RoundedButton.RoundedButton roundedButton1;
    }
}