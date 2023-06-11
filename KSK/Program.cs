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
            
            ApplicationConfiguration.Initialize();
            var main_form = new LogInWindow();
            main_form.Show();
            Application.Run();
        }

        static async Task connectionMethodAsync()
        {
            String connectionString = "Server=Local Instance MySQL80;User ID=root;Password=qwerty;Database=ksk";
            using var connection = new MySqlConnection(connectionString);
            await connection.OpenAsync();

            //using var command = new MySqlCommand("select * from login where username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'", connection);
            //using var reader = await command.ExecuteReaderAsync();
            //while (await reader.ReadAsync())
            //{
              //  var value = reader.GetValue(0);
                // do something with 'value'
            //}
        }
    }
}