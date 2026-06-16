namespace Loginsystem.Forms
{
    partial class RegisterForms
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
            btnRegister = new Button();
            txtConfirm = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(116, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(138, 174);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(100, 23);
            txtConfirm.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(138, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 54);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 177);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Confime:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 11;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(317, 174);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 12;
            // 
            // RegisterForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtConfirm);
            Controls.Add(btnRegister);
            Name = "RegisterForms";
            Text = "RegisterForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtConfirm;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cmbRole;
    }
}