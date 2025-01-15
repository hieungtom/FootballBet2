using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public static class Databaze
    {
        public static BindingList<Zapas> Zapasy { get; private set; } = new BindingList<Zapas>();
        static Databaze()
        {
            var u1 = new Ucet("admin", "admin", 1000);

            Zapasy.Add(new Zapas("Real Madrid", "Stuttgart", 1.31, 5.98, 9.36, "domaci"));
            Zapasy.Add(new Zapas("Manchester City", "Inter", 1.38, 5.21, 8.67, "remiza"));
            Zapasy.Add(new Zapas("Real Madrid", "Stuttgart", 3.69, 3.80, 2.02, "hoste"));
        }
    }
}
