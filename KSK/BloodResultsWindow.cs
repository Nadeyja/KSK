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
    public partial class BloodResultsWindow : Form
    {

        private MySqlConnection con = Program.connectionMethodAsync();
        private MySqlCommand command;
        private MySqlDataReader reader;
        public BloodResultsWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            command = new MySqlCommand("select ID_Klient from klient where ID_Klient = " + textBox1.Text, con);
            reader = command.ExecuteReader();
            if (reader.Read())
            {            
                con.Close();
                con.Open();
                command = new MySqlCommand("select ID_Klient from wyniki_badan where ID_Klient = " + textBox1.Text, con);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    con.Open();
                    command = new MySqlCommand("update wyniki_badan set grupa_krwi = '" + textBox2.Text + "' where ID_Klient = " + textBox1.Text, con);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    command = new MySqlCommand("update wyniki_badan set informacja_zwrotna = '" + textBox3.Text + "' where ID_Klient = " + textBox1.Text, con);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Zaaktualizowana wyniki badań!", "", MessageBoxButtons.OK);
                }
                else
                {
                    int id_badanie = 1;
                    int temp = 1;
                    con.Close();
                    con.Open();
                    command = new MySqlCommand("select ID_Badanie from wyniki_badan order by ID_Badanie", con);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader.GetInt32(0);
                        if (temp > id_badanie)
                        {
                            id_badanie = temp - 1;
                            break;
                        }
                        else
                        {
                            id_badanie = temp + 1;
                        }

                    }
                    con.Close();
                    con.Open();
                    command = new MySqlCommand("insert into wyniki_badan (ID_Badanie, grupa_krwi, informacja_zwrotna, ID_Klient) value (" + id_badanie + ", '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox1.Text + ")", con);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Dodano wyniki badań!", "", MessageBoxButtons.OK);
                }

            }
            else
            {
                con.Close();
                MessageBox.Show("Nie ma klienta o takim ID!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
