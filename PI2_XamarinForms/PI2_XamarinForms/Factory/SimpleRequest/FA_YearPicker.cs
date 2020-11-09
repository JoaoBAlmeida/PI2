using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Factory
{
    public class FA_YearPicker : FactoryPicker
    {
        protected override List<dynamic> CreateBody()
        {
            List<dynamic> years = new List<dynamic>();
            for (int year = 1985; year <= 2016; year++)
            {
                years.Add(year);
            }
            return years;
        }

        protected override string GetTitle()
        {
            return "Choose your Year";
        }
    }
}
