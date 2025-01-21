using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public class Zapas
    {
        public string?   Domaci { get; set; }
        public string?   Hoste { get; set; }
        public decimal?  KurzDomaci { get; set; }
        public decimal?  KurzRemiza { get; set; }
        public decimal?  KurzHoste { get; set; }
        public string?   Vysledek { get; set; }

        public Zapas() { }

        public Zapas (string domaci, string hoste, decimal kurzDomaci, decimal kurzRemiza, decimal kurzHoste, string vysledek)
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
