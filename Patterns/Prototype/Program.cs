using System;
using Prototype.Prototypes;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            var simpleShirt = new SimpleShirt();
            var simpleShirtClone = simpleShirt.Clone();
            Console.WriteLine("Original:arms {0}, body {1}",simpleShirt.Arms,simpleShirt.Body);
            Console.WriteLine("Clone:arms {0}, body {1}", simpleShirtClone.Arms, simpleShirtClone.Body);

            var noArmsShirt = new NoArmsShirt();
            var noArmsShirtClone = noArmsShirt.Clone();
            Console.WriteLine("Original:arms {0}, body {1}", noArmsShirt.Arms, noArmsShirt.Body);
            Console.WriteLine("Clone:arms {0}, body {1}", noArmsShirtClone.Arms, noArmsShirtClone.Body);

            Console.ReadKey();
        }
    }
}
