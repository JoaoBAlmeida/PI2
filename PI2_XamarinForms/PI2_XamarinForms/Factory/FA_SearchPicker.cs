using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_SearchPicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            return new List<dynamic>
            {
                "Year",
                "Country",
                "Sex",
                "Age",
                "Suicides_no",
                "Population",
                "PIB_Year",
                "PIB_Capita",
                "Generation"
            };
        }

        protected override string GetTitle()
        {
            return "Choose atribute to search from";
        }
    }
}
