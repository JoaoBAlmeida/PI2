using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicidePIB_C : DBSuicideDAO
    {
        private string PIB;
        public SuicidePIB_C(string[] args)
        {
            OpenDB();
            if(args.Count() == 2)
            {
                PIB = args[0];
                compare = args[1];
            }
            else
            {
                PIB = args[0];
            }
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE gdp_per_capita " + compare + " " + PIB;
        }
    }
}
