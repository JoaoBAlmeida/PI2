using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy.MinedSection
{
    public class MethodAssist
    {
        private IStrategyMethodSupport _strategy;

        public void SetStrategy(IStrategyMethodSupport Strategy)
        {
            this._strategy = Strategy;
        }

        public MethodAssist() { }

        public List<object> CreatePickers()
        {
            return _strategy.UISupport();
        }
    }
}
