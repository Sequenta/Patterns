namespace Decorator.Bodies
{
    public class SimpleShirtBody:ShirtComponent
    {
        public SimpleShirtBody()
        {
            Description = "Simple body, ";
        }

        public override double Cost()
        {
            return 50;
        }
    }
}