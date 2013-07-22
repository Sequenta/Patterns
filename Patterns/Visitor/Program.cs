using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var shirtCollection = new ShirtCollection();
            shirtCollection.Add(new Shirt("L","Black","Adidas",100));
            shirtCollection.Add(new Shirt("XL","Yellow","Reebok",120));
            shirtCollection.Add(new Shirt("S","White","Nike",110));
            shirtCollection.Show();
            Console.WriteLine();

            Console.WriteLine("-----SALES! 10% OFF!-----");
            var priceVisitor = new PriceVisitor();
            shirtCollection.Accept(priceVisitor);
            shirtCollection.Show();

            Console.ReadKey();
        }
    }
}
