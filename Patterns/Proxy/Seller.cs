namespace Proxy
{
    public class Seller:ICanGiveShirt
    {
        private ICanGiveShirt factory = new Factory();
        public Shirt GiveShirt(string size, string color)
        {
            if ((color != "Red") && (color != "Blue") && (color !="Yellow"))
            {
                throw new InvalidColorOfShirtException();
            }
            return factory.GiveShirt(size, color);
        }
    }
}