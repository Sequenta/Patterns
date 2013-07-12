namespace Decorator
{
    public abstract class ShirtComponent
    {
        public string Description { get; set; }
        public abstract double Cost();
    }
}