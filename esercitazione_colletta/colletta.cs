using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_colletta
{
    public class colletta
    {
        Dictionary<string, double> persone = new Dictionary<string, double>();
        public void aggiunta(double cifra, string nome)
        {
            persone[nome] += cifra;
        }
        public void rimozione(double cifra, string nome)
        {
            persone[nome] -= cifra;
        }
        public void modifica(double cifra, string nome)
        {
            persone[nome] = cifra;
        }
        public void visualizza()
        {
            Dictionary<string, double>.KeyCollection keyColl = persone.Keys;

            string a = "";
            foreach (string s in keyColl)
            {
                a += s.ToString();
            }
        }
    }
}
