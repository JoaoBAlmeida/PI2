using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using PI2_XamarinForms.Models;
using PI2_XamarinForms.Template;

using Microcharts;
using SkiaSharp;
//Important so that it works
using Entry = Microcharts.ChartEntry;
using MySql.Data.MySqlClient;

namespace PI2_XamarinForms.ViewModel
{
    public class KNNGraphViewModel
    {
        private List<Entry> _entries;
        public List<Entry> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }
        public KNNGraphViewModel(DBSuicideDAO dB)
        {
            MySqlDataReader rdr = dB.GetFromDB();
            //Conversion DataReader to List<Suicides>
            KNN_Sex sex = new KNN_Sex();
            if (rdr != null)
                while (rdr.Read())
                {
                    sex.age1 = int.Parse(rdr["age1"].ToString());
                    sex.age2 = int.Parse(rdr["age2"].ToString());
                    sex.age3 = int.Parse(rdr["age3"].ToString());
                    sex.age4 = int.Parse(rdr["age4"].ToString());
                    sex.age5 = int.Parse(rdr["age5"].ToString());
                    sex.age6 = int.Parse(rdr["age6"].ToString());
                    sex.gdp_per_capita = int.Parse(rdr["gdp_per_capita"].ToString());
                    sex.population = int.Parse(rdr["population"].ToString());
                    
                }
            else
            {
                sex.age1 = 0;
                sex.age2 = 0;
                sex.age3 = 0;
                sex.age4 = 0;
                sex.age5 = 0;
                sex.age6 = 0;
                sex.gdp_per_capita = 0;
                sex.population = 0;
            }

            List<Entry> values = new List<Entry>
            {
                new Entry(sex.age1)
                {
                    Color = SKColor.Parse(Color.IndianRed.ToHex().ToString()),
                    Label = "5 - 14 year",
                    ValueLabel = sex.age1.ToString()
                },
                new Entry(sex.age2)
                {
                    Color = SKColor.Parse(Color.Red.ToHex().ToString()),
                    Label = "15 - 24 years",
                    ValueLabel = sex.age2.ToString()
                },
                new Entry(sex.age3)
                {
                    Color = SKColor.Parse(Color.DarkOrange.ToHex().ToString()),
                    Label = "25 - 34 years",
                    ValueLabel = sex.age3.ToString()
                },
                new Entry(sex.age4)
                {
                    Color = SKColor.Parse(Color.Orange.ToHex().ToString()),
                    Label = "35 - 54 years",
                    ValueLabel = sex.age4.ToString()
                },
                new Entry(sex.age5)
                {
                    Color = SKColor.Parse(Color.Yellow.ToHex().ToString()),
                    Label = "55 - 74 years",
                    ValueLabel = sex.age5.ToString()
                },
                new Entry(sex.age6)
                {
                    Color = SKColor.Parse(Color.YellowGreen.ToHex().ToString()),
                    Label = "+75 years",
                    ValueLabel = sex.age6.ToString()
                }
            };

            Entries = values;
        }
    }
}
