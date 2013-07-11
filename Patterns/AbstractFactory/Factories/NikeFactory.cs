using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class NikeFactory:IShirtFactory
    {
        public IShirt MakeSimpleShirt(string size, string color)
        {
            Console.WriteLine("Nike is now making simple t-shirt...");
            return new SimpleShirt(size, color, "Nike");
        }

        public IShirt MakeNoArmsShirt(string size, string color)
        {
            Console.WriteLine("Nike is now making no arms t-shirt...");
            return new NoArmsShirt(size, color, "Nike");
        }
    }
}