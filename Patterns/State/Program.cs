using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            var shirt = new Shirt("Adidas");
            shirt.Wear();
            shirt.Wear();
            shirt.Wear();
            shirt.Wear();

            shirt.Wash();
            shirt.Wear();

            Console.ReadKey();
        }
    }
}
