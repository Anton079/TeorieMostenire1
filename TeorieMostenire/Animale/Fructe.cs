using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Animale
{
    public class Fructe
    {
        private string _culoareVerde;
        private string _culoareGalbena;
        private string _culoarePortocalie;
        private string _vitaminaC;
        private string _vitaminaB;
        private string _vitaminaA;

        public Fructe(string culoareVerde, string culoareGalbena, string culoarePortocalie, string vitaminaC, string vitaminaB, string vitaminaA)
        {
            _culoareVerde = culoareVerde;
            _culoareGalbena = culoareGalbena;
            _culoarePortocalie = culoarePortocalie;
            _vitaminaC = vitaminaC;
            _vitaminaB = vitaminaB;
            _vitaminaA = vitaminaA;
        }

        public string CuloareVerde
        {
            get { return _culoareVerde; }
            set { _culoareVerde = value; }
        }

        public string CuloareGalbena
        {
            get { return _culoareGalbena; }
            set { _culoareGalbena = value; }
        }

        public string CuloarePortocalie
        {
            get { return _culoarePortocalie; }
            set { _culoarePortocalie = value; }
        }

        public string VitaminaC
        {
            get { return _vitaminaC; }
            set { _vitaminaC = value; }
        }

        public string VitaminaB
        {
            get { return _vitaminaB; }
            set { _vitaminaB = value; }
        }

        public string VitaminaA
        {
            get { return _vitaminaA; }
            set { _vitaminaA = value; }
        }

        public string FructeInfo()
        {
            string text = " ";
            text += "Culoare Verde " + _culoareVerde + "\n";
            text += "Culoare galbena" + _culoareGalbena + "\n";
            text += "Culoare Portocalie " + _culoarePortocalie + "\n";
            text += "Vitamina C" + _vitaminaC + "\n";
            text += "Vitamina B" + _vitaminaB + "\n";
            text += "Vitamina A" + _vitaminaA + "\n";
            return text;
        }
    }   
}
