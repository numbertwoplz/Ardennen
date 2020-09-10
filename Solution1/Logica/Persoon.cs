using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persoon
    {
        String Naam;
        public Persoon(String naam)
        {
            Naam = naam;
        }

        public override string ToString()
        {
            return "Mijn naam is " + this.Naam ;
        }
    }
}
