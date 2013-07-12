using System;

namespace Facade
{
    public class Manufacturer
    {
        private BodyFactory bodyFactory;
        private ColorFactory colorFactory;
        private PackageFactory packageFactory;

        public Manufacturer()
        {
            bodyFactory = new BodyFactory();
            colorFactory = new ColorFactory();
            packageFactory = new PackageFactory();
        }

        public Shirt GetShirt(string size, string color)
        {
            Console.WriteLine("New order for {0} t-shirt sizeof {1}",color,size);
            var shirt = bodyFactory.MakeBody(size);
            Console.WriteLine("Body factory created body size of {0}",size);
            shirt = colorFactory.ColorShirt(shirt, color);
            Console.WriteLine("Color factory colored body in {0}",color);
            shirt = packageFactory.PackShirt(shirt);
            Console.WriteLine("Package factory packed t-shirt");
            Console.WriteLine("Returning newly created t-shirt...");
            return shirt;
        }
    }
}