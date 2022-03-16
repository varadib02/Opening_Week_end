using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningWeekend
{
    class O_weekend
    {
        public string eredetiCim { get; set; }
        public string magyarCim { get; set; }
        public DateTime bemutato { get; set; }
        public string forgalmazo { get; set; }
        public int bevel { get; set; }
        public int latogato { get; set; }

        public O_weekend(string sor)
        {
            string[] s = sor.Split(';');

            eredetiCim = s[0];
            magyarCim = s[1];
            bemutato = DateTime.Parse(s[2]);
            forgalmazo = s[3];
            bevel = Convert.ToInt32(s[4]);
            latogato = Convert.ToInt32(s[5]);
        }
    }
}
