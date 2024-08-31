using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Fructe
{
    public class Banana : Fructe
    {
        public Banana(string culoareVerde, string culoareGalbena, string culoarePortocalie, string vitaminaC, string vitaminaB, string vitaminaA) : base(culoareVerde, culoareGalbena, culoarePortocalie, vitaminaC, vitaminaB, vitaminaA)
        {
            base.CuloareGalbena = culoareGalbena;
            base.VitaminaC = vitaminaC;
        }

        public Banana(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(" ");

            CuloareVerde = token[6];
            VitaminaC= token[7];
        }

        public string CuloareGalbena
        {
            get { return CuloareGalbena; }
            set { CuloareGalbena = value; }
        }

        public string VitaminaC
        {
            get { return VitaminaC; }
            set { VitaminaC = value; }
        }

        public string FructeInfo()
        {
            string text = " ";
            text += "Culoare Galbena: " + CuloareGalbena + "\n";
            text += "Vitamina C: " + VitaminaC + "\n";
            return text;
        }
    }
}
