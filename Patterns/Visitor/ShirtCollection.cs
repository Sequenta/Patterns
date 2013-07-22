using System;
using System.Collections.Generic;

namespace Visitor
{
    public class ShirtCollection
    {
        List<Shirt> shirts = new List<Shirt>();

        public void Add(Shirt shirt)
        {
            shirts.Add(shirt);
        }

        public void Remove(Shirt shirt)
        {
            shirts.Remove(shirt);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var shirt in shirts)
            {
                shirt.Accept(visitor);
            }
        }

        public void Show()
        {
            Console.WriteLine("Label |Size |Color |Price");
            foreach (var shirt in shirts)
            {
                Console.WriteLine(shirt.ToString());
            }
        }
    }
}