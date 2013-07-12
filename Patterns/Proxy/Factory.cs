namespace Proxy
{
    public class Factory:ICanGiveShirt
    {
        public Shirt GiveShirt(string size, string color)
        {
            return new Shirt(size,color);
        }
    }
}