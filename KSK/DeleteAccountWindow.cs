using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSK
{
    public partial class DeleteAccountWindow : Form
    {
        private MySqlConnection connection = Program.connectionMethodAsync();
        private int id;
        private int id_klient;
        private CustomerWindow customerWindow;
        public DeleteAccountWindow(int id, int id_klient, CustomerWindow customerWindow)
        {
            this.id = id;
            this.id_klient = id_klient;
            this.customerWindow = customerWindow;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            using var command = new MySqlCommand("select ID_Uzytkownik from uzytkownicy where login = '" + textBox1.Text + "' AND haslo = '" + textBox2.Text + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt32(0) == id)
                {
                    connection.Close();
                    connection.Open();
                    using var command2 = new MySqlCommand("delete from uzytkownicy where ID_Uzytkownik = " + id, connection);
                    command2.CommandType = CommandType.Text;
                    command2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Konto zostało usunięte!" + id, "", MessageBoxButtons.OK);
                    LogInWindow logInWindow = new LogInWindow();
                    this.Close();
                    customerWindow.Close();
                    logInWindow.Show();
                }
                else
                {
                    MessageBox.Show("Błędne dane", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Błędne dane", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
