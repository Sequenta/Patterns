namespace Composite
{
    public abstract class CollectionElement
    {
        protected string description;

        protected CollectionElement(string description)
        {
            this.description = description;
        }

        public abstract void Add(CollectionElement element);
        public abstract void Remove(CollectionElement element);
        public abstract void Description();
    }
}