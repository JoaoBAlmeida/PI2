using PI2_XamarinForms.Controllers;
using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public class PickerStrategy : IStrategyUISupport
    {
        public DBSuicideDAO GetTemplate(int choices, string[] args)
        {
            if (choices == 0)
            {
                return new SuicideYear(args);
            }
            else if (choices == 1)
            {
                string arg = args[0];
                return new SuicideCountry(arg);
            }
            else if (choices == 2)
            {
                string arg = args[0];
                return new SuicideSex(arg);
            }
            else if (choices == 3)
            {
                string arg = args[0];
                return new SuicideAge(arg);
            }
            else if (choices == 8)
            {
                string arg = args[0];
                return new SuicideGen(arg);
            }
            else
            {
                throw new Exception("Error on Page Creation");
            }
        }

        public List<object> UISupport(int choices)
        {
            UIGenerator UIControl = new UIGenerator();
            List<object> objs = new List<object>();

            if (choices == 0)
            {
                objs.Add(UIControl.generateYearPicker());
                objs.Add(UIControl.generateComparePicker());
                return objs;
            }
            else if (choices == 1)
            {
                objs.Add(UIControl.generateCountryPicker());
                return objs;
            }
            else if (choices == 2)
            {
                objs.Add(UIControl.generateSexPicker());
                return objs;
            }
            else if (choices == 3)
            {
                objs.Add(UIControl.generateAgePicker());
                return objs;
            }
            else if (choices == 8)
            {
                objs.Add(UIControl.generateGenPicker());
                return objs;
            }
            else
            {
                throw new Exception("Error on Picker Creation");
            }
        }
    }
}
