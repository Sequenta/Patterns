using System;

namespace TemplateMethod.ShirtFactories
{
    public class NikeShirtFactory:ShirtFactory
    {
        public override void MakeBody()
        {
            Console.WriteLine("Made body without hands");
        }

        public override void Color()
        {
            Console.WriteLine("Colored yellow");
        }

        public override void MakePrint()
        {
            Console.WriteLine("Made Nike print");
        }
    }
}