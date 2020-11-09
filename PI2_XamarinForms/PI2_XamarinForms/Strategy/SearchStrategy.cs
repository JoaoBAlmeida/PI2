using PI2_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public class SearchStrategy : IStrategyUISearch
    {
        public IEnumerable<Suicides> SearchedParameters(int choice, string keyword, List<Suicides> suicides)
        {
            //TODO - Search if it's to seperate each choice into a new Strategy
            if (choice == 0)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Year.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 1)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Country.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 2)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Sex.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 3)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Age.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 4)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Suicides_no.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 5)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.Population.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 6)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.PIB_Year.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 7)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.PIB_Capita.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else if (choice == 8)
            {
                if (keyword.Length >= 1)
                {
                    IEnumerable<Suicides> sugestion = suicides.Where(c => c.PIB_Capita.ToString().ToLower().Contains(keyword.ToLower()));
                    return sugestion;
                }
                else return suicides;
            }
            else throw new Exception("Please select a search option!");
        }
    }
}
