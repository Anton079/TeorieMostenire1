using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorieMostenire.Sticle
{
    public class Recipiente
    {
        private string _recipientMetal;
        private string _recipientPlastic;
        private string _recipientSticla;
        private string _dopPlastic;
        private string _dopMetalic;

        public Recipiente(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _recipientMetal = token[0];
            _recipientPlastic = token[1];
            _recipientSticla = token[2];
            _dopPlastic = token[3];
            _dopMetalic = token[4];
        }

        public Recipiente(string recipientMetal, string recipientPlastic, string recipientSticla, string dopPlastic, string dopMetalic)
        {
            _recipientMetal = recipientMetal;
            _recipientPlastic = recipientPlastic;
            _recipientSticla = recipientSticla;
            _dopPlastic = dopPlastic;
            _dopMetalic = dopMetalic;
        }

        public string RecipientMetal
        {
            get { return _recipientMetal; }
            set { _recipientMetal = value; }
        }

        public string RecipientPlastic
        {
            get { return _recipientPlastic; }
            set { _recipientPlastic = value; }
        }

        public string RecipientSticla
        {
            get { return _recipientSticla; }
            set { _recipientSticla = value; }
        }

        public string DopPlastic
        {
            get { return _dopPlastic; }
            set { _dopPlastic = value; }
        }

        public string DopMetalic
        {
            get { return _dopMetalic; }
            set { _dopMetalic = value; }
        }

        public string RecipientInfo()
        {
            string text = " ";
            text += "Metal " + _recipientMetal + "\n";
            text += "Plastic " + _recipientPlastic + "\n";
            text += "Sticla " + _recipientSticla + "\n";
            text += "DopPlastic " + _dopMetalic + "\n";
            text += "DopMetalic " + _dopMetalic + "\n";
            return text;
        }

        public string SaveTo()
        {
            return _recipientMetal + "," + _recipientPlastic + "," + _recipientSticla + _dopMetalic + "," + _dopPlastic;
        }
    }
}
