namespace Decorator.ColorDecorators
{
    public class BlueShirtColor:ShirtComponent
    {
        private ShirtComponent shirt;

        public BlueShirtColor(ShirtComponent shirt)
        {
            this.shirt = shirt;
            Description = shirt.Description + "blue color, ";
        }

        public override double Cost()
        {
            return 10 + shirt.Cost();
        } 
    }
}