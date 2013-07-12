namespace Proxy
{
    public class Shirt
    {
        public string Size { get; private set; }
        public string Color { get; private set; }

        public Shirt(string size,string color)
        {
            Size = size;
            Color = color;
        }

        public override string ToString()
        {
            return string.Format("This is {0} t-shirt size of {1}", Color, Size);
        }
    }
}