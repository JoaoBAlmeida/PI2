using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Template.KNNRequests
{
    public class Knn_female : DBSuicideDAO
    {
        private string country;
        public Knn_female(string country)
        {
            OpenDB();
            this.country = country;
        }
        protected override string GetQuery()
        {
            return "SELECT * FROM females WHERE country = '" + country + "'";
        }
    }
}
