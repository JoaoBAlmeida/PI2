using PI2_XamarinForms.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PI2_XamarinForms.Controllers
{
    public class UIGenerator
    {
        #region Picker Factory Files
        public Picker generateComparePicker()
        {
            FA_ComparisonPicker CP = new FA_ComparisonPicker();
            return CP.generatePicker();
        }
        public Picker generateYearPicker()
        {
            FA_YearPicker YP = new FA_YearPicker();
            return YP.generatePicker();
        }
        public Picker generateCountryPicker()
        {
            FA_CountryPicker CountryP = new FA_CountryPicker();
            return CountryP.generatePicker();
        }
        public Picker generateSexPicker()
        {
            FA_SexPicker SP = new FA_SexPicker();
            return SP.generatePicker();
        }
        public Picker generateAgePicker()
        {
            FA_AgePicker AP = new FA_AgePicker();
            return AP.generatePicker();
        }
        public Picker generateGenPicker()
        {
            FA_SuicideGenPicker GP = new FA_SuicideGenPicker();
            return GP.generatePicker();
        }

        public Picker generateSearchPicker()
        {
            FA_SearchPicker SrchP = new FA_SearchPicker();
            return SrchP.generatePicker();
        }
        #endregion

        #region Entry Factory

        public Entry generateSuicideNoEntry()
        {
            FA_SuicideNoEntry SE = new FA_SuicideNoEntry();
            return SE.generateEntry();
        }
        public Entry generatePopulationEntry()
        {
            FA_PopulationEntry PE = new FA_PopulationEntry();
            return PE.generateEntry();
        }
        public Entry generatePIBYEntry()
        {
            FA_PIBYEntry YE = new FA_PIBYEntry();
            return YE.generateEntry();
        }
        public Entry generatePIBCEntry()
        {
            FA_PIBCEntry CE = new FA_PIBCEntry();
            return CE.generateEntry();
        }

        #endregion
    }
}
