using System;

namespace Composite
{
    public class Shirt:CollectionElement
    {
        public Shirt(string description) : base(description)
        {
        }

        public override void Add(CollectionElement element)
        {
            throw new NotImplementedException("Shirt is not collection!");
        }

        public override void Remove(CollectionElement element)
        {
            throw new NotImplementedException("Shirt is not collection!");
        }

        public override void Description()
        {
            Console.WriteLine(description);
        }
    }
}