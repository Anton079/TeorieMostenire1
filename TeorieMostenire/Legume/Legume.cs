using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Legume
{
    public class Legume
    {
        private string _apaMulta;
        private string _vitamitaC;
        private string _vitaminaK;
        private string _vitaminaB6;
        private string _culoarRosie;
        private string _culoareaVerde;
        private string _culoareaGalben;

        public Legume(string apaMulta, string vitaminaC, string vitaminaK, string vitaminaB6, string culoareRosie, string culoareVerde, string culoareGalben)
        {
            _apaMulta = apaMulta;
            _vitamitaC = vitaminaC;
            _vitaminaK = vitaminaK;
            _vitaminaB6 = vitaminaB6;
            _culoarRosie = culoareRosie;
            _culoareaVerde = culoareVerde;
            _culoareaGalben = culoareGalben;
        }

        public Legume(string proprietati)
        {
            string[] token = proprietati.Split(' ');

            _apaMulta = token[0];
            _vitamitaC = token[1];
            _vitaminaK = token[2];
            _vitaminaB6 = token[3];
            _culoarRosie = token[4];
            _culoareaVerde = token[5];
            _culoareaGalben = token[6];
        } 

        public string ApaMulta
        {
            get { return _apaMulta; }
            set { _apaMulta = value; }
        }

        public string VitaminaC
        {
            get { return _vitamitaC; }
            set { _vitamitaC = value; }
        }

        public string VitaminaK
        {
            get { return _vitaminaK; }
            set { _vitaminaK = value; }
        }

        public string VitaminaB6
        {
            get { return _vitaminaB6; }
            set { _vitaminaB6 = value; }
        }

        public string CuloareRosie
        {
            get { return _culoarRosie; }
            set { _culoarRosie = value; }
        }

        public string CuloareVerde
        {
            get { return _culoareaVerde; }
            set { _culoareaVerde = value; }
        }

        public string CuloareGalben
        {
            get { return _culoareaGalben; }
            set { _culoareaGalben = value; }
        }

        public string LegumeInfo()
        {
            string text = " ";
            text += "Apa multa " + _apaMulta + "\n";
            text += "Vitamina C: " + _vitamitaC + "\n";
            text += "Vitamina K: " + _vitaminaK + "\n";
            text += "Vitamina B6: " + _vitaminaB6 + "\n";
            text += "Culoarea Rosie: " + _culoarRosie + "\n";
            text += "Culoarea Verde: " + _culoareaVerde + "\n";
            text += "Culoarea Galben: " + _culoareaGalben + "\n";
            return text;
        }

        public string SaveTo()
        {
            return _apaMulta + "," + _vitamitaC + "," + VitaminaK + "," + _vitaminaB6 + "," + _culoarRosie + "," + _culoareaVerde + "," + _culoareaGalben;
        }
    }
}
