using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_SuicideGenPicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            return new List<dynamic>
            {
                "Generation X",
                "Generation Z",
                "G.I. Generation",
                "Silent",
                "Boomers",
                "Millenials"
            };
        }

        protected override string GetTitle()
        {
            return "Choose your generation";
        }
    }
}
