namespace INFOSYS
{
    partial class ReportGenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerateReport = new Button();
            dgvReport = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Transaction = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnApplyFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.LightCyan;
            btnGenerateReport.Location = new Point(12, 37);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(173, 42);
            btnGenerateReport.TabIndex = 0;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.PaleTurquoise;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Columns.AddRange(new DataGridViewColumn[] { ID, Username, Email, Transaction });
            dgvReport.Location = new Point(12, 110);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(776, 188);
            dgvReport.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Visible = false;
            Username.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Visible = false;
            Email.Width = 125;
            // 
            // Transaction
            // 
            Transaction.HeaderText = "Transaction";
            Transaction.MinimumWidth = 6;
            Transaction.Name = "Transaction";
            Transaction.ReadOnly = true;
            Transaction.Visible = false;
            Transaction.Width = 125;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.PaleTurquoise;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(12, 323);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(776, 31);
            txtSearch.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplyFilter.ForeColor = Color.LightCyan;
            btnApplyFilter.Location = new Point(207, 37);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(173, 42);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // ReportGenerationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 407);
            Controls.Add(btnApplyFilter);
            Controls.Add(txtSearch);
            Controls.Add(dgvReport);
            Controls.Add(btnGenerateReport);
            Name = "ReportGenerationForm";
            Text = "ReportGenerationForm";
            Load += ReportGenerationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateReport;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Transaction;
        private TextBox txtSearch;
        private Button btnApplyFilter;
    }
}
