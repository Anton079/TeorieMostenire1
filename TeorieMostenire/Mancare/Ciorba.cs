using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Ciorba : Mancare
    {
        private string _carne;
        private string _cartofi;
        private string _bors;

        public Ciorba(string carne, string cartofi, string bors, string branza, string oua, string condimente) : base(carne, cartofi, branza, oua, condimente)
        {
            _bors = bors;
            _cartofi = cartofi;
            _carne = carne;
        }

        public string Bors
        {
            get { return _bors; }
            set { _bors = value; }
        }

        public string Cartofi
        {
            get { return _cartofi; }
            set { _cartofi = value ; }
        }

        public string Carne
        {
            get { return _carne; }
            set { _carne = value ; }
        }

        public string CiorbaInfo()
        {
            string text = " ";
            text += "Carne " + _carne + "\n";
            text += "Cartofi " + _cartofi + "\n";
            text += "Bors " + _bors + "\n";
            text += "branza " + Branza + "\n";
            text += "Oua " + Oua + "\n";
            text += "Condimente " + Condimente + "\n";
            return text;
        }

        public string ToSave()
        {
            return Carne + "," + Cartofi + "," + _bors;
        }
    }
}
