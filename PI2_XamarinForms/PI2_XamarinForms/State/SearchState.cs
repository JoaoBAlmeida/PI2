using PI2_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI2_XamarinForms.State
{
    public abstract class SearchState
    {
        //TODO - Create dictionary for new states based on your choice

        protected int reference = -2;

        public int GetReference()
        {
            return this.reference;
        }

        public void SetReference(int value)
        {
            reference = value;
        }
        public abstract void Handle(ModelState model, int choice);
        public abstract IEnumerable<Suicides> SearchedList(string keyword, List<Suicides> suicides);
    }
}
