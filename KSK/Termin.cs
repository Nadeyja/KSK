using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSK
{
    class Termin
    {
        DateTime date;
        string status;
        public Termin(DateTime date, string status)
        {
            this.date = date;
            this.status = status;
        }
        public override string ToString()
        {
            string termin = date.ToString() + " " + status;
            return termin;
        }
    }
}
