using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace INFOSYS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private bool ValidateUser(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();
            string query = "SELECT COUNT(*) FROM users WHERE LOWER(username) = LOWER(@username) AND LOWER(password) = LOWER(@password)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful.");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotpasswordForm forgotPasswordForm = new ForgotpasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}
