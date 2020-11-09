using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_ComparisonPicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            return new List<dynamic>
            { 
                "=",
                ">=",
                "<=",
                ">",
                "<"
            };
        }

        protected override string GetTitle()
        {
            return "What's the desired Comparison?";
        }
    }
}
