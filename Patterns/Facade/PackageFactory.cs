namespace Facade
{
    public class PackageFactory
    {
        public Shirt PackShirt(Shirt shirt)
        {
            shirt.Package = "Newly packed";
            return shirt;
        }
    }
}