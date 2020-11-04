using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PI2_XamarinForms.Factory
{
    public abstract class FactoryEntry
    {
        public Entry generateEntry()
        {
            Entry entry = new Entry
            {
                Placeholder = GetHolder(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            return entry;
        }
        protected abstract string GetHolder();
    }
}
