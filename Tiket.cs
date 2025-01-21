using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public class Tiket
    {
        public List<Prilezitost> Prilezitosti { get; private set; } = new List<Prilezitost>();
        public decimal CelkovyKurz { get; private set; } = 1m;
        public decimal Castka { get; set; }
        public decimal MoznaVyhra => Castka * CelkovyKurz;

        public void PridejPrilezitost(Prilezitost prilezitost)
        {
            Prilezitosti.Add(prilezitost);
            CelkovyKurz *= prilezitost.VybranyKurz;
        }

        public void OdeberPrilezitost(Prilezitost prilezitost)
        {
            Prilezitosti.Remove(prilezitost);
            CelkovyKurz /= prilezitost.VybranyKurz;
        }

        //overeni zda ma uzivatel vsechny prilezitosti vyherni
        public bool JeVyherni()
        {
            return Prilezitosti.All(p => p.JeSpravna());
        }
    }
}
