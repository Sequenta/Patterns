namespace Adapter
{
    public class AmericanShirt
    {
        private readonly string size;

        public AmericanShirt(string size)
        {
            this.size = size;
        }

        public string AmericanSize()
        {
            return size;
        }
    }
}