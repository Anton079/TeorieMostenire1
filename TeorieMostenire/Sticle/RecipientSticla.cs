using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeorieMostenire.Sticle;

namespace TeorieMostenire
{
    public class RecipientSticla : Recipiente
    {
        private string _recipientSticla;
        private string _ambalajHartie;

        public RecipientSticla(string recipientSticla, string dopMetalic, string ambalajHartie, string recipientMetal, string recipientPlastic, string dopPlastic) : base( recipientMetal,  recipientPlastic,  recipientSticla,  dopPlastic,  dopMetalic)
        {
            _recipientSticla = recipientSticla;
            _ambalajHartie = ambalajHartie;
         
        }

        public RecipientSticla(string proprietati):base(proprietati)
        {
            string[] token = proprietati.Split(' ');

            _recipientSticla = token[5];
            _ambalajHartie = token[6];         
        }

        public string RecipientSticlaInfo()
        {
            string text = " ";
            text += "Recipient Sticla " + _recipientSticla + "\n";
            text += "AmbalajeHartie " + _ambalajHartie + "\n";
            text += "Dop Metalic " + base.DopMetalic + "\n";
            return text;
        }

        public string SaveTo()
        {
            return _recipientSticla + "," + _ambalajHartie + "," + base.DopMetalic;
        }
    }
}
