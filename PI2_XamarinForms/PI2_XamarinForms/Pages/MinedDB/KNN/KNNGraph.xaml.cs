using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microcharts;
using SkiaSharp;
//Important so that it works
using Entry = Microcharts.ChartEntry;

namespace PI2_XamarinForms.Pages.MinedDB.KNN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KNNGraph : ContentPage
    {
        //TODO - Set this list creation into DB Template
        List<Entry> values = new List<Entry>
        {
            new Entry(300)
            {
                Color = SKColor.Parse(Color.IndianRed.ToHex().ToString()),
                Label = "5 - 14 year",
                ValueLabel = "300"
            },
            new Entry(250)
            {
                Color = SKColor.Parse(Color.Red.ToHex().ToString()),
                Label = "15 - 24 years",
                ValueLabel = "250"
            },
            new Entry(200)
            {
                Color = SKColor.Parse(Color.DarkOrange.ToHex().ToString()),
                Label = "25 - 34 years",
                ValueLabel = "200"
            },
            new Entry(150)
            {
                Color = SKColor.Parse(Color.Orange.ToHex().ToString()),
                Label = "35 - 54 years",
                ValueLabel = "150"
            },
            new Entry(100)
            {
                Color = SKColor.Parse(Color.Yellow.ToHex().ToString()),
                Label = "55 - 74 years",
                ValueLabel = "100"
            },
            new Entry(500)
            {
                Color = SKColor.Parse(Color.YellowGreen.ToHex().ToString()),
                Label = "+75 years",
                ValueLabel = "50"
            }
        };

        public KNNGraph(string country)
        {
            InitializeComponent();
            Graph01.Chart = new BarChart() { Entries = values };
        }
    }
}