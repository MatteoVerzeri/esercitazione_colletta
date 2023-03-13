﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_colletta
{
    public class Importo
    {
        public Importo(double valore, string valuta)
        {
            Valore = valore;
            Valuta = valuta;
        }

        public double Valore { get; set; }
        public string Valuta { get; set; }

        public override string ToString()
        {
            return Valore + " " + Valuta;
        }
    }
}
