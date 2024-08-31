using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Legume
{
    public class Castravete : Legume
    {
        public Castravete(string apaMulta, string vitaminaC, string vitaminaK, string vitaminaB6, string culoareRosie, string culoareVerde, string culoareGalben) : base(apaMulta, vitaminaC, vitaminaK, vitaminaB6, culoareRosie, culoareVerde, culoareGalben)
        {
            base.VitaminaK = vitaminaK;
            base.ApaMulta = apaMulta;
            base.CuloareVerde = culoareVerde;
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

        public string CuloareVerde
        {
            get { return CuloareVerde; }
            set { CuloareVerde = value; }
        }

        public string CastraveteInfo()
        {
            string text = " ";
            text += $"Apa multa: {base.ApaMulta}\n";
            text += $"Vitamina K: {base.VitaminaK}\n";
            text += $"Culoarea Verde: {base.CuloareVerde}\n";
            return text;
        }

        public string SaveTo()
        {
            return base.ApaMulta + "," + base.VitaminaK + "," + base.CuloareVerde;
        }
    }
}
