using System;
using System.Windows.Forms;
using Tourist;

namespace VD
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ENTER());
        }
        static class Database
        {
            public static string connectionString = "Data Source=praktika.db;Cache=Shared;Mode=ReadOnly;";
        }
    }
}