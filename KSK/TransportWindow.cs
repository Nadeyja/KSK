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
    public partial class TransportWindow : Form
    {
        private int id_pracownik;
        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;
        public TransportWindow(int id_pracownik)
        {
            this.id_pracownik = id_pracownik;
            InitializeComponent();
            reloadListBox();
        }
        private void reloadListBox()
        {
            listBox1.Items.Clear();
            con.Open();
            DateTime date;
            string trasa;
            int id_transport;
            command = new MySqlCommand("select data, trasa, ID_Transport from transport where ID_Pracownik = " + id_pracownik + " order by data", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                date = reader.GetDateTime(0);
                trasa = reader.GetString(1);
                id_transport = reader.GetInt32(2);
                object transport = new Transport(date, trasa, id_transport);
                listBox1.Items.Add(transport.ToString());
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id_transport = 1;
            int temp = 1;
            DateTime date = dateTimePicker1.Value;
            string timeString = date.ToString("yyyy-MM-dd HH:mm:ss");
            con.Open();
            command = new MySqlCommand("select ID_Transport from transport order by ID_Transport", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetInt32(0);
                if (temp > id_transport)
                {
                    id_transport = temp - 1;
                    break;
                }
                else
                {
                    id_transport = temp + 1;
                }

            }
            con.Close();
            Transport transport = new Transport(date, textBox1.Text, id_transport);
            con.Open();
            command = new MySqlCommand("insert into transport (ID_Transport, data, trasa, ID_Pracownik) value (" + id_transport + ", '" + timeString + "', '"+textBox1.Text+"', " + id_pracownik + ")", con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
            reloadListBox();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string transport = listBox1.SelectedItem.ToString();
                string str_id_transport = transport.Split(' ').Last();
                int id_transport = Int32.Parse(str_id_transport);
                con.Open();
                command = new MySqlCommand("delete from transport where ID_Transport = " + id_transport, con);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                con.Close();
                reloadListBox();
            }
            else
            {
                MessageBox.Show("Transport nie zaznaczony!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
