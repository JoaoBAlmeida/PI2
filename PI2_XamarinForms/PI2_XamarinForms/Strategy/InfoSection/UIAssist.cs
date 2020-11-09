using PI2_XamarinForms.Pages.CheckDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public class UIAssist
    {
        private IStrategyUISupport UIStrategy;

        public void SetStrategy(IStrategyUISupport strategy)
        {
            this.UIStrategy = strategy;
        }

        public UIAssist() { }

        public List<object> CreateInfoUI(int choice)
        {
            return UIStrategy.UISupport(choice);
        }

        public SuicidesList CreatePage(int choices, string[] args)
        {
            return new SuicidesList(UIStrategy.GetTemplate(choices, args));
        }
    }
}
