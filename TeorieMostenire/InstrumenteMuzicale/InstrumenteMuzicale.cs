using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.InstrumenteMuzicale
{
    public class InstrumenteMuzicale
    {
        private string _clapete;
        private string _corzi;
        private string _pedale;
        private string _sistemSuflare;
        private string _tambur;
        private string _cinele;

        public InstrumenteMuzicale(string clapete, string corzi, string pedale, string sistemSuflare, string tambur, string cinele)
        {
            _clapete = clapete;
            _corzi = corzi;
            _pedale = pedale;
            _sistemSuflare = sistemSuflare;
            _tambur = tambur;
            _cinele = cinele;
        }

        public InstrumenteMuzicale(string proprietati)
        {
            string[] token = proprietati.Split(' ');

            _clapete = token[0];
            _corzi = token[1];
            _pedale = token[2];
            _sistemSuflare = token[3];
            _tambur = token[4];
            _cinele= token[5];
        }

        public string Clapete
        {
            get { return _clapete; }
            set { _clapete = value; }
        }

        public string Corzi
        {
            get { return _corzi; }
            set { _corzi = value; }
        }

        public string Pedale
        {
            get { return _pedale; }
            set { _pedale = value; }
        }

        public string SistemSuflare
        {
            get { return _sistemSuflare; }
            set { _sistemSuflare = value; }
        }

        public string Tambur
        {
            get { return _tambur; }
            set { _tambur = value; }
        }

        public string Cinele
        {
            get { return _cinele; }
            set { _cinele = value; }
        }


        //                                         FUNCTIONEAZA LA FEL CA GET SI SET URILE DE SUS ?
        //public string Clapete { get; set; }
        //public string Corzi { get; set; }
        //public string Pedale { get; set; }
        //public string SistemSuflare { get; set; }
        //public string Tambur { get; set; }
        //public string Cinele { get; set; }

        public string InstrumesteMuzicaleInfo()
        {
            string text = " ";
            text += "Clapete " + _clapete + "\n";
            text += "Corzi " + _corzi + "\n";
            text += "pedale " + _pedale + "\n";
            text += "Sistemul de Suflare " + _sistemSuflare + "\n";
            text += "Tambur " + _tambur + "\n";
            text += "Cinele " + _cinele + "\n";
            return text;
        }

        public string SaveTo()
        {
            return _clapete + "," + _corzi + "," + _pedale + "," + _sistemSuflare + "," + _tambur + "," + _cinele;
        }




    }
}
