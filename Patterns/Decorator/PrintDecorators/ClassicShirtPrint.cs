namespace Decorator.PrintDecorators
{
    public class ClassicShirtPrint:ShirtComponent
    {
        private ShirtComponent shirt;

        public ClassicShirtPrint(ShirtComponent shirt)
        {
            this.shirt = shirt;
            Description = shirt.Description + "classic print, ";
        }

        public override double Cost()
        {
            return 5 + shirt.Cost();
        }
    }
}