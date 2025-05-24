namespace INFOSYS
{
    partial class ForgotpasswordForm
    {
        private void InitializeComponent()
        {
            email = new Label();
            txtEmail = new TextBox();
            btnSendLink = new Button();
            buttonback = new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.ForeColor = Color.LightCyan;
            email.Location = new Point(73, 64);
            email.Name = "email";
            email.Size = new Size(54, 25);
            email.TabIndex = 0;
            email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.PaleTurquoise;
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(73, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 31);
            txtEmail.TabIndex = 1;
            // 
            // btnSendLink
            // 
            btnSendLink.FlatStyle = FlatStyle.Flat;
            btnSendLink.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendLink.ForeColor = Color.LightCyan;
            btnSendLink.Location = new Point(73, 163);
            btnSendLink.Name = "btnSendLink";
            btnSendLink.Size = new Size(94, 36);
            btnSendLink.TabIndex = 2;
            btnSendLink.Text = "Send";
            btnSendLink.UseVisualStyleBackColor = true;
            btnSendLink.Click += btnSendLink_Click;

            // 
            // buttonback
            // 
            buttonback.FlatStyle = FlatStyle.Flat;
            buttonback.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonback.ForeColor = Color.LightCyan;
            buttonback.Location = new Point(357, 163);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(94, 36);
            buttonback.TabIndex = 3;
            buttonback.Text = "Back";
            buttonback.UseVisualStyleBackColor = true;
            buttonback.Click += button1_Click;  // This is the correct method reference

            // 
            // ForgotpasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(534, 301);
            Controls.Add(buttonback);
            Controls.Add(btnSendLink);
            Controls.Add(txtEmail);
            Controls.Add(email);
            Name = "ForgotpasswordForm";
            Text = "ForgotpasswordForm";
            Load += ForgotpasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label email;
        private TextBox txtEmail;
        private Button btnSendLink;
        private Button buttonback;
    }
}
