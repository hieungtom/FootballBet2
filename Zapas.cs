using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public class Zapas
    {
        public string   Domaci { get; set; }
        public string   Hoste { get; set; }
        public double   KurzDomaci { get; set; }
        public double   KurzRemiza { get; set; }
        public double   KurzHoste { get; set; }
        public string   Vysledek { get; set; }

        public Zapas (string domaci, string hoste, double kurzDomaci, double kurzRemiza, double kurzHoste, string vysledek)
        {
            Domaci = domaci;
            Hoste = hoste;
            KurzDomaci = kurzDomaci;
            KurzRemiza = kurzRemiza;
            KurzHoste = kurzHoste;
            Vysledek = vysledek;
        }

    }
}
