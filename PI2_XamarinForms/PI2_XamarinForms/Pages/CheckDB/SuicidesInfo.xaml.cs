using PI2_XamarinForms.Controllers;
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
            Generation = 8
        }
        private enum entriestype
        {
            Suicides_Number = 4,
            Population,
            PIB_for_year,
            PIB_per_capita
        }

        #endregion

        #region Global Variables

        private Picker ChosenPicker;
        private Picker ComparisonPicker;
        private Entry ValueEntry;
        private UIController_SInfo UIControl = new UIController_SInfo();

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
                else if(PkSearch.SelectedIndex == 1)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideCountry(getArg())));
                    return;
                }
                else if(PkSearch.SelectedIndex == 2)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideSex(getArg())));
                    return;
                }
                else if(PkSearch.SelectedIndex == 3)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideAge(getArg())));
                    return;
                }
                else if(PkSearch.SelectedIndex == 8)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideGen(getArg())));
                    return;
                }
                else
                {
                    DisplayAlert("ERROR", "Selected option not found", "OK");
                    return;
                }
            }
            else if(Enum.IsDefined(typeof(entriestype), PkSearch.SelectedIndex))
            {
                if (PkSearch.SelectedIndex == 4)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicideNum(collectArgs())));
                    return;
                }
                else if (PkSearch.SelectedIndex == 5)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicidePopulation(collectArgs())));
                    return;
                }
                else if (PkSearch.SelectedIndex == 6)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicidePIB_Y(collectArgs())));
                    return;
                }
                else if (PkSearch.SelectedIndex == 7)
                {
                    Navigation.PushAsync(new SuicidesList(new SuicidePIB_C(collectArgs())));
                    return;
                }
                else
                {
                    DisplayAlert("ERROR", "Selected option not found", "OK");
                    return;
                }
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
                ChosenPicker = UIControl.generateYearPicker();
                ComparisonPicker = UIControl.generateComparePicker();
                ComparisonPicker.SelectedIndex = 0;
                Stkoptions.Children.Add(ChosenPicker);
                Stkoptions.Children.Add(ComparisonPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 1)
            {
                ChosenPicker = UIControl.generateCountryPicker();
                Stkoptions.Children.Add(ChosenPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 2)
            {
                ChosenPicker = UIControl.generateSexPicker();
                Stkoptions.Children.Add(ChosenPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 3)
            {
                ChosenPicker = UIControl.generateAgePicker();
                Stkoptions.Children.Add(ChosenPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 4)
            {
                ValueEntry = UIControl.generateSuicideNoEntry();
                ComparisonPicker = UIControl.generateComparePicker();
                ComparisonPicker.SelectedIndex = 0;
                Stkoptions.Children.Add(ValueEntry);
                Stkoptions.Children.Add(ComparisonPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 5)
            {
                ValueEntry = UIControl.generatePopulationEntry();
                ComparisonPicker = UIControl.generateComparePicker();
                ComparisonPicker.SelectedIndex = 0;
                Stkoptions.Children.Add(ValueEntry);
                Stkoptions.Children.Add(ComparisonPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 6)
            {
                ValueEntry = UIControl.generatePIBYEntry();
                ComparisonPicker = UIControl.generateComparePicker();
                ComparisonPicker.SelectedIndex = 0;
                Stkoptions.Children.Add(ValueEntry);
                Stkoptions.Children.Add(ComparisonPicker);
                return;
            }
            else if(PkSearch.SelectedIndex == 7)
            {
                ValueEntry = UIControl.generatePIBCEntry();
                ComparisonPicker = UIControl.generateComparePicker();
                ComparisonPicker.SelectedIndex = 0;
                Stkoptions.Children.Add(ValueEntry);
                Stkoptions.Children.Add(ComparisonPicker);
                return;
            }
            else if (PkSearch.SelectedIndex == 8)
            {
                ChosenPicker = UIControl.generateGenPicker();
                Stkoptions.Children.Add(UIControl.generateGenPicker());
                return;
            }
        }
        #region Picker Data
        private string[] generateArgs()
        {
            string[] args = new string[2];
            args[0] = ChosenPicker.SelectedItem.ToString();
            args[1] = ComparisonPicker.SelectedItem.ToString();
            return args;
        }
        private string getArg()
        {
            return ChosenPicker.SelectedItem.ToString();
        }
        #endregion

        #region Entry Data
        private string[] collectArgs()
        {
            string[] args = new string[2];
            args[0] = ValueEntry.Text.Trim();
            args[1] = ComparisonPicker.SelectedItem.ToString();
            return args;
        }
        #endregion

        #region UI Control

        private void ClearScreen()
        {
            while(Stkoptions.Children.Count > 1)
            {
                Stkoptions.Children.RemoveAt(Stkoptions.Children.Count - 1);
            }
        }

        #endregion

        

    }
}