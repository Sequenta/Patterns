using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            var classicShirtCollection = new ShirtCollection("Classic t-shirt collection");
            classicShirtCollection.Add(new Shirt("Red t-shirt"));
            classicShirtCollection.Add(new Shirt("Blue t-shirt"));
            classicShirtCollection.Add(new Shirt("White t-shirt"));

            var iterator = classicShirtCollection.CreateIterator();
            while (iterator.HasNext())
            {
                var shirt = (Shirt) iterator.Next();
                shirt.Description();
            }

            Console.ReadKey();
        }
    }
}
