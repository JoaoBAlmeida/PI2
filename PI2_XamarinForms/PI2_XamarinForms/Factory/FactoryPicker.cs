using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PI2_XamarinForms.Factory
{
    public abstract class FactoryPicker
    {

        public Picker generatePicker()
        {
            Picker picker = new Picker
            {
                Title = GetTitle(),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            picker.ItemsSource = CreateBody();
            return picker;
        }
        protected abstract string GetTitle();
        protected abstract List<dynamic> CreateBody();
    }
}
