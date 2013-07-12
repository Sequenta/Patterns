using System;
using System.Collections;
using Flyweight.Shirts;

namespace Flyweight
{
    public class ShirtFactory
    {
        private Hashtable stock = new Hashtable();

        public Shirt GetShirt(Colors color)
        {
            var newShirtMessage = string.Format("Returned new {0} t-shirt", color);
            var oldShirt = string.Format("Returned {0} t-shirt from stock", color);
            var shirt = stock[color] as Shirt;
            if (shirt != null)
            {
                Console.WriteLine(oldShirt);
                return shirt;
            }
            switch (color)
            {
                case Colors.Red:
                    Console.WriteLine(newShirtMessage);
                    shirt = new RedShirt();
                    stock.Add(Colors.Red,shirt);
                    return shirt;
                case Colors.Blue:
                    Console.WriteLine(newShirtMessage);
                    shirt = new BlueShirt();
                    stock.Add(Colors.Blue, shirt);
                    return shirt;
                default:
                    throw new ArgumentOutOfRangeException("color");
            }
        }
    }
}