using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public interface IStrategyUISupport
    {
        List<object> UISupport(int choices);
        DBSuicideDAO GetTemplate(int choices, string[] args);
    }
}
