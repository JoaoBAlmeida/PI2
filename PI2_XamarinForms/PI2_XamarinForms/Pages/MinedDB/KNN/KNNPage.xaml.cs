using PI2_XamarinForms.Strategy.MinedSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PI2_XamarinForms.Pages.MinedDB.KNN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KNNPage : ContentPage
    {
        #region Variables
        MethodAssist Assistant = new MethodAssist();
        Picker country;
        #endregion

        public KNNPage()
        {
            InitializeComponent();
            Fulfill_UI();
        }

        private void Fulfill_UI()
        {
            Assistant.SetStrategy(new knnStrategy());
            country = (Picker)Assistant.CreatePicker();
            country.SelectedIndex = 0;
            StkMain.Children.Insert(0, country);
        }

        private void goKnnGraph(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new KNNGraph(country.SelectedItem.ToString()));
        }

        private void goKnnDictionary(object sender, EventArgs e)
        {
            //TODO - Create a page showing database dictionary of knn method
        }
    }
}