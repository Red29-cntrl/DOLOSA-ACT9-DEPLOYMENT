using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace INFOSYS
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        // Load users into the DataGridView
        private void LoadUsers()
        {
            string query = "SELECT id, username, email FROM users";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }
        }

        // Add new user
        private void AddUser(string username, string password, string email)
        {
            string query = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Update existing user
        private void UpdateUser(int id, string username, string email)
        {
            string query = "UPDATE users SET username = @username, email = @email WHERE id = @id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete user
        private void DeleteUser(int id)
        {
            string query = "DELETE FROM users WHERE id = @id";
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Add User button click event
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AddUser(username, password, email);
            MessageBox.Show("User added successfully.");
            LoadUsers();  // Refresh the user list
        }

        // Update User button click event
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
                string username = txtUsername.Text;
                string email = txtEmail.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                UpdateUser(id, username, email);
                MessageBox.Show("User updated successfully.");
                LoadUsers();  // Refresh the user list
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        // Delete User button click event
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
                DeleteUser(id);
                MessageBox.Show("User deleted successfully.");
                LoadUsers();  // Refresh the user list
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        // Handle cell click in the DataGridView (optional, for user selection)
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        // Back button click event
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        // Form Load event to populate the DataGridView with users when the form is opened
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
