using System;

namespace Command
{
    public class FirstDepartment:IDepartment
    {
        public void MakeBatch(string shirtsColor, int numberOfShirts)
        {
            Console.WriteLine("First department made {0} {1} t-shirts",numberOfShirts,shirtsColor);
        }
    }
}