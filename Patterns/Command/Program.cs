using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            var factory = new Factory();
            factory.GetOrder("Red",800);
            factory.GetOrder("Black",1200);

            Console.ReadKey();
        }
    }
}
