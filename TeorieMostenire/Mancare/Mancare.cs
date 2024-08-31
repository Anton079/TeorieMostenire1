using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Mancare
    {
        private string _carne;
        private string _cartofi;
        private string _branza;
        private string _oua;
        private string _condimente;

        public Mancare(string proprietati)
        {
            string [] token = proprietati.Split(',');

            _carne = token[0];
            _cartofi = token[1];
            _branza = token[2];
            _oua = token[3];
            _condimente = token[4];
        }

        public Mancare(string carne, string cartofi, string branza, string oua, string condimente)
        {
            _carne = carne;
            _cartofi=cartofi;
            _branza = branza;
            _oua = oua;
            _condimente = condimente;
        }

        public string Carne
        {
            get { return _carne; }
            set { _carne = value; }
        }

        public string Cartofi
        {
            get { return _cartofi; }
            set { _cartofi = value; }
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

        public string Condimente
        {
            get { return _condimente; }
            set { _condimente = value; }
        }

        public string MancareInfo()
        {
            string text = " ";
            text += "carne " + _carne + "\n";
            text += "Cartofi " + _cartofi + "\n";
            text += "Branza " + _branza + "\n";
            text += "Oua" + _oua + "\n";
            text += "Condimente " + _condimente + "\n";
            return text;
        }

        public string ToSave()
        {
            return _carne + "," + _cartofi + "," + _branza + "," + _oua + "," + "," + _condimente;
        }


    }
}
