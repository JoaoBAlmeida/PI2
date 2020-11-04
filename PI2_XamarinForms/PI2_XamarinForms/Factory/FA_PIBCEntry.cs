using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_PIBCEntry : FactoryEntry
    {
        protected override string GetHolder()
        {
            return "Escreva a quantidade do PIB per capita a ser pesquisada";
        }
    }
}
