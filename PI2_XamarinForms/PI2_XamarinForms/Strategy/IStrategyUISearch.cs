using PI2_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public interface IStrategyUISearch
    {
        IEnumerable<Suicides> SearchedParameters(int choice, string keyword, List<Suicides> suicides);
    }
}
