using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Aspirator : Electrocasnice
    {
        private string _putere;
        private string _capacitate;

        public Aspirator(string maner, string termostat, string racitor, string ecran, string perie, string sacDeColectare, string putere, string capacitate) : base( maner,  termostat,  racitor,  ecran,  perie,  sacDeColectare)
        {
            _putere = putere;
            _capacitate = capacitate;
        }

        public Aspirator(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _putere = token[6];
            _capacitate = token[7];
        }

        public string Putere
        {
            get { return _putere; }
            set { _putere = value; }
        }

        public string Capacitate
        {
            get { return _capacitate; }
            set { _capacitate = value; }
        }

        public string AspiratorInfo()
        {
            string text = " ";
            text += "Putere " + _putere + "\n";
            text += "Capacitate " + _capacitate + "\n";
            return text;
        }

        public string ToSave()
        {
            return _putere + "," + _capacitate + "," + base.Maner + "," + base.Termostat + "," + base.Racitor + "," + base.Ecran + "," + base.Perie + "," + base.SacDeColectare;
        }
    }
}
