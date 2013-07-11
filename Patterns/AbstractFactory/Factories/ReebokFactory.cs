using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class ReebokFactory:IShirtFactory
    {
        public IShirt MakeSimpleShirt(string size, string color)
        {
            Console.WriteLine("Reebok is now making simple t-shirt...");
            return new SimpleShirt(size, color, "Reebok");
        }

        public IShirt MakeNoArmsShirt(string size, string color)
        {
            Console.WriteLine("Reebok is now making no arms t-shirt...");
            return new NoArmsShirt(size, color, "Reebok");
        }
    }
}