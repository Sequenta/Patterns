using System;
using System.Collections.Generic;

namespace Builder
{
    public class Shirt
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("T-shirt characteristics:");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}