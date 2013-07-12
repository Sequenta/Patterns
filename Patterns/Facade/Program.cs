using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var manufacturer = new Manufacturer();
            var shirt = manufacturer.GetShirt("XXL", "Yellow");
            Console.WriteLine(shirt.ToString());
            Console.ReadKey();
        }
    }
}
