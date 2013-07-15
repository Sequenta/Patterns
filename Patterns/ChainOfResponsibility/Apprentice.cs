using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Apprentice:Worker
    {
        private List<string> materials;

        public Apprentice()
        {
            materials = new List<string> {"Cotton"};
        }

        public override void MakeBodyForShirt(Shirt shirt)
        {
            if (materials.Contains(shirt.Material))
            {
                Console.WriteLine("Apprentice made t-shirt {0} body",shirt.Material);
            }
            else
            {
                upperWorker.MakeBodyForShirt(shirt);
            }
        }
    }
}