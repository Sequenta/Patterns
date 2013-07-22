using System;

namespace TemplateMethod.ShirtFactories
{
    public class AdidasShirtFactory:ShirtFactory
    {
        public override void MakeBody()
        {
            Console.WriteLine("Made body with hands");
        }

        public override void Color()
        {
            Console.WriteLine("Colored black");
        }

        public override void MakePrint()
        {
            Console.WriteLine("Made Adidas print");
        }
    }
}