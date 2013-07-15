using System.Collections.Generic;

namespace Iterator
{
    public class ShirtCollection
    {
        private readonly string description;
        private List<Shirt> shirts;

        public ShirtCollection(string description)
        {
            this.description = description;
            shirts = new List<Shirt>();
        }

        public string Description
        {
            get { return description; }
        }

        public void Add(Shirt shirt)
        {
            shirts.Add(shirt);
        }

        public IIterator CreateIterator()
        {
            return new ShirtCollectionIterator(shirts.ToArray());
        }
    }
}