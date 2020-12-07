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

        public object CreatePicker()
        {
            return _strategy.UISupport();
        }
    }
}
