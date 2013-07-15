using Bridge.Implementors;

namespace Bridge
{
    public class ShirtConstructor
    {
        protected IShirtFactory factory;

        public IShirtFactory Factory
        {
            set { factory = value; }
        }

        public virtual void MakeBody()
        {
            factory.MakeBody();
        }

        public virtual void Color()
        {
            factory.Color();
        }

        public virtual void MakePrint()
        {
            factory.MakePrint();
        }
    }
}