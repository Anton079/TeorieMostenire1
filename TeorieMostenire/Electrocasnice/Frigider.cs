using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieMostenire.Animale;

namespace TeorieMostenire
{
    public class Frigider : Electrocasnice
    {
        private string _rafturi;
        private string _congelator;
        public Frigider(string rafturi, string congelator, string maner, string termostat, string racitor, string ecran, string perie, string sacDeColectare) : base(maner, termostat, racitor, ecran, perie, sacDeColectare)
        {
            _congelator = congelator;
            _rafturi = rafturi;
        }

        public Frigider(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _congelator = token[6];
            _rafturi = token[7];
        }

        public string Rafturi
        {
            get { return _rafturi; }
            set { _rafturi = value; }
        }

        public string Congelator
        {
            get { return _congelator; }
            set { _congelator = value; }
        }

        public string ElectroCasniceInfo()
        {
            string text = " ";
            text += "Rafturi " + _rafturi + "\n";
            text += "Congelator " + _congelator + "\n";
            return text;
        }
    }
}
