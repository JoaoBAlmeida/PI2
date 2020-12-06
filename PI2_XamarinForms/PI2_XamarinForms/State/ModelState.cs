using PI2_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI2_XamarinForms.State
{
    public class ModelState
    {
        private SearchState _state;
        public SearchState State
        {
            get { return this._state; }
            set { _state = value; }
        }

        public ModelState()
        {
            _state = new YearState();
        }

        public void CheckState(int choice)
        {
            if (choice != _state.GetReference())
            {
                FixState(choice);
            }
        }

        public IEnumerable<Suicides> TreatedList(string keyword, List<Suicides> suicides)
        {
            return _state.SearchedList(keyword, suicides);
        }

        public void FixState(int choice)
        {
            _state.Handle(this, choice);
            _state.SetReference(choice);
        }
    }
}
