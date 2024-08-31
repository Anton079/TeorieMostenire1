using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.vehicule
{
    public class Barca : Vehicul
    {
        private string _ancora;
        private string _catarg;
        private string _punte;

        public Barca(string ancora, string catarg, string punte, string volan, string roti, string motor, string combustibil, string scaune, string usi) : base(volan, roti, motor, combustibil, scaune, usi)
        {
            _ancora = ancora;
            _catarg = catarg;
            _punte = punte;
        }

        public Barca(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _ancora = token[6];
            _catarg = token[7];
            _punte = token[8];
        }

        public string Ancora
        {
            get { return _ancora; }
            set { _ancora = value; }
        }

        public string Catarg
        {
            get { return _catarg; }
            set { _catarg = value; }
        }

        public string Punte
        {
            get { return _punte; }
            set { _punte = value; }
        }

        public string BarcaInfo()
        {
            string text = "Barca " + "\n";
            text += "Ancora " + _ancora + "\n";
            text += "Catarg " + _catarg + "\n";
            text += "Punte " + _punte + "\n";
            text += "Volan " + Volan + "\n";
            text += "Roti " + Motor + "\n";
            text += "Combustibil " + Combustibil + "\n";
            text += "Scaune " + Scaune + "\n";
            text += "Usi " + Usi + "\n";
            return text;
        }

        public string ToSave()
        {
            return _ancora + "," + _catarg + "," + _punte + "," + Volan + "," + Roti + "," + Combustibil + "," + Scaune + "," + Usi;
        }
    }
}
