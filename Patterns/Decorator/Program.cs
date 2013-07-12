using System;
using Decorator.Bodies;
using Decorator.ColorDecorators;
using Decorator.PrintDecorators;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            ShirtComponent shirt = new SimpleShirtBody();
            shirt = new RedShirtColor(shirt);
            shirt = new ClassicShirtPrint(shirt);
            Console.WriteLine("Shirt description: {0}",shirt.Description);
            Console.WriteLine("Cost: {0}",shirt.Cost());

            Console.ReadKey();
        }
    }
}
