using Org.BouncyCastle.Crypto.Prng;
using PI2_XamarinForms.Controllers;
using PI2_XamarinForms.Factory;
using PI2_XamarinForms.Strategy;
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
        private UIAssist UIControl = new UIAssist();

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
                return;
            }

            try
            {
                Navigation.PushAsync(UIControl.CreatePage(PkSearch.SelectedIndex, getArgs()));
            }
            catch (Exception error)
            {
                DisplayAlert("ERROR", error.Message, "OK");
                return;
            }

        }

        private void PkSearch_IndexChanged(object sender, EventArgs e)
        {
            ClearScreen();
            if (Enum.IsDefined(typeof(pickerstype), PkSearch.SelectedIndex))
            {
                UIControl.SetStrategy(new PickerStrategy());
                List<object> UIElem = UIControl.CreateInfoUI(PkSearch.SelectedIndex);
                try
                {
                    if(UIElem.Count == 2)
                    {
                        ChosenPicker = (Picker)UIElem[0];
                        ComparisonPicker = (Picker)UIElem[0];
                        ComparisonPicker.SelectedIndex = 0;
                        Stkoptions.Children.Add(ChosenPicker);
                        Stkoptions.Children.Add(ComparisonPicker);
                    }
                    else
                    {
                        ChosenPicker = (Picker)UIElem[0];
                        Stkoptions.Children.Add(ChosenPicker);
                    }  
                }catch(Exception error)
                {
                    DisplayAlert("ERROR", error.Message, "OK");
                }
            }
            else if (Enum.IsDefined(typeof(entriestype), PkSearch.SelectedIndex))
            {
                UIControl.SetStrategy(new EntryStrategy());
                List<object> UIElem = UIControl.CreateInfoUI(PkSearch.SelectedIndex);
                try
                {
                    ValueEntry = (Entry)UIElem[0];
                    ComparisonPicker = (Picker)UIElem[0];
                    ComparisonPicker.SelectedIndex = 0;
                }
                catch (Exception error)
                {
                    DisplayAlert("ERROR", error.Message, "OK");
                }
            }
        }

        #region Collect Options Data
        private string[] getArgs()
        {
            //TODO - Search options about sending this function into a controller

            string[] args = new string[2];
            if (Stkoptions.Children[1].GetType() == typeof(Picker))
            {
                if (ChosenPicker.SelectedIndex < 0) throw new Exception("Need to choose the referenced value to search");
                args[0] = ChosenPicker.SelectedItem.ToString();
            }
            else
            {
                if (ValueEntry.Text.Trim().Length <= 0) throw new Exception("Need to choose the referenced value to search");
                args[0] = ValueEntry.Text.Trim();
            }
            if (Stkoptions.Children.Count == 3)
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