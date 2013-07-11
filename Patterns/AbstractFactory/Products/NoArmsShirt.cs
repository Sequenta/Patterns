namespace AbstractFactory.Products
{
    public class NoArmsShirt:IShirt
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public bool Arms { get; set; }

        public NoArmsShirt(string size,string color,string label)
        {
            Size = size;
            Color = color;
            Label = label;
            Arms = false;
        }

        public override string ToString()
        {
            return string.Format("This is {0} no arms t-shirt size of {1} from {2}", Color, Size, Label);
        }
    }
}