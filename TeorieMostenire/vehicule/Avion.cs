using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.vehicule
{
    public class Avion : Vehicul
    {
        private string _aripi;
        private string _turboVentilator;
        private string _cutieNeagra;

        public Avion(string aripi, string turboVentilator, string cutieNeagra, string volan, string roti, string motor, string combustibil, string scaune, string usi) : base(volan, roti, motor, combustibil, scaune, usi)
        {
            _aripi = aripi;
            _turboVentilator = turboVentilator;
            _cutieNeagra = cutieNeagra;
        }

        public Avion(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _aripi = token[6];
            _turboVentilator= token[7];
            _cutieNeagra= token[8];
        }

        public string Aripi
        {
            get { return _aripi; }
            set { _aripi = value; }
        }

        public string TurboVentilator
        {
            get { return _turboVentilator; }
            set { _turboVentilator = value; }
        }

        public string CutieNeagra
        {
            get { return _cutieNeagra; }
            set { _cutieNeagra = value; }
        }

        public string AvionInfo()
        {
            string text = " ";
            text += "Aripi " + _aripi + "\n";
            text += "TurboVentilator " + _turboVentilator + "\n";
            text += "Cutie Neagra " + _cutieNeagra + "\n";
            text += "Volan " + Volan + "\n";
            text += "Roti " + Roti + "\n";
            text += "Motor " + Motor + "\n";
            text += "Combustibil " + Combustibil + "\n";
            text += "Scaune " + Scaune + "\n";
            text += "Usi " + Usi + "\n";
            return text;
        }

        public string ToSave()
        {
            return Aripi + "," + _turboVentilator + "," + _cutieNeagra + "," + Volan + "," + Roti + "," + Motor + "," + Combustibil + "," + Scaune + "," + Usi;
        }
    }
}
