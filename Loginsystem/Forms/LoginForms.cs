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
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        private void LoginForms_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }
            var user = AuthService.Authenticate(username, password);
            if (user != null)
            {
                // Guarda o usuário logado em uma variável estática (ou em Program)
                Session.LoggedUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }

        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForms();
            registerForm.ShowDialog();
        }
    }
}
