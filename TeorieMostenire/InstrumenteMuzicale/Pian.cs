using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.InstrumenteMuzicale
{
    public class Pian : InstrumenteMuzicale
    {
        public Pian(string clapete, string corzi, string pedale, string sistemSuflare, string tambur, string cinele) : base(clapete, corzi, pedale, sistemSuflare, tambur, cinele)
        {
            Clapete = clapete;
            Corzi = corzi;
            Pedale = pedale;
        }

        public Pian(string atribute) :base(atribute)
        {
            string[] token = atribute.Split(' ');

            Clapete = token[6];
            Corzi = token[7];
            Pedale = token[8];
        }

        public string PianInfo()
        {
            string text = " ";
            text += "Clapete " + Clapete + "\n";
            text += "Corzi " + Corzi + "\n";
            text += "Pedale " + Pedale + "\n";
            return text;
        }

        public string SaveTo()
        {
            return Clapete + "," + Corzi + "," + Pedale;
        }
    }
}
