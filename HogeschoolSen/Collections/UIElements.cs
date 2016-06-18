using HogeschoolSen.Buttons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogeschoolSen.Collections
{
    public class UIElements : ICollection
    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new UIElementsIterator(this);
        }

        public void AddElement(IButton element)
        {
            _items.Add(element);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
