using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicideCountry : DBSuicideDAO
    {
        public string Country;
        public SuicideCountry(string arg)
        {
            OpenDB();
            Country = arg;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE country = '" + Country + "'";
        }
    }
}
