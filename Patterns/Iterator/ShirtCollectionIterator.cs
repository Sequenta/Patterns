namespace Iterator
{
    public class ShirtCollectionIterator:IIterator
    {
        private readonly Shirt[] elements;
        private int position;

        public ShirtCollectionIterator(Shirt[] elements)
        {
            this.elements = elements;
        }

        public bool HasNext()
        {
            if (position>=elements.Length)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var element = elements[position];
            position += 1;
            return element;
        }
    }
}