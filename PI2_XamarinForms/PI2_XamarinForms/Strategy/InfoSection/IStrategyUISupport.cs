using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public interface IStrategyUISupport
    {
        //TODO - Search if this could be done with virtuals, to accept the strategy from Suicides List
        List<object> UISupport(int choices);
        DBSuicideDAO GetTemplate(int choices, string[] args);
    }
}
