using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PI2_XamarinForms.Pages.MinedDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MethodsPage : ContentPage
    {
        public MethodsPage()
        {
            InitializeComponent();
        }

        private void goKNN(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KNN.KNNPage());
        }
    }
}