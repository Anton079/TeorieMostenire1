using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Legume
{
    public class Ardei : Legume
    {
        public Ardei(string apaMulta, string vitaminaC, string vitaminaK, string vitaminaB6, string culoareRosie, string culoareVerde, string culoareGalben) : base(apaMulta, vitaminaC, vitaminaK, vitaminaB6, culoareRosie, culoareVerde, culoareGalben)
        {
            base.VitaminaC = vitaminaC;
            base.VitaminaB6 = vitaminaB6;
            base.CuloareGalben = culoareGalben;
        }

        public string VitaminaC
        {
            get { return VitaminaC; }
            set { VitaminaC = value; }
        }

        public string VitaminaB6
        {
            get { return VitaminaB6; }
            set { VitaminaB6 = value; }
        }

        public string CuloareGalben
        {
            get { return CuloareGalben; }
            set { CuloareGalben = value; }
        }

        public string RosieInfo()
        {
            string text = $"Vitamina C: {VitaminaC}\n";
            text += $"Vitamina B6: {VitaminaB6}\n";
            text += $"Culoarea Galben: {CuloareGalben}\n";
            return text;
        }
    }
}
