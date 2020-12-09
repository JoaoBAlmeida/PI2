using System;
using System.Collections.Generic;
using System.Text;
using PI2_XamarinForms.Controllers;

namespace PI2_XamarinForms.Strategy.MinedSection
{
    public class knnStrategy : IStrategyMethodSupport
    {
        public List<object> UISupport()
        {
            UIGenerator generator = new UIGenerator();
            List<object> uielems = new List<object>();
            uielems.Add(generator.generateSexPicker());
            uielems.Add(generator.generateCountryPicker());
            return uielems;
        }
    }
}
