using System;

namespace Bridge.Implementors
{
    public class NikeFactory:IShirtFactory
    {
        private const string Name = "Nike";
        private const string ShirtColor = "Blue";

        public void MakeBody()
        {
            Console.WriteLine("This is {0} body", Name);
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