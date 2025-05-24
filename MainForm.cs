using System;
using System.Windows.Forms;

namespace INFOSYS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            welcome.Text = "Welcome User";
        }

        private void usermanagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
        }

        private void transactions_Click(object sender, EventArgs e)
        {
            TransactionFormDesign transactionForm = new TransactionFormDesign();
            transactionForm.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            ReportGenerationForm reportGenerationForm = new ReportGenerationForm();
            reportGenerationForm.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
