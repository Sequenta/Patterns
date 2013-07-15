using System;

namespace Bridge.Implementors
{
    public class AdidasFactory:IShirtFactory
    {
        private const string Name = "Adidas";
        private const string ShirtColor = "Red";

        public void MakeBody()
        {
            Console.WriteLine("This is {0} body",Name );
        }

        public void Color()
        {
            Console.WriteLine("This is {0} color", ShirtColor);
        }

        public void MakePrint()
        {
            Console.WriteLine("This is {0} print", Name);
        }
    }
}