using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class ShirtCollection:CollectionElement
    {
        private List<CollectionElement> elements;
        public ShirtCollection(string description) : base(description)
        {
            elements = new List<CollectionElement>();
        }

        public override void Add(CollectionElement element)
        {
            elements.Add(element);
        }

        public override void Remove(CollectionElement element)
        {
            elements.Remove(element);
        }

        public CollectionElement GetChild(int index)
        {
            return elements[index];
        }

        public CollectionElement GetChild(CollectionElement element)
        {
            return elements.Find(foundElement => foundElement == element);
        }

        public override void Description()
        {
            Console.WriteLine("{0}{1} contains:{0}", Environment.NewLine, description);
            foreach (var collectionElement in elements)
            {
                collectionElement.Description();
            }
        }
    }
}