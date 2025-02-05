using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RoundedButton;
using CustomControls.RoundedTextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StockFusion
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidInputPrompt.Text = "Enter your username";
                labelInvalidInputPrompt.Location = new Point(249, 120);
                labelInvalidInputPrompt.Visible = true;
            }
            else
            {
                labelInvalidInputPrompt.Visible = false;
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            string password = roundedTextBox2.Text;

            // Clear any previous error messages
            labelInvalidInputPrompt.Visible = false;

            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidInputPrompt.Text = "Enter your username";
                labelInvalidInputPrompt.Location = new Point(249, 120);
                labelInvalidInputPrompt.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                labelInvalidInputPrompt.Text = "Enter password";
                labelInvalidInputPrompt.Location = new Point(249, 200);
                labelInvalidInputPrompt.Visible = true;
            }
            else
            {
                // Validate credentials
                if (ValidateUserCredentials(userName, password))
                {
                    User user = new User();
                    user.Show();
                    this.Hide();
                }
                else
                {
                    labelInvalidInputPrompt.Text = "Invalid username or password";
                    labelInvalidInputPrompt.Location = new Point(249, 200);
                    labelInvalidInputPrompt.Visible = true;
                }
            }
        }

        private bool ValidateUserCredentials(string userName, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SignUp] WHERE [User Name] = @UserName AND [Password] = @Password", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Password", password);
                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Forget forget = new Forget();
            forget.Show();
            this.Hide();
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(Show.Checked);
        }
        private void TogglePasswordVisibility(bool showPassword)
        {
            // roundedTextBox2.PasswordChar = !showPassword;
            roundedTextBox2.PasswordChar = !showPassword;

        }

    }
}
