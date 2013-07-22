using System;

namespace Strategy.Startegies
{
    public class QualityStrategy:IMakingStrategy
    {
        public void Perform()
        {
            Console.WriteLine("Made 1000 t-shirts of high quality");
        }
    }
}