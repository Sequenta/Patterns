using System;

namespace Strategy.Startegies
{
    public class BalanceStrategy:IMakingStrategy
    {
        public void Perform()
        {
            Console.WriteLine("Made 1500 t-shirts of normal quality");
        }
    }
}