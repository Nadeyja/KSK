﻿using MySqlConnector;
using System;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idtermin = 1;
            string timeString = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
            MessageBox.Show(timeString, "Wyniki", MessageBoxButtons.OK);
            con.Open();
            command = new MySqlCommand("select ID_Termin from termin order by ID_Termin desc", con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                idtermin = reader.GetInt32(0)+1;
            }        
            con.Close();
            con.Open();
            command = new MySqlCommand("insert into termin (ID_Termin, data, status, ID_Klient) value ("+idtermin+", '"+timeString+"', 'Niezaakceptowany', "+id_klient+")", con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}