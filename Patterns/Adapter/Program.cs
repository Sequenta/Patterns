using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            var euroShirt = new EuroShirt("56");
            var americanShirt = new SizeAdapter(new AmericanShirt("XL"));
            Console.WriteLine(ShirtSizeInformer.GetSize(euroShirt));
            Console.WriteLine(ShirtSizeInformer.GetSize(americanShirt));

            Console.ReadKey();
        }
    }
}
