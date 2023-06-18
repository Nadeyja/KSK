using MySqlConnector;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSK
{

    public partial class Form1 : Form
    {
        private int id_klient;
        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;


        public Form1(int id)
        {
            id_klient = id;
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
            command = new MySqlCommand("select data, status, ID_Termin from termin where ID_Klient = " + id_klient + " order by data", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                date = reader.GetDateTime(0);
                status = reader.GetString(1);
                id_termin = reader.GetInt32(2);
                object termin = new Termin(date, status, id_termin);
                listBox1.Items.Add(termin.ToString());
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id_termin = 1;
            int temp = 1;
            DateTime date = dateTimePicker1.Value;
            string timeString = date.ToString("yyyy-MM-dd HH:mm:ss");
            con.Open();
            command = new MySqlCommand("select ID_Termin from termin order by ID_Termin", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetInt32(0);
                if (temp > id_termin)
                {
                    id_termin = temp - 1;
                    break;
                }
                else
                {
                    id_termin = temp + 1;
                }

            }
            con.Close();
            Termin termin = new Termin(date, "Niezaakceptowany", id_termin);
            con.Open();
            command = new MySqlCommand("insert into termin (ID_Termin, data, status, ID_Klient) value (" + id_termin + ", '" + timeString + "', 'Niezaakceptowany', " + id_klient + ")", con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
            reloadListBox();

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
