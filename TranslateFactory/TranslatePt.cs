using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryTranslator
{
    public class TranslatePt : ITranslatorFactory
    {
        string lingTo;
        public TranslatePt()
        {
            lingTo = "pt";
        }
        public string Translate(string lingOri, string txt)
        {
            return "Tradução em -> " + lingTo + "-" + lingOri + " - " + txt;
        }

       
    }
}
