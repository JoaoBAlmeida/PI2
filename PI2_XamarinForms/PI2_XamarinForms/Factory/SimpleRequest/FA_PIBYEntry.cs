using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_PIBYEntry : FactoryEntry
    {
        protected override string GetHolder()
        {
            return "Escreva a quantidade do Pib por ano a ser pesquisado";
        }
    }
}
