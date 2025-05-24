using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace INFOSYS
{
    public partial class ForgotpasswordForm : Form
    {
        public ForgotpasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotpasswordForm_Load(object sender, EventArgs e) { }

        // Logic to send password reset link to the user's email
        private void SendPasswordResetLink(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT username FROM users WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        var username = cmd.ExecuteScalar()?.ToString();

                        if (username != null)
                        {
                            MessageBox.Show("Password reset link sent.");
                        }
                        else
                        {
                            MessageBox.Show("Email not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Event handler for the "Send" button click
        private void btnSendLink_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            SendPasswordResetLink(email);
        }

        // Event handler for the "Back" button click
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
