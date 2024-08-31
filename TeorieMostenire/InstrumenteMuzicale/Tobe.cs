using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.InstrumenteMuzicale
{
    public class Tobe : InstrumenteMuzicale
    {
        public Tobe(string clapete, string corzi, string pedale, string sistemSuflare, string tambur, string cinele) : base(clapete, corzi, pedale, sistemSuflare, tambur, cinele)
        {
            Tambur = tambur;
            Cinele = cinele;
        }

        public Tobe(string atribute) : base(atribute)
        {
            string[ ]token = atribute.Split(' ');

            Tambur = token[6];
            Cinele = token[7];
        }

        public string TobeInfo()
        {
            string text = " ";
            text += "Tambur " + Tambur + "\n";
            text += "Cinele " + Cinele + "\n";
            return text;
        }

        public string SaveTo()
        {
            return Tambur + "," + Cinele;
        }
    }
}
