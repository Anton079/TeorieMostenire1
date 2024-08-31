using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Fasole : Mancare
    {
        private string _fasoleBoabe;
        private string _telina;
        private string _usturoi;

        public Fasole(string fasoleBoabe, string telina, string usturoi, string carne, string cartofi, string branza, string oua, string condimente) : base(carne, cartofi, branza, oua, condimente)
        {
            _fasoleBoabe = fasoleBoabe;
            _telina = telina;
            _usturoi = usturoi;
        }

        public string FasoleBoabe
        {
            get { return _fasoleBoabe; }
            set { _fasoleBoabe = value; }
        }

        public string Telina
        {
            get { return _telina; }
            set { _telina = value; }
        }

        public string Usturoi
        {
            get { return _usturoi; }
            set { _usturoi = value; }
        }

        public string FasoleInfo()
        {
            string text = " ";
            text += "Fasole Boabe: " + _fasoleBoabe + "\n";
            text += "Telina: " + _telina + "\n";
            text += "Usturoi: " + _usturoi + "\n";
            text += "Carne: " + Carne + "\n";
            text += "Cartofi: " + Cartofi + "\n";
            text += "Branza " + Branza + "\n";
            text += "Oua " + Oua + "\n";
            text += "Condimente: " + Condimente + "\n";
            return text;
        }

        public string ToSave()
        {
            return _fasoleBoabe + "," + _telina + "," + _usturoi;
        }

    }
}
