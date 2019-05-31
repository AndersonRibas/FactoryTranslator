using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTranslator
{
    public class TranslateEn : ITranslatorFactory
    {
        private string lingTo;
        

        public TranslateEn()
        {
            lingTo = "en";
        }

        public string Translate(string lingOri, string txt)
        {
            return "Tradução em -> " + lingTo + "-" + lingOri + " - " + txt;
        }
    }
}
