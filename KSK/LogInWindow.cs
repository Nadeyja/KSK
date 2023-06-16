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
            MySqlConnection connection = Program.connectionMethodAsync();
            int id = loginToApp(connection);
            if (id != 0)
            {
                connection.Open();
                using var command = new MySqlCommand("select ID_Uzytkownik from klient where ID_Uzytkownik = " + id, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CustomerWindow customerWindow = new CustomerWindow(id);
                    this.Hide();
                    customerWindow.Show();
                }
                else
                {
                    EmployeeWindow employeeWindow = new EmployeeWindow(id);
                    this.Hide();
                    employeeWindow.Show();
                }
            }
        }
        private void LogInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.closeMainForms();
        }
    }
}