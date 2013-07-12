using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            var orders = new List<Colors> {Colors.Blue,Colors.Red,Colors.Red};
            var factory = new ShirtFactory();
            foreach (var order in orders)
            {
                var shirt = factory.GetShirt(order);
                shirt.Descriptiion();
            }

            Console.ReadKey();
        }
    }
}
