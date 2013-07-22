using System;
using TemplateMethod.ShirtFactories;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-----Adidas factory-----");
            var adidasFactory = new AdidasShirtFactory();
            adidasFactory.MakeShirt();
            Console.WriteLine();

            Console.WriteLine("-----Nike factory-----");
            var nikeFactory = new NikeShirtFactory();
            nikeFactory.MakeShirt();
            Console.WriteLine();

            Console.WriteLine("-----Reebok factory-----");
            var reebokFactory = new ReebokShirtFactory();
            reebokFactory.MakeShirt();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
