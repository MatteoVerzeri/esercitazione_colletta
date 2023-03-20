using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_colletta
{
    public class Colletta : IEquatable<Colletta>
    {

        public Colletta(string id, string cognome, string nome)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
        }

        public string Id { get; set; }

        public string Cognome { get; set; }

        public string Nome { get; set; }

        public bool Equals(Colletta p)
        {
            if (p == null)
                return false;
            if (p == this)
                return true;
            return Id.Equals(p.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(Object o)
        {
            if (!(o is Colletta))
                return false;

            return Equals((Colletta)o);
        }

        public override string ToString()
        {
            return Id + " " + Cognome + " " + Nome;
        }
        /*public void aggiungi(Colletta p, Importo i)
        {

        }*/
    }
}
