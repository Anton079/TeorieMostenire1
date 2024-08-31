using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    internal class Orhidee : Plante
    {
        private string _apa;

        public Orhidee(string frunze, string floare, string apa, string spini, string fructe) : base( spini,  floare,  frunze,  fructe)
        {
            base.Frunze = frunze;
            base.Floare = floare;
            _apa = apa;
        }

        public string Apa
        {
            get { return _apa; }
            set { _apa = value; }
        }

        public string OrhideeInfo()
        {
            string text = " ";
            text += "Frunze " + base.Frunze + "\n";
            text += "Floare " + base.Floare + "\n";
            text += "Apa " + _apa + "\n";
            return text;
        }

        public string SaveTo()
        {
            return base.Frunze + "," + base.Floare + "," + this._apa;
        }
    }
}
