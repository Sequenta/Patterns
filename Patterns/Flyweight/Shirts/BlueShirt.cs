using System;

namespace Flyweight.Shirts
{
    public class BlueShirt:Shirt
    {
        public BlueShirt()
        {
            Color = Colors.Blue;
            Size = "XL";
        }
        public override void Descriptiion()
        {
            Console.WriteLine("This is {0} t-shirt size of {1}",Color,Size);
        }
    }
}