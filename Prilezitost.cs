using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public class Prilezitost
    {
        public Zapas Zapas { get; set; }
        public string ZvolenaPrilezitost { get; set; }
        public decimal VybranyKurz { get; set; }

        //overeni zvolene prilezitosti od uzivatele s vysledkem
        public bool JeSpravna()
        {
            return Zapas.Vysledek == ZvolenaPrilezitost;
        }
    }
}
