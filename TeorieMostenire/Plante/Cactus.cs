using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Cactus : Plante
    {
        private string _uscat;

        public Cactus(string uscat, string spini, string floare, string frunze, string fructe) : base( spini,  floare,  frunze,  fructe)
        {
            _uscat = uscat;
            base.Spini = spini;
            base.Floare = floare;
            base.Fructe = fructe;
        }

        public string Uscat
        {
            get { return _uscat; }
            set { _uscat = value; }
        }

        public string CactusInfo()
        {
            string text = " ";
            text += "Uscat: " + _uscat + "\n";
            text += "Floare " + base.Floare + "\n";
            text += "Spini " + base.Spini + "\n";
            text += "Fructe " + base.Fructe + "\n"; 
            return text;
        }

        public string ToSave()
        {
            return Spini + "," + Floare + ",," + _uscat;
        }
    }
}
