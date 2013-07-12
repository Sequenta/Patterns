namespace Flyweight.Shirts
{
    public abstract class Shirt
    {
        protected string Size { get; set; }
        protected Colors Color { get; set; }

        public abstract void Descriptiion();
    }
}