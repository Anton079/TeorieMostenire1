using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Plante
    {
        private string _spini;
        private string _floare;
        private string _frunze;
        private string _fructe;

        public Plante(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _spini = token[0];
            _floare = token[1];
            _frunze = token[2];
            _fructe = token[3];
        }

        public Plante(string spini, string floare, string frunze, string fructe)
        {
            _spini = spini;
            _floare = floare;
            _frunze = frunze;
            _fructe = fructe;
        }

        public string Spini
        {
            get { return _spini; }
            set { _spini = value; }
        }

        public string Floare
        {
            get { return _floare; }
            set { _floare = value; }
        }

        public string Frunze
        {
            get { return _frunze; }
            set { _frunze = value; }
        }

        public string Fructe
        {
            get { return _fructe; }
            set { _fructe = value; }
        }

        public string PlanteInfo()
        {
            string text = "Spini: " + _spini + "\n";
            text += "Floare: " + _floare + "\n";
            text += "Frunze: " + _frunze + "\n";
            text += "Fructe: " + _fructe + "\n";
            return text;
        }

        public string ToSave()
        {
            return _spini + "," + _floare + "," + _frunze + "," + _fructe;
        }
    }


}
