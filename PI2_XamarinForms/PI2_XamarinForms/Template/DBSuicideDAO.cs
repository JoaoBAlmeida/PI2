using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using MySql.Data.MySqlClient;
using PI2_XamarinForms.Models;

namespace PI2_XamarinForms.Template
{
    public abstract class DBSuicideDAO
    {
        private string ConnectionURL = "SERVER=localhost;DATABASE=pi2;UID=root;PASSWORD=;";
        protected abstract string GetQuery();

        protected string compare = "=";
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;

        //Public function to open the DB connection
        public void OpenDB()
        {
            connection = new MySqlConnection(ConnectionURL);
            connection.Open();
        }

        //Public function to get info from DB
        public List<Suicides> GetFromDB()
        {
            try
            {
                cmd = new MySqlCommand(GetQuery(), connection);
                rdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                rdr = null;
            }
            //Conversion DataReader to List<Suicides>
            List<Suicides> suicides = new List<Suicides>();
            if(rdr != null)
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
            
            rdr.Close();
            return suicides;
        }

        //Public Function to close DB connection
        public void CloseDB()
        {
            connection.Close();
        }
    }
}
