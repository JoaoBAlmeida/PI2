using MySql.Data.MySqlClient;
using PI2_XamarinForms.Models;
using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PI2_XamarinForms.ViewModel
{
    public class SuicideViewModel
    {
        private List<Suicides> items;
        public List<Suicides> Items
        {
            get { return items; }
            set { items = value; }
        }

        public SuicideViewModel(DBSuicideDAO DB)
        {
            MySqlDataReader rdr = DB.GetFromDB();
            //Conversion DataReader to List<Suicides>
            List<Suicides> suicides = new List<Suicides>();
            if (rdr != null)
                while (rdr.Read())
                {
                    suicides.Add(new Suicides()
                    {
                        Country = rdr["country"].ToString(),
                        Year = int.Parse(rdr["year"].ToString()),
                        Sex = rdr["sex"].ToString(),
                        Age = rdr["age"].ToString(),
                        Suicides_no = int.Parse(rdr["suicides_no"].ToString()),
                        Population = int.Parse(rdr["population"].ToString()),
                        PIB_Year = rdr["gdp_for_year"].ToString(),
                        PIB_Capita = rdr["gdp_per_capita"].ToString(),
                        Generation = rdr["generation"].ToString()
                    });
                }
            else
            {
                suicides.Add(new Suicides()
                {
                    Country = "empty",
                    Year = 0,
                    Sex = "empty",
                    Age = "empty",
                    Suicides_no = 0,
                    Population = 0,
                    PIB_Year = "empty",
                    PIB_Capita = "empty",
                    Generation = "empty"
                });
            }

            Items = suicides;
        }
    }
}
