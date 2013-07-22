using System;

namespace Strategy.Startegies
{
    public class FastStrategy:IMakingStrategy
    {
        public void Perform()
        {
            Console.WriteLine("Made 2000 t-shirts of low quality");
        }
    }
}