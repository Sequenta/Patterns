namespace Facade
{
    public class Shirt
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Package { get; set; }

        public override string ToString()
        {
            return string.Format("This is {0} {1} t-shirt size of {2}", Package, Color, Size);
        }
    }
}
