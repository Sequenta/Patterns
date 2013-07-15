using System;

namespace Command
{
    public class SecondDepartment:IDepartment
    {
        public void MakeBatch(string shirtsColor, int numberOfShirts)
        {
            Console.WriteLine("Second department made {0} {1} t-shirts", numberOfShirts, shirtsColor);
        }
    }
}