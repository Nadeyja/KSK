﻿using MySqlConnector;
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
    public partial class EmployeeWindow : Form
    {
        private int id_pracownik;
        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;
        public EmployeeWindow(int id)
        {

            InitializeComponent();
            con.Open();
            command = new MySqlCommand("select ID_Pracownik from pracownik where ID_Uzytkownik = " + id, con);
            reader = command.ExecuteReader();
            reader.Read();
            id_pracownik = reader.GetInt32(0);
            con.Close();
            con.Open();
            command = new MySqlCommand("select imię, nazwisko from pracownik where ID_Pracownik = " + id_pracownik, con);
            reader = command.ExecuteReader();
            reader.Read();
            label5.Text = reader.GetString(0);
            label6.Text = reader.GetString(1);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAppointmentWindow employeeAppointmentWindow = new EmployeeAppointmentWindow();
            employeeAppointmentWindow.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            TransportWindow transportWindow = new TransportWindow(id_pracownik);
            transportWindow.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
           BloodResultsWindow bloodResultWindow = new BloodResultsWindow();
           bloodResultWindow.ShowDialog();

        }
    }
}
