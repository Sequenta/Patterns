using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class AdidasFactory:IShirtFactory
    {
        public IShirt MakeSimpleShirt(string size, string color)
        {
            Console.WriteLine("Adidas is now making simple t-shirt...");
            return new SimpleShirt(size,color,"Adidas");
        }

        public IShirt MakeNoArmsShirt(string size, string color)
        {
            Console.WriteLine("Adidas is now making no arms t-shirt...");
            return new NoArmsShirt(size, color, "Adidas");
        }
    }
}