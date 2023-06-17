using MySqlConnector;

namespace KSK
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }
        public int loginToApp(MySqlConnection connection)
        {
            connection.Open();
            using var command = new MySqlCommand("select ID_Uzytkownik from uzytkownicy where login = '" + login.Text + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                connection.Close();
                connection.Open();
                using var command2 = new MySqlCommand("select haslo from uzytkownicy where ID_Uzytkownik = " + id, connection);
                MySqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                string haslo = reader2.GetString(0);
                if (haslo == password.Text)
                {
                    MessageBox.Show("Uda³o siê zalogowaæ, id u¿ytkownika: " + id +"   " + haslo + "     " + password.Text, "", MessageBoxButtons.OK);
                    connection.Close();

                    return id;
                }
                else
                {
                    MessageBox.Show("B³êdne dane logowania", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return 0;
                }
                
            }
            else
            {
                MessageBox.Show("B³êdne dane logowania", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    customerWindow.Show();
                    this.Close();
                    
                }
                else
                {
                    EmployeeWindow employeeWindow = new EmployeeWindow(id);
                    employeeWindow.Show();
                    this.Close();
                    
                }
            }
        }
    }
}