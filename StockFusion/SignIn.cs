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
using WindowsFormsApp1.Dashboard;

namespace StockFusion
{
    public partial class SignIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VET6LBO\MSSQLSERVER01;Initial Catalog=StockFusion;Integrated Security=True;TrustServerCertificate=True");

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
            if (roundedTextBox1.Texts == " " || roundedTextBox2.Texts == " ")
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    try
                    {
                        string query = "SELECT UserType FROM SignUp WHERE Username=@Username AND Password=@Password";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Username", roundedTextBox1.Texts);
                            cmd.Parameters.AddWithValue("@Password", roundedTextBox2.Texts);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                string userType = table.Rows[0]["UserType"].ToString();
                                if (userType == "Admin")
                                {
                                    Admin_main admin_Main = new Admin_main();
                                    admin_Main.Show();
                                }

                                else if (userType == "Customer")
                                {
                                    //Customer_main customer_Main = new Customer_main();
                                    //customer_Main.Show();
                                    MessageBox.Show("Login sucessful for Customer");
                                }
                                else if (userType == "Manager")
                                {
                                    //Admin_main admin_Main = new Admin_main();
                                    //admin_Main.Show();
                                    MessageBox.Show("Login sucessful for Manager");
                                }
                                else if (userType == "FinancialManager")
                                {
                                    //Admin_main admin_Main = new Admin_main();
                                    //admin_Main.Show();
                                    MessageBox.Show("Login sucessful for FinancialManager");
                                }

                                else
                                {
                                    MessageBox.Show("Invalid UserType assigned. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                InsertLogin(roundedTextBox1.Texts, roundedTextBox2.Texts, "Active");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        private void InsertLogin(string userName, string password, string status)
        {
            string query = "INSERT INTO Login (Username, Password, Status) VALUES (@UserName, @Password, @Status)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Status", status);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
