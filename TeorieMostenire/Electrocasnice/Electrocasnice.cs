using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire
{
    public class Electrocasnice
    {
        private string _maner;
        private string _termostat;
        private string _racitor;
        private string _ecran;
        private string _perie;
        private string _sacDeColecare;

        public Electrocasnice(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _maner = token[0];
            _termostat = token[1];
            _racitor = token[2];
            _ecran = token[3];
            _perie = token[4];
            _sacDeColecare = token[5];
        }

        public Electrocasnice(string maner, string termostat, string racitor, string ecran, string perie, string sacDeColectare)
        {
            _maner = maner;
            _termostat = termostat;
            _racitor = racitor;
            _ecran = ecran;
            _perie = perie;
            _sacDeColecare = sacDeColectare;
        }

        public string Maner
        {
            get { return _maner; }
            set { _maner = value; }
        }

        public string Termostat
        {
            get { return _termostat; }
            set { _termostat = value; }
        }

        public string Racitor
        {
            get { return _racitor; }
            set { _racitor = value; }
        }

        public string Ecran
        {
            get { return _ecran; }
            set { _ecran = value; }
        }

        public string Perie
        {
            get { return _perie; }
            set { _perie = value; }
        }

        public string SacDeColectare
        {
            get { return _sacDeColecare; }
            set { _sacDeColecare = value; }
        }

        public string ElectroCasniceInfo()
        {
            string text = " ";
            text += "Maner " + _maner + "\n";
            text += "Termostat " + _termostat + "\n";
            text += "Racitor " + _racitor + "\n";
            text += "Ecran " + _ecran + "\n";
            text += "Perie " + _perie + "\n";
            text += "SacDeColectare " + _sacDeColecare + "\n";
            return text;
        }
    }
}
