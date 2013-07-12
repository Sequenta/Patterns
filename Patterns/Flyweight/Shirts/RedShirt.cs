using System;

namespace Flyweight.Shirts
{
    public class RedShirt:Shirt
    {
        public RedShirt()
        {
            Color = Colors.Red;
            Size = "S";
        }

        public override void Descriptiion()
        {
            Console.WriteLine("This is small red t-shirt");
        }
    }
}