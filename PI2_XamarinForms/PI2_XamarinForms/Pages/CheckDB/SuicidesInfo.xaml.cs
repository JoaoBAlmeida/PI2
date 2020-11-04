using PI2_XamarinForms.Factory;
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
    public partial class SuicidesInfo : ContentPage
    {
        #region Enums
        private enum pickerstype
        {
            Year,
            Country,
            Sex,
            Age,
            Generation = 7
        }
        private enum entriestype
        {
            Suicides_Number = 4,
            Population,
            PIB_per_capita
        }

        #endregion

        #region Global Variables

        private Picker ChosenPicker;
        private Picker ComparisonPicker;

        #endregion
        public SuicidesInfo()
        {
            InitializeComponent();
        }

        private void doSearch(object sender, EventArgs e)
        {
            if(PkSearch.SelectedIndex < 0)
            {
                DisplayAlert("ERROR", "Need to choose a type of search", "OK");
            }
            else if(Enum.IsDefined(typeof(pickerstype), PkSearch.SelectedIndex))
            {
                if (ChosenPicker.SelectedIndex < 0)
                {
                    DisplayAlert("ERROR", "Need to choose the referenced value to search", "OK");
                    return;
                }
                if (PkSearch.SelectedIndex == 0)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideYear(generateArgs())));
                    return;
                }
                else
                {
                    DisplayAlert("Picker", "Picker Type", "OK");
                    return;
                }
            }
            else if(Enum.IsDefined(typeof(entriestype), PkSearch.SelectedIndex))
            {
                DisplayAlert("Entry", "Entry Type", "OK");
                return;
            }
            else
            {
                DisplayAlert("ERROR", "Picker não está reconhecendo opções\nPor favor, selecione uma opção válida", "OK");
                return;
            }
            
        }

        private void PkSearch_IndexChanged(object sender, EventArgs e)
        {
            ClearScreen();
            if (PkSearch.SelectedIndex == 0)
            {
                Stkoptions.Children.Add(generateYearPicker());
                Stkoptions.Children.Add(generateComparePicker());
            }
        }

        private string[] generateArgs()
        {
            string[] args = new string[2];
            args[0] = ChosenPicker.SelectedItem.ToString();
            args[1] = ComparisonPicker.SelectedItem.ToString();
            return args;
        }

        #region UI Control

        private void ClearScreen()
        {
            while(Stkoptions.Children.Count > 1)
            {
                Stkoptions.Children.RemoveAt(Stkoptions.Children.Count - 1);
            }
        }

        #endregion

        #region Picker Factory Files
        private Picker generateComparePicker()
        {
            FA_ComparisonPicker CP = new FA_ComparisonPicker();
            ComparisonPicker = CP.generatePicker();
            ComparisonPicker.SelectedIndex = 0;
            return ComparisonPicker;
        }
        private Picker generateYearPicker()
        {
            FA_YearPicker YP = new FA_YearPicker();
            ChosenPicker = YP.generatePicker();
            return ChosenPicker;
        }
        #endregion

    }
}