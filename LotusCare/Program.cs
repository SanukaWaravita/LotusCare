using LotusCare.Forms;
using LotusCare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusCare
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LotusCare\LotusCare\LotusCareDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            IUserService userService = new UserService(connectionString);

            Application.Run(new LoginForm(userService));
        }
    }
}
