namespace FactoryMethod.Products
{
    public class SimpleShirt:IShirt
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public bool Arms { get; set; }

        public SimpleShirt(string label)
        {
            Label = label;
            Arms = true;
        }

        public override string ToString()
        {
            return string.Format("This is {0} tshirt with arms", Label);
        }
    }
}