using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    internal class Trandafiri : Plante
    {

        public Trandafiri(string spini, string frunze, string floare, string fructe) : base(spini ,floare ,frunze, fructe)
        {
            base.Frunze = frunze;
            base.Spini = spini;
            base.Floare = floare;
        }

        public string TrandafirInfo()
        {
            string text = " ";
            text += "Frunze " + base.Frunze + "\n";
            text += "Spini " + base.Spini + "\n";
            text += "Floare " + base.Floare + "\n";
            return text;
        }

        private string SaveTo()
        {
            return base.Fructe + "," + base.Floare + "," + base.Spini;
        }

    }
}
