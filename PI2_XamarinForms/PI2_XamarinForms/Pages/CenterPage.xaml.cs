using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PI2_XamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CenterPage : ContentPage
    {
        public CenterPage()
        {
            InitializeComponent();
        }

        private void GoSuicidesInfo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CheckDB.SuicidesInfo());
        }

        private void GoMining(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinedDB.MethodsPage());
        }
    }
}