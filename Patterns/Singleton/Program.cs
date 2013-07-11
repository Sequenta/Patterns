using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            //var uniqueShirt = new UniqueShirt(); Cannot access private constructor
            var uniqueShirt = UniqueShirt.GetInstance();
            Console.WriteLine("Authograph on unique t-shirt:{0}",uniqueShirt.Autograph);
            Console.ReadKey();
        }
    }
}
