using System;
using Builder.Builders;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var customer = new Customer();
            var adidasBuilder = new AdidasBuilder();
            var nikeBuilder = new NikeBuilder();
            var reebokBuilder = new ReebokBuilder();

            customer.AskForShirt(adidasBuilder);
            var adidasShirt = adidasBuilder.GetResult();
            adidasShirt.Show();

            customer.AskForShirt(nikeBuilder);
            var nikeShirt = nikeBuilder.GetResult();
            nikeShirt.Show();

            customer.AskForShirt(reebokBuilder);
            var reebokShirt = reebokBuilder.GetResult();
            reebokShirt.Show();

            Console.ReadKey();
        }
    }
}
