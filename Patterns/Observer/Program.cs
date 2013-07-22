using System;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            var shirtShop = new ShirtShop();
            var firstClient = new Client("First client");
            var secondClient = new Client("Second client");
            var thirdClient = new Client("Third client");

            shirtShop.Subscribe(firstClient);
            shirtShop.Subscribe(secondClient);
            shirtShop.Subscribe(thirdClient);
            shirtShop.Message = "New shirts available from 'Adidas'!";

            shirtShop.Unsubscribe(firstClient);
            shirtShop.Message = "New shirts available from 'Nike'!";

            var newClient = new Client("New client");
            shirtShop.Subscribe(newClient);
            shirtShop.Message = "New shirts available from 'Reebok'!";

            Console.ReadKey();
        }
    }
}
