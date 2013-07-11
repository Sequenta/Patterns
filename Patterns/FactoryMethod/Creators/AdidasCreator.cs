using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class AdidasCreator:ICreator
    {
        public IShirt CreateShirt()
        {
            return new NoArmsShirt("adidas");
        }
    }
}