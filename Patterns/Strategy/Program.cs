using System;
using Strategy.Startegies;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var shirtFactory = new ShirtFactory();

            shirtFactory.MakingStrategy = new FastStrategy();
            shirtFactory.MakeShirts();

            shirtFactory.MakingStrategy = new BalanceStrategy();
            shirtFactory.MakeShirts();

            shirtFactory.MakingStrategy = new QualityStrategy();
            shirtFactory.MakeShirts();

            Console.ReadKey();
        }
    }
}
