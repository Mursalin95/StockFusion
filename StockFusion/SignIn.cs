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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StockFusion
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.Click += new EventHandler(Form_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form_Click(object? sender, EventArgs e)
        {
            ActiveControl = null;
            Cursor = Cursors.Default;
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidUserNamePrompt.Text = "Enter your username";
                labelInvalidUserNamePrompt.Visible = true;
            }
            else
            {
                labelInvalidUserNamePrompt.Visible = false;
            }
        }

        private void roundedTextBox2_TextChanged(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            string password = roundedTextBox2.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                labelInvalidUserNamePrompt.Text = "Enter your username";
                labelInvalidUserNamePrompt.Visible = true;
            }
            else
            {
                labelInvalidUserNamePrompt.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                labelInvalidPasswordPrompt.Text = "Enter password";
                labelInvalidPasswordPrompt.Location = new Point(249, 200);
                labelInvalidPasswordPrompt.Visible = true;
            }
            else
            {
                labelInvalidPasswordPrompt.Visible = false;
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private bool ValidateUserCredentials(string userName, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [SignUp] WHERE [UserName] = @UserName AND [Password] = @Password", conn))
                    {
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName.Trim();
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password.Trim();
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

        private string GetUserType(string userName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT [UserType] FROM [SignUp] WHERE [UserName] = @UserName", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["UserType"].ToString();
                            }
                            else
                            {
                                return string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
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
            roundedTextBox2.PasswordChar = !showPassword;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string userName = roundedTextBox1.Text;
            string password = roundedTextBox2.Text;

            if (ValidateUserCredentials(userName, password))
            {
                string userType = GetUserType(userName);
                if (userType == "Admin")
                {
                    MessageBox.Show("Success");
                }
                else if (userType == "FinancialManager")
                {
                    // FinancialManager financialManager = new FinancialManager();
                    // financialManager.Show();
                }
                else if (userType == "Manager")
                {
                    // Manager manager = new Manager();
                    // manager.Show();
                }
                else if (userType == "Customer")
                {
                    // Customer customer = new Customer();
                    // customer.Show();
                }
                this.Hide();
            }
            else
            {
                labelInvalidPasswordPrompt.Text = "Invalid username or password";
                labelInvalidPasswordPrompt.Visible = true;
            }
        }
    }
}

