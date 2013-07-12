namespace Decorator.ColorDecorators
{
    public class RedShirtColor:ShirtComponent
    {
        private ShirtComponent shirt;

        public RedShirtColor(ShirtComponent shirt)
        {
            this.shirt = shirt;
            Description = shirt.Description + "red color, ";
        }

        public override double Cost()
        {
            return 20 + shirt.Cost();
        }
    }
}