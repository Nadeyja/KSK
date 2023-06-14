using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;

namespace KSK
{
    internal static class Program
    {
        public static LogInWindow main_window = new LogInWindow();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(main_window);
        }
        public static void closeMainForms()
        {
            main_window.Close();
        }
        public static MySqlConnection connectionMethodAsync()
        {
            MySqlConnection connection = new MySqlConnection("datasource= localhost; database=ksk;port=3306; username = root; password= qwertyuiop");
            return connection;
        }
    }
}