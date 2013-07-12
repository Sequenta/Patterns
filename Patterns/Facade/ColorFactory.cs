namespace Facade
{
    public class ColorFactory
    {
        public Shirt ColorShirt(Shirt shirt, string color)
        {
            shirt.Color = color;
            return shirt;
        }
    }
}