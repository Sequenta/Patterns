using System;
using FactoryMethod.Creators;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var adidasCreator = new AdidasCreator();
            var nikeCreator = new NikeCreator();

            var adidasShirt = adidasCreator.CreateShirt();
            var nikeShirt = nikeCreator.CreateShirt();

            Console.WriteLine(adidasShirt.ToString());
            Console.WriteLine(nikeShirt.ToString());

            Console.ReadKey();
        }
    }
}
