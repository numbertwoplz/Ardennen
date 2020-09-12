using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persoon
    {
        public int TeBetalen { get; set; }
        public string Naam { get; set; }
        public int Betaald { get; set; }
        public Persoon(string naam,int tebetalen,int betaald)
        {
            Naam = naam;
            TeBetalen = tebetalen;
            Betaald = betaald;
        }

        public void Betaal(int bedrag)
        {
            Betaald = Betaald + bedrag;
        }
        
        public override string ToString()
        {
            return "Mijn naam is " + this.Naam ;
        }
    }
}
