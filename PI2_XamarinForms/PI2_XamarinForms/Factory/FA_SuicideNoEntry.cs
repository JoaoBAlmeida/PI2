using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_SuicideNoEntry : FactoryEntry
    {
        protected override string GetHolder()
        {
            return "Escreva a quantida de suicidios a ser pesquisado";
        }
    }
}
