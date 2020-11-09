using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Template
{
    public class SuicideSex : DBSuicideDAO
    {
        private string sex;
        public SuicideSex(string arg)
        {
            OpenDB();
            sex = arg;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM suicides WHERE sex = '" + sex + "'";
        }
    }
}
