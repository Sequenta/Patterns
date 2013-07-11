using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class NikeCreator:ICreator
    {
        public IShirt CreateShirt()
        {
            return new SimpleShirt("nike");
        }
    }
}