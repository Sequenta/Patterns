namespace Decorator.Bodies
{
    public class NoHandsShirtBody:ShirtComponent
    {
        public NoHandsShirtBody()
        {
            Description = "No-hands body, ";
        }
        public override double Cost()
        {
            return 40;
        }
    }
}