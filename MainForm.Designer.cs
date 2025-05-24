namespace INFOSYS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label welcome;
        private Button usermanagement;
        private Button transactions;
        private Button reports;
        private Button logout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            welcome = new Label();
            usermanagement = new Button();
            transactions = new Button();
            reports = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.LightCyan;
            welcome.Location = new Point(185, 50);
            welcome.Name = "welcome";
            welcome.Size = new Size(220, 35);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome User";
            // 
            // usermanagement
            // 
            usermanagement.BackColor = Color.DarkSlateGray;
            usermanagement.FlatStyle = FlatStyle.Flat;
            usermanagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usermanagement.ForeColor = Color.LightCyan;
            usermanagement.Location = new Point(71, 136);
            usermanagement.Name = "usermanagement";
            usermanagement.Size = new Size(170, 74);
            usermanagement.TabIndex = 1;
            usermanagement.Text = "User Management";
            usermanagement.UseVisualStyleBackColor = false;
            usermanagement.Click += usermanagement_Click;
            // 
            // transactions
            // 
            transactions.BackColor = Color.DarkSlateGray;
            transactions.FlatStyle = FlatStyle.Flat;
            transactions.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactions.ForeColor = Color.LightCyan;
            transactions.Location = new Point(306, 136);
            transactions.Name = "transactions";
            transactions.Size = new Size(170, 74);
            transactions.TabIndex = 2;
            transactions.Text = "Transactions";
            transactions.UseVisualStyleBackColor = false;
            transactions.Click += transactions_Click;
            // 
            // reports
            // 
            reports.BackColor = Color.DarkSlateGray;
            reports.FlatStyle = FlatStyle.Flat;
            reports.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reports.ForeColor = Color.LightCyan;
            reports.Location = new Point(71, 241);
            reports.Name = "reports";
            reports.Size = new Size(170, 74);
            reports.TabIndex = 3;
            reports.Text = "Reports";
            reports.UseVisualStyleBackColor = false;
            reports.Click += reports_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.DarkSlateGray;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.LightCyan;
            logout.Location = new Point(306, 241);
            logout.Name = "logout";
            logout.Size = new Size(170, 74);
            logout.TabIndex = 4;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(555, 397);
            Controls.Add(logout);
            Controls.Add(reports);
            Controls.Add(transactions);
            Controls.Add(usermanagement);
            Controls.Add(welcome);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
