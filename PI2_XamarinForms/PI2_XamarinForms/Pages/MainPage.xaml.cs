using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PI2_XamarinForms.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void goToCenterPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CenterPage());
        }
    }
}
