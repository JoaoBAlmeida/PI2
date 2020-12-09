using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PI2_XamarinForms.Template;
using PI2_XamarinForms.ViewModel;
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
        #region variables
        DBSuicideDAO DB;
        #endregion

        public KNNGraph(DBSuicideDAO dB, string country)
        {
            InitializeComponent();
            this.DB = dB;
            this.Title = "Data from " + country;
            KNNGraphViewModel KNN_VM = new KNNGraphViewModel(dB);
            Graph01.Chart = new LineChart() { Entries = KNN_VM.Entries };
        }
        protected override bool OnBackButtonPressed()
        {
            DB.CloseDB();
            return base.OnBackButtonPressed();
        }
    }
}