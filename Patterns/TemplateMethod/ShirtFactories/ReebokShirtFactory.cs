using System;

namespace TemplateMethod.ShirtFactories
{
    public class ReebokShirtFactory:ShirtFactory
    {
        public override void MakeBody()
        {
            Console.WriteLine("Made body with hands");
        }

        public override void Color()
        {
            Console.WriteLine("Colored red");
        }

        public override void MakePrint()
        {
            Console.WriteLine("Made Reebok print");
        } 
    }
}