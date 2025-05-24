using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace INFOSYS
{
    public partial class TransactionFormDesign : Form
    {
        public TransactionFormDesign()
        {
            InitializeComponent();
        }

        // This method is triggered when the TransactionFormDesign is loaded
        private void TransactionFormDesign_Load(object sender, EventArgs e)
        {
            LoadTransactionTypes();
            txtAmount.Text = "0.00"; // Set default amount to 0
        }

        // Method to load transaction types into the ComboBox
        private void LoadTransactionTypes()
        {
            cmbTransactionType.Items.Clear();

            string query = "SELECT transaction_type FROM transaction_types"; // Assuming you have a table for this

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string transactionType = reader["transaction_type"].ToString();
                            cmbTransactionType.Items.Add(transactionType);
                        }
                    }
                }

                if (cmbTransactionType.Items.Count > 0)
                {
                    cmbTransactionType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction types: {ex.Message}");
            }
        }

        // Button click event for adding a transaction
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTransactionType.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please fill in both the transaction type and amount.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
                return;
            }

            int userId = 1; // Replace with actual logic to get logged-in user ID
            string transactionType = cmbTransactionType.SelectedItem.ToString();

            AddTransaction(userId, transactionType, amount);
        }

        // Method to add a transaction to the database
        private void AddTransaction(int userId, string transactionType, decimal amount)
        {
            string query = "INSERT INTO transactions (user_id, transaction_type_id, amount, created_at) " +
                           "VALUES (@userId, (SELECT id FROM transaction_types WHERE transaction_type = @transactionType), @amount, NOW())";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@transactionType", transactionType);
                        cmd.Parameters.AddWithValue("@amount", amount);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Transaction added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}");
            }
        }
    }
}
