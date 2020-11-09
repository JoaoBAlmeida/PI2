using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_SexPicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            return new List<dynamic>
            {
                "male",
                "female"
            };
        }

        protected override string GetTitle()
        {
            return "Choose your sex";
        }
    }
}
