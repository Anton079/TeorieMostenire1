using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Placinta : Mancare
    {
        private string _branza;
        private string _oua;
        private string _zahar;

        public Placinta(string branza, string oua, string zahar , string carne, string cartofi, string condimente) : base (carne, cartofi, branza, oua, condimente)
        {
            _branza = branza;
            _oua = oua;
            _zahar = zahar;
        }

        public string Branza
        {
            get { return _branza; }
            set { _branza = value; }
        }

        public string Oua
        {
            get { return _oua; }
            set { _oua = value; }
        }

        public string Zahar
        {
            get { return _zahar; }
            set { _zahar = value; }
        }

        public string PlacintaInfo()
        {
            string text = " ";
            text += "Branza " + _branza + "\n";
            text += "Oua " + _oua + "\n";
            text += "zahar " + _zahar + "\n";
            text += "carne" + Carne + "\n";
            text += "cartofi " + Cartofi + "\n";
            text += "condimente " + Condimente + "\n";
            return text;
        }

        public string ToSave()
        {
            return _branza + "," + _zahar + "," + _oua;
        }
    }
}
