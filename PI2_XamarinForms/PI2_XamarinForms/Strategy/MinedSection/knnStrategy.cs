using System;
using System.Collections.Generic;
using System.Text;
using PI2_XamarinForms.Controllers;

namespace PI2_XamarinForms.Strategy.MinedSection
{
    public class knnStrategy : IStrategyMethodSupport
    {
        public object UISupport()
        {
            UIGenerator generator = new UIGenerator();
            return generator.generateCountryPicker();
        }
    }
}
