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
    public partial class EmployeeAppointmentWindow : Form
    {
        private int id_klient;
        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;
        public EmployeeAppointmentWindow()
        {
            InitializeComponent();
            reloadListBox();
        }
        private void reloadListBox()
        {
            listBox1.Items.Clear();
            con.Open();
            DateTime date;
            string status;
            int id_termin;
            command = new MySqlCommand("select data, status, ID_Termin, ID_Klient from termin order by data", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                date = reader.GetDateTime(0);
                status = reader.GetString(1);
                id_termin = reader.GetInt32(2);
                id_klient = reader.GetInt32(3);
                object termin = new Termin(date, status, id_termin, id_klient);
                string toList = Termin.toString(date, status, id_termin, id_klient);
                listBox1.Items.Add(toList);

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string termin = listBox1.SelectedItem.ToString();
                string str_id_termin = termin.Split(' ').Last();
                int id_termin = Int32.Parse(str_id_termin);
                con.Open();
                command = new MySqlCommand("update termin set status = 'Zaakceptowany' where ID_Termin = " + id_termin, con);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                con.Close();
                reloadListBox();
            }
            else
            {
                MessageBox.Show("Termin nie zaznaczony!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string termin = listBox1.SelectedItem.ToString();
                string str_id_termin = termin.Split(' ').Last();
                int id_termin = Int32.Parse(str_id_termin);
                con.Open();
                command = new MySqlCommand("delete from termin where ID_Termin = " + id_termin, con);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                con.Close();
                reloadListBox();
            }
            else
            {
                MessageBox.Show("Termin nie zaznaczony!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
