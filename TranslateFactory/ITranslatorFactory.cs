using System;

namespace FactoryTranslator
{
    public interface ITranslatorFactory
    {
        string Translate(string lingOri, string txt);
    }
}
