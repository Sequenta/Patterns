namespace AbstractFactory.Products
{
    public class SimpleShirt:IShirt
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public bool Arms { get; set; }

        public SimpleShirt(string size, string color, string label)
        {
            Size = size;
            Color = color;
            Label = label;
            Arms = true;
        }

        public override string ToString()
        {
            return string.Format("This is {0} simple t-shirt size of {1} from {2}", Color, Size, Label);
        }
    }
}