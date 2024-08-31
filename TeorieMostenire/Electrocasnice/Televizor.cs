using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieMostenire.Animale;

namespace TeorieMostenire
{
    public class Televizor : Electrocasnice
    {
        private string _diagonala;
        private string _rezolutie;
        private string _tipEcran;

        public Televizor(string maner, string termostat, string racitor, string ecran, string perie, string sacDeColectare, string diagonala, string rezolutie, string tipEcran) : base (maner, termostat, racitor, ecran, perie, sacDeColectare)
        {
            _diagonala = diagonala;
            _rezolutie = rezolutie;
            _tipEcran = tipEcran;
        }

        public Televizor(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _diagonala = token[6];
            _rezolutie = token[7];
            _tipEcran = token[8];
        }

        public string Diagonala
        {
            get { return _diagonala; }
            set { _diagonala = value; }
        }

        public string Rezolutie
        {
            get { return _rezolutie; }
            set { _rezolutie = value; }
        }

        public string TipEcran
        {
            get { return _tipEcran; }
            set { _tipEcran = value; }
        }

        public string TelevizorInfo()
        {
            string text = " ";
            text += "Diagonala " + _diagonala + "\n";
            text += "Rezolutie " + _rezolutie + "\n";
            text += "Tip Ecran " + _tipEcran + "\n";
            return text;
        }

        public string ToSave()
        {
            return _diagonala + "," + _rezolutie + "," + _tipEcran + "," + base.Maner + "," + base.Termostat + "," + base.Racitor + "," + base.Ecran + "," + base.Perie + "," + base.SacDeColectare;
        }
    }
}
