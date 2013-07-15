namespace Adapter
{
    public class SizeAdapter:ISizeInfo
    {
        private AmericanShirt shirt;

        public SizeAdapter(AmericanShirt shirt)
        {
            this.shirt = shirt;
        }

        public string Size()
        {
            return shirt.AmericanSize();
        }
    }
}