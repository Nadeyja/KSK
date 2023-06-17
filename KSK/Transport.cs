using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSK
{
    internal class Transport
    {
        public DateTime date;
        public string trasa;
        public int id;
        public Transport(DateTime date, string trasa, int id)
        {
            this.date = date;
            this.trasa = trasa;
            this.id = id;
        }
        public override string ToString()
        {
            string transport = date.ToString() + " " + trasa + ", Id: " + id;
            return transport;
        }
    }
}
