using MySqlConnector;

namespace KSK
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }
        private int loginToApp(MySqlConnection connection)
        {
            connection.Open();
            using var command = new MySqlCommand("select ID_Uzytkownik from uzytkownicy where login = '" + login.Text + "' AND haslo = '" + password.Text + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                MessageBox.Show("Uda?o si? zalogowa?, id u?ytkownika: " + id, "", MessageBoxButtons.OK);
                connection.Close();
                return id;
            }
            else
            {
                MessageBox.Show("B??dne dane logowania", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = loginToApp(Program.connectionMethodAsync());
            if (id != 0)
            {
                CustomerWindow CustWindow = new CustomerWindow(id);
                this.Hide();
                CustWindow.Show();
            }
        }
        private void LogInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.closeMainForms();
        }
    }
}