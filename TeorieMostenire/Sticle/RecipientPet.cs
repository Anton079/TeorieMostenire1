using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TeorieMostenire.Sticle;

namespace TeorieMostenire
{
    public class RecipientPet : Recipiente
    {
        private string _ambalajPlastic;

        public RecipientPet(string ambalajPlastic, string recipientMetal, string recipientPlastic, string recipientSticla, string dopPlastic, string dopMetalic) : base ( recipientMetal,  recipientPlastic,  recipientSticla,  dopPlastic,  dopMetalic)
        {
            base.RecipientPlastic = recipientPlastic;
            base.DopPlastic = dopPlastic;
            _ambalajPlastic = ambalajPlastic;
        }

        public RecipientPet(string proprietati) : base(proprietati)
        {
            string [] token = proprietati.Split(' ');

            _ambalajPlastic = token[5];
        }

        public string AmbalajPlastic
        {
            get { return _ambalajPlastic;}
            set { _ambalajPlastic = value;}
        }

        public string RecipientPetInfo()
        {
            string text = " ";
            text += "Ambalaj Plastic " + _ambalajPlastic + "\n";
            text += "Dop Plastic " + base.DopPlastic + "\n";
            text += "Recipient Plastic " + base.RecipientPlastic + "\n";
            return text;
        }

        public string SaveTo()
        {
            return this._ambalajPlastic + "," + base.DopPlastic + "," + base.RecipientPlastic;
        }
    }
}
