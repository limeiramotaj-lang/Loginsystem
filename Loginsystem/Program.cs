using Loginsystem.Data;
using Loginsystem.Forms;
using Loginsystem.Models;

namespace Loginsystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Garante que o banco seja criado e as migrations aplicadas
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // Cria o banco se não existir
            }
            while (true)
            {
                using (var loginForm = new LoginForms())
                {
                    var result = loginForm.ShowDialog();
                    if (result == DialogResult.OK && Session.LoggedUser != null)
                    {
                        Application.Run(new MainForms());
                        // Se o MainForm fechar, volta para o loop (logout ou restart)
                        // Se quiser realmente encerrar, break;else
                        {
                            break; // Fechou o login sem sucesso
                        }
                    }
                }
            }
        }
    }
}
