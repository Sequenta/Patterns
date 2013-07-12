using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            var seller = new Seller();
            var shirt = seller.GiveShirt("XL","Red");
            Console.WriteLine(shirt.ToString());

            try
            {
                var wrongShirt = seller.GiveShirt("S","Green");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }

            Console.ReadKey();
        }
    }
}
