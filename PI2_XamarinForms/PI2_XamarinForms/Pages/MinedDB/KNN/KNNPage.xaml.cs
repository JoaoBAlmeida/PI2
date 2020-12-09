using PI2_XamarinForms.Strategy.MinedSection;
using PI2_XamarinForms.Template.KNNRequests;
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
        Picker sex;
        #endregion

        public KNNPage()
        {
            InitializeComponent();
            Fulfill_UI();
        }

        private void Fulfill_UI()
        {
            Assistant.SetStrategy(new knnStrategy());
            List<object> uielems = Assistant.CreatePickers();
            sex = (Picker)uielems[0];
            sex.SelectedIndex = 0;
            country = (Picker)uielems[1];
            country.SelectedIndex = 0;
            StkMain.Children.Add(sex);
            StkMain.Children.Add(country);
        }

        private void goKnnGraph(object sender, EventArgs e)
        {
            //No need to check if picker selected - they are set at 0
            if (sex.SelectedIndex == 0) Navigation.PushModalAsync(new KNNGraph(new Knn_male(country.SelectedItem.ToString()), country.SelectedItem.ToString()));
            else if(sex.SelectedIndex == 1) Navigation.PushModalAsync(new KNNGraph(new Knn_female(country.SelectedItem.ToString()), country.SelectedItem.ToString()));

        }

        private void goKnnDictionary(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new KNNDictionary());
        }
    }
}