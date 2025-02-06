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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StockFusion
{
    public partial class Forget : Form
    {
        public Forget()
        {
            InitializeComponent();
            this.Click += new EventHandler(Form_Click);
            roundedTextBox1.Enter += new EventHandler(roundedTextBox1_Enter);
            roundedTextBox1.TextChanged += new EventHandler(roundedTextBox1_TextChanged);
            roundedTextBox2.TextChanged += new EventHandler(roundedTextBox2_TextChanged);
            roundedTextBox3.TextChanged += new EventHandler(roundedTextBox3_TextChanged);
            Checkbox1.CheckedChanged += new EventHandler(Checkbox1_CheckedChanged);
            roundedButton1.Click += new EventHandler(roundedButton1_Click);
        }

        private void Form_Click(object? sender, EventArgs e)
        {
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roundedTextBox1.Text))
            {
                labelInvalidPrompt.Text = "Enter your username";
                labelInvalidPrompt.Location = new Point(137, 110);
                labelInvalidPrompt.Visible = true;
            }
            else
            {
                labelInvalidPrompt.Visible = false;
            }
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidPrompt.Visible = true;
                labelInvalidPrompt.Text = "Enter your username";
                labelInvalidPrompt.Location = new Point(137, 110);
            }
            else if (!IsUserNameExists(userName))
            {
                labelInvalidPrompt.Text = "Username not found";
                labelInvalidPrompt.Location = new Point(137, 110);
                labelInvalidPrompt.Visible = true;
            }
            else
            {
                labelInvalidPrompt.Visible = false;
            }
        }

        private void roundedTextBox2_TextChanged(object sender, EventArgs e)
        {
            string password = roundedTextBox2.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                labelInvalidPrompt.Text = "Enter your password";
                labelInvalidPrompt.Visible = true;
            }
            else
            {
                labelInvalidPrompt.Visible = false;
            }
        }

        private void roundedTextBox3_TextChanged(object sender, EventArgs e)
        {
            string confirmPassword = roundedTextBox3.Text;
            string newPassword = roundedTextBox2.Text;

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                labelInvalidPrompt.Text = "Confirm your password";
                labelInvalidPrompt.Visible = true;
            }
            else if (confirmPassword != newPassword)
            {
                labelInvalidPrompt.Text = "Passwords do not match";
                labelInvalidPrompt.Visible = true;
            }
            else
            {
                labelInvalidPrompt.Visible = false;
            }
        }

        private void Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(Checkbox1.Checked);
        }

        private void TogglePasswordVisibility(bool showPassword)
        {
            roundedTextBox2.PasswordChar = !showPassword;
            roundedTextBox3.PasswordChar = !showPassword;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            string newPassword = roundedTextBox2.Text;
            string confirmPassword = roundedTextBox3.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidPrompt.Text = "Enter your username";
                labelInvalidPrompt.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                labelInvalidPrompt.Text = "Enter new password";
                labelInvalidPrompt.Visible = true;
                return;
            }

            if (newPassword != confirmPassword)
            {
                labelInvalidPrompt.Text = "Passwords do not match";
                labelInvalidPrompt.Visible = true;
                return;
            }

            if (UpdatePassword(userName, newPassword))
            {
                MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                labelInvalidPrompt.Text = "Failed to update password";
                labelInvalidPrompt.Visible = true;
            }
        }

        private bool IsUserNameExists(string userName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SignUp] WHERE [UserName] = @UserName", conn))
                    {
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName.Trim();
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

        private bool UpdatePassword(string userName, string newPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE [SignUp] SET [Password] = @Password WHERE [UserName] = @UserName", conn))
                    {
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName.Trim();
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = newPassword.Trim();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

