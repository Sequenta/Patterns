using System;

namespace Iterator
{
    public class Shirt
    {
        private readonly string description;

        public Shirt(string description)
        {
            this.description = description;
        }

        public void Description()
        {
            Console.WriteLine(description);
        }
    }
}