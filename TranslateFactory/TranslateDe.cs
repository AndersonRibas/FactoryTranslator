using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryTranslator
{

    public class TranslateDe : ITranslatorFactory
    {
        private string lingTo;

        public TranslateDe()
        {
            lingTo = "de";
        }

        public string Translate(string lingOri, string txt)
        {
            return "Tradução em -> " + lingTo + "-" + lingOri + " - " + txt;
        }
    }
}
