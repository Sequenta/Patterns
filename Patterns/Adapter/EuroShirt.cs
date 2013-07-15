namespace Adapter
{
    public class EuroShirt:ISizeInfo
    {
        private string size;

        public EuroShirt(string size)
        {
            this.size = size;
        }

        public string Size()
        {
            return size;
        }
    }
}