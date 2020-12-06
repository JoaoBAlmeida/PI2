using PI2_XamarinForms.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Singleton
{
    public class SearchDictionary
    {
        private Dictionary<int, SearchState> _states;
        public Dictionary<int, SearchState> States { get { return _states; } }
        private SearchDictionary()
        {
            _states = new Dictionary<int, SearchState>()
            {
                {0, new YearState() },
                {1, new CountryState() },
                { 2, new SexState() },
                { 3, new AgeState() },
                { 4, new NumberState() },
                { 5, new PopulationState() },
                { 6, new PibYState() },
                { 7, new PibCState() },
                { 8, new GenState() }
            };
        }

        private static SearchDictionary _instance;

        public static SearchDictionary GetInstace()
        {
            if(_instance == null)
            {
                _instance = new SearchDictionary();
            }
            return _instance;
        }
    }
}
