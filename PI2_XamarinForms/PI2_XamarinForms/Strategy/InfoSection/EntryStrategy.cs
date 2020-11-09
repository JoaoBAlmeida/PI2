using PI2_XamarinForms.Controllers;
using PI2_XamarinForms.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.Strategy
{
    public class EntryStrategy : IStrategyUISupport
    {
        public DBSuicideDAO GetTemplate(int choices, string[] args)
        {
            if (choices == 4)
            {
                return new SuicideNum(args);
            }
            else if (choices == 5)
            {
                return new SuicidePopulation(args);
            }
            else if (choices == 6)
            {
                return new SuicidePIB_Y(args);
            }
            else if (choices == 7)
            {
                return new SuicidePIB_C(args);
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

            if (choices == 4)
            {
                objs.Add(UIControl.generateSuicideNoEntry());
            }
            else if (choices == 5)
            {
                objs.Add(UIControl.generatePopulationEntry());
            }
            else if (choices == 6)
            {
                objs.Add(UIControl.generatePIBYEntry());
            }
            else if (choices == 7)
            {
                objs.Add(UIControl.generatePIBCEntry());
            }
            else
            {
                throw new Exception("Error on Entry Creation");
            }

            objs.Add(UIControl.generateComparePicker());
            return objs;
        }
    }
}
