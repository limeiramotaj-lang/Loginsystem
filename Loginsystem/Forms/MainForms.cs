using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loginsystem.Models;
using Loginsystem.Services;

namespace Loginsystem.Forms
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void btnAdminPanel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Área administrativa (você pode listar usuários, etc.)");
            // Abrir um form de administração, etc.
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Session.LoggedUser = null;
            this.Close();
            Application.Restart(); // Ou reabrir o LoginForm
        }

        private void MainForms_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem-vindo, {Session.LoggedUser.Username}!";
            if (AuthService.IsInRole(Session.LoggedUser, "Admin"))
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }
    }
}
    

