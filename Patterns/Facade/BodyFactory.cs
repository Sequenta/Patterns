namespace Facade
{
    public class BodyFactory
    {
        public Shirt MakeBody(string size)
        {
            return new Shirt {Size = size};
        }
    }
}