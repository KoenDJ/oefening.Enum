using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening.Enum
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public Salaris Lonen { get; set; }
        public string LandVanHerkomst { get; set; }

        public Werknemer(string naam, Salaris salaris , string landVanHerkomst = "België")
        {
            Naam = naam;
            Lonen = salaris;
            LandVanHerkomst = landVanHerkomst;
        }

        public override string ToString()
        {
            return Naam;
        }

        public void GetNetto()
        {

        }
    }
}
