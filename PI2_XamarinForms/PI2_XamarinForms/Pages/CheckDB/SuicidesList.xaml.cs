using PI2_XamarinForms.Controllers;
using PI2_XamarinForms.Models;
using PI2_XamarinForms.Strategy;
using PI2_XamarinForms.Template;
using PI2_XamarinForms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PI2_XamarinForms.Pages.CheckDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuicidesList : ContentPage
    {

        #region Variables
        Picker picker;
        DBSuicideDAO DB;
        List<Suicides> suicides;
        UIGenerator UIControl = new UIGenerator();
        SearchStrategy SrchStrategy = new SearchStrategy();
        #endregion

        public SuicidesList(DBSuicideDAO dB)
        {
            InitializeComponent();
            DB = dB;
            picker = UIControl.generateSearchPicker();
            StkContent.Children.Insert(0, picker);
            SuicideViewModel VM = new SuicideViewModel(DB);
            ListSuicidal.ItemsSource = VM.Items;
            suicides = VM.Items;
        }
        protected override bool OnBackButtonPressed()
        {
            //TODO - Try to close database without assimilating to a local variable
            DB.CloseDB();
            return base.OnBackButtonPressed();
        }

        private void SrchContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO - Create a Strategy Context to hold the strategy;
            try
            {
                ListSuicidal.ItemsSource = SrchStrategy.SearchedParameters(picker.SelectedIndex, SrchBar.Text.Trim(), suicides);
            }
            catch(Exception error)
            {
                DisplayAlert("ERROR", error.Message, "OK");
            }
        }
    }
}