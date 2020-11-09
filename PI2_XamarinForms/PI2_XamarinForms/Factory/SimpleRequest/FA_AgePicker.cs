using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_AgePicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            return new List<dynamic>
            {
                "75+ years",
                "55-74 years",
                "35-54 years",
                "25-34 years",
                "15-24 years",
                "5-14 years"
            };
        }

        protected override string GetTitle()
        {
            return "Choose your age range";
        }
    }
}
