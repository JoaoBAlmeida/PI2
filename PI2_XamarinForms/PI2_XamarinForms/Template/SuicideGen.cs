using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicideGen : DBSuicideDAO
    {
        public string generation;

        public SuicideGen(string arg)
        {
            OpenDB();
            generation = arg;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE generation " + compare + " '" + generation + "'";
        }
    }
}
