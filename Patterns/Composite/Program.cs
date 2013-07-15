using System;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            var assortment = new ShirtCollection("Assortment");
            var classicShirtCollection = new ShirtCollection("Classic t-shirt collection");
            classicShirtCollection.Add(new Shirt("Red t-shirt"));
            classicShirtCollection.Add(new Shirt("Blue t-shirt"));
            classicShirtCollection.Add(new Shirt("White t-shirt"));

            var fashionShirtCollection = new ShirtCollection("Fashion t-shirt collecion");
            fashionShirtCollection.Add(new Shirt("Diesel t-shirt"));
            fashionShirtCollection.Add(new Shirt("Razor t-shirt"));
            fashionShirtCollection.Add(new Shirt("Reserved t-shirt"));

            assortment.Add(classicShirtCollection);
            assortment.Add(fashionShirtCollection);

            assortment.Description();

            var fashionCollection = assortment.GetChild(fashionShirtCollection) as ShirtCollection;
            var fashionShirt = fashionCollection.GetChild(1);
            Console.WriteLine();
            fashionShirt.Description();

            Console.ReadKey();
        }
    }
}
