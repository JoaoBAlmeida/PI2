using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicidePopulation : DBSuicideDAO
    {
        private string population;
        
        public SuicidePopulation(string[] args)
        {
            OpenDB();
            if(args.Count() == 2)
            {
                population = args[0];
                compare = args[1];
            }
            else
            {
                population = args[1];
            }
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE population " + compare + " " + population;
        }
    }
}
