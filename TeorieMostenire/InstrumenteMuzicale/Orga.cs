using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.InstrumenteMuzicale
{
    public class Orga : InstrumenteMuzicale
    {
        public Orga(string clapete, string corzi, string pedale, string sistemSuflare, string tambur, string cinele) : base(clapete, corzi, pedale, sistemSuflare, tambur, cinele)
        {
            Clapete = clapete;
            SistemSuflare = sistemSuflare;
            Pedale = pedale;
        }

        public Orga(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            Clapete = token[6];
            SistemSuflare = token[7];
            Pedale = token[8];
        }

        public string OrgaInfo()
        {
            string text = " ";
            text += "Clapete " + Clapete + "\n";
            text += "Sistem de suflare " + SistemSuflare + "\n";
            text += "Pedale " + Pedale + "\n";
            return text;
        }

        public string SaveTo()
        {
            return Clapete + "," + SistemSuflare + "," + Pedale;
        }
    }
}
