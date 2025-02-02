using System.Text.RegularExpressions;

namespace StockFusion
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Click += new EventHandler(Form_Click);

            // Add event handlers for password fields
            roundedTextBox6.MouseEnter += new EventHandler(PasswordField_MouseEnter);
            roundedTextBox6.MouseLeave += new EventHandler(PasswordField_MouseLeave);
            roundedTextBox6.MouseClick += new MouseEventHandler(PasswordField_MouseClick);
            roundedTextBox6.Click += new EventHandler(PasswordField_Click);

            roundedTextBox7.MouseEnter += new EventHandler(PasswordField_MouseEnter);
            roundedTextBox7.MouseLeave += new EventHandler(PasswordField_MouseLeave);
            roundedTextBox7.MouseClick += new MouseEventHandler(PasswordField_MouseClick);
            roundedTextBox7.Click += new EventHandler(PasswordField_Click);

            // Add TextChanged event handlers for password fields
            roundedTextBox6.TextChanged += new EventHandler(PasswordField_TextChanged);
            roundedTextBox7.TextChanged += new EventHandler(PasswordField_TextChanged);
        }

        private void Form1_Load(object? sender, EventArgs e)
        {

        }

        private void Form_Click(object? sender, EventArgs e)
        {
            ActiveControl = null;
            Cursor = Cursors.Default;
            textBox1.Visible = false; // Hide textBox1 when clicking outside
        }

        private void roundedTextBox1_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roundedTextBox1.Texts) && !ValidName(roundedTextBox1.Texts, roundedTextBox1))
            {
                labelInvalidInputPrompt.Text = "Please enter alphabet only";
                labelInvalidInputPrompt.Visible = true;
                labelFirstNamePrompt.Visible = false;
                labelLastNamePrompt.Visible = false;
            }
            else
            {
                labelInvalidInputPrompt.Visible = false;

                if (!string.IsNullOrWhiteSpace(roundedTextBox1.Texts))
                {
                    labelLastNamePrompt.Text = "Please enter your last name";
                    labelLastNamePrompt.Visible = true;
                }
                else
                {
                    labelLastNamePrompt.Visible = false; // Hide if first name is empty
                }

                if (!string.IsNullOrWhiteSpace(roundedTextBox2.Texts))
                {
                    labelFirstNamePrompt.Visible = false; // Hide if last name is not empty
                }

                if (!string.IsNullOrWhiteSpace(roundedTextBox1.Texts) && !string.IsNullOrWhiteSpace(roundedTextBox2.Texts))
                {
                    labelFirstNamePrompt.Visible = false;
                    labelLastNamePrompt.Visible = false;
                }
            }
        }

        private void roundedTextBox2_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roundedTextBox2.Texts) && !ValidName(roundedTextBox2.Texts, roundedTextBox2))
            {
                labelInvalidInputPrompt.Text = "Please enter alphabet only";
                labelInvalidInputPrompt.Visible = true;
                labelFirstNamePrompt.Visible = false;
                labelLastNamePrompt.Visible = false;
            }
            else
            {
                labelInvalidInputPrompt.Visible = false;

                if (!string.IsNullOrWhiteSpace(roundedTextBox2.Texts))
                {
                    labelFirstNamePrompt.Text = "Please enter your first name";
                    labelFirstNamePrompt.Visible = true;
                }
                else
                {
                    labelFirstNamePrompt.Visible = false; // Hide if last name is empty
                }

                if (!string.IsNullOrWhiteSpace(roundedTextBox1.Texts))
                {
                    labelLastNamePrompt.Visible = false; // Hide if first name is not empty
                }

                if (!string.IsNullOrWhiteSpace(roundedTextBox1.Texts) && !string.IsNullOrWhiteSpace(roundedTextBox2.Texts))
                {
                    labelFirstNamePrompt.Visible = false;
                    labelLastNamePrompt.Visible = false;
                }
            }
        }

        private void roundedTextBox3_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(roundedTextBox3.Texts) && !ValidEmail(roundedTextBox3.Texts))
            {
                labelInvalidInputPrompt.Text = "Please enter a valid email address";
                labelInvalidInputPrompt.Location = new Point(286, 211);
                labelInvalidInputPrompt.Visible = true;
            }
            else
            {
                labelInvalidInputPrompt.Visible = false;
            }
        }

        private void roundedTextBox4_TextChanged(object? sender, EventArgs e)
        {
            string phoneNumber = roundedTextBox4.Texts.Trim(); // Get the phone number

            if (phoneNumber.Length == 11)
            {
                labelInvalidInputPrompt.Visible = false; // Hide message when exactly 11 digits
            }
            else
            {
                labelInvalidInputPrompt.Text = "Please enter a valid phone number";
                labelInvalidInputPrompt.Location = new Point(286, 268);
                labelInvalidInputPrompt.Visible = true; // Show message if <11 or >11 digits
            }
            if (phoneNumber.Length == 0)
            {
                labelInvalidInputPrompt.Visible = false; // Hide message when empty
            }
        }

        private void roundedTextBox5_TextChanged(object? sender, EventArgs e)
        {
          //  ValidatePassword(roundedTextBox5.Texts, roundedTextBox5);
        }

        private void roundedTextBox6_TextChanged(object? sender, EventArgs e)
        {
            ValidatePassword(roundedTextBox6.Texts, roundedTextBox6);
            ComparePasswords(sender);
        }

        private void roundedTextBox7_TextChanged(object? sender, EventArgs e)
        {
            ValidatePassword(roundedTextBox7.Texts, roundedTextBox7);
            ComparePasswords(sender);
        }

        private void roundedButton1_Click(object? sender, EventArgs e)
        {
            bool isValid = true;
            labelEmptyFieldPrompt.Visible = false;
            if (string.IsNullOrWhiteSpace(roundedTextBox1.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox2.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox3.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox4.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox5.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox6.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBox7.Texts))
            {
                isValid = false;
            }
            
            

            // If any field is invalid, return early
            if (!isValid)
            {
                labelEmptyFieldPrompt.Visible = true;
                labelEmptyFieldPrompt.Text = "Please fill up requirements";
                labelEmptyFieldPrompt.Location = new Point(328, 545);

                return;
            }
            //labelEmptyFieldPrompt.Visible = false;

            // If all fields are valid, proceed with confirmation
            DialogResult result = MessageBox.Show("Are you sure to confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object? sender, EventArgs e)
        {
            TogglePasswordVisibility(checkBox1.Checked);
        }

        private void ValidatePassword(string password, CustomControls.RoundedTextBox.RoundedTextBox textBox)
        {
            int minLength = 6;
            int maxLength = 20;
            bool hasLetters = Regex.IsMatch(password, @"[A-Za-z]");
            bool hasNumbers = Regex.IsMatch(password, @"[0-9]");
            bool hasSymbols = Regex.IsMatch(password, @"[\W_]");

            bool isValid = password.Length >= minLength && password.Length <= maxLength &&
                           Regex.IsMatch(password, @"^[A-Za-z0-9\p{P}]+$") &&
                           ((hasLetters && hasNumbers) || (hasLetters && hasSymbols) || (hasNumbers && hasSymbols));

            labelInvalidInputPrompt.Visible = !isValid;
            textBox1.Visible = !isValid;  // Show textBox1 if password is invalid
        }

        private void ComparePasswords(object? sender)
        {
            if (string.IsNullOrWhiteSpace(roundedTextBox6.Texts) || string.IsNullOrWhiteSpace(roundedTextBox7.Texts))
            {
                labelInvalidInputPrompt.Visible = false;
                return;
            }

            bool passwordsMatch = roundedTextBox6.Texts == roundedTextBox7.Texts;

            if (passwordsMatch)
            {
                labelInvalidInputPrompt.Visible = false;
            }
            else
            {
                labelInvalidInputPrompt.Text = "The password does not match";
                labelInvalidInputPrompt.Location = new Point(286, 430);
                labelInvalidInputPrompt.Visible = true;
                if (sender == roundedTextBox6)
                {
                    textBox1.Visible = true;
                }
                else
                {
                    textBox1.Visible = false;
                   
                }// Show textBox1 if passwords do not match and sender is roundedTextBox6 or roundedTextBox7


            }
        }

        private void TogglePasswordVisibility(bool showPassword)
        {
           // roundedTextBox5.PasswordChar = !showPassword;
            roundedTextBox6.PasswordChar = !showPassword;
            roundedTextBox7.PasswordChar = !showPassword;
        }

        private bool ValidName(string name, CustomControls.RoundedTextBox.RoundedTextBox textBox)
        {
            return Regex.IsMatch(name, @"^[A-Za-z]+(?:[-\s][A-Za-z]+)*$");
        }

        private bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool ValidNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d{11}$");
        }

        private void PasswordField_MouseEnter(object? sender, EventArgs e)
        {
            if (sender == roundedTextBox6 && !labelInvalidInputPrompt.Visible)
            {
                textBox1.Visible = true;
            }
            else if (sender == roundedTextBox7 && !roundedTextBox7.Focused && !labelInvalidInputPrompt.Visible)
            {
                textBox1.Visible = false;
            }

        }

        private void PasswordField_MouseLeave(object? sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void PasswordField_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender == roundedTextBox6 && !labelInvalidInputPrompt.Visible)
            {
                textBox1.Visible = true;
            }

        }

        private void PasswordField_Click(object? sender, EventArgs e)
        {
            if (sender == roundedTextBox6 && !labelInvalidInputPrompt.Visible)
            {
                textBox1.Visible = true;
            }
            else if (sender == roundedTextBox7 && !labelInvalidInputPrompt.Visible)
            {
                textBox1.Visible = false;
            }

        }

        private void PasswordField_TextChanged(object? sender, EventArgs e)
        {
            if (sender == roundedTextBox6)
            {
                ComparePasswords(sender);
            }
        }
    }
}
