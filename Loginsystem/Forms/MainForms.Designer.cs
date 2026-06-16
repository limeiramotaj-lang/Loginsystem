namespace Loginsystem.Forms
{
    partial class MainForms
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
            btnAdminPanel = new Button();
            btnLogout = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Location = new Point(85, 201);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(75, 23);
            btnAdminPanel.TabIndex = 0;
            btnAdminPanel.Text = "Admin";
            btnAdminPanel.UseVisualStyleBackColor = true;
            btnAdminPanel.Click += btnAdminPanel_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(231, 201);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(100, 77);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome";
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 318);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnAdminPanel);
            Name = "MainForms";
            Text = "MainForm";
            Load += MainForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminPanel;
        private Button btnLogout;
        private Label lblWelcome;
    }
}