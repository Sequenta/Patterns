using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Master:Worker
    {
        private List<string> materials;

        public Master()
        {
            materials = new List<string> {"Silk","Cotton","Viscoze"};    
        }

        public override void MakeBodyForShirt(Shirt shirt)
        {
            if (materials.Contains(shirt.Material))
            {
                Console.WriteLine("Master made t-shirt {0} body", shirt.Material);
            }
            else
            {
                Console.WriteLine("T-shirt can't be made of this material!");
            }
        }
    }
}