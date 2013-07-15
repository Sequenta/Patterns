using System;
using Bridge.Implementors;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            var constructor = new ShirtConstructor();
            constructor.Factory = new AdidasFactory();
            constructor.MakeBody();
            constructor.Factory = new NikeFactory();
            constructor.Color();
            constructor.Factory = new ReebokFactory();
            constructor.MakePrint();

            Console.ReadKey();
        }
    }
}
