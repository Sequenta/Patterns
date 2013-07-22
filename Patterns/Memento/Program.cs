using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            var order = new Order();
            order.Label = "Adidas";
            order.Color = "Black";
            order.Size = "XL";
            order.Number = 500;
            Console.WriteLine("-----Original-----");
            Console.WriteLine(order.ToString());

            var orderStorage = new OrderStorage();
            orderStorage.Memento = order.SaveOrder();

            order.Label = "Nike";
            order.Size = "L";
            Console.WriteLine("-----Changed-----");
            Console.WriteLine(order.ToString());

            order.RestoreFromStorage(orderStorage.Memento);
            Console.WriteLine("-----Restored-----");
            Console.WriteLine(order.ToString());

            Console.ReadKey();
        }
    }
}
