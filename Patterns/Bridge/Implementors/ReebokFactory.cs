using System;

namespace Bridge.Implementors
{
    public class ReebokFactory:IShirtFactory
    {
        private const string Name = "Reebok";
        private const string ShirtColor = "Yellow";

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