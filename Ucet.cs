﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public class Ucet
    {
        public string?  Username { get; set; }
        public string?  Heslo { get; set; }
        public decimal? Zustatek { get; set; }

        public Ucet() { }

        public Ucet(string username, string heslo, decimal zustatek)
        {
            Username = username;
            Heslo = heslo;
            Zustatek = zustatek;
        }
    }
}
