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
    public partial class CustomerWindow : Form
    {
        private int id_klient;
        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public CustomerWindow(int id)
        {
            InitializeComponent();
            con.Open();
            command = new MySqlCommand("select ID_Klient from klient where ID_Uzytkownik = " + id, con);
            reader = command.ExecuteReader();
            reader.Read();
            id_klient = reader.GetInt32(0);
            con.Close();
            con.Open();
            command = new MySqlCommand("select imie, nazwisko from klient where ID_Klient = " + id_klient, con);
            reader = command.ExecuteReader();
            reader.Read();
            label5.Text = reader.GetString(0);
            label6.Text = reader.GetString(1);
            con.Close();
            con.Open();
            command = new MySqlCommand("select stopień from ulga where ID_Klient = " + id_klient, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                int stopien = reader.GetInt32(0);
                if (stopien == 0)
                {
                    label4.Text = "Brak";
                }
                else
                {
                    label4.Text = stopien.ToString();
                }
            }
            else
            {
                label4.Text = "Not found";
            }
            con.Close();
            con.Open();
            command = new MySqlCommand("select grupa_krwi from wyniki_badan where ID_Klient = " + id_klient, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                label2.Text = reader.GetString(0);
            }
            else
            {
                label2.Text = "Not found";
            }

            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            this.Close();
            logInWindow.Show();

        }
        private void Cust_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.closeMainForms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 CustAppWindow = new Form1(id_klient);
            CustAppWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            command = new MySqlCommand("select informacja_zwrotna from wyniki_badan where ID_Klient = " + id_klient, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Informacja zwrotna: " + reader.GetString(0), "Wyniki", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
    }
}
