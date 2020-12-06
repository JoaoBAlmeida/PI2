using PI2_XamarinForms.Models;
using PI2_XamarinForms.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.State
{
    public class PopulationState : SearchState
    {
        public override void Handle(ModelState model, int choice)
        {
            if (choice == 5)
            {
                throw new Exception("There was an error on the chosen search option");
            }
            else
            {
                SearchDictionary srchOpts = SearchDictionary.GetInstace();
                Dictionary<int, SearchState> pairs = srchOpts.States;
                model.State = pairs[choice];
            }
        }

        public override IEnumerable<Suicides> SearchedList(string keyword, List<Suicides> suicides)
        {
            if (keyword.Length >= 1)
            {
                IEnumerable<Suicides> sugestion = suicides.Where(c => c.Population.ToString().ToLower().Contains(keyword.ToLower()));
                return sugestion;
            }
            else return suicides;
        }
    }
}
