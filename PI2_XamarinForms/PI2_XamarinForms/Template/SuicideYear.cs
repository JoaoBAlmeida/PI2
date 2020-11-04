using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace PI2_XamarinForms.Template
{
    public class SuicideYear : DBSuicideDAO
    {
        private string year;

        public SuicideYear(string[] args)
        {
            OpenDB();
            if (args.Count() == 2)
            {
                year = args[0];
                compare = args[1];
            }
            else year = args[0];
        }

        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE year " + compare + " " + year;
        }
    }
}
