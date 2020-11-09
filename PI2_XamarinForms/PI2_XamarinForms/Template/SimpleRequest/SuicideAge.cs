using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicideAge : DBSuicideDAO
    {
        private string age;
        public SuicideAge(string arg)
        {
            OpenDB();
            age = arg;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE age = '" + age + "'";
        }
    }
}
