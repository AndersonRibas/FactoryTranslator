using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryTranslator
{
    public class TranslatorFactory
    {
        public ITranslatorFactory GenerateTranslator(string lingTo)
        {
            
            if(lingTo.ToLower().Equals("de"))
            {
                return new TranslateDe();
            }
            else if (lingTo.ToLower().Equals("en"))
            {
                return new TranslateEn();
            }
            else if (lingTo.ToLower().Equals("pt"))
            {
                return new TranslatePt();
            }
            else
            {
                return null;
            }

        }
    }
}
