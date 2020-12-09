using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Template.KNNRequests
{
    public class Knn_male : DBSuicideDAO
    {
        private string country;
        public Knn_male(string country)
        {
            OpenDB();
            this.country = country;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM males WHERE country = '" + country + "'";
        }
    }
}
