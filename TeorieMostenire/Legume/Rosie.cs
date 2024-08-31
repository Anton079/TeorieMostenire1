using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Legume
{
    public class Rosie : Legume
    {
        public Rosie(string apaMulta, string vitaminaC, string vitaminaK, string vitaminaB6, string culoareRosie, string culoareVerde, string culoareGalben) : base(apaMulta, vitaminaC, vitaminaK, vitaminaB6, culoareRosie, culoareVerde, culoareGalben)
        {
            base.VitaminaC = vitaminaC;
            base.VitaminaK = vitaminaK;
            base.ApaMulta = apaMulta;
            base.CuloareRosie = culoareRosie;
        }



        public string ApaMulta
        {
            get { return ApaMulta; }
            set { ApaMulta = value; }
        }

        public string VitaminaK
        {
            get { return VitaminaK; }
            set { VitaminaK = value; }
        }

        public string VitaminaC
        {
            get { return VitaminaC; }
            set { VitaminaC = value; }
        }

        public string CuloareRosie
        {
            get { return base.CuloareRosie; }
            set { base.CuloareRosie = value; }
        }

        public string RosieInfo()
        {
            string text = " ";
            text += $"Apa multa: {ApaMulta}\n";
            text += $"Vitamina C: {VitaminaC}\n";
            text += $"Vitamina K: {VitaminaK}\n";
            text += $"Culoarea Rosie: {CuloareRosie}\n";
            return text;
        }
    }
}
