namespace Decorator.PrintDecorators
{
    public class StylishShirtPrint:ShirtComponent
    {
        private ShirtComponent shirt;

        public StylishShirtPrint(ShirtComponent shirt)
        {
            this.shirt = shirt;
            Description = shirt.Description + "stylish print, ";
        }

        public override double Cost()
        {
            return 10 + shirt.Cost();
        }
    }
}