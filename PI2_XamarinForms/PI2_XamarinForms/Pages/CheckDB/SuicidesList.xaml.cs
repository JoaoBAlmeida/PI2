using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PI2_XamarinForms.Pages.CheckDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuicidesList : ContentPage
    {
        DBSuicideDAO DB;
        public SuicidesList(DBSuicideDAO dB)
        {
            InitializeComponent();
            DB = dB;
            ListSuicidal.ItemsSource = DB.GetFromDB();
        }
        protected override bool OnBackButtonPressed()
        {
            DB.CloseDB();
            return base.OnBackButtonPressed();
        }
    }
}