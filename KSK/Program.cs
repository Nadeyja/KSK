using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;

namespace KSK
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new LogInWindow();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
        public static MySqlConnection connectionMethodAsync()
        {
            MySqlConnection connection = new MySqlConnection("datasource= localhost; database=ksk; port=3306; username = root; password= qwertyuiop"); //Tutaj nale¿y wprowadziæ nazwe po³¹czenia oraz username roota oraz jego has³o
            return connection;
        }
    }
}