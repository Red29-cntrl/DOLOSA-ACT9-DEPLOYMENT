namespace INFOSYS
{
    partial class TransactionFormDesign
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
            cmbTransactionType = new ComboBox();
            txtAmount = new TextBox();
            btnAddTransaction = new Button();
            SuspendLayout();
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.BackColor = Color.PaleTurquoise;
            cmbTransactionType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "Deposit", "Withdrawal", "Purchase" });
            cmbTransactionType.Location = new Point(63, 47);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(506, 33);
            cmbTransactionType.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.PaleTurquoise;
            txtAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(63, 98);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter Amount";
            txtAmount.Size = new Size(216, 31);
            txtAmount.TabIndex = 1;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.FlatStyle = FlatStyle.Flat;
            btnAddTransaction.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTransaction.ForeColor = Color.LightCyan;
            btnAddTransaction.Location = new Point(63, 143);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(216, 40);
            btnAddTransaction.TabIndex = 2;
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TransactionFormDesign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(653, 236);
            Controls.Add(btnAddTransaction);
            Controls.Add(txtAmount);
            Controls.Add(cmbTransactionType);
            Name = "TransactionFormDesign";
            Text = "TransactionFormDesign";
            Load += TransactionFormDesign_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTransactionType;
        private TextBox txtAmount;
        private Button btnAddTransaction;
    }
}