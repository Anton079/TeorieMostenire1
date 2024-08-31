using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Fructe
{
    public class Mar : Fructe
    {
        public Mar(string culoareVerde, string culoareGalbena, string culoarePortocalie, string vitaminaC, string vitaminaB, string vitaminaA) : base(culoareVerde, culoareGalbena, culoarePortocalie, vitaminaC, vitaminaB, vitaminaA)
        {
            base.VitaminaC = vitaminaC;
            base.CuloareVerde = culoareVerde;
        }

        public Mar(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            VitaminaC = token[6];
            CuloareVerde = token[7];
        }

        public string VitaminaC
        {
            get { return VitaminaC; }
            set { VitaminaC = value; }
        }

        public string CuloareVerde
        {
            get { return CuloareVerde; }
            set { CuloareVerde = value; }
        }

        public string MarInfo()
        {
            string text = " ";
            text += "Vitamina C" + VitaminaC + "\n";
            text += "CuloareVerde " + CuloareVerde + "\n";
            return text;
        }
    }

}
