using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening.Enum
{
    public class Salaris
    {
        public string TypeContract { get; set; }
        public double BrutoBedrag { get; set; }
        public double BtwPercentage { get; set; }
        public Salaris(string typeContract = "maandcontract", double brutoBedrag = 2440.55, double btwPercentage = 21)
        {
            TypeContract = typeContract;
            BrutoBedrag = brutoBedrag;
            BtwPercentage = btwPercentage;
        }

        public double BerekenNetto()
        {
            double nettoBedrag = BrutoBedrag;
            nettoBedrag -= BrutoBedrag * (BtwPercentage / 100);
            return nettoBedrag;
        }

        public override string ToString()
        {
            return $"Bruttoloon: {Math.Round(BrutoBedrag, 2)}\n " +
                $"Nettoloon: {Math.Round(BerekenNetto(),2)}";

        }
    }
}
