using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var adidasCustomer = new Customer(new AdidasFactory());
            var nikeCustomer = new Customer(new NikeFactory());
            var reebokCustomer = new Customer(new ReebokFactory());

            adidasCustomer.AskForShirt("XL","Red");
            nikeCustomer.AskForShirt("L","Blue");
            reebokCustomer.AskForShirt("S","Yellow");

            Console.ReadKey();
        }
    }
}
