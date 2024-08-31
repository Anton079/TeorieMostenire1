using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieMostenire.Sticle;

namespace TeorieMostenire
{
    public class RecipientDoza : Recipiente
    {
        private string _recipientMetalic;
        private string _faraCapac;

        public RecipientDoza(string recipienteMetalic, string faraCapac, string recipientMetal, string recipientPlastic, string recipientSticla, string dopPlastic, string dopMetalic) : base ( recipientMetal,  recipientPlastic,  recipientSticla,  dopPlastic,  dopMetalic)
        {
            _recipientMetalic = recipienteMetalic;
            _faraCapac = faraCapac;
        }

        public RecipientDoza(string astribute) : base (astribute)
        {
            string[] token = astribute.Split(' ');

            _recipientMetalic = token[5];
            _faraCapac = token[6];
        }

        public string RecipientMetalic
        {
            get { return _recipientMetalic; }
            set { _recipientMetalic = value; }
        }

        public string FaraCapac
        {
            get { return _faraCapac;}
            set { _faraCapac = value;}
        }

        public string RecipienteDoza()
        {
            string text = " ";
            text += "RecipientMetalic " + _recipientMetalic + "\n";
            text += "Fara Copac " + _faraCapac + "\n";
            return text;
        }

        public string SaveTo()
        {
            return _faraCapac + "," + _recipientMetalic;
        }
         
    }
}
