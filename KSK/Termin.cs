using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSK
{
    class Termin
    {
        public DateTime date;
        public string status;
        public int id;
        public int id_klient;
        public Termin(DateTime date, string status, int id_termin)
        {
            this.date = date;
            this.status = status;
            this.id = id_termin;
        }
        public Termin(DateTime date, string status, int id_termin, int id_klient)
        {
            this.date = date;
            this.status = status;
            this.id = id_termin;
            this.id_klient = id_klient;
        }
        public override string ToString()
        {
            string termin = date.ToString() + " " + status + ", Id: " + id;
            return termin;
        }
        public static string toString(DateTime date, string status, int id, int id_klient)
        {
            MySqlConnection connection = Program.connectionMethodAsync();
            connection.Open();
            using var command = new MySqlCommand("select imie, nazwisko from klient where ID_Klient = " + id_klient, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string imie = reader.GetString(0);
            string nazwisko = reader.GetString(1);
            string termin = imie + " " + nazwisko + " " + date.ToString() + " " + status + ", Id: " + id;
            return termin;
        }
    }
}
