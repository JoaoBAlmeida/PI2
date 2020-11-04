using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicideNum : DBSuicideDAO
    {
        private string number;
        public SuicideNum(string[] args)
        {
            OpenDB();
            if(args.Count() == 2)
            {
                number = args[0];
                compare = args[1];
            }else
            {
                number = args[0];
            }
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE suicides_no " + compare + " " + number;
        }
    }
}
