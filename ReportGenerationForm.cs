using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace INFOSYS
{
    public partial class ReportGenerationForm : Form
    {
        public ReportGenerationForm()
        {
            InitializeComponent();
        }

        // Load transactions based on the filter
        private void LoadTransactions(string filter = "")
        {
            // Updated query with JOIN to get the transaction_type from the transaction_types table
            string query = "SELECT t.transaction_id, t.user_id, tt.transaction_type, t.amount, t.created_at " +
                           "FROM transactions t " +
                           "JOIN transaction_types tt ON t.transaction_type_id = tt.id"; // Join with the transaction_types table

            // If there's a filter, apply it to the transaction_type or user_id
            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE tt.transaction_type LIKE @filter OR t.user_id LIKE @filter";
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvReport.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading transactions: {ex.Message}");
            }
        }

        // Apply filter on the report
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            LoadTransactions(filter);
        }

        // Generate and export Excel report
        private void GenerateExcelReport()
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Transactions");

                // Add headers
                worksheet.Cell(1, 1).Value = "Transaction ID";
                worksheet.Cell(1, 2).Value = "User ID";
                worksheet.Cell(1, 3).Value = "Transaction Type";
                worksheet.Cell(1, 4).Value = "Amount";
                worksheet.Cell(1, 5).Value = "Created At";

                int row = 2;
                foreach (DataGridViewRow dgvRow in dgvReport.Rows)
                {
                    if (dgvRow.Cells["transaction_id"].Value != null)
                    {
                        worksheet.Cell(row, 1).Value = dgvRow.Cells["transaction_id"].Value.ToString();
                        worksheet.Cell(row, 2).Value = dgvRow.Cells["user_id"].Value.ToString();
                        worksheet.Cell(row, 3).Value = dgvRow.Cells["transaction_type"].Value.ToString(); // Get transaction type
                        worksheet.Cell(row, 4).Value = dgvRow.Cells["amount"].Value.ToString();
                        worksheet.Cell(row, 5).Value = dgvRow.Cells["created_at"].Value.ToString();
                        row++;
                    }
                }

                // Define file path and save Excel file
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TransactionsReport.xlsx");
                workbook.SaveAs(filePath);

                MessageBox.Show($"Report generated and saved to: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while generating report: {ex.Message}");
            }
        }

        // Button click event to generate the report
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateExcelReport();
        }

        // Form Load event to load transactions
        private void ReportGenerationForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
