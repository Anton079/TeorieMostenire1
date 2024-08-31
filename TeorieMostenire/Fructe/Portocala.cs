using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Fructe
{
    public class Portocala : Fructe
    {
        public Portocala(string culoareVerde, string culoareGalbena, string culoarePortocalie, string vitaminaC, string vitaminaB, string vitaminaA) : base(culoareVerde, culoareGalbena, culoarePortocalie, vitaminaC, vitaminaB, vitaminaA)
        {
            base.VitaminaC = vitaminaC;
            base.VitaminaA = vitaminaA;
            base.CuloarePortocalie = culoarePortocalie;
        }

        public Portocala(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            VitaminaC = token[6];
            CuloarePortocalie = token[7];
            VitaminaA = token[8];
        }

        public string VitaminaC
        {
            get { return VitaminaC; }
            set { VitaminaC = value; }
        }

        public string VitaminaA
        {
            get { return VitaminaA; }
            set { VitaminaA = value; }
        }

        public string CuloarePortocalie
        {
            get { return CuloarePortocalie; }
            set { CuloarePortocalie = value; }
        }

        public string PortocalaInfo()
        {
            string text = " ";
            text += "Vitamina C " + VitaminaC + "\n";
            text += "Vitamina A " + VitaminaA + "\n";
            text += "CuloarePortocalie " + CuloarePortocalie + "\n";
            return text;
        }
    }
}
