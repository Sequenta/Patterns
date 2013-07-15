using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            var master = new Master();
            var apprentice = new Apprentice();

            apprentice.SetUpperWorker(master);

            apprentice.MakeBodyForShirt(new Shirt("Cotton"));
            apprentice.MakeBodyForShirt(new Shirt("Silk"));
            apprentice.MakeBodyForShirt(new Shirt("Steel"));

            Console.ReadKey();
        }
    }
}
