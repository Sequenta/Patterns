using System;
using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    public class Customer
    {
        private IShirt noarmsTshirt;
        private IShirt simpleTshirt;
        private IShirtFactory factory;

        public Customer(IShirtFactory shirtFactory)
        {
            factory = shirtFactory;
        }

        public void AskForShirt(string size, string color)
        {
            noarmsTshirt = factory.MakeNoArmsShirt(size, color);
            Console.WriteLine(noarmsTshirt.ToString());
            simpleTshirt = factory.MakeSimpleShirt(size, color);
            Console.WriteLine(simpleTshirt.ToString());
        }
    }
}