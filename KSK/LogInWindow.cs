using MySqlConnector;

namespace KSK
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }
        bool connectionMethodAsync()
        {
            MySqlConnection connection = new MySqlConnection("datasource= localhost; database=ksk;port=3306; username = root; password= qwerty");
            
            connection.Open();

            using var command = new MySqlCommand("select * from uzytkownicy where login = '" + login.Text + "' AND haslo = '" + password.Text + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Successfully Sign In!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Username And Password Not Match!", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool canLogin = connectionMethodAsync();
            if (canLogin) { 
                CustomerWindow CustWindow = new CustomerWindow();
                this.Hide();
                CustWindow.Show();
            }
        }
        private void LogInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}