using PI2_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.State
{
    public class CountryState : SearchState
    {
        public override void Handle(ModelState model, int choice)
        {
            if (choice == 0)
            {
                model.State = new YearState();
            }
            else if (choice == 2)
            {
                model.State = new SexState();
            }
            else if (choice == 3)
            {
                model.State = new AgeState();
            }
            else if (choice == 4)
            {
                model.State = new NumberState();
            }
            else if (choice == 5)
            {
                model.State = new PopulationState();
            }
            else if (choice == 6)
            {
                model.State = new PibYState();
            }
            else if (choice == 7)
            {
                model.State = new PibCState();
            }
            else if (choice == 8)
            {
                model.State = new GenState();
            }
            else throw new Exception("Please select a search option!");
        }

        public override IEnumerable<Suicides> SearchedList(string keyword, List<Suicides> suicides)
        {
            if (keyword.Length >= 1)
            {
                IEnumerable<Suicides> sugestion = suicides.Where(c => c.Country.ToString().ToLower().Contains(keyword.ToLower()));
                return sugestion;
            }
            else return suicides;
        }
    }
}
